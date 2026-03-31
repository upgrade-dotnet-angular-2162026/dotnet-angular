using Microsoft.AspNetCore.Mvc;

namespace HandsOnRouting.Controllers
{
    public class StaffController : Controller
    {
        [Route("Staff/GetAllStaff")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("AddStaff")]
        public IActionResult Create()
        {
            return View();
        }
        [Route("GetStaff/{id}")]
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
