using Microsoft.AspNetCore.Mvc;

namespace MyHelloMVCApp.Controllers
{
    public class SampleController : Controller
    {
        public string Welcome()
        {
            return "Welcome to MVC World!!";
        }
        public string Greet(string name)
        {
            return $"Hello,{name}";
        }
        public int Add(int a,int b)
        {
            int result = a + b;
            return result;
        }
    }
}
