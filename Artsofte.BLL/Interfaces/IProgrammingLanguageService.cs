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
    public interface IProgrammingLanguageService
    {
        Task AddAsync(ProgrammingLanguageDTO item);
        Task<ProgrammingLanguageDTO> GetAsync(Expression<Func<ProgrammingLanguageDTO, bool>>? predicate);
        ICollection<ProgrammingLanguageDTO> GetAll();
        Task DeleteAsync(Guid id);
        
    }
}
