using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal.Migrations
{
    public partial class DB3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoKhung",
                table: "Xe");

            migrationBuilder.DropColumn(
                name: "SoMay",
                table: "Xe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SoKhung",
                table: "Xe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoMay",
                table: "Xe",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
