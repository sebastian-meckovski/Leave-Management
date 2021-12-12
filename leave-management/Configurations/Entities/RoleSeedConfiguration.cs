using leave_management.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace leave_management.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                    new IdentityRole
                    {
                        Id = "go2314-3dwed-3434ed-1e23eg",
                        Name = Roles.Administrator,
                        NormalizedName = Roles.Administrator.ToUpper()
                    },
                    new IdentityRole
                    {
                        Id = "go2515-3Ywec-34G4ed-1e23eg",
                        Name = Roles.User,
                        NormalizedName = Roles.User
                    }
                ); ;
        }
    }
}