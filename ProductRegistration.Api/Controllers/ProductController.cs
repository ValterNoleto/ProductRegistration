using Microsoft.AspNetCore.Mvc;
using ProductRegistration.Api.Data;
using ProductRegistration.Api.Models;

namespace ProductRegistration.Api.Controllers
{
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _repository.Create(product);
            return Created("", product);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProduct(int id)
        {
            return Ok(_repository.Get(id));
        }
    }
}
