﻿using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductVO>>> FindAll()
        {
            var products = await _productRepository.FindAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVO>> FindById(long id)
        {
            var product = await _productRepository.FindById(id);
            if(product.Id <= 0) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductVO>> Create([FromBody]ProductVO vo)
        {
            if (vo == null) return BadRequest();
            var product = await _productRepository.Create(vo);
            return Ok(product);
        }

        [HttpPut]
        public async Task<ActionResult<ProductVO>> Update([FromBody]ProductVO vo)
        {
            if (vo == null) return BadRequest();
            var product = await _productRepository.Update(vo);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var status = await _productRepository.Delete(id);
            if(!status) return BadRequest();
            return Ok(status);
        }
    }
}
