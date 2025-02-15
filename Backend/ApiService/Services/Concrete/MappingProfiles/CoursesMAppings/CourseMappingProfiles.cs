using AutoMapper;
using Dtos.Concrete.CourseDtos;
using Entities.Concrete.Courses;

namespace Services.Concrete.MappingProfiles.CoursesMAppings
{
    public class CourseMappingProfiles : Profile
    {
        public CourseMappingProfiles()
        {
            CreateMap<Courses,CourseListDto>().ReverseMap();
        }
    }
}
