using Entities;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService : IProductService
    {
        private IProductRepository repository;
        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<Product>> getAllProduct(int position, int skip, string? desc, int? minPrice, int? maxPrice, int?[] categoriesId)
        {
            return await repository.getAllProduct( position,  skip,  desc,  minPrice,  maxPrice,categoriesId);
        }
    }
}
