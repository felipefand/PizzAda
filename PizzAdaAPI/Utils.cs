using PizzAdaAPI.Models;
using System.Text.Json;

namespace PizzAdaAPI
{
    static public class Utils
    {
        static public List<Product> GetProductList()
        {
            using var reader = new StreamReader("./produtos.json");
            var json = reader.ReadToEnd();
            var products = JsonSerializer.Deserialize<List<Product>>(json);

            return products;
        }

        static public int GetNextId()
        {
            var products = GetProductList().OrderBy(x => x.Id).ToList();
            var id = 1;

            for (int i = 0; i < products.Count(); i++)
            {
                if (products[i].Id == id)
                    id++;
            }

            return id;
        }

        static public void Serialize(List<Product> products)
        {
            var json = JsonSerializer.Serialize(products);
            System.IO.File.WriteAllText("./produtos.json", json);
        }

        // TOFIX DRY
        static public List<Order> GetOrderList()
        {
            using var reader = new StreamReader("./pedidos.json");
            var json = reader.ReadToEnd();
            var orders = JsonSerializer.Deserialize<List<Order>>(json);

            return orders;
        }

        static public void SerializeOrders(List<Order> orders)
        {
            var json = JsonSerializer.Serialize(orders);
            System.IO.File.WriteAllText("./pedidos.json", json);
        }
    }
}
