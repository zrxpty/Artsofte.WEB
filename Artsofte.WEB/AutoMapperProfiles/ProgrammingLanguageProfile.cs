using Artsofte.BLL.DTO;
using Artsofte.DAL.Models;
using Artsofte.WEB.Models.ViewModels;
using AutoMapper;

namespace Artsofte.WEB.AutoMapperProfiles
{
    public class ProgrammingLanguageProfile: Profile
    {
        public ProgrammingLanguageProfile()
        {
            CreateMap<ProgrammingLanguage, ProgrammingLanguageVM>().ReverseMap();
            CreateMap<ProgrammingLanguageVM, ProgrammingLanguageDTO>().ReverseMap();
            CreateMap<ProgrammingLanguage, ProgrammingLanguageDTO>().ReverseMap();
        }
    }
}
