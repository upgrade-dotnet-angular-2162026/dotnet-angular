using Microsoft.AspNetCore.Mvc;

namespace HandsOnRouting.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("GetStudent/{id:int}")]
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
        [Route("Delete/{classId}/Student/{studentId}")]
        public IActionResult Delete(string classId,int studentId)
        {
            return View();
        }
    }
}
