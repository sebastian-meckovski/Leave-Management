using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace leave_management.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "go2314-3dwed-3434ed-1e23eg",
                column: "ConcurrencyStamp",
                value: "27e167d2-3cef-4590-9c78-ce7cabee2e1b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "go2515-3Ywec-34G4ed-1e23eg",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "edbb5632-4a09-4aa5-95be-1438ef58d836", "User" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "199d0484-c6dd-4fb6-a7f9-e172760ec332",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e44495ad-d158-44ca-93d6-1c32d19e3b59", "AQAAAAEAACcQAAAAEIyhOAValmd+eWYW1rUqVphUfHl4Jmi+gLzDoCnKeUOTf8UQNK92EcoUS/X970M1nw==", "28726fbc-466f-4416-9a86-9f797f2e5968" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26c03eab-1465-420b-8c7a-05b4afac7fe2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cb1a4c5-fd6e-48e5-aa70-1c0fc807644e", "AQAAAAEAACcQAAAAENZScXDmAAXuG0rfyrva5Ey5K9Wh4aNtwiKI3IPGwyvN9jnt2BJFeCI5dOzLqh4K8Q==", "e0026ac9-ae55-4547-ba68-034c17e5431c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "11ef6cf1-b8b8-4098-aaed-3964d7e8ad2c", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "199d0484-c6dd-4fb6-a7f9-e172760ec332",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b020fe92-3a65-44bb-922e-dc14cc5e5189", "AQAAAAEAACcQAAAAEDgPr/m6OkXHqacxiMioglBLj3v/5Jw9auQ+5g6VbbeiJKPlJ/CK95djUkFN0B+RhA==", "5bee940d-63ea-4b36-bbac-ec46b6c070d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26c03eab-1465-420b-8c7a-05b4afac7fe2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b89aa87-db7f-488d-8c9f-b89c03807bdc", "AQAAAAEAACcQAAAAENhVmh81p6RVqieTu8dhJ2DKGblhQHIwm8Isc4BRiEYdude85r02k5lyBziGYUrBig==", "25a2fd87-aa23-49a2-af73-918c7f579223" });
        }
    }
}
