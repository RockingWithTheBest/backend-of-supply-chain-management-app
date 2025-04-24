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
    public class OrderTests
    {
        private readonly string connectionString = "Server=ROCKINWITHEBEST;Database=Supply Chain Management;Integrated Security=True;Persist Security Info=False;TrustServerCertificate=True;";

        public IEnumerable<object[]> GetOrderData()
        {
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var testData = connection.Query("SELECT  Id,   OrderStatus,TaxStatus, Quantity," +
                    "ProductId, CustomerId FROM Orders");
                 return testData.Select(x=>new object[] { x.Id, x.OrderStatus, x.TaxStatus,x.Quantity, 
                     x.ProductId,x.CustomerId });
            }
        }

        [Theory]
        [MemberData(nameof(OrderTestsData))]
        public void TestOrders(int Id, string OrderStatus, string TaxStatus, int Quantity, int ProductId, int CustomerId)
        {
            var orders = new OrderEntity
            {
                Id = Id,
                OrderStatus = OrderStatus,
                TaxStatus = TaxStatus,
                Quantity = Quantity,
                ProductId = ProductId,
                CustomerId = CustomerId
            };
            orders.Should().Satisfy<OrderEntity>(x =>
            {
                x.OrderStatus.Should().NotBeEmpty();
                x.Id.Should().BePositive();
                x.TaxStatus.Should().NotBeEmpty();
                x.Quantity.Should().BePositive();
                x.ProductId.Should().BePositive();
                x.CustomerId.Should().BePositive();
            });
        }

        public static IEnumerable<object[]> OrderTestsData = new OrderTests().GetOrderData();
    }
}
