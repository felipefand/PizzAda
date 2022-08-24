using Microsoft.AspNetCore.Mvc;
using PizzAdaAPI.Models;
using System.Text.Json;
using static PizzAdaAPI.Utils;

namespace PizzAdaAPI.Controllers
{
    [ApiController]
    [Route("produtos")]
    public class PizzaController : Controller
    {

        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get([FromQuery] string? filter)
        {
            Console.WriteLine($"GET REACHED | Filter = {filter}");
            var products = GetProductList();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                var filteredProducts = products
                    .Where(x => x.Name.ToLower().Contains(filter.ToLower()))
                    .ToList();

                Console.WriteLine("[GET] Returning filtered list.");
                return Ok(new
                {
                    StatusCode = 200,
                    Message = "Produto(s) encontrado(s).",
                    Data = filteredProducts
                });
            }

            Console.WriteLine("[GET] Returning non-filtered list.");
            return Ok(new
            {
                StatusCode = 200,
                Message = "Filtro não aplicado.",
                Data = products
            });
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get (int id)
        {
            Console.WriteLine($"SINGLE GET REACHED | Product ID = {id}");
            var products = GetProductList();
            var product = products.FirstOrDefault(x => x.Id == id);

            if (product == null) return NotFound();

            Console.WriteLine($"[SINGLE GET] Returning {product.Name}");
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Create([FromBody] Product requestProduct)
        {
            Console.WriteLine($"POST REACHED | ProductName = {requestProduct.Name}");
            var products = GetProductList();
            if (products.Any(x => x.Name == requestProduct.Name)) return Unauthorized(); // Haven't found anything to use instead of Unauthorized. Yet.

            requestProduct.Id = Utils.GetNextId();

            products.Add(requestProduct);

            Serialize(products);

            Console.WriteLine($"[POST] Product {requestProduct.Name} was successfully created.");
            return Created("", requestProduct);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> Delete(int id)
        {
            Console.WriteLine($"DELETE REACHED | ProductId = {id}");
            var products = GetProductList();
            var product = products.FirstOrDefault(x => x.Id.Equals(id));

            if (product == null) return NotFound();

            products.Remove(product);
            Serialize(products);

            Console.WriteLine($"[DELETE] Product {product.Name} was successfully deleted.");
            return Ok(new
            {
                StatusCode = 200,
                Message = "Deletado com Sucesso",
                Data = product
            });
        }

        [HttpPatch]
        public async Task<ActionResult<Product>> Update([FromBody] Product requestProduct)
        {
            Console.WriteLine($"UPDATE REACHED | ProductName = {requestProduct.Name}");

            var products = GetProductList();
            var product = products.FirstOrDefault(x => x.Name.Equals(requestProduct.Name));

            if (product == null) return NotFound();

            Console.WriteLine($"[UPDATE] {product.Name}'s price changed from {product.Price} to {requestProduct.Price}");
            product.Price = requestProduct.Price;

            Serialize(products);
            return Ok(product);
        }
    }
}
