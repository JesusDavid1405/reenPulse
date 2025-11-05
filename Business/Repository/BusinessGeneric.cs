using AutoMapper;
using Data.Interfaces.IDataBasic;
using Entity.Models.Base;
using System.Data.Entity.Infrastructure;
using Utilities.Exceptions;
using Utilities.Helpers.Business;

namespace Business.Repository
{
    public class BusinessGeneric<TGetDto, TCreateDto, TEntity> : ABusinessGeneric<TGetDto, TCreateDto, TEntity> where TEntity : BaseModel
    {
        protected readonly IDataBasic<TEntity> Data;
        protected readonly IMapper _mapper;

        public BusinessGeneric(IDataBasic<TEntity> data, IMapper mapper)
        {
            Data = data;
            _mapper = mapper;
        }

        public override async Task<IEnumerable<TGetDto>> GetAllAsync()
        {
            try
            {
                var entities = await Data.GetAllAsync();
                return _mapper.Map<IEnumerable<TGetDto>>(entities);
            }
            catch (Exception ex)
            {
                throw new BusinessException("Error al obtener todos los registros.", ex);
            }
        }

        public override async Task<TGetDto?> GetByIdAsync(int id)
        {
            try
            {
                BusinessValidationHelper.ThrowIfZeroOrLess(id, "El ID debe ser mayor que cero.");

                var entity = await Data.GetByIdAsync(id);
                return entity == null ? default : _mapper.Map<TGetDto>(entity);
            }
            catch (Exception ex)
            {
                throw new BusinessException($"Error al obtener el registro con ID {id}.", ex);
            }
        }

        protected virtual IQueryable<TEntity>? ApplyUniquenessFilter(IQueryable<TEntity> query, TEntity candidate)
            => null;

        public override async Task<TGetDto> CreateAsync(TCreateDto dto)
        {
            try
            {
                BusinessValidationHelper.ThrowIfNull(dto, "El DTO no puede ser nulo.");
                var candidate = _mapper.Map<TEntity>(dto);

                var allEntities = await Data.GetAllAsync();
                var query = ApplyUniquenessFilter(allEntities.AsQueryable(), candidate);

                if (query is not null)
                {
                    var existing = query.FirstOrDefault();
                    if (existing is not null)
                    {
                        if (!existing.IsDeleted)
                            throw new BusinessException("Ya existe un registro con los mismos datos.");

                        existing.IsDeleted = false;
                        _mapper.Map(dto, existing);

                        var updated = await Data.UpdateAsync(existing);
                        return _mapper.Map<TGetDto>(updated);
                    }
                }

                candidate.InitializeLogicalState();
                var created = await Data.AddAsync(candidate);
                return _mapper.Map<TGetDto>(created);
            }
            catch (DbUpdateException dbx)
            {
                throw new BusinessException("Violación de unicidad al crear el registro. Revisa valores únicos.", dbx);
            }
            catch (Exception ex)
            {
                throw new BusinessException("Error al crear el registro.", ex);
            }
        }

        public override async Task<TGetDto> UpdateAsync(TCreateDto dto)
        {
            try
            {
                BusinessValidationHelper.ThrowIfNull(dto, "El DTO no puede ser nulo.");
                var entity = _mapper.Map<TEntity>(dto);
                var updated = await Data.UpdateAsync(entity);
                return _mapper.Map<TGetDto>(updated);
            }
            catch (Exception ex)
            {
                throw new BusinessException("Error al actualizar el registro.", ex);
            }
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            try
            {
                BusinessValidationHelper.ThrowIfZeroOrLess(id, "El ID debe ser mayor que cero.");

                var entity = await Data.GetByIdAsync(id);
                if (entity == null) return false;

                if (entity.Active)
                    throw new BusinessException("No se puede eliminar un registro que se encuentra activo.");

                return await Data.DeleteAsync(id);
            }
            catch (DbUpdateException dbx)
            {
                throw new BusinessException($"No se pudo eliminar el registro con ID {id} por restricciones de datos.", dbx);
            }
            catch (Exception ex)
            {
                throw new BusinessException($"Error al eliminar el registro con ID {id}.", ex);
            }
        }

        public override async Task<bool> DeleteLogicAsync(int id)
        {
            try
            {
                BusinessValidationHelper.ThrowIfZeroOrLess(id, "El ID debe ser mayor que cero.");

                var entity = await Data.GetByIdAsync(id);
                if (entity == null) return false;

                if (entity.Active)
                    throw new BusinessException("No se puede eliminar un registro que se encuentra activo.");

                return await Data.DeleteLogicAsync(id);
            }
            catch (Exception ex)
            {
                throw new BusinessException($"Error al eliminar lógicamente el registro con ID {id}.", ex);
            }
        }
    }
}
