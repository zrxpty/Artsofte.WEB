using Artsofte.BLL.DTO;
using Artsofte.BLL.Interfaces;
using Artsofte.DAL.Interface;
using Artsofte.DAL.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Artsofte.BLL.Services
{
    public class ProgrammingLanguageService : IProgrammingLanguageService
    {
        private IUnitOfWork _uow { get; set; }
        private IMapper _mapper;

        public ProgrammingLanguageService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public ICollection<ProgrammingLanguageDTO> GetAll()
        {
            return _mapper.Map<ICollection<ProgrammingLanguageDTO>>(_uow.GetRepository<ProgrammingLanguage>().GetAll());
        }

        public async Task AddAsync(ProgrammingLanguageDTO item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));
            ProgrammingLanguage programming = _mapper.Map<ProgrammingLanguage>(item);

            await _uow.GetRepository<ProgrammingLanguage>().CreateAsync(programming);
            await _uow.SaveChangesAsync();
        }

        public Task<ProgrammingLanguageDTO> GetAsync(Expression<Func<ProgrammingLanguageDTO, bool>>? predicate)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            ProgrammingLanguage programmingLanguage = await _uow.GetRepository<ProgrammingLanguage>().GetAsync(x => x.Id == id);
            if (programmingLanguage != null)
            {
                await _uow.GetRepository<ProgrammingLanguage>().DeleteAsync(programmingLanguage);
                await _uow.SaveChangesAsync();
            }
        }

        
    }
}
