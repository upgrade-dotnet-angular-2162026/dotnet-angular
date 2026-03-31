using Microsoft.AspNetCore.Mvc;

namespace HandsOnRouting.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Student/GetStudent/{id:int}")]
        public IActionResult Details(int Id)
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();

        }
        public IActionResult Edit()
        {
            return View();  
        }
        public IActionResult Delete(int Id)
        {
            return View();
        }
    }
}
