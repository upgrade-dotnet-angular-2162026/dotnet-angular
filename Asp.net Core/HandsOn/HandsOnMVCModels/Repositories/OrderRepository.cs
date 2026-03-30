using HandsOnMVCModels.Models;

namespace HandsOnMVCModels.Repositories
{
    public interface IOrderRepository
    {
        
        Order? GetOrder(Guid orderId);
        List<Order> GetOrders(string customreId);
    }
    public class OrderRepository : IOrderRepository
    {
        private static List<Order> orders = new List<Order>()
        {
            new Order()
            {
                OrderId = Guid.NewGuid(),
                OrderDate = DateTime.Now,
                CustomerId="C0001",
                TotalPrice=4500
            }
        };
       
        public Order? GetOrder(Guid orderId)
        {
            Order ?order = orders.SingleOrDefault(o => o.OrderId == orderId);
            return order;
        }

        public List<Order> GetOrders(string customreId)
        {
            var custoerOrders = orders.Where(o => o.CustomerId == customreId).ToList();
            return custoerOrders;
        }

      
    }
}
