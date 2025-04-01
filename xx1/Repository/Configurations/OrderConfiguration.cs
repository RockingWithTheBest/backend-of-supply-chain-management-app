using Back_End.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace xx1.Repository.Configurations
{
    public class OrderConfiguration:IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasData
            (
               new OrderEntity
               {
                Id = 1,
                OrderStatus = "Pending",
                TaxStatus = "Taxed",
                Quantity = 4,
                ProductId = 2,
                CustomerId = 6,
                Customer = null,
                Product = null
              },
              new OrderEntity
              {
                Id = 2,
                OrderStatus = "Shipped",
                TaxStatus = "Not Taxed",
                Quantity = 1,
                ProductId = 3,
                CustomerId = 2,
                Customer = null,
                Product = null
              },
              new OrderEntity
              {
                Id = 3,
                OrderStatus = "Delivered",
                TaxStatus = "Taxed",
                Quantity = 3,
                ProductId = 9,
                CustomerId = 1,
                Customer = null,
                Product = null
              },
              new OrderEntity
              {
                Id = 4,
                OrderStatus = "Delivered",
                TaxStatus = "Not Taxed",
                Quantity = 5,
                ProductId = 15,
                CustomerId = 4,
                Customer = null,
                Product= null
              },
              new OrderEntity
              {
                Id = 5,
                OrderStatus = "Delivered",
                TaxStatus = "Taxed",
                Quantity = 1,
                ProductId = 17,
                CustomerId = 3,
                Customer = null,
                Product = null
              },
              new OrderEntity
              {
                Id = 6,
                OrderStatus = "Pending",
                TaxStatus = "Not Taxed",
                Quantity = 4,
                ProductId = 19,
                CustomerId = 3,
                Customer = null,
                Product = null
              },
              new OrderEntity
              {
                Id = 7,
                OrderStatus = "Shipped",
                TaxStatus = "Taxed",
                Quantity = 2,
                ProductId = 4,
                CustomerId= 6,
                Customer = null,
                Product = null
              },
              new OrderEntity
              {
                Id = 22,
                OrderStatus = "Pending",
                TaxStatus = "Not Taxed",
                Quantity = 2,
                ProductId = 36,
                CustomerId = 17,
                Customer = null,
                Product = null
              }
            );
        }
    }
}
