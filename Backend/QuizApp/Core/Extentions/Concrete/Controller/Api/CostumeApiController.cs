using Core.Utilities.Results.MVC.BaseResult;
using Microsoft.AspNetCore.Mvc;

namespace Core.Extentions.Concrete.Controller.Api
{
    public class CostumeApiController : ControllerBase
    {
         public IActionResult ActionResultInstance<T>(IApiDataResult<T> response) where T : class
        {
            return new ObjectResult(response.Data)
            {
                StatusCode = Convert.ToInt32(response.Status)
            };
        }
    }
}
