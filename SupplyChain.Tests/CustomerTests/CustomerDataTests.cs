using Back_End.Models;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Tests.CustomerTests
{
    public class CustomerDataTests
    {
        [Fact]
        public void CustomerEntity_AddCustomer_Success()
        {
            var customer = new CustomerEntity()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                ShippingAddress = "123 Elm St",
                Password =  "Passwo1!",
                Email = "john@gmail.com",
                DateOfBirth = new DateOnly(0001,01,01),
                RoleId = 37546743
             };
            customer.Should().NotBeNull();
            customer.Id.Should().Be(1);
            customer.Email.Should().Be("john@gmail.com");
            customer.LastName.Should().Be("Doe");
            Assert.Equal("Passwo1!", customer.Password);
            Assert.Equal(new DateOnly(0001, 01, 01), customer.DateOfBirth);
            Assert.Equal(37546743, customer.RoleId);
        }
        [Fact]
        public void CustomerEntity_UpdateCustomerDetails_Success()
        {
            var customer = new CustomerEntity()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                ShippingAddress = "123 Elm St",
                Password = "Passwo1!",
                Email = "john@gmail.com",
                DateOfBirth = new DateOnly(0001, 01, 01),
                RoleId = 37546743
            };
            customer = new CustomerEntity()
            {
                Id = 1,
                FirstName = "Johnny",
                LastName = "Mike",
                ShippingAddress = "123 St Kosmatova",
                Password = "PPPiii!",
                Email = "johnnyMike@gmail.com",
                DateOfBirth = new DateOnly(0001, 01, 01),
                RoleId = 37546743
            };

            Assert.Equal(1, customer.Id);
            Assert.Equal("Johnny", customer.FirstName);
            Assert.Equal("Mike",customer.LastName);
            Assert.Equal(new DateOnly(0001, 01, 01),customer.DateOfBirth);
            Assert.Equal("PPPiii!", customer.Password);
            Assert.Equal("johnnyMike@gmail.com", customer.Email);
            Assert.Equal(37546743, customer.RoleId);
        }
        [Fact]
        public void CustomerEntity_ConfirmData_Success()
        {
            var customer = new CustomerEntity()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                ShippingAddress = "123 Elm St",
                Password = "Passwo1!",
                Email = "john@gmail.com",
                DateOfBirth = new DateOnly(0001, 01, 01),
                RoleId = 37546743
            };
            customer.Should().NotBeNull();
            customer.Id.Should().Be(1);
            customer.Email.Should().MatchEquivalentOf("*@*.com");
            customer.DateOfBirth.Should().Be(new DateOnly(0001, 01, 01));
            customer.ShippingAddress.Should().Be("123 Elm St");
            customer.RoleId.Should().Be(37546743);
        }
    }
}
