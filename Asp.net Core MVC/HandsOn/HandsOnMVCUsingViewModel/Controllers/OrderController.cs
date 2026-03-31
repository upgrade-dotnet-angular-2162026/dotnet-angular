using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingViewModel.Models;
using HandsOnMVCUsingViewModel.ViewModel;
namespace HandsOnMVCUsingViewModel.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Order/OrderDetails/{OrderId}")]
        public IActionResult OrderDetails(string OrderId)
        {
            Product product = new Product()
            {
                Id = 3083,
                Name = "Mouse",
                Price = 1000
            };
            Order order = new Order()
            {
                OrderId="O0001",
                ProductId=product.Id,
                Qty=3,
                OrderDate=DateTime.Now,
                
            };
            order.TotalPrice = order.Qty * product.Price;
            ProductOrderVM productOrderVM = new ProductOrderVM()
            {
                ProductId = product.Id,
                Name = product.Name,
                OrderId = order.OrderId,
                Qty = order.Qty,
                OrderDate = order.OrderDate,
                TotalPrice = order.TotalPrice,
                Price = product.Price,
                DeliverDate = order.OrderDate.AddDays(3)

            };
            return View(productOrderVM);
        }
    }
}
