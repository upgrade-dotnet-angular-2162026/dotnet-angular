using HandsOnEFCoreLazyAndEagerLoading.Data;
using HandsOnEFCoreLazyAndEagerLoading.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCoreLazyAndEagerLoading.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet("GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            var data = await _context.Employees
                                    .ToListAsync();
            return Ok(data);
        }

        // Get employees with department (Eager)
        [HttpGet("eager")]
        public async Task<IActionResult> GetEmployeesEager()
        {
            var data = await _context.Employees
                                     .Include(e => e.Department)
                                     .ToListAsync();
            return Ok(data);
        }

        // Create employee
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return Ok(employee);
        }
    }
}