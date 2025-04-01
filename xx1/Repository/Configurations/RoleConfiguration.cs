using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using xx1.Entities_Models_;

namespace xx1.Repository.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<RoleEntity>
    {
        public void Configure(EntityTypeBuilder<RoleEntity> builder)
        {
            builder.HasData(
                new RoleEntity
                {
                    Id = 37546743,
                    RoleName = "Customer"
                },
                new RoleEntity
                {
                    Id = 8678576,
                    RoleName = "Employee"
                },
                new RoleEntity
                {
                    Id = 5323542,
                    RoleName = "Supplier"
                }
            );
        }
    }
}
