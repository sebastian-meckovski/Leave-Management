using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace leave_management.Data.Migrations
{
    public partial class LeaveTypeDefaultDatesColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "LeaveTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DefaultDays",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "LeaveTypes");

            migrationBuilder.DropColumn(
                name: "DefaultDays",
                table: "LeaveTypes");
        }
    }
}
