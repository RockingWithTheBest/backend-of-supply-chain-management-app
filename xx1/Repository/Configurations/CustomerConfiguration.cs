using Back_End.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace xx1.Repository.Configurations
{
    public class CustomerConfiguration: IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.HasData
            (
                new CustomerEntity
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    ShippingAddress = "123 Elm St",
                    Password = "Passwo1!",
                    Email = "",
                    DateOfBirth = new DateOnly(0001, 01, 01),
                    OrdersList = [],
                    RoleId = 37546743,
                    ReturnId = null,
                    Return = null,
                    Role = null
                },
              new CustomerEntity
              {
                  Id = 2,
                  FirstName = "Jane",
                  LastName = "Smith",
                  ShippingAddress = "456 Oak St",
                  Password = "",
                  Email = "",
                  DateOfBirth = new DateOnly(0001, 01, 01),
                  OrdersList = [],
                  RoleId = 37546743,
                  ReturnId = null,
                  Return = null,
                  Role = null
              },
              new CustomerEntity
              {
                  Id = 3,
                  FirstName = "Alice",
                  LastName = "Johnson",
                  ShippingAddress = "789 Pine St",
                  Password = "",
                  Email = "",
                  DateOfBirth = new DateOnly(0001, 01, 01),
                  OrdersList = [],
                  RoleId = 37546743,
                  ReturnId = null,
                  Return = null,
                  Role = null
              },
              new CustomerEntity
              {
                  Id = 4,
                  FirstName = "Bob",
                  LastName = "Brown",
                  ShippingAddress = "321 Maple St",
                  Password = "",
                  Email = "",
                  DateOfBirth = new DateOnly(0001, 01, 01),
                  OrdersList = [],
                  RoleId = 37546743,
                  ReturnId = null,
                  Return = null,
                  Role = null
              },
              new CustomerEntity
              {
                  Id = 5,
                  FirstName = "Charlie",
                  LastName = "Davis",
                  ShippingAddress = "654 Cedar St",
                  Password = "",
                  Email = "",
                  DateOfBirth = new DateOnly(0001, 01, 01),
                  OrdersList = [],
                  RoleId = 37546743,
                  ReturnId = null,
                  Return = null,
                  Role = null
              },
              new CustomerEntity
              {
                  Id = 6,
                  FirstName = "Eve",
                  LastName = "Wilson",
                  ShippingAddress = "987 Birch St",
                  Password = "",
                  Email = "",
                  DateOfBirth = new DateOnly(0001, 01, 01),
                  OrdersList = [],
                  RoleId = 37546743,
                  ReturnId = null,
                  Return = null,
                  Role = null
              },
              new CustomerEntity
              {
                  Id = 17,
                  FirstName = "Chanda",
                  LastName = "Brian",
                  ShippingAddress = "New Orlean HouseNo3",
                  Password = "Passwo1!",
                  Email = "chandabrian@gmail.com",
                  DateOfBirth = new DateOnly(0001, 01, 01),
                  OrdersList = [],
                  RoleId = 37546743,
                  ReturnId = null,
                  Return = null,
                  Role = null
              },
              new CustomerEntity
              {
                  Id = 18,
                  FirstName = "Lindah",
                  LastName = "Chingeleshi",
                  ShippingAddress = "szdehvfbszjf",
                  Password = "Passwo1!",
                  Email = "lindah@gmail.com",
                  DateOfBirth = new DateOnly(0001, 01, 01),
                  OrdersList = [],
                  RoleId = 37546743,
                  ReturnId = null,
                  Return = null,
                  Role = null
              }
            );
        }
    }
}
