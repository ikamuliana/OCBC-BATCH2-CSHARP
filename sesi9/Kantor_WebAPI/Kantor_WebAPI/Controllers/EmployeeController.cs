using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Kantor_WebAPI.Models;

namespace Kantor_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;
        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }

        //GET:api/User
        [HttpGet(Name = "Get All")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            //return new string[]
            return _context.GetAllEmployee();
        }

        //Get:api/user/{id}
        [HttpGet("{id}", Name = "Get where")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetEmployee(id);
        }

        //Post api 
        [HttpPost]
        public ActionResult<IEnumerable<EmployeeItem>> PostEmployeeItem(string nama, string jenisKelamin, string alamat)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.PostEmployee(nama, jenisKelamin, alamat);
        }

        //Put api
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<EmployeeItem>> PutEmployeeItem(string id, string nama, string jenisKelamin, string alamat)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.PutEmployee(id, nama, jenisKelamin, alamat);
        }

        //Delete api
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<EmployeeItem>> DeleteEmployeeItem(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.DeleteEmployee(id);
        }
    }
}
