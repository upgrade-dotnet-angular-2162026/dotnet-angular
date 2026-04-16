using EComm.OrderService.DTOs;
using EComm.OrderService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComm.OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet("GetOrdersByUser/{userId}")]
        public async Task<IActionResult> GetOrders(string userId)
        {
            var orders = await _orderService.GetOrdersByUserIdAsync(userId);
            return Ok(orders);
        }
        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderDto orderDto)
        {
            await _orderService.CreateOrderAsync(orderDto);
            return Ok(orderDto);
        }
        [HttpDelete("CancelOrder/{orderId}")]
        public async Task<IActionResult> CancelOrder(Guid orderId)
        {
            await _orderService.CancelOrderAsync(orderId);
            return NoContent();
        }
    }
}
