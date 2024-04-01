using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Integrated_Platform_App.API.Migrations
{
    public partial class addTaskBar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "MenuBar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "MenuBar");
        }
    }
}
