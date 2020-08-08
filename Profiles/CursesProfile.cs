using API.Dtos;
using API.Models;
using AutoMapper;

namespace API.Profiles
{
    public class CursesProfile : Profile
    {
        public CursesProfile()
        {
            CreateMap<Curse, CurseReadDto>();
        }
    }
}
