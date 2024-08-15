
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
        public async Task<IActionResult> Get()
        {
            await Task.Delay(4000);
            return Ok(Products);
        }
    }
}