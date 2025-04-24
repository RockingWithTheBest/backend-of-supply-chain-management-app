using Dapper;
using FluentAssertions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xx1.Entities_Models_;

namespace SupplyChain.Tests.Data_Driven_Tests
{
    public class EmployeeTests
    {
        private readonly string connectionString = "Server=ROCKINWITHEBEST;Database=Supply Chain Management;Integrated Security=True;Persist Security Info=False;TrustServerCertificate=True;";

        public IEnumerable<object[]> GetEmployeeData()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var testDate = connection.Query("SELECT  Id, FirstName," +
                    " LastName ,Password ,Email,DateOfBirth, RoleId FROM  Employees");
                return testDate.Select(x => new object[] { x.Id, x.LastName, x.Password,
                    x.Email, x.DateOfBirth, x.RoleId });
            }
        }
        [Theory]
        [MemberData(nameof(EmployeesTestData))]
        public void TestEmployee(int Id, string LastName, string Password, 
            string Email, DateTime DateOFBirth, int RoleId)
        {
            var employee = new EmployeeEntity 
            { 
                Id = Id,
                LastName = LastName,
                Password = Password,
                Email = Email,
                DateOfBirth = DateOnly.FromDateTime(DateOFBirth),
                RoleId = RoleId
            };

            employee.Should().Satisfy<EmployeeEntity>(x =>
            {
                x.Id.Should().BePositive();
                x.LastName.Should().NotBeEmpty();
                x.Password.Should().NotBeEmpty();
                x.Email.Should().Match("*@*.**");
                x.RoleId.Should().BePositive();
                x.DateOfBirth.GetType().Should().Be(typeof(DateOnly));
            });
        }
        public static IEnumerable<object[]> EmployeesTestData = new EmployeeTests().GetEmployeeData();
    }
}
