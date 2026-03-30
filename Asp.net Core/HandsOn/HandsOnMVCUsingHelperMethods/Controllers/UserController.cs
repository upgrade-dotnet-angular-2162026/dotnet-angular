using HandsOnMVCUsingHelperMethods.Models;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingHelperMethods.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Validate()
        {
            //create UI for Validate User
            return View();
        }
        [HttpPost]
        public IActionResult Validate(Login login)
        {
            if (login.Username == "Admin" && login.Password == "12345")
            {
                ViewBag.ErrorMsg = "Valid Credentials";
            }
            else
            {
                ViewBag.ErrorMsg = "Invaldi Credentials";
            }
            return View(); //return to same View
        }
    }
}
