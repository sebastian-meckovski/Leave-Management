using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace leave_management.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "go2314-3dwed-3434ed-1e23eg", "b152610f-6321-4318-92ef-2575608ae14c", "Administrator", "ADMINISTRATOR" },
                    { "go2515-3Ywec-34G4ed-1e23eg", "9b657228-f250-44a5-8386-acb6c1353acc", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateCreated", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "199d0484-c6dd-4fb6-a7f9-e172760ec332", 0, "258344fd-17f6-4160-b7e6-655cb9086d1a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEJo2MSUX/htHbrlrOVvq+Aa2p1EsDoa6vmqriwUb+cVgBMw1varhqmCjd2aDbTTfhA==", null, false, "0c6e4e4a-cc41-499b-8a13-373282a44157", null, false, null },
                    { "26c03eab-1465-420b-8c7a-05b4afac7fe2", 0, "037810f3-8caf-4209-9893-f0eed9ad19f5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAELzJ9kpRQ//mEg/EZ0ysSeK5B+E5H+gsCaE4wNjc2U+c2rHQxjfVO6/5fS+0YGePjA==", null, false, "936ab2ba-dc74-40e7-948d-b97102eeca5c", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "go2314-3dwed-3434ed-1e23eg", "199d0484-c6dd-4fb6-a7f9-e172760ec332" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "go2515-3Ywec-34G4ed-1e23eg", "26c03eab-1465-420b-8c7a-05b4afac7fe2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "go2314-3dwed-3434ed-1e23eg", "199d0484-c6dd-4fb6-a7f9-e172760ec332" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "go2515-3Ywec-34G4ed-1e23eg", "26c03eab-1465-420b-8c7a-05b4afac7fe2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "go2314-3dwed-3434ed-1e23eg");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "go2515-3Ywec-34G4ed-1e23eg");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "199d0484-c6dd-4fb6-a7f9-e172760ec332");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26c03eab-1465-420b-8c7a-05b4afac7fe2");
        }
    }
}
