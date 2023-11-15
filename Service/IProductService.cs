using Entities;

namespace Service
{
    public interface IProductService
    {
  
        Task<IEnumerable<Product>> getAllProduct(int position, int skip, string? desc, int? minPrice, int? maxPrice, int?[] categoriesId);
       
        //Task<Product> getProductById(int id);
    }
}