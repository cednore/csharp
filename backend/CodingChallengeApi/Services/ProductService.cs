using CodingChallengeApi.Models;
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
                // This is a mock external API call that the candidate would replace with a real API
                // For the challenge, they could use a real public API like https://fakestoreapi.com/products
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