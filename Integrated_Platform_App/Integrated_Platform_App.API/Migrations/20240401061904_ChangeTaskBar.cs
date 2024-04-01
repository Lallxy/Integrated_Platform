using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Integrated_Platform_App.API.Migrations
{
    public partial class ChangeTaskBar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatTime",
                table: "TaskBar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "TaskBar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatTime",
                table: "TaskBar");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "TaskBar");
        }
    }
}
