using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.DTO;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        //public OrderController()
        //{
        //    _httpClient = new HttpClient();
        //    _httpClient.BaseAddress = new Uri("http://localhost:5171/");
        //}


        public OrderController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        [HttpGet("placeOrder/{productId}/{orderId}")]
        public async Task<IActionResult> PlaceOrder(int productId, int orderId)
        {

            if (await IsProductAvailable(productId))
            {
                return Ok("Order Placed!!!");
            }
            else
            {
                return Ok("Out of Stock!!!");
            }
        }

        //[HttpGet("isProductAvailable/{productId}")]
        [NonAction]
        public async Task<bool> IsProductAvailable(int productId)
        {
            //convert JsonData to ProductAvailabiltityDTO
            var response = await _httpClient.GetFromJsonAsync<ProductAvailabilityDto>(
                $"api/products/{productId}/availability");

            return response.Available;
        }
    }
}
