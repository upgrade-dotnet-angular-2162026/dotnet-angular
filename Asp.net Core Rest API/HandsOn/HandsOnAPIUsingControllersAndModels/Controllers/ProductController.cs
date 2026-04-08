using HandsOnAPIUsingControllersAndModels.Models;
using HandsOnAPIUsingControllersAndModels.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingControllersAndModels.Controllers
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
        //endpoints
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var products=productRepository.GetAll();
            return StatusCode(200, products); //here products is send as json data with status code 200
        }
        [HttpGet("Get/{id}")]
        public IActionResult Get([FromRoute]int id)
        {
            try
            {
                var product = productRepository.Get(id);
                if (product != null)
                    return Ok(product);
                else
                    return BadRequest("Invalid Id");
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost,Route("Add")]
        public IActionResult Add([FromBody]Product product)
        {
            productRepository.Add(product);
            return RedirectToAction("GetAll");
        }
        [HttpDelete,Route("Delete/{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            productRepository.Delete(id);
            return Ok("Record Deleted");
        }
        [HttpPut, Route("Edit")]
        public IActionResult Edit([FromBody] Product product)
        {
            productRepository.Update(product);
            return RedirectToAction("GetAll");
        }

    }
}
