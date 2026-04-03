using Microsoft.AspNetCore.Mvc;
using ECart.BAL.DTOs;
using ECart.BAL.Services;
namespace ECart.MVC.Controllers
{
    //[Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("GetAllProducts")]
        public IActionResult Index()
        {
            var products = _productService.GetProducts();
            return View(products);
        }
        [Route("GetProduct/{name}")]
        public IActionResult Details(string name)
        {
            var product=_productService.GetProduct(name);
            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductDto productDto)
        {
            if(ModelState.IsValid)
            {
                _productService.Add(productDto);
                return RedirectToAction("Index");
            }
            return View();
        }
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("Index");
        }
        
        public IActionResult Edit(string name)
        {
            var product = _productService.GetProduct(name);
            return View(product);
        }
        [HttpPost]
     
        public IActionResult Edit(ProductDto productDto)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(productDto);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
