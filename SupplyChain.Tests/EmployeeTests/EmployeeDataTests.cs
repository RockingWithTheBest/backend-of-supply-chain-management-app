using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using xx1.Entities_Models_;

namespace SupplyChain.Tests.EmployeeTests
{
    public class EmployeeDataTests
    {
        [Fact]
        public void EmployeeEntity_AddEmployee_Success()
        {
            //Arrange
            var employee = new EmployeeEntity()
            {
                Id = 1,
                FirstName = "Lauryn",
                LastName = "Hill",
                Password = "password",
                Email = "lauryn@hill.com",
                DateOfBirth = new DateOnly(1998,09,10),
                RoleId = 10,
            };
            //Act and Assert
            Assert.Equal(1, employee.Id);
            Assert.Equal("Lauryn", employee.FirstName);
            Assert.Equal("Hill", employee.LastName);
            Assert.Equal("password", employee.Password);
            Assert.Equal("lauryn@hill.com", employee.Email);
            Assert.Equal(new DateOnly(1998, 09, 10), employee.DateOfBirth);
            Assert.Equal(10, employee.RoleId);
        }
        [Fact]
        public void EmployeeEntity_UpdateEmployeeDetails_Success()
        {
            //Arrange
            var employee = new EmployeeEntity()
            {
                Id = 1,
                FirstName = "Lauryn",
                LastName = "Hill",
                Password = "password",
                Email = "lauryn@hill.com",
                DateOfBirth = new DateOnly(1998, 09, 10),
                RoleId = 10,
            };
            //Act and Assert
            employee = new EmployeeEntity()
            {
                Id = 1,
                FirstName = "Martha",
                LastName = "Chomba",
                Password = "sets111",
                Email = "laurynHill@gmail.com",
                DateOfBirth = new DateOnly(1998, 09, 10),
                RoleId = 11,
            };
            Assert.Equal(1, employee.Id);
            Assert.Equal("Martha", employee.FirstName);
            Assert.Equal("Chomba", employee.LastName);
            Assert.Equal("sets111", employee.Password);
            Assert.Equal("laurynHill@gmail.com", employee.Email);
            Assert.Equal(new DateOnly(1998, 09, 10), employee.DateOfBirth);
            Assert.Equal(11, employee.RoleId);
        }
        [Fact]
        public void EmployeeEntity_AddEmployee2_Success()
        {
            //Arrange
            var employee = new EmployeeEntity()
            {
                Id = 1,
                FirstName = "Lauryn",
                LastName = "Hill",
                Password = "password",
                Email = "lauryn@hill.com",
                DateOfBirth = new DateOnly(1998, 09, 10),
                RoleId = 10,
            };
            //Act and Assert
            employee.Id.Should().BePositive();
            employee.RoleId.Should().BePositive();
            employee.Email.Should().MatchEquivalentOf("*@*.com");        }
    }
}
