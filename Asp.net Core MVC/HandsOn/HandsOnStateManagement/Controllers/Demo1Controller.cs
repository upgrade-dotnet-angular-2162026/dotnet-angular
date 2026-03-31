using Microsoft.AspNetCore.Mvc;

namespace HandsOnStateManagement.Controllers
{
    public class Demo1Controller : Controller
    {
        public IActionResult Index()
        {
            var name = Request.Cookies["Uname"];
            ViewBag.Name = name;
            return View();
        }
        public IActionResult Details()
        {
            //Read session
            var uname = HttpContext.Session.GetString("uname");
            ViewBag.Username = uname;
            return View();
        }
    }
}
