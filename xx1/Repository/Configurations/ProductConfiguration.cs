using Back_End.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace xx1.Repository.Configurations
{
    public class ProductConfiguration:IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder) 
        {
            builder.HasData
            (
                new ProductEntity
                {
                    Id = 2,
                    Name = "Galaxy S23",
                    Brand = "Samsung",
                    Description = "Electronics",
                    Price = new decimal(899.99),
                    StockQuantity = 13,
                    SupplierId = 3
                },
                new ProductEntity
                  {
                    Id = 3,
                    Name = "MacBook Pro",
                    Brand = "Apple",
                    Description = "Electronics",
                    Price = new decimal(1999.99),
                    StockQuantity = 20,
                    SupplierId = 4
                  },
                new ProductEntity
                  {
                    Id = 4,
                    Name = "Dell XPS 13",
                    Brand = "Dell",
                    Description = "Electronics",
                    Price = new decimal(1299.99),
                    StockQuantity = 14,
                    SupplierId =5
                  },
                new ProductEntity
                  {
                    Id = 5,
                    Name ="Sony WH-1000XM4",
                    Brand = "Sony",
                    Description = "Electronics",
                    Price = new decimal(349.99),
                    StockQuantity = 100,
                    SupplierId =  5
                  },
                new ProductEntity
                  {
                    Id = 6,
                    Name = "4K Ultra HD TV",
                    Brand = "LG",
                    Description = "Electronics",
                    Price = new decimal(799.99),
                    StockQuantity = 25,
                    SupplierId = 2
                  },
                new ProductEntity
                  {
                    Id = 7,
                    Name = "Smart Home Hub",
                    Brand = "Amazon",
                    Description = "Electronics",
                    Price= new decimal(149.99),
                    StockQuantity = 80,
                    SupplierId = 3
                  },
                new ProductEntity
                  {
                    Id = 8,
                    Name = "Electric Skateboard",
                    Brand = "Boosted",
                    Description = "Electronics",
                    Price = new decimal(1299.99),
                    StockQuantity = 10,
                    SupplierId = 4
                  },
                new ProductEntity
                  {
                    Id = 9,
                    Name = "Electric Bike",
                    Brand = "Rad Power Bikes",
                    Description = "Motors",
                    Price = new decimal(1499.99),
                    StockQuantity = 25,
                    SupplierId = 5
                  },
                new ProductEntity
                  {
                    Id = 10,
                    Name = "Harley Davidson Motorcycle",
                    Brand = "Harley",
                    Description = "Motors",
                    Price = new decimal(19999.99),
                    StockQuantity = 23,
                    SupplierId = 5
                  },
                new ProductEntity
                  {
                    Id = 11,
                    Name = "Yamaha Outboard Motor",
                    Brand = "Yamaha",
                    Description = "Motors",
                    Price = 3000,
                    StockQuantity = 8,
                    SupplierId = 3
                  },
                new ProductEntity
                  {
                    Id = 12,
                    Name = "Car GPS Navigation",
                    Brand = "Garmin",
                    Description = "Motors",
                    Price = new decimal(199.99),
                    StockQuantity = 40,
                    SupplierId = 2
                  },
                new ProductEntity
                  {
                    Id = 13,
                    Name = "Electric Car Charger",
                    Brand = "ChargePoint",
                    Description = "Motors",
                    Price = new decimal(499.99),
                    StockQuantity = 20,
                    SupplierId = 3
                  },
                new ProductEntity
                  {
                    Id = 14,
                    Name = "Graphic T-Shirt",
                    Brand = "Nike",
                    Description = "Clothes",
                    Price = new decimal(24.99),
                    StockQuantity = 150,
                    SupplierId = 4
                  },
                new ProductEntity
                  {
                    Id = 15,
                    Name = "Skinny Jeans",
                    Brand = "Levi’s",
                    Description = "Clothes",
                    Price = new decimal(59.99),
                    StockQuantity = 77,
                    SupplierId = 5
                  },
                new ProductEntity
                  {
                    Id = 16,
                    Name = "Leather Jacket",
                    Brand = "Zara",
                    Description = "Clothes",
                    Price = new decimal(129.99),
                    StockQuantity = 30,
                    SupplierId = 1
                  },
                new ProductEntity
                  {
                    Id = 17,
                    Name = "Windbreaker",
                    Brand = "Adidas",
                    Description = "Clothes",
                    Price = new decimal(49.99),
                    StockQuantity = 60,
                    SupplierId = 1
                  },
                new ProductEntity
                  {
                    Id = 18,
                    Name = "Sneakers",
                    Brand = "Puma",
                    Description = "Clothes",
                    Price = new decimal(89.99),
                    StockQuantity = 70,
                    SupplierId = 5
                  },
                new ProductEntity
                  {
                    Id = 19,
                    Name = "Baseball Cap",
                    Brand = "New Era",
                    Description =  "Clothes",
                    Price = new decimal(29.99),
                    StockQuantity = 93,
                    SupplierId =  2
                  },
                new ProductEntity
                  {
                    Id =20,
                    Name = "Formal Dress",
                    Brand = "H&M",
                    Description = "Clothes",
                    Price = new decimal(79.99),
                    StockQuantity = 40,
                    SupplierId = 2
                  },
                new ProductEntity
                  {
                    Id = 21,
                    Name = "Winter Coat",
                    Brand = "Columbia",
                    Description = "Clothes",
                    Price = new decimal(139.99),
                    StockQuantity = 15,
                    SupplierId = 2
                  },
                new ProductEntity
                  {
                    Id = 23,
                    Name = "AirPods",
                    Brand = "Samsung",
                    Description = "Electronics",
                    Price = new decimal(345.99),
                    StockQuantity = 20,
                    SupplierId = 2
                  },
                new ProductEntity
                  {
                    Id = 35,
                    Name = "iphone 14",
                    Brand = "Apple",
                    Description = "Electronics",
                    Price = new decimal(1234.98),
                    StockQuantity = 4,
                    SupplierId = 2
                  },
                new ProductEntity
                  {
                    Id = 36,
                    Name = "Jordan 1 HighTop",
                    Brand = "Nike",
                    Description = "Clothes",
                    Price = 10000,
                    StockQuantity = 8,
                    SupplierId = 2
                  },
                new ProductEntity
                  {
                    Id = 37,
                    Name = "Jordan 9",
                    Brand = "Nike",
                    Description = "Motors",
                    Price = new decimal(999.99),
                    StockQuantity = 23,
                    SupplierId = 2
                  }
            );
        }
    }
}
