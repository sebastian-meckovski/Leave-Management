using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace leave_management.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "go2314-3dwed-3434ed-1e23eg",
                column: "ConcurrencyStamp",
                value: "b1e4b70f-db69-413a-9215-a5390b4e7093");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "go2515-3Ywec-34G4ed-1e23eg",
                column: "ConcurrencyStamp",
                value: "11ef6cf1-b8b8-4098-aaed-3964d7e8ad2c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "199d0484-c6dd-4fb6-a7f9-e172760ec332",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b020fe92-3a65-44bb-922e-dc14cc5e5189", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDgPr/m6OkXHqacxiMioglBLj3v/5Jw9auQ+5g6VbbeiJKPlJ/CK95djUkFN0B+RhA==", "5bee940d-63ea-4b36-bbac-ec46b6c070d4", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26c03eab-1465-420b-8c7a-05b4afac7fe2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7b89aa87-db7f-488d-8c9f-b89c03807bdc", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAENhVmh81p6RVqieTu8dhJ2DKGblhQHIwm8Isc4BRiEYdude85r02k5lyBziGYUrBig==", "25a2fd87-aa23-49a2-af73-918c7f579223", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "go2314-3dwed-3434ed-1e23eg",
                column: "ConcurrencyStamp",
                value: "b152610f-6321-4318-92ef-2575608ae14c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "go2515-3Ywec-34G4ed-1e23eg",
                column: "ConcurrencyStamp",
                value: "9b657228-f250-44a5-8386-acb6c1353acc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "199d0484-c6dd-4fb6-a7f9-e172760ec332",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "258344fd-17f6-4160-b7e6-655cb9086d1a", false, null, "AQAAAAEAACcQAAAAEJo2MSUX/htHbrlrOVvq+Aa2p1EsDoa6vmqriwUb+cVgBMw1varhqmCjd2aDbTTfhA==", "0c6e4e4a-cc41-499b-8a13-373282a44157", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26c03eab-1465-420b-8c7a-05b4afac7fe2",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "037810f3-8caf-4209-9893-f0eed9ad19f5", false, null, "AQAAAAEAACcQAAAAELzJ9kpRQ//mEg/EZ0ysSeK5B+E5H+gsCaE4wNjc2U+c2rHQxjfVO6/5fS+0YGePjA==", "936ab2ba-dc74-40e7-948d-b97102eeca5c", null });
        }
    }
}
