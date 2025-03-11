using CodingChallengeApi.Models;

namespace CodingChallengeApi.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
    }
} 