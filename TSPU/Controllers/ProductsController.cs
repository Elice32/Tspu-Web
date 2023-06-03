using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TspuWeb.Repositories;
using TspuWeb.Models;

namespace TspuWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var dbProducts = _productRepository.GetDataProduct(id);

            if (dbProducts == null)
            {
                return NotFound();
            }

            var productContract = new dbProducts(dbProducts);
            return Ok(productContract);
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] dbProducts product)
        {
            var dbProducts = new dbProducts(product);
            _productRepository.AddProduct(dbProducts);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateProduct([FromBody] dbProducts product)
        {
            if (product == null || product.Id == 0)
            {
                return BadRequest();
            }

            var dbProducts = new dbProducts(product);
            _productRepository.EditProduct(dbProducts);
            return Ok();
        }

        [HttpPost]
        public IActionResult AddProducts([FromBody] dbProducts product)
        {
            var dbProducts = new dbProducts(product);
            _productRepository.AddProduct(dbProducts);
            return Ok();
        }
    }
}