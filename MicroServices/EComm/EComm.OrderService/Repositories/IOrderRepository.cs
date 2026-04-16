using EComm.OrderService.Entities;
namespace EComm.OrderService.Repositories
{
    public interface IOrderRepository
    {
        Task CreateOrderAsync(Order order);
        Task CancelOrderAsync(Guid orderId);
        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
    }
}
