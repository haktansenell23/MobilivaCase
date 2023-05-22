using CommonLibrary.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MobilivaCase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : GenericController
    {
        [HttpPost]
        public IActionResult CreateOrder(CreateOrderRequest request)
        {



            return new ObjectResult(true);
        }



    }
}
