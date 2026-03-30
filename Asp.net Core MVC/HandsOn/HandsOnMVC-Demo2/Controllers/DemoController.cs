using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace HandsOnMVC_Demo2.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            string[] cities = 
                { "Pune", "Chennai", "Hyderabad", "Mumbai", "Kochin" };
            ViewData["cities"] = cities;
            return View();
        }
        public IActionResult GetEmployees()
        {
            List<string> employees = new List<string>() 
            { "Rohan", "Karan", "Jeson", "Monica" };
            ViewBag.Employees = employees;
            return View();
        }
    }
}
