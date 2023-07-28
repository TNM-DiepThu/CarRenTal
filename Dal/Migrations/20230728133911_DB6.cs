using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal.Migrations
{
    public partial class DB6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Xe_Loai_xe_LoaiXeId",
                table: "Xe");

            migrationBuilder.DropIndex(
                name: "IX_Xe_LoaiXeId",
                table: "Xe");

            migrationBuilder.DropColumn(
                name: "LoaiXeId",
                table: "Xe");

            migrationBuilder.CreateIndex(
                name: "IX_Xe_IdLoaiXe",
                table: "Xe",
                column: "IdLoaiXe");

            migrationBuilder.AddForeignKey(
                name: "FK_Xe_Loai_xe_IdLoaiXe",
                table: "Xe",
                column: "IdLoaiXe",
                principalTable: "Loai_xe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Xe_Loai_xe_IdLoaiXe",
                table: "Xe");

            migrationBuilder.DropIndex(
                name: "IX_Xe_IdLoaiXe",
                table: "Xe");

            migrationBuilder.AddColumn<Guid>(
                name: "LoaiXeId",
                table: "Xe",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Xe_LoaiXeId",
                table: "Xe",
                column: "LoaiXeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Xe_Loai_xe_LoaiXeId",
                table: "Xe",
                column: "LoaiXeId",
                principalTable: "Loai_xe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
