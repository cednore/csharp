using CodingChallengeApi.Models;
using CodingChallengeApi.ViewModel;
using System.Text.Json;

namespace CodingChallengeApi.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ProductService> _logger;
        private List<Product> _cachedProducts;

        public ProductService(HttpClient httpClient, ILogger<ProductService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
            _cachedProducts = new List<Product>();
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            if (_cachedProducts.Any())
            {
                return _cachedProducts;
            }

            try
            {

                var productList = new List<ProductViewModel>();
                _logger.LogInformation("Fetching the data of products from external fake store API");
                productList = await _httpClient.GetAsync("https://fakestoreapi.com/products");
                var productDBList = new List<Product>();
                if (productList != null)
                {
                    _logger.LogInformation("Successfully fetched data of products");
                    var product = new Product();
                    foreach (var item in productList)
                    {
                        product.Id = item.Id;
                        product.Name = item.Name;
                        product.Description = item.Description;
                        product.Price = item.Price;
                        product.StockQuantity = item.StockQuantity;
                        product.Category = item.Category;
                        product.StoImageUrlckQuantity = item.StoImageUrlckQuantity;
                    }
                    _logger.LogInformation("Adding data to product model from list of product");
                    productDBList.Add(product);
                }
                    // TODO: Replace this mock implementation with a real API call to Fake Store API
                    // API Endpoint: https://fakestoreapi.com/products
                    // Use the _httpClient to make the API call

                    // Example of how to make an HTTP request:
                    // var response = await _httpClient.GetAsync("https://fakestoreapi.com/products");
                    // response.EnsureSuccessStatusCode();
                    // var content = await response.Content.ReadAsStringAsync();

                    // TODO: Deserialize the JSON response and map it to our Product model
                    // You'll need to transform the data from the Fake Store API format to our Product model

                    // For now, we're using mock data
                    _cachedProducts = GenerateMockProducts();
                
                // Simulate network delay
                await Task.Delay(300);
                
                return _cachedProducts;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching products from external API");
                return Enumerable.Empty<Product>();
            }
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            var products = await GetProductsAsync();
            return products.FirstOrDefault(p => p.Id == id);
        }

        private List<Product> GenerateMockProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Description = "High-performance laptop", Price = 1299.99m, StockQuantity = 10, Category = "Electronics" },
                new Product { Id = 2, Name = "Smartphone", Description = "Latest smartphone model", Price = 899.99m, StockQuantity = 15, Category = "Electronics" },
                new Product { Id = 3, Name = "Headphones", Description = "Noise-cancelling headphones", Price = 199.99m, StockQuantity = 20, Category = "Audio" },
                new Product { Id = 4, Name = "Coffee Maker", Description = "Automatic coffee maker", Price = 89.99m, StockQuantity = 5, Category = "Kitchen" },
                new Product { Id = 5, Name = "Desk Chair", Description = "Ergonomic office chair", Price = 249.99m, StockQuantity = 8, Category = "Furniture" }
            };
        }
    }
} 