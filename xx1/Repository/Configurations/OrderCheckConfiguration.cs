using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xx1.Entities_Models_;

namespace xx1.Repository.Configurations
{
    public class OrderCheckConfiguration:IEntityTypeConfiguration<OrderCheckEntity>
    {
        public void Configure(EntityTypeBuilder<OrderCheckEntity> builder) 
        {
            builder.HasData
            (
                new OrderCheckEntity
                {
                    Id= 6,
                    OrderId= 1,
                    ProductId= 2,
                    Status= "Order Supplied",
                    ProductName= "Galaxy S23",
                    ProductQuantity= 5,
                    Product= null,
                    Order= null
                },
                new OrderCheckEntity
              {
                Id = 10,
                OrderId = 6,
                ProductId = 19,
                Status = "Order Supplied",
                ProductName = "Baseball Cap",
                ProductQuantity = 4,
                Product = null,
                Order = null
              },
                new OrderCheckEntity
              {
                Id = 11,
                OrderId = 22,
                ProductId = 36,
                Status = "Order Supplied",
                ProductName = "Jordan 1 HighTop",
                ProductQuantity = 2,
                Product= null,
                Order = null
              },
                new OrderCheckEntity
              {
                Id = 12,
                OrderId = 6,
                ProductId = 19,
                Status = "Order Supplied",
                ProductName = "Baseball Cap",
                ProductQuantity = 2,
                Product = null,
                Order = null
              },
                new OrderCheckEntity
              {
                Id = 13,
                OrderId = 4,
                ProductId = 15,
                Status = "Order Supplied",
                ProductName = "Skinny Jeans",
                ProductQuantity = 1,
                Product = null,
                Order = null
              },
                new OrderCheckEntity
              {
                Id = 14,
                OrderId = 4,
                ProductId = 15,
                Status = "Order Supplied",
                ProductName = "Skinny Jeans",
                ProductQuantity = 2,
                Product = null,
                Order = null
              },
                new OrderCheckEntity
              {
                Id = 15,
                OrderId = 6,
                ProductId = 19,
                Status = "Order Supplied",
                ProductName = "Baseball Cap",
                ProductQuantity = 1,
                Product = null,
                Order = null
              },
                new OrderCheckEntity
              {
                Id = 16,
                OrderId =7,
                ProductId = 4,
                Status = "Order Supplied",
                ProductName = "Dell XPS 13",
                ProductQuantity = 1,
                Product = null,
                Order = null
              }
            );
        }
    }
}
