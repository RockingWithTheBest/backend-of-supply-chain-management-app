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
    public class ProductTests
    {
        private readonly string connectionString = "Server=ROCKINWITHEBEST;Database=Supply Chain Management;Integrated Security=True;Persist Security Info=False;TrustServerCertificate=True;";
        public IEnumerable<object[]> GetLoginTestData()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var testData = connection.Query("SELECT Id, Name, Brand, StockQuantity, SupplierId FROM Products");
                return testData.Select(user => new object[] { (int)user.Id, (string)user.Name, user.Brand, (int)user.StockQuantity, (int)user.SupplierId });
            }
        }
        [Theory]
        [MemberData(nameof(LoginTestData))]
        public void TestLogin(int Id, string Name, string Brand, int StockQuantity, int SupplierId)
        {
            ProductEntity product = new ProductEntity();
            product.Name = Name;
            product.Brand = Brand;
            product.Id = Id;
            product.StockQuantity = StockQuantity;
            product.SupplierId = SupplierId;


            product.Should().Satisfy<ProductEntity>(pr =>
            {
                pr.Name.Should().NotBeEmpty();
                pr.Brand.Should().NotBeEmpty();
                pr.Id.Should().BePositive();
                pr.StockQuantity.Should().BePositive();
                pr.SupplierId.Should().BePositive();
            });
        }

        public static IEnumerable<object[]> LoginTestData => new ProductTests().GetLoginTestData();
    }
}
