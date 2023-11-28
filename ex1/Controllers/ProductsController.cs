using Entities;
using Microsoft.AspNetCore.Mvc;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ex1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService service;
        public ProductsController(IProductService service)
        {
            this.service = service;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<IEnumerable<Product>> Get( string? desc, int? minPrice, int? maxPrice, [FromQuery] int?[] categoriesId)
        {
            return await service.getAllProduct( desc,  minPrice,  maxPrice, categoriesId);
        }

    

   
    }
}
