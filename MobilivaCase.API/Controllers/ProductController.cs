using CommonLibrary.Entities;
using CommonLibrary.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MobilivaCase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : GenericController
    {

        [HttpGet]
        public IActionResult GetProducts(CategoryEnum CategoryEnum)
        {






            return new ObjectResult(true);
        }

  

    }
}
