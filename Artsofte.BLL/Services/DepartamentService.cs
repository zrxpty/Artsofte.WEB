using Artsofte.BLL.DTO;
using Artsofte.BLL.Interfaces;
using Artsofte.DAL.Interface;
using Artsofte.DAL.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Artsofte.BLL.Services
{
    public class DepartamentService : IDepartamentService
    {
        private IUnitOfWork _uow { get; set; }
        private IMapper _mapper;
        private readonly IEmployeeService _employeeService;

        public DepartamentService(IUnitOfWork uow, IMapper mapper, IEmployeeService employeeService)
        {
            _employeeService= employeeService;
            _uow = uow;
            _mapper = mapper;
        }
        public ICollection<DepartamentDTO> GetAll()
        {
            return _mapper.Map<ICollection<DepartamentDTO>>(_uow.GetRepository<Departament>().GetAll());
        }

        public async Task AddAsync(DepartamentDTO item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));
            Departament departament = _mapper.Map<Departament>(item);
            
            await _uow.GetRepository<Departament>().CreateAsync(departament);
            await _uow.SaveChangesAsync();
        }

        public async Task<DepartamentDTO> GetAsync(Expression<Func<Departament, bool>>? predicate)
        {
            return _mapper.Map<DepartamentDTO>(await _uow.GetRepository<Departament>().GetAsync(predicate));
        }

        public async Task DeleteAsync(Guid id)
        {
            Departament departament = await _uow.GetRepository<Departament>().GetAsync(x => x.Id == id);
            if (departament != null)
            {
                await _uow.GetRepository<Departament>().DeleteAsync(departament);
                await _uow.SaveChangesAsync();
            }
        }

        
    }
}
