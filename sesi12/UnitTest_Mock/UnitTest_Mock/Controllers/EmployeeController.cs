using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Models;
using UnitTest_Mock.Services;

namespace UnitTest_Mock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        #region Property
        private readonly IEmployeeServices _emplployeeService;
        #endregion

        #region Constructor
        public EmployeeController(IEmployeeServices employeeService)
        {
            _emplployeeService = employeeService;
        }
        #endregion

        [HttpGet(nameof(GetEmployeeById))]
        public async Task<string> GetEmployeeById(int EmpID)
        {
            var result = await _emplployeeService.GetEmployeebyId(EmpID);
            return result;
        }

        [HttpGet(nameof(GetEmployeeDetails))]
        public async Task<Employee> GetEmployeeDetails(int EmpID)
        {
            var result = await _emplployeeService.GetEmployeeDetails(EmpID);
            return result;
        }
    }
}