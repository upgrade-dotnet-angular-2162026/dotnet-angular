using Microsoft.AspNetCore.Mvc;
using HandsOnMVCModels.Repositories;
using HandsOnMVCModels.Models;
using AspNetCoreGeneratedDocument;
namespace HandsOnMVCModels.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        public OrderController()
        {
            _orderRepository= new OrderRepository();
        }
        public IActionResult Index()
        {
            List<Order> orders = _orderRepository.GetOrders("C0001");
            return View(orders);
        }
        public IActionResult Details(Guid orderId)
        {
            Order? order = _orderRepository.GetOrder(orderId);
            return View(order);
        }
    }
}
