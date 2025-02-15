using Core.Extentions.Concrete.Controller.Api;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace WebApi.Controllers
{

    [Route("api/[controller]/[action]")]
    public class CourseController : CostumeApiController
    {
        private readonly ICourseServices courseServices;
        public CourseController(ICourseServices courseServices)
        {
            this.courseServices = courseServices;
        }

        [HttpGet("/products")]
        public async Task <IActionResult> GetCourseActiveCourseList() 
        {

            var result = await courseServices.GetAllActiveCourse();
            return ActionResultInstance(result);

        }
    }
}
