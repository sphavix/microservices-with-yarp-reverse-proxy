
using Microsoft.AspNetCore.Mvc;
using Order.Api.Models;

namespace Order.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<CustomerOrder> GetOrders()
        {
            var orders = new List<CustomerOrder>();
            orders.AddRange(new List<CustomerOrder>
            {
                new CustomerOrder(1, "John Doe", "Shoes"),
                new CustomerOrder(1, "Joel Rundul", "Jacket"),
                new CustomerOrder(1, "Hulk Panthal", "Pants"),
                new CustomerOrder(1, "Zodiac Starsign", "Shirt")

            });
            return orders;
        }
    }
}