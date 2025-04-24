using Back_End.Models;
using Dapper;
using FluentAssertions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Tests
{
    public class SupplierTest
    {
        private readonly string connectionString = "Server=ROCKINWITHEBEST;Database=Supply Chain Management;Integrated Security=True;Persist Security Info=False;TrustServerCertificate=True;";
        public IEnumerable<object[]> GetSupplierData()
        {
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var testData = connection.Query("SELECT Id, Name, Email FROM Supplies");
                return testData.Select(x=>new object[] { (int)x.Id, x.Name, x.Email});
            }
        }

        [Theory]
        [MemberData(nameof(SupplierTestData))]
        public void TestSuppiers(int Id, string name, string email)
        {
            var supplier = new SupplierEntity()
            {
                Id = Id,
                Name = name,
                Email = email
            };

            supplier.Should().Satisfy<SupplierEntity>(sup =>
            {
                sup.Id.Should().BePositive();
                sup.Name.Should().NotBeEmpty();
                sup.Email.Should().NotBeEmpty();
                sup.Email.Should().Match("*@*.com");
            });
        }

        public static IEnumerable<object[]> SupplierTestData = new SupplierTest().GetSupplierData();
    }
}
