
using Microsoft.AspNetCore.Mvc;

namespace Products.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly string[] Products = new[]
        {
            "Clothes", "Bags", "Shoes", "Jackets", "Pants", "Shirts"
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Products);
        }
    }
}