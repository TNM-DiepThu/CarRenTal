using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal.Migrations
{
    public partial class DB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NhienLieuTieuThu",
                table: "Loai_xe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NhienLieuTieuThu",
                table: "Loai_xe",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");
        }
    }
}
