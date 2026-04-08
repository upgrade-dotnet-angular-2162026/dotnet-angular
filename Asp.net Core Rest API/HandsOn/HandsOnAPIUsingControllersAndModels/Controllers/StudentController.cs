using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingControllersAndModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<string> students = new List<string> { "Rohan", "Chethan", "Tina", "Mona" };
        //EndPoints//ActionMethods
        [HttpGet("GetAll")]
        public IActionResult GetAllStudents()
        {
            return Ok(students); //send students in json form with status code 200
        }
        [HttpGet("GetStudent/{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = students[id];
            return Ok(student);
        }
        [HttpPost, Route("Add/{name}")]
        public IActionResult AddStudent(string name)
        {
            students.Add(name);
            //return Ok("Student Added");
            return Ok(students);
        }
        [HttpPut("EditStudent/{id}/{name}")]
        public IActionResult EditStudent(int id, string name)
        {
            students[id] = name;
            return Ok(students);
        }
        [HttpDelete("DeleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            students.RemoveAt(id - 1);
            return Ok(students);
        }


    }
}
