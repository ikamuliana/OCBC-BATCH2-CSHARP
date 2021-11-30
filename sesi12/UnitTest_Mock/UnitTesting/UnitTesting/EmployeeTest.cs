using Moq;
using System;
using UnitTest_Mock.Controllers;
using UnitTest_Mock.Models;
using UnitTest_Mock.Services;
using Xunit;

namespace UnitTesting
{
    public class EmployeeTest
    {
        #region Property
        private Mock<IEmployeeServices> mock = new Mock<IEmployeeServices>();

        public Mock<IEmployeeServices> Mock { get => mock; set => mock = value; }
        #endregion
        [Fact]
        public async void GetEmployeebyId()
        {
            Mock.Setup(p => p.GetEmployeebyId(1)).ReturnsAsync("JK");
            EmployeeController emp = new EmployeeController(Mock.Object);
            string result = await emp.GetEmployeeById(1);
            Assert.Equal("JK", result);
        }
        [Fact]
        public async void GetEmployeeDetails()
        {
            var employeeDTO = new Employee()
            {
                Id = 1,
                Name = "JK",
                Desgination = "SDE"
            };
            Mock.Setup(p => p.GetEmployeeDetails(1)).ReturnsAsync(employeeDTO);
            EmployeeController emp = new EmployeeController(Mock.Object);
            var result = await emp.GetEmployeeDetails(1);
            Assert.True(employeeDTO.Equals(result));
        }
    }
}