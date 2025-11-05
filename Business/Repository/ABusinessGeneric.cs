using Business.Interfaces.IBusinessBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public abstract class ABusinessGeneric<TGetDto, TCreateDto, TEntity> : IBusinessBasic<TGetDto, TCreateDto>
    {
        public abstract Task<IEnumerable<TGetDto>> GetAllAsync();
        public abstract Task<TGetDto?> GetByIdAsync(int id);
        public abstract Task<TGetDto> CreateAsync(TCreateDto dto);
        public abstract Task<TGetDto> UpdateAsync(TCreateDto dto);
        public abstract Task<bool> DeleteAsync(int id);
        public abstract Task<bool> DeleteLogicAsync(int id);
    }
}
