using AutoMapper;
using sistemapersonaltrainer.Server.DTOs;
using sistemapersonaltrainer.Server.Models;

namespace sistemapersonaltrainer.Server.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile(IMapperConfigurationExpression config)
        {
            config.CreateMap<User, UserReadDTO>().ReverseMap();
            config.CreateMap<User, UserCreateDTO>().ReverseMap();
        }
    }
}

