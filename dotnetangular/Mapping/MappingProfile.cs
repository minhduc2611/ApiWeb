using AutoMapper;
using dotnetangular.Controllers.Resources;
using dotnetangular.Models;

namespace dotnetangular.Mapping
{
    public class MappingProfile : Profile
    {
        
        public MappingProfile()
        {
            CreateMap<Make,MakeResource>();
            CreateMap<DemoModel,DemoModelResource>();
        }
    }
}