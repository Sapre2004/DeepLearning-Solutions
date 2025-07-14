using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeApi.Controllers
{
    [Route("api/emp")] // 👈 Changed from [controller] to "emp"
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<string> employees = new List<string> { "John", "Jane", "Bob" };

        // GET: api/emp
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(employees);
        }

        // POST: api/emp
        [HttpPost]
        public ActionResult Post([FromBody] string employeeName)
        {
            employees.Add(employeeName);
            return CreatedAtAction(nameof(Get), new { name = employeeName }, employeeName);
        }
    }
}
