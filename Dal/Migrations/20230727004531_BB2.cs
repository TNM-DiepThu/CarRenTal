using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal.Migrations
{
    public partial class BB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "Đang_kiem");

            migrationBuilder.AddColumn<decimal>(
                name: "ChiPhi",
                table: "Đang_kiem",
                type: "DECIMAL",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChiPhi",
                table: "Đang_kiem");

            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "Đang_kiem",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
