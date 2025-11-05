using Data.Interfaces.IDataBasic;
using Data.Interfaces.IDataImplement;
using Data.Repository;
using Entity.Infrastructure.Context;
using Entity.Models.Implements;
using System.Data.Entity;

namespace Data.Services
{
    public class UserPlantRepository : DataGeneric<UserPlant>, IUserPlantRepository
    { 
        public UserPlantRepository(ApplicationDbContext context) : base(context) { }

        public override async Task<IEnumerable<UserPlant>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking()
                .Where(e => !e.IsDeleted)
                .OrderByDescending(e => e.CreatedAt)
                .Include(e => e.User)
                .Include(e => e.PlantSpecies)
                .ToListAsync();
        }
    }
}
