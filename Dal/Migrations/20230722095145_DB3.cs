using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal.Migrations
{
    public partial class DB3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhuPhi",
                table: "Hoa_đon_chi_tiet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PhuPhi",
                table: "Hoa_đon_chi_tiet",
                type: "DECIMAL",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
