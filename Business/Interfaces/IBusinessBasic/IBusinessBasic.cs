using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces.IBusinessBasic
{
    public interface IBusinessBasic<TDtoGet, TDtoCreate>
    {
        Task<IEnumerable<TDtoGet>> GetAllAsync();
        Task<TDtoGet?> GetByIdAsync(int id);
        Task<TDtoGet> CreateAsync(TDtoCreate dto);
        Task<TDtoGet> UpdateAsync(TDtoCreate dto);
        Task<bool> DeleteAsync(int id);
        Task<bool> DeleteLogicAsync(int id);
    }
}
