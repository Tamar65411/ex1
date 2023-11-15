﻿using Entities;

namespace Repository
{
    public interface IProductRepository
    {
    
        Task<IEnumerable<Product>> getAllProduct(int position, int skip, string? desc, int? minPrice, int? maxPrice, int?[] categoriesId);
     
    }
}