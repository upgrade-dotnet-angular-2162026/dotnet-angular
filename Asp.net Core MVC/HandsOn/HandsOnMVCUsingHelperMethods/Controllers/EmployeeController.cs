using HandsOnMVCUsingHelperMethods.Models;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingHelperMethods.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                //add employee details to the db
                return Json(employee);
            }
            else
            {
                return View();
            }
        }
             
    }
}
