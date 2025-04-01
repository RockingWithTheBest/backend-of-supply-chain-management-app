using Back_End.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace xx1.Repository.Configurations
{
    public class SuppliesConfiguration : IEntityTypeConfiguration<SupplierEntity>
    {
        public void Configure(EntityTypeBuilder<SupplierEntity> builder)
        {
            builder.HasData(
            new SupplierEntity
            {
                Id= 1,
                Name = "Nicolai",
                Email = "nicolaiS100@gmail.com"
            },
            new SupplierEntity
            {
                Id =2,
                Name = "Bwalya",
                Email = "bwalaya@gmail.com"
            },
            new SupplierEntity
            {
                Id=3,
                Name = "Kenny",
                Email ="kenny100@gmail.com"
            },
            new SupplierEntity
            {
                Id = 4,
                Name = "benjamin_K",
                Email ="benyyK@gmail.com"
            },
            new SupplierEntity
            {
                Id = 5,
                Name ="Lionel M",
                Email ="LionelMbewe@gmail.com"
            }
            );
        }
    }
}
