using Microsoft.AspNetCore.Mvc;
using xx1.Entities_Models_;
using xx1.Repository.Interface;

namespace xx1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee iemployer;
        public EmployeeController(IEmployee iemployer)
        {
            this.iemployer = iemployer;
        }

        [HttpGet]
        [Route("GetAllEmployeeRecords")]
        public IActionResult Index()
        {
            var employees = iemployer.GetAll();
            if (employees == null)
            {
                return NotFound("No records are present in the Employees Tables");
            }
            else
            {
                return Ok(employees);
            }
        }


        [HttpPost]
        [Route("AddSingleRecord")]
        public IActionResult AddSingleEmployee(EmployeeEntity employee)
        {
            var employeeRecord = iemployer.AddEmployee(employee);
            if (employeeRecord == null)
            {
                return BadRequest("Employee can't be of type NULL");
            }
            else
            {
                return Ok($"Added Employee with ID {employee.Id} to Database");
            }
        }
        [HttpPut]
        [Route("UpdateDetails")]
        public IActionResult EditSingleEmployee(EmployeeEntity employee, int Id)
        {
            var employeeVar = iemployer.UpdateEmployeeDetails(employee, Id);
            if (employeeVar == null)
            {
                return BadRequest("Can't add NULL to database");
            }
            else
            {
                return Ok($"Employee with Id {employeeVar} updated");
            }
        }

        [HttpGet]
        [Route("GetSingleEmployeeById")]
        public IActionResult GetEmployee(int id)
        {
            var employeeVar = iemployer.GetEmployeeById(id);
            if (employeeVar == null)
            {
                return NotFound($"No instances with such an Id {id} is found");
            }
            else
            {
                return Ok(employeeVar);
            }
        }
    }
}
