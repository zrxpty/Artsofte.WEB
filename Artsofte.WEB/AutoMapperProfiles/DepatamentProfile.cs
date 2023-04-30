using Artsofte.BLL.DTO;
using Artsofte.DAL.Models;
using Artsofte.WEB.Models.ViewModels;
using AutoMapper;

namespace Artsofte.WEB.AutoMapperProfiles
{
    public class DepatamentProfile: Profile
    {
        public DepatamentProfile()
        {
            CreateMap<Departament, DepartamentVM>().ReverseMap();
            CreateMap<DepartamentVM, DepartamentDTO>().ReverseMap();
            CreateMap<DepartamentDTO, Departament>().ReverseMap();
            CreateMap<DepartamentDTO, DepartamentVM>().ReverseMap();
        }
    }
}
