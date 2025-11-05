using Entity.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Utilities.Exceptions;
using System.Linq.Expressions;
using Entity.Models.Base;

namespace Data.Repository
{
    public class DataGeneric<T> : ADataGeneric<T> where T : BaseModel
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public DataGeneric(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        private IQueryable<T> BaseQuery() =>
            _dbSet.AsNoTracking()
                  .Where(e => !e.IsDeleted)
                  .OrderByDescending(e => e.CreatedAt)
                  .ThenByDescending(e => e.Id);


        public override async Task<IEnumerable<T>> GetAllAsync()
            => await BaseQuery().ToListAsync();

        public override async Task<T?> GetByIdAsync(int id)
            => await _dbSet.AsNoTracking()
                           .FirstOrDefaultAsync(e => e.Id == id && !e.IsDeleted);

        public override async Task<T> AddAsync(T entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public override async Task<T> UpdateAsync(T entity)
        {
            var existing = await _dbSet.FirstOrDefaultAsync(
                x => x.Id == entity.Id && !x.IsDeleted);

            if (existing is null)
                throw new EntityNotFoundException(typeof(T).Name, entity.Id);

            // Campos inmutables
            var originalCreatedAt = existing.CreatedAt;
            var originalId = existing.Id;

            _context.Entry(existing).CurrentValues.SetValues(entity);

            existing.Id = originalId;
            existing.CreatedAt = originalCreatedAt;

            await _context.SaveChangesAsync();
            return existing;
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) return false;

            _dbSet.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public override async Task<bool> DeleteLogicAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) return false;

            entity.IsDeleted = true;
            _dbSet.Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }
    }

}
