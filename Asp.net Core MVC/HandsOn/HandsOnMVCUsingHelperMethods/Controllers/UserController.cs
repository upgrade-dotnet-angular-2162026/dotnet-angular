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
            //ModelState used to Validate the Model passed as parameter
            if (ModelState.IsValid)
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
            else
            {
                return View(); //Retrun to the same view when validation fails
            }
        }
    }
}
