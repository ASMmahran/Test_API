using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Test_API.Controllers.V1
{
    [ApiController]
    [ApiVersion(1.0)]
    [Route("api/v{version:apiVersion}/products")]
    public class ProductsController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var product = new
            {
                id = 1,
                name = "Laptop",
                price = 25000
            };
            return Ok(product);
        }
    }
}