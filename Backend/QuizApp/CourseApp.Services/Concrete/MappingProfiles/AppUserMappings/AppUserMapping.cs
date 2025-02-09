using AutoMapper;
using QuizApp.Dtos.Concrete.AppEntities.AppUser;
using QuizApp.Entities.Concrete.AppEntities;

namespace QuizApp.Services.Concrete.MappingProfiles.AppUserMappings
{
    public class AppUserMapping : Profile
    {
        public AppUserMapping()
        {
            CreateMap<AppUser, CreateAppUserDto>().ReverseMap();
        }
    }
}
