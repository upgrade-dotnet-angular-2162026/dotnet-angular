using Microsoft.AspNetCore.Mvc;
using HandsOnMVCModels.Models;
namespace HandsOnMVCModels.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> producs = new List<Product>()
            {
                new Product(){ProductId=23,Name="Mouse",Price=500,Description="E-Item"},
                new Product(){ProductId=22,Name="Keyboard",Price=800,Description="E-Item"},
                new Product(){ProductId=29,Name="Headset",Price=1500,Description="E-Item"},
                new Product(){ProductId=26,Name="Earbuds",Price=2500,Description="E-Item"},
            };
            return View(producs);
        }
        public IActionResult Details()
        {
            //initiate model with in the action Details
            Product product = new Product()
            {
                ProductId = 33,
                Name = "Laptop",
                Price = 56000,
                Description = "Electronic Gadget"
            };
            return View(product); //use product details in a view page
        }
    }
}
