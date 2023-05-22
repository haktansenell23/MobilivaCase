using CommonLibrary.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MobilivaCase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController : ControllerBase
    {

        public IActionResult ActionResult<T>(ApiResponse<T> response)
        {
            if(response.StatusCode == 204)
            {
                return new ObjectResult(null)
                {
                    Value = response,
                    StatusCode = response.StatusCode
                };

               
            }
            return new ObjectResult(response)
            {
                Value=response,
                StatusCode=response.StatusCode,
            };

        }


    }
}
