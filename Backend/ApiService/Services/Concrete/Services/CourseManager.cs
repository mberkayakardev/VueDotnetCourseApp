using AutoMapper;
using Core.Utilities.Results.MVC.BaseResult;
using Dtos.Concrete.CourseDtos;
using Entities.Concrete.Courses;
using QuizApp.Repositories.EntityFramework.Abstract;
using QuizApp.Services.Abstract.Base;
using Services.Abstract;

namespace Services.Concrete.Services
{
    public class CourseManager : BaseServices, ICourseServices
    {
        public CourseManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public async Task<IApiDataResult<List<CourseListDto>>> GetAllActiveCourse()
        {
            var result = await _unitOfWork.GetGenericRepositories<Courses>().GetAllAsync(x => x.IsActive == true);
            if (result == null || result.Count == 0)
                return new ApiDataResult<List<CourseListDto>>(null, Core.Utilities.Results.MVC.ComplexTypes.ApiResultStatus.NotFound);

            var MappingResult  = _mapper.Map<List<CourseListDto>>(result);

            return new ApiDataResult<List<CourseListDto>>(MappingResult, Core.Utilities.Results.MVC.ComplexTypes.ApiResultStatus.Ok,""); 
        }
    }
}
