using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVC_Demo2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
