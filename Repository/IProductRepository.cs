﻿using Entities;

namespace Repository
{
    public interface IProductRepository
    {
    
        Task<IEnumerable<Product>> getAllProduct( string? desc, int? minPrice, int? maxPrice, int?[] categoriesId);
     
    }
}