using Back_End.Models;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xx1.Entities_Models_;

namespace SupplyChain.Tests.SupplierTests
{
    public class SupplierDataTests
    {
        [Fact]
        public void SupplierEntity_AddSupplier_Success()
        {
            //Arrange
            var supplier = new SupplierEntity()
            {
                Id = 1,
                Name = "Nicolai",
                Email = "nicolaiS100@gmail.com"
            };
            supplier.Email.Equals("nicolaiS100@gmail.com");
            supplier.Id.Equals(1);
            supplier.Name.Equals("Nicolai");
        }
        [Fact]
        public void SupplierEntity_UpdateSupplierDetails_Success()
        {
            var supplier = new SupplierEntity()
            {
                Id = 1,
                Name = "Nicolai",
                Email = "nicolaiS100@gmail.com"
            };

            supplier = new SupplierEntity()
            {
                Id = 1,
                Name = "Bwalya",
                Email = "bwalaya@gmail.com"
            };
            Assert.Equal(1, supplier.Id);
            Assert.Equal("Bwalya", supplier.Name);
            Assert.Equal("bwalaya@gmail.com", supplier.Email);
        }
        [Fact]
        public void SupplierEntity_CheckCorrectness_Success()
        {
            var supplier = new SupplierEntity()
            {
                Id = 1,
                Name = "Bwalya",
                Email = "bwalaya@gmail.com"
            };
            supplier.Should().NotBeNull();
            supplier.Email.Should().MatchEquivalentOf("*@*.com");
            supplier.Id.Should().BeGreaterThan(0);
            supplier.Id.Should().BePositive();
        }
    }
}
