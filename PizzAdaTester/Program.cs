using System.Text.Json;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace PizzAdaTester
{
    public class Product
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Price")]
        public decimal Price { get; set; }

        public Product(string Name, decimal Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
    }

    internal class Program
    {
        public static async Task TestMethod(Product product)
        {
            HttpClient client = new HttpClient();
            var url = "https://localhost:7062/produtos/";

            var json = JsonSerializer.Serialize(product);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var result = await client.PostAsync(url, data);

            var code = result.StatusCode;

            Console.WriteLine(code);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Nome:");
                var name = Console.ReadLine();
                Console.WriteLine("Preço:");
                var price = Decimal.Parse(Console.ReadLine());

                var product = new Product(name, price);
                TestMethod(product);
                Console.ReadKey();
            }
        }


    }
}