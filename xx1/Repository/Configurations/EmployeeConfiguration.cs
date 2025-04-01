using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xx1.Entities_Models_;

namespace xx1.Repository.Configurations
{
    public class EmployeeConfiguration:IEntityTypeConfiguration<EmployeeEntity>
    {
        public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
        {
            builder.HasData
              (
                    new EmployeeEntity
                    {
                        Id = 1,
                        FirstName = "Max",
                        LastName = "Millian",
                        Password = "PassNo1@",
                        Email = "maxmillian@gmail.com",
                        DateOfBirth = new DateOnly(2024,11,10),
                        RoleId = 8678576,
                        Role = null
                    },
                    new EmployeeEntity
                    {
                        Id = 2,
                        FirstName = "string",
                        LastName = "string",
                        Password = "string",
                        Email = "string",
                        DateOfBirth = new DateOnly(2024,11,10),
                        RoleId = 8678576,
                        Role = null
                    },
                    new EmployeeEntity
                    {
                        Id = 3,
                        FirstName = "aefr",
                        LastName = "aedawe",
                        Password=  "Passwo1!",
                        Email = "SZCDS@gmaolc.cps",
                        DateOfBirth = new DateOnly(0001,01,01),
                        RoleId = 8678576,
                        Role = null
                    },
                    new EmployeeEntity
                    {
                        Id = 4,
                        FirstName = "aesf",
                        LastName = "waedfaw",
                        Password = "Passwo1!",
                        Email = "weafsa@gmail.coesm",
                        DateOfBirth = new DateOnly(0001,01,01),
                        RoleId = 8678576,
                        Role = null
                    }
              );
        }
    }
}
