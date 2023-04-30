using Artsofte.BLL.DTO;
using Artsofte.BLL.Interfaces;
using Artsofte.DAL.Interface;
using Artsofte.DAL.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Artsofte.BLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IUnitOfWork _uow { get; set; }
        private IMapper _mapper;

        public EmployeeService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task AddAsync(EmployeeDTO item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));
            var departament = await _uow.GetRepository<Departament>().GetAsync(x => x.Id == item.Departament.Id);
            var programmingLanguage = await _uow.GetRepository<ProgrammingLanguage>().GetAsync(x => x.Id == item.ProgrammingLanguage.Id);
            Employee employee = _mapper.Map<Employee>(item);
            employee.ProgrammingLanguage = programmingLanguage;
            employee.Departament = departament;
            await _uow.GetRepository<Employee>().CreateAsync(employee);
            await _uow.SaveChangesAsync();
           
        }

        public async Task DeleteAsync(Guid id)
        {
            Employee employee = await _uow.GetRepository<Employee>().GetAsync(x => x.Id == id);
            if (employee != null)
            {
                await _uow.GetRepository<Employee>().DeleteAsync(employee);
                await _uow.SaveChangesAsync();
            }
        }

        public ICollection<EmployeeDTO> GetAll()
        {
            return _mapper.Map<ICollection<EmployeeDTO>>(_uow.GetRepository<Employee>().GetAll().Include(x => x.Departament).Include(x => x.ProgrammingLanguage));
        }

        public async Task<EmployeeDTO> GetAsync(Expression<Func<Employee, bool>>? predicate)
        {
            
            return _mapper.Map<EmployeeDTO>(await _uow.GetRepository<Employee>().GetAsync(predicate, x => x.Departament, x => x.ProgrammingLanguage));
        }

        public async Task<EmployeeDTO> UpdateAsync(EmployeeDTO item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            var newDepartament = await _uow.GetRepository<Departament>().GetAsync(x => x.Id == item.Departament.Id);
            if (newDepartament == null)
            {
                throw new ArgumentException($"Departament with Id={item.Departament.Id} does not exist in the database.");
            }

            var newProgrammingLanguage = await _uow.GetRepository<ProgrammingLanguage>().GetAsync(x => x.Id == item.ProgrammingLanguage.Id);
            if (newProgrammingLanguage == null)
            {
                throw new ArgumentException($"ProgrammingLanguage with Id={item.ProgrammingLanguage.Id} does not exist in the database.");
            }

            var newEmployee = await _uow.GetRepository<Employee>().GetAsync(x => x.Id == item.Id);
            if (newEmployee == null)
            {
                throw new ArgumentException($"Employee with Id={item.Id} does not exist in the database.");
            }

            newEmployee.Name = item.Name;
            newEmployee.Surname = item.Surname;
            newEmployee.ProgrammingLanguageId = newProgrammingLanguage.Id;
            newEmployee.DepartamentId = newDepartament.Id;

            newEmployee = await _uow.GetRepository<Employee>().UpdateAsync(newEmployee);
            await _uow.SaveChangesAsync();

            return _mapper.Map<EmployeeDTO>(newEmployee);
        }

    }
}
