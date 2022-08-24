using System.Text.Json.Serialization;

namespace PizzAdaAPI.Models
{
    public class Product
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Price")]
        public decimal Price { get; set; }
    }
}
