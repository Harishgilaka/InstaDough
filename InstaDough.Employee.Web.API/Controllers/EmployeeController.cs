using InstaDough.Core.BusinessManager.Interface;
using InstaDough.Employee.Handlers.Command;
using InstaDough.Employee.Handlers.Query;
using InstaDough.Employee.Handlers.QueryResult;
using Microsoft.AspNetCore.Mvc;

namespace InstaDough.Employee.Web.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private IDispatcher _dispatcher;
        public EmployeeController(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        [HttpGet]
        public IActionResult GetEmployee([FromQuery] EmployeeQuery query)
        {
            return Ok(_dispatcher.Execute<EmployeeQuery, IEnumerable<EmployeeResult>>(query));
        }

        [HttpPost]
        public IActionResult CreateEmployee([FromBody] EmployeeCommand employee)
        {
            _dispatcher.Execute<EmployeeCommand>(employee);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetEmployeeWithID([FromQuery] EmployeeDetails query)
        {
            return Ok(_dispatcher.Execute<EmployeeDetails, EmployeeDetailsResult>(query));
        }
    }
}
