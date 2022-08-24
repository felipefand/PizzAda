using PizzAdaApp.Models;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Reflection;
using System.Text;


namespace PizzAdaApp
{
    public partial class Form1 : Form
    {
        static private string baseUrl = Properties.Settings.Default.BaseUrl;
        private List<Product> productList;

        public Form1()
        {
            InitializeComponent();
            var products = GetProducts("").Result;
            PopulateProductBoxes(products, false);
            productList = new List<Product>();
        }

        public int FilterId(string unique)
        {
            var id = String.Empty;

            for (int i = 0; i < unique.Length; i++)
            {
                if (Char.IsDigit(unique[i]))
                    id += unique[i];
                else
                    break;
            }

            Int32.TryParse(id, out int returnId);
            return returnId;
        }

        public int GetIdByName(string name)
        {
            var products = GetProducts("").Result;
            var product = products.FirstOrDefault(x => x.Name.Equals(name));

            if (product == null) return 0;

            return product.Id;
        }

        private void StatusUpdate(string status)
        {
            statusLabel.Text = $"Status: {status}";
        }

        private decimal PriceUpdate()
        {
            var price = 0M;

            foreach(var product in productList)
            {
                price += product.Price;
            }

            priceLabel.Text = $"Preço Total: {price.ToString("C")}";

            return price;
        }

        private void PopulateProductBoxes(List<Product> products, bool droppedDown)
        {
            editNameBox.Items.Clear();
            productBox.Items.Clear();
            for (int i = 0; i < products.Count; i++)
            {
                productBox.Items.Add($"{products[i].Id} - {products[i].Name} - {products[i].Price.ToString("C")}");
                editNameBox.Items.Add(products[i].Name);
            }

            if (droppedDown)
                productBox.DroppedDown = true;
        }

        // GET
        private async static Task<Product> GetProduct(int id)
        {
            HttpClient client = new HttpClient();
            var url = baseUrl + "produtos/" + id;

            var response = await client.GetAsync(url).ConfigureAwait(false);
            var json = await response.Content.ReadAsStringAsync();
            var product = JsonSerializer.Deserialize<Product>(json);

            if (product == null) return new Product();

            return product;
        }

        private async void editNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = GetIdByName(editNameBox.Text);

            var product = GetProduct(id).Result;

            editPriceBox.Text = product.Price.ToString();
        }

        public static async Task<List<Product>> GetProducts(string filter)
        {
            HttpClient client = new HttpClient();
            var url = baseUrl + "produtos/" + (string.IsNullOrEmpty(filter) ? "" : $"?filter={filter}");

            var response = await client.GetAsync(url).ConfigureAwait(false);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<Result>(json);

            if (result.StatusCode != 200)
                return new List<Product>();

            return result.List;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            var products = GetProducts(filterBox.Text).Result;

            PopulateProductBoxes(products, true);
            filterBox.Text = String.Empty;
        }

        // POST
        public static async Task<bool> CreateProduct(Product product)
        {
            HttpClient client = new HttpClient();
            var url = baseUrl + "produtos/";

            var json = JsonSerializer.Serialize(product);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var result = await client.PostAsync(url, data).ConfigureAwait(false);

            var code = result.StatusCode;

            if (((int)code).Equals(401)) return false;

            return true;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(registerPriceBox.Text, out decimal price);
            if (!string.IsNullOrEmpty(registerNameBox.Text) && price > 0)
            {
                var product = new Product(registerNameBox.Text, price);
                var created = CreateProduct(product).Result;

                if (!created)
                {
                    StatusUpdate("Nome de produto repetido!");
                    return;
                }

                StatusUpdate("Produto criado com sucesso.");
                var products = GetProducts("").Result;
                PopulateProductBoxes(products, false);
                registerPriceBox.Text = String.Empty;
                registerNameBox.Text = String.Empty;
            }
        }

        // REMOVE
        public static async Task<bool> RemoveProduct(int productId)
        {
            HttpClient client = new HttpClient();
            var url = baseUrl + "produtos/" + productId;

            var result = await client.DeleteAsync(url).ConfigureAwait(false);
            var code = result.StatusCode;

            if ((int)code == 404) return false;

            return true;
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            var id = GetIdByName(editNameBox.Text);

            if (id == 0) return;

            var deleted = RemoveProduct(id).Result;

            if (!deleted)
            {
                StatusUpdate("Produto não encontrado.");
                return;
            }

            StatusUpdate("Produto removido com sucesso.");
            var products = GetProducts("").Result;
            PopulateProductBoxes(products, false);
            editPriceBox.Text = String.Empty;
        }

        // UPDATE
        private static async Task<bool> EditProduct(Product product)
        {
            HttpClient client = new HttpClient();
            var url = baseUrl + "produtos/";

            var json = JsonSerializer.Serialize(product);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var result = await client.PatchAsync(url, data).ConfigureAwait(false);

            var code = result.StatusCode;

            if ((int)code == 404) return false;

            return true;

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(editPriceBox.Text, out decimal price);
            if (!string.IsNullOrEmpty(editNameBox.Text) && price > 0)
            {
                var product = new Product(editNameBox.Text, price);
                var edited = EditProduct(product).Result;


                if (!edited)
                {
                    StatusUpdate("Edição inválida.");
                    return;
                }

                StatusUpdate("Produto editado com sucesso.");
                var products = GetProducts("").Result;
                PopulateProductBoxes(products, false);
                editPriceBox.Text = String.Empty;
            }
        }

        // ORDER
        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            var id = FilterId(productBox.Text);

            var product = GetProduct(id).Result;

            if (product == null) return;

            productList.Add(product);
            orderList.Items.Add(product.Name).SubItems.Add(product.Price.ToString("C"));
            PriceUpdate();
        }

        private void deleteEntryButton_Click(object sender, EventArgs e)
        {
            if (productList.Count == 0) return;

            productList.RemoveAt(productList.Count - 1);
            orderList.Items.RemoveAt(orderList.Items.Count - 1);
            PriceUpdate();
        }

        // POST ORDER
        public static async Task<bool> CreateOrder(Order order)
        {
            HttpClient client = new HttpClient();
            var url = baseUrl + "pedidos/";

            var json = JsonSerializer.Serialize(order);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var result = await client.PostAsync(url, data).ConfigureAwait(false);

            var code = result.StatusCode;

            if (((int)code).Equals(401)) return false;

            return true;
        }

        private void finishOrderButton_Click(object sender, EventArgs e)
        {
            if (orderList.Items.Count == 0) return;

            var price = PriceUpdate();

            var order = new Order(price, productList);

            var created = CreateOrder(order).Result;

            if (!created)
            {
                StatusUpdate("Pedido falhou.");
                return;
            }

            StatusUpdate("Pedido finalizado com sucesso.");

            productList.Clear();
            orderList.Items.Clear();
            priceLabel.Text = "Preço Total: ";
        }

        // GET ORDER
        public static async Task<List<Order>> GetOrders()
        {
            HttpClient client = new HttpClient();
            var url = baseUrl + "pedidos/";

            var response = await client.GetAsync(url).ConfigureAwait(false);
            var json = await response.Content.ReadAsStringAsync();
            var orders = JsonSerializer.Deserialize<List<Order>>(json);

            return orders;
        }
        private void statsButton_Click(object sender, EventArgs e)
        {
            var orders = GetOrders().Result;
            var totalValue = 0M;

            foreach(var order in orders)
            {
                totalValue += order.Price;
            }

            Form2 form = new Form2();
            form.Show();
            form.orderCountLabel.Text = $"Total de Pedidos: {orders.Count}";
            form.totalValueLabel.Text = $"Valor Total de Vendas: {totalValue}";

        }
    }
}