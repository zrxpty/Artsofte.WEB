using Artsofte.BLL.DTO;
using Artsofte.DAL.Models;
using Artsofte.WEB.Models.ViewModels;
using AutoMapper;

namespace Artsofte.WEB.AutoMapperProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile() { 
            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<EmployeeDTO, EmployeeVM>().ReverseMap();
        }
    }
}
