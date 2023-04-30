using Artsofte.BLL.DTO;
using Artsofte.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Artsofte.BLL.Interfaces
{
    public interface IEmployeeService
    {
        Task AddAsync(EmployeeDTO item);
        Task<EmployeeDTO> GetAsync(Expression<Func<Employee, bool>>? predicate);
        ICollection<EmployeeDTO> GetAll();
        Task DeleteAsync(Guid id);
        Task<EmployeeDTO> UpdateAsync(EmployeeDTO item);
        
    }
}
