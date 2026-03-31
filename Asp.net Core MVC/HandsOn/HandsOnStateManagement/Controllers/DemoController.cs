using Microsoft.AspNetCore.Mvc;

namespace HandsOnStateManagement.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            var name = "Rajan";
            //set value in cookie
            Response.Cookies.Append("Uname", name);
            return RedirectToAction("Show");
        }
        public IActionResult Show()
        {
            //Read Cookie
            var name = Request.Cookies["Uname"];
            ViewBag.Name = name;
            return View();
        }
    }
}
