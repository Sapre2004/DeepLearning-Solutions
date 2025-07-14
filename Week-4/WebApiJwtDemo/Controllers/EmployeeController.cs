using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApiJwtDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")] // Only allow Admin role
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new[]
            {
                new { Id = 1, Name = "John Doe", Department = "IT" },
                new { Id = 2, Name = "Jane Smith", Department = "HR" }
            };

            return Ok(employees);
        }
    }
}
