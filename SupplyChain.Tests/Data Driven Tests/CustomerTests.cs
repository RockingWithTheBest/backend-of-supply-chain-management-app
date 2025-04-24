using Back_End.Models;
using Dapper;
using FluentAssertions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Tests.Data_Driven_Tests
{
    public class CustomerTests
    {
        private readonly string connectionString = "Server=ROCKINWITHEBEST;Database=Supply Chain Management;Integrated Security=True;Persist Security Info=False;TrustServerCertificate=True;";
        public IEnumerable<object[]> GetCustomerData()
        {
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var testData = connection.Query("SELECT Id, FirstName, LastName, ShippingAddress, " +
                    " DateOfBirth FROM Customers");
                return testData.Select(x=> new object[] { (int)x.Id,x.FirstName, x.LastName,x.ShippingAddress,
               x.DateOfBirth});
            }
        }

        [Theory]
        [MemberData(nameof(CustomerTestData))]
        public void TestCustomer(int Id, string FirstName, string 
            LastName, string ShippingAddress,  DateTime DateOfBirth)
        {
            var customer = new CustomerEntity
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                ShippingAddress = ShippingAddress,

                //Email = Email,
                DateOfBirth = DateOnly.FromDateTime(DateOfBirth)
            };

            customer.Should().NotBeNull();
            customer.Should().Satisfy<CustomerEntity>(c =>
            {
                c.Id.Should().BePositive();
                c.FirstName.Should().NotBeEmpty();
                c.LastName.Should().NotBeEmpty();
                //c.Email.Should().Match("*@*.com");
                //c.Password.Should().NotBeEmpty();
                c.ShippingAddress.Should().NotBeEmpty();
                c.DateOfBirth.GetType().Should().Be(typeof(DateOnly));
            });
        }
        public static IEnumerable<object[]> CustomerTestData = 
            new CustomerTests().GetCustomerData();
    }
}
