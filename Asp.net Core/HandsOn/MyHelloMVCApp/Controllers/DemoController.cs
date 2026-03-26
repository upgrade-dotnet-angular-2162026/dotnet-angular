using Microsoft.AspNetCore.Mvc;

namespace MyHelloMVCApp.Controllers
{
    public class DemoController : Controller
    {
        //Render view page from an anction method
        public IActionResult Info()
        {
            return View(); //View() return view page as a responce
        }
        public IActionResult Welcome(string name)
        {
            //set value in ViewData
            ViewData["n"]=name;
            return View();
        }
        public IActionResult LoadData()
        {
            ViewData["flowers"] = new List<string> { "Rose", "Lilly", "Jasmie" };
            return View();
        }
    }
}
