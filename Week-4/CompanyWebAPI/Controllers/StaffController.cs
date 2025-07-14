using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CompanyWebAPI.Models;
using CompanyWebAPI.Filters;

namespace CompanyWebAPI.Controllers
{
    [Authorize] // Require JWT token for all actions
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(CustomAuthFilter))] // Apply custom header validation
    public class StaffController : ControllerBase
    {
        private readonly List<Staff> _staffList;

        public StaffController()
        {
            _staffList = GetStandardStaffList();
        }

        // Generate sample staff list
        private List<Staff> GetStandardStaffList()
        {
            return new List<Staff>
            {
                new Staff
                {
                    Id = 1,
                    Name = "Alice Johnson",
                    Salary = 55000,
                    Permanent = true,
                    Department = new Department { Id = 1, DeptName = "IT" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, SkillName = "C#" },
                        new Skill { Id = 2, SkillName = "SQL" }
                    },
                    DateOfBirth = new DateTime(1991, 4, 12)
                },
                new Staff
                {
                    Id = 2,
                    Name = "Bob Smith",
                    Salary = 48000,
                    Permanent = false,
                    Department = new Department { Id = 2, DeptName = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, SkillName = "Excel" },
                        new Skill { Id = 4, SkillName = "Recruitment" }
                    },
                    DateOfBirth = new DateTime(1993, 7, 19)
                }
            };
        }

        // GET api/staff
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Staff>> GetStaff()
        {
            // Uncomment to test custom exception filter
            // throw new Exception("Testing custom exception filter.");
            return Ok(_staffList);
        }

        // POST api/staff
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddStaff([FromBody] Staff staff)
        {
            if (staff == null)
                return BadRequest("Invalid staff object.");

            _staffList.Add(staff);
            return Ok(staff);
        }
    }
}
