using EComm.OrderService.DTOs;
using EComm.OrderService.Entities;

namespace EComm.OrderService.Services
{
    public interface IOrderService
    {
        Task CreateOrderAsync(CreateOrderDto order);
        Task CancelOrderAsync(Guid orderId);
        Task<List<ReadOrderDto>> GetOrdersByUserIdAsync(string userId);
    }
}
