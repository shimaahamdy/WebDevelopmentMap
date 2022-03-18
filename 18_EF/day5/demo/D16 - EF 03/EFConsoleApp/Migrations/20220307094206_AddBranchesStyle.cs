using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFConsoleApp.Migrations
{
    public partial class AddBranchesStyle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Style",
                table: "Branches",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Style",
                table: "Branches");
        }
    }
}
