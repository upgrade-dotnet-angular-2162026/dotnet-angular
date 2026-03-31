using Microsoft.AspNetCore.Mvc;

namespace HandsOnStateManagement.Controllers
{
    public class AuthenticateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username,string password)
        {
            if(username!=null && password!=null) 
                {
                //store username in session
                HttpContext.Session.SetString("uname", username);
                    return RedirectToAction("Welcome");
                }
            return View();
        }
        public IActionResult Welcome()
        {
            //Read session
            var uname = HttpContext.Session.GetString("uname");
            ViewBag.Username = uname;
            return View();
        }
    }
}
