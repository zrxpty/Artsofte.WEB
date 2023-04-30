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
    public interface IDepartamentService
    {
        Task AddAsync(DepartamentDTO item);
        Task<DepartamentDTO> GetAsync(Expression<Func<Departament, bool>>? predicate);
        ICollection<DepartamentDTO> GetAll();
        Task DeleteAsync(Guid id);
       
    }
}
