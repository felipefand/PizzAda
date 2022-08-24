using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PizzAdaApp.Models
{
    public class Order
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Price")]
        public decimal Price { get; set; }

        [JsonPropertyName("products")]
        public List<Product> products { get; set; }

        public Order(decimal price, List<Product> products)
        {
            this.Price = price;
            this.products = products;
        }
    }
}
