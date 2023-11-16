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

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        //public async Task<IEnumerable<Product>> Get(int id)
        //{
        //    return await service.getProductsByCategoryId(id);
        //}

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
