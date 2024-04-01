using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Platform_App.API.DAO.Interface
{
    public interface IBaseDAL<T>
    {
        Task<ForResult> GetSingleAsync(int id);
        Task<ForResult> AddAsync(T model);
        Task<ForResult> DeleteAsync(int id);
        Task<ForResult> UpdateAsync(T model);
    }
}
