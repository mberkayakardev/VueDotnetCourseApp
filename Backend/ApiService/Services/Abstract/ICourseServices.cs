using Core.Utilities.Results.MVC.BaseResult;
using Dtos.Concrete.CourseDtos;
using QuizApp.Services.Abstract.Base;

namespace Services.Abstract
{
    public interface ICourseServices : IBaseServices
    {
        Task<IApiDataResult<List<CourseListDto>>> GetAllActiveCourse();
    }
}
