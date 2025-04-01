using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using xx1.Entities_Models_;

namespace xx1.Repository.Configurations
{
    public class InventoryConfiguration:IEntityTypeConfiguration<InventoryEntity>
    {
        public void Configure(EntityTypeBuilder<InventoryEntity> builder)
        {
            builder.HasData
            (
                new InventoryEntity
                {
                    Id = 7,
                    OrderCheckId = 6,
                    OrderId = 1,
                    ProductName = "Galaxy S23",
                    Quantity = 4,
                    PricePaid = new decimal(3599.96),
                    CustomerNames = "Eve Wilson",
                    Status = "Recieved Order",
                    CustomerId = 6,
                    OrderCheck = null,
                    Order = null,
                    Customer = null
                },
                new InventoryEntity
                {
                    Id = 8,
                    OrderCheckId = 10,
                    OrderId = 6,
                    ProductName = "Baseball Cap",
                    Quantity = 4,
                    PricePaid = new decimal(119.96),
                    CustomerNames = "Alice Johnson",
                    Status = "New Order",
                    CustomerId = 3,
                    OrderCheck = null,
                    Order = null,
                    Customer = null
                },
                new InventoryEntity
                {
                    Id = 9,
                    OrderCheckId = 11,
                    OrderId = 22,
                    ProductName = "Jordan 1 HighTop",
                    Quantity = 2,
                    PricePaid = 20000,
                    CustomerNames = "Chanda Brian",
                    Status = "Recieved Order",
                    CustomerId = 17,
                    OrderCheck = null,
                    Order = null,
                    Customer = null
                },
                new InventoryEntity
                {
                    Id = 11,
                    OrderCheckId = 16,
                    OrderId = 7,
                    ProductName = "Dell XPS 13",
                    Quantity = 2,
                    PricePaid = new decimal(2599.98),
                    CustomerNames = "Eve Wilson",
                    Status= "New Order",
                    CustomerId = 17,
                    OrderCheck = null,
                    Order = null,
                    Customer = null
                }
            );
        }
    }
}
