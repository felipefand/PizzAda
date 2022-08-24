using Microsoft.AspNetCore.Mvc;
using PizzAdaAPI.Models;
using static PizzAdaAPI.Utils;

namespace PizzAdaAPI.Controllers
{
    [ApiController]
    [Route("pedidos")]
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetOrder()
        {
            Console.WriteLine($"ORDER GET REACHED");
            var orders = GetOrderList();

            Console.WriteLine($"[ORDER GET] Returning {orders.Count} orders.");
            return Ok(orders);
        }

        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder([FromBody] Order order)
        {
            Console.WriteLine($"POST ORDER REACHED");
            var orders = GetOrderList();
            order.Id = orders.Count + 1;

            orders.Add(order);

            SerializeOrders(orders);

            Console.WriteLine($"[POST ORDER] Order {order.Id} was successfully created.");
            return Created("", order);
        }
    }
}
