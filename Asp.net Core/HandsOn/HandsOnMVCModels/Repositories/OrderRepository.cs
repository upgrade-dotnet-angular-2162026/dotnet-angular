using HandsOnMVCModels.Models;

namespace HandsOnMVCModels.Repositories
{
    public interface IOrderRepository
    {
        void MakeOrder(Order order);
        void EditOrder(Order order);
        void DeleteOrder(Guid orderId);
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

        public void DeleteOrder(Guid orderId)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].OrderId == orderId)
                {
                    orders.RemoveAt(i);
                }
            }
        }

        public void EditOrder(Order order)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].OrderId==order.OrderId)
                {
                    orders[i].TotalPrice = order.TotalPrice;
                }
            }
        }

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

        public void MakeOrder(Order order)
        {
            orders.Add(order);
        }
    }
}
