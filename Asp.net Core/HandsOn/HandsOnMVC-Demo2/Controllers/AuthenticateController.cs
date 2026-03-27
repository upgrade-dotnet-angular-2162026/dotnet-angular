using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVC_Demo2.Controllers
{
    public class AuthenticateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(string uname)
        {
            if(uname!=null)
            {
                //set value(uname) in TempDate
                TempData["uname"] = uname;
                //navigate to Employee Controller Index action
                return RedirectToAction("Index", "Employee");
            }
            ViewBag.Error = "Pls Enter UserName";
            return View();
        }
    }
}
