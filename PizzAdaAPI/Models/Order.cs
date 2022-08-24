using System.Text.Json.Serialization;

namespace PizzAdaAPI.Models
{
    public class Order
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Price")]
        public decimal Price { get; set; }

        [JsonPropertyName("products")]
        public List<Product> products { get; set; }
    }
}
