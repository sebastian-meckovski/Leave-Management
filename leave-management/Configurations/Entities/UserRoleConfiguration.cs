using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace leave_management.Configurations.Entities
{
    internal class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "go2314-3dwed-3434ed-1e23eg",
                        UserId = "199d0484-c6dd-4fb6-a7f9-e172760ec332"
                    },

                    new IdentityUserRole<string>
                    {
                        RoleId = "go2515-3Ywec-34G4ed-1e23eg",
                        UserId = "26c03eab-1465-420b-8c7a-05b4afac7fe2"
                    }
                );
        }
    }
}