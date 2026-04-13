using ECommService.DTOs;
using ECommService.Entities;
using ECommService.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace ECommService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add(ProductCreateDto productDto)
        {
            //convert productDto to product entity
            if (ModelState.IsValid)
            {
                try
                {
                    var product = new Product()
                    {
                        Name = productDto.Name,
                        Price = productDto.Price,
                        Stock = productDto.Stock,
                    };
                    await productRepository.Add(product);
                    return Ok(product);
                }
                catch (Exception ex)
                {

                    return StatusCode(500, ex.InnerException.Message);
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        [HttpGet("Search/{name}")]
        public async Task<IActionResult> Search(string name)
        {
            try
            {
                var product = await productRepository.Search(name);
                //convert product entity to productReadDto
                var productReadDto = new ProductReadDto()
                {
                    Name = product.Name,
                    Price = product.Price,
                    Id = product.Id
                };
                return Ok(productReadDto);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.InnerException.Message);
            }
        }
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                var product = await productRepository.Get(id);
                await productRepository.Delete(product);
                return Ok(product);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.InnerException.Message);
            }
        }
        [HttpPatch("Edit")]
        public async Task<IActionResult> Update([FromQuery] int id, [FromBody] ProductUpdateDto dto)
        {
            try
            {
                var existingProduct = await productRepository.Get(id);
                existingProduct.Price = dto.Price;
                existingProduct.Stock = dto.Stock;
                await productRepository.Update(existingProduct);
                return Ok(existingProduct);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.InnerException.Message);
            }

        }


        [HttpGet("GetAll")]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var products = await productRepository.GetAll();
                //convert product entities to ProductReadDtos
                var productsDto = products.Select(product => new ProductReadDto()
                {
                    Name = product.Name,
                    Price = product.Price,
                    Id = product.Id
                });
                return Ok(productsDto);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.InnerException.Message);
            }
        }
    }
}
