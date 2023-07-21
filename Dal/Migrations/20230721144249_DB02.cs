using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal.Migrations
{
    public partial class DB02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bảo dưỡng_Xe_IdXe",
                table: "Bảo dưỡng");

            migrationBuilder.DropForeignKey(
                name: "FK_Đăng kiểm_Xe_IdXe",
                table: "Đăng kiểm");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoá đơn chi tiết_Hoá đơn thuê xe_IdHoaDon",
                table: "Hoá đơn chi tiết");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoá đơn chi tiết_Xe_IdXe",
                table: "Hoá đơn chi tiết");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoá đơn thuê xe_Khách hàng_IdKhachHang",
                table: "Hoá đơn thuê xe");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoá đơn thuê xe_Nhân viên_IdNhanVien",
                table: "Hoá đơn thuê xe");

            migrationBuilder.DropForeignKey(
                name: "FK_Loại xe_Hãng Xe_IdHangXe",
                table: "Loại xe");

            migrationBuilder.DropForeignKey(
                name: "FK_Người thân_Khách hàng_IdKhachHang",
                table: "Người thân");

            migrationBuilder.DropForeignKey(
                name: "FK_Nhân viên_Chức Vụ_IdChucVu",
                table: "Nhân viên");

            migrationBuilder.DropForeignKey(
                name: "FK_Tài khoản_Nhân viên_IdNhanVien",
                table: "Tài khoản");

            migrationBuilder.DropForeignKey(
                name: "FK_Xe_Loại xe_LoaiXeId",
                table: "Xe");

            migrationBuilder.DropForeignKey(
                name: "FK_Xe_Màu sắc_IdMauSac",
                table: "Xe");

            migrationBuilder.DropForeignKey(
                name: "FK_Xe bảo hiểm_Bảo Hiểm_IdHangBaoHiem",
                table: "Xe bảo hiểm");

            migrationBuilder.DropForeignKey(
                name: "FK_Xe bảo hiểm_Xe_IdXe",
                table: "Xe bảo hiểm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Xe bảo hiểm",
                table: "Xe bảo hiểm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tài khoản",
                table: "Tài khoản");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nhân viên",
                table: "Nhân viên");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Người thân",
                table: "Người thân");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Màu sắc",
                table: "Màu sắc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loại xe",
                table: "Loại xe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Khách hàng",
                table: "Khách hàng");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hoá đơn thuê xe",
                table: "Hoá đơn thuê xe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hoá đơn chi tiết",
                table: "Hoá đơn chi tiết");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hãng Xe",
                table: "Hãng Xe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Đăng kiểm",
                table: "Đăng kiểm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chức Vụ",
                table: "Chức Vụ");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bảo Hiểm",
                table: "Bảo Hiểm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bảo dưỡng",
                table: "Bảo dưỡng");

            migrationBuilder.RenameTable(
                name: "Xe bảo hiểm",
                newName: "Xe_bao_hiem");

            migrationBuilder.RenameTable(
                name: "Tài khoản",
                newName: "Tai_khoan");

            migrationBuilder.RenameTable(
                name: "Nhân viên",
                newName: "Nhan_vien");

            migrationBuilder.RenameTable(
                name: "Người thân",
                newName: "Nguoi_than");

            migrationBuilder.RenameTable(
                name: "Màu sắc",
                newName: "Mau_sac");

            migrationBuilder.RenameTable(
                name: "Loại xe",
                newName: "Loai_xe");

            migrationBuilder.RenameTable(
                name: "Khách hàng",
                newName: "Khach_hang");

            migrationBuilder.RenameTable(
                name: "Hoá đơn thuê xe",
                newName: "Hoa_don_thue_xe");

            migrationBuilder.RenameTable(
                name: "Hoá đơn chi tiết",
                newName: "Hoa_đon_chi_tiet");

            migrationBuilder.RenameTable(
                name: "Hãng Xe",
                newName: "Hang_Xe");

            migrationBuilder.RenameTable(
                name: "Đăng kiểm",
                newName: "Đang_kiem");

            migrationBuilder.RenameTable(
                name: "Chức Vụ",
                newName: "Chuc_Vu");

            migrationBuilder.RenameTable(
                name: "Bảo Hiểm",
                newName: "Bao_Hiem");

            migrationBuilder.RenameTable(
                name: "Bảo dưỡng",
                newName: "Bao_Duong");

            migrationBuilder.RenameIndex(
                name: "IX_Xe bảo hiểm_IdXe",
                table: "Xe_bao_hiem",
                newName: "IX_Xe_bao_hiem_IdXe");

            migrationBuilder.RenameIndex(
                name: "IX_Xe bảo hiểm_IdHangBaoHiem",
                table: "Xe_bao_hiem",
                newName: "IX_Xe_bao_hiem_IdHangBaoHiem");

            migrationBuilder.RenameIndex(
                name: "IX_Tài khoản_IdNhanVien",
                table: "Tai_khoan",
                newName: "IX_Tai_khoan_IdNhanVien");

            migrationBuilder.RenameIndex(
                name: "IX_Nhân viên_IdChucVu",
                table: "Nhan_vien",
                newName: "IX_Nhan_vien_IdChucVu");

            migrationBuilder.RenameIndex(
                name: "IX_Người thân_IdKhachHang",
                table: "Nguoi_than",
                newName: "IX_Nguoi_than_IdKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_Loại xe_IdHangXe",
                table: "Loai_xe",
                newName: "IX_Loai_xe_IdHangXe");

            migrationBuilder.RenameIndex(
                name: "IX_Hoá đơn thuê xe_IdNhanVien",
                table: "Hoa_don_thue_xe",
                newName: "IX_Hoa_don_thue_xe_IdNhanVien");

            migrationBuilder.RenameIndex(
                name: "IX_Hoá đơn thuê xe_IdKhachHang",
                table: "Hoa_don_thue_xe",
                newName: "IX_Hoa_don_thue_xe_IdKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_Hoá đơn chi tiết_IdXe",
                table: "Hoa_đon_chi_tiet",
                newName: "IX_Hoa_đon_chi_tiet_IdXe");

            migrationBuilder.RenameIndex(
                name: "IX_Hoá đơn chi tiết_IdHoaDon",
                table: "Hoa_đon_chi_tiet",
                newName: "IX_Hoa_đon_chi_tiet_IdHoaDon");

            migrationBuilder.RenameIndex(
                name: "IX_Đăng kiểm_IdXe",
                table: "Đang_kiem",
                newName: "IX_Đang_kiem_IdXe");

            migrationBuilder.RenameIndex(
                name: "IX_Bảo dưỡng_IdXe",
                table: "Bao_Duong",
                newName: "IX_Bao_Duong_IdXe");

            migrationBuilder.AddColumn<int>(
                name: "SoCongTo",
                table: "Xe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCCD",
                table: "Nguoi_than",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CCCD",
                table: "Khach_hang",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TienCoc",
                table: "Hoa_đon_chi_tiet",
                type: "DECIMAL",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "SoCongToBaoDuong",
                table: "Bao_Duong",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Xe_bao_hiem",
                table: "Xe_bao_hiem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tai_khoan",
                table: "Tai_khoan",
                column: "username");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nhan_vien",
                table: "Nhan_vien",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nguoi_than",
                table: "Nguoi_than",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mau_sac",
                table: "Mau_sac",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loai_xe",
                table: "Loai_xe",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Khach_hang",
                table: "Khach_hang",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hoa_don_thue_xe",
                table: "Hoa_don_thue_xe",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hoa_đon_chi_tiet",
                table: "Hoa_đon_chi_tiet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hang_Xe",
                table: "Hang_Xe",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Đang_kiem",
                table: "Đang_kiem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chuc_Vu",
                table: "Chuc_Vu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bao_Hiem",
                table: "Bao_Hiem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bao_Duong",
                table: "Bao_Duong",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Giay To The Chap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiGiayTo = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giay To The Chap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiPhuPhi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLoaiPhuPhi = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiPhuPhi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tai San The Chap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiTaiSan = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tai San The Chap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chi Phi Phat Sinh",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiaTien = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    IdHDCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLPP = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chi Phi Phat Sinh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chi Phi Phat Sinh_Hoa_đon_chi_tiet_IdHDCT",
                        column: x => x.IdHDCT,
                        principalTable: "Hoa_đon_chi_tiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chi Phi Phat Sinh_LoaiPhuPhi_IdLPP",
                        column: x => x.IdLPP,
                        principalTable: "LoaiPhuPhi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "The Chap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GiaTri = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    IdHDCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGiayTo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTS = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_The Chap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_The Chap_Giay To The Chap_IdGiayTo",
                        column: x => x.IdGiayTo,
                        principalTable: "Giay To The Chap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_The Chap_Hoa_đon_chi_tiet_IdHDCT",
                        column: x => x.IdHDCT,
                        principalTable: "Hoa_đon_chi_tiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_The Chap_Tai San The Chap_IdTS",
                        column: x => x.IdTS,
                        principalTable: "Tai San The Chap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chi Phi Phat Sinh_IdHDCT",
                table: "Chi Phi Phat Sinh",
                column: "IdHDCT");

            migrationBuilder.CreateIndex(
                name: "IX_Chi Phi Phat Sinh_IdLPP",
                table: "Chi Phi Phat Sinh",
                column: "IdLPP");

            migrationBuilder.CreateIndex(
                name: "IX_The Chap_IdGiayTo",
                table: "The Chap",
                column: "IdGiayTo");

            migrationBuilder.CreateIndex(
                name: "IX_The Chap_IdHDCT",
                table: "The Chap",
                column: "IdHDCT");

            migrationBuilder.CreateIndex(
                name: "IX_The Chap_IdTS",
                table: "The Chap",
                column: "IdTS");

            migrationBuilder.AddForeignKey(
                name: "FK_Bao_Duong_Xe_IdXe",
                table: "Bao_Duong",
                column: "IdXe",
                principalTable: "Xe",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Đang_kiem_Xe_IdXe",
                table: "Đang_kiem",
                column: "IdXe",
                principalTable: "Xe",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoa_đon_chi_tiet_Hoa_don_thue_xe_IdHoaDon",
                table: "Hoa_đon_chi_tiet",
                column: "IdHoaDon",
                principalTable: "Hoa_don_thue_xe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoa_đon_chi_tiet_Xe_IdXe",
                table: "Hoa_đon_chi_tiet",
                column: "IdXe",
                principalTable: "Xe",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoa_don_thue_xe_Khach_hang_IdKhachHang",
                table: "Hoa_don_thue_xe",
                column: "IdKhachHang",
                principalTable: "Khach_hang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoa_don_thue_xe_Nhan_vien_IdNhanVien",
                table: "Hoa_don_thue_xe",
                column: "IdNhanVien",
                principalTable: "Nhan_vien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loai_xe_Hang_Xe_IdHangXe",
                table: "Loai_xe",
                column: "IdHangXe",
                principalTable: "Hang_Xe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nguoi_than_Khach_hang_IdKhachHang",
                table: "Nguoi_than",
                column: "IdKhachHang",
                principalTable: "Khach_hang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nhan_vien_Chuc_Vu_IdChucVu",
                table: "Nhan_vien",
                column: "IdChucVu",
                principalTable: "Chuc_Vu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tai_khoan_Nhan_vien_IdNhanVien",
                table: "Tai_khoan",
                column: "IdNhanVien",
                principalTable: "Nhan_vien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Xe_Loai_xe_LoaiXeId",
                table: "Xe",
                column: "LoaiXeId",
                principalTable: "Loai_xe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Xe_Mau_sac_IdMauSac",
                table: "Xe",
                column: "IdMauSac",
                principalTable: "Mau_sac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Xe_bao_hiem_Bao_Hiem_IdHangBaoHiem",
                table: "Xe_bao_hiem",
                column: "IdHangBaoHiem",
                principalTable: "Bao_Hiem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Xe_bao_hiem_Xe_IdXe",
                table: "Xe_bao_hiem",
                column: "IdXe",
                principalTable: "Xe",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bao_Duong_Xe_IdXe",
                table: "Bao_Duong");

            migrationBuilder.DropForeignKey(
                name: "FK_Đang_kiem_Xe_IdXe",
                table: "Đang_kiem");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoa_đon_chi_tiet_Hoa_don_thue_xe_IdHoaDon",
                table: "Hoa_đon_chi_tiet");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoa_đon_chi_tiet_Xe_IdXe",
                table: "Hoa_đon_chi_tiet");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoa_don_thue_xe_Khach_hang_IdKhachHang",
                table: "Hoa_don_thue_xe");

            migrationBuilder.DropForeignKey(
                name: "FK_Hoa_don_thue_xe_Nhan_vien_IdNhanVien",
                table: "Hoa_don_thue_xe");

            migrationBuilder.DropForeignKey(
                name: "FK_Loai_xe_Hang_Xe_IdHangXe",
                table: "Loai_xe");

            migrationBuilder.DropForeignKey(
                name: "FK_Nguoi_than_Khach_hang_IdKhachHang",
                table: "Nguoi_than");

            migrationBuilder.DropForeignKey(
                name: "FK_Nhan_vien_Chuc_Vu_IdChucVu",
                table: "Nhan_vien");

            migrationBuilder.DropForeignKey(
                name: "FK_Tai_khoan_Nhan_vien_IdNhanVien",
                table: "Tai_khoan");

            migrationBuilder.DropForeignKey(
                name: "FK_Xe_Loai_xe_LoaiXeId",
                table: "Xe");

            migrationBuilder.DropForeignKey(
                name: "FK_Xe_Mau_sac_IdMauSac",
                table: "Xe");

            migrationBuilder.DropForeignKey(
                name: "FK_Xe_bao_hiem_Bao_Hiem_IdHangBaoHiem",
                table: "Xe_bao_hiem");

            migrationBuilder.DropForeignKey(
                name: "FK_Xe_bao_hiem_Xe_IdXe",
                table: "Xe_bao_hiem");

            migrationBuilder.DropTable(
                name: "Chi Phi Phat Sinh");

            migrationBuilder.DropTable(
                name: "The Chap");

            migrationBuilder.DropTable(
                name: "LoaiPhuPhi");

            migrationBuilder.DropTable(
                name: "Giay To The Chap");

            migrationBuilder.DropTable(
                name: "Tai San The Chap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Xe_bao_hiem",
                table: "Xe_bao_hiem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tai_khoan",
                table: "Tai_khoan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nhan_vien",
                table: "Nhan_vien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nguoi_than",
                table: "Nguoi_than");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mau_sac",
                table: "Mau_sac");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loai_xe",
                table: "Loai_xe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Khach_hang",
                table: "Khach_hang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hoa_don_thue_xe",
                table: "Hoa_don_thue_xe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hoa_đon_chi_tiet",
                table: "Hoa_đon_chi_tiet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hang_Xe",
                table: "Hang_Xe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Đang_kiem",
                table: "Đang_kiem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chuc_Vu",
                table: "Chuc_Vu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bao_Hiem",
                table: "Bao_Hiem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bao_Duong",
                table: "Bao_Duong");

            migrationBuilder.DropColumn(
                name: "SoCongTo",
                table: "Xe");

            migrationBuilder.DropColumn(
                name: "CCCD",
                table: "Nguoi_than");

            migrationBuilder.DropColumn(
                name: "CCCD",
                table: "Khach_hang");

            migrationBuilder.DropColumn(
                name: "TienCoc",
                table: "Hoa_đon_chi_tiet");

            migrationBuilder.DropColumn(
                name: "SoCongToBaoDuong",
                table: "Bao_Duong");

            migrationBuilder.RenameTable(
                name: "Xe_bao_hiem",
                newName: "Xe bảo hiểm");

            migrationBuilder.RenameTable(
                name: "Tai_khoan",
                newName: "Tài khoản");

            migrationBuilder.RenameTable(
                name: "Nhan_vien",
                newName: "Nhân viên");

            migrationBuilder.RenameTable(
                name: "Nguoi_than",
                newName: "Người thân");

            migrationBuilder.RenameTable(
                name: "Mau_sac",
                newName: "Màu sắc");

            migrationBuilder.RenameTable(
                name: "Loai_xe",
                newName: "Loại xe");

            migrationBuilder.RenameTable(
                name: "Khach_hang",
                newName: "Khách hàng");

            migrationBuilder.RenameTable(
                name: "Hoa_don_thue_xe",
                newName: "Hoá đơn thuê xe");

            migrationBuilder.RenameTable(
                name: "Hoa_đon_chi_tiet",
                newName: "Hoá đơn chi tiết");

            migrationBuilder.RenameTable(
                name: "Hang_Xe",
                newName: "Hãng Xe");

            migrationBuilder.RenameTable(
                name: "Đang_kiem",
                newName: "Đăng kiểm");

            migrationBuilder.RenameTable(
                name: "Chuc_Vu",
                newName: "Chức Vụ");

            migrationBuilder.RenameTable(
                name: "Bao_Hiem",
                newName: "Bảo Hiểm");

            migrationBuilder.RenameTable(
                name: "Bao_Duong",
                newName: "Bảo dưỡng");

            migrationBuilder.RenameIndex(
                name: "IX_Xe_bao_hiem_IdXe",
                table: "Xe bảo hiểm",
                newName: "IX_Xe bảo hiểm_IdXe");

            migrationBuilder.RenameIndex(
                name: "IX_Xe_bao_hiem_IdHangBaoHiem",
                table: "Xe bảo hiểm",
                newName: "IX_Xe bảo hiểm_IdHangBaoHiem");

            migrationBuilder.RenameIndex(
                name: "IX_Tai_khoan_IdNhanVien",
                table: "Tài khoản",
                newName: "IX_Tài khoản_IdNhanVien");

            migrationBuilder.RenameIndex(
                name: "IX_Nhan_vien_IdChucVu",
                table: "Nhân viên",
                newName: "IX_Nhân viên_IdChucVu");

            migrationBuilder.RenameIndex(
                name: "IX_Nguoi_than_IdKhachHang",
                table: "Người thân",
                newName: "IX_Người thân_IdKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_Loai_xe_IdHangXe",
                table: "Loại xe",
                newName: "IX_Loại xe_IdHangXe");

            migrationBuilder.RenameIndex(
                name: "IX_Hoa_don_thue_xe_IdNhanVien",
                table: "Hoá đơn thuê xe",
                newName: "IX_Hoá đơn thuê xe_IdNhanVien");

            migrationBuilder.RenameIndex(
                name: "IX_Hoa_don_thue_xe_IdKhachHang",
                table: "Hoá đơn thuê xe",
                newName: "IX_Hoá đơn thuê xe_IdKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_Hoa_đon_chi_tiet_IdXe",
                table: "Hoá đơn chi tiết",
                newName: "IX_Hoá đơn chi tiết_IdXe");

            migrationBuilder.RenameIndex(
                name: "IX_Hoa_đon_chi_tiet_IdHoaDon",
                table: "Hoá đơn chi tiết",
                newName: "IX_Hoá đơn chi tiết_IdHoaDon");

            migrationBuilder.RenameIndex(
                name: "IX_Đang_kiem_IdXe",
                table: "Đăng kiểm",
                newName: "IX_Đăng kiểm_IdXe");

            migrationBuilder.RenameIndex(
                name: "IX_Bao_Duong_IdXe",
                table: "Bảo dưỡng",
                newName: "IX_Bảo dưỡng_IdXe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Xe bảo hiểm",
                table: "Xe bảo hiểm",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tài khoản",
                table: "Tài khoản",
                column: "username");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nhân viên",
                table: "Nhân viên",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Người thân",
                table: "Người thân",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Màu sắc",
                table: "Màu sắc",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loại xe",
                table: "Loại xe",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Khách hàng",
                table: "Khách hàng",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hoá đơn thuê xe",
                table: "Hoá đơn thuê xe",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hoá đơn chi tiết",
                table: "Hoá đơn chi tiết",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hãng Xe",
                table: "Hãng Xe",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Đăng kiểm",
                table: "Đăng kiểm",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chức Vụ",
                table: "Chức Vụ",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bảo Hiểm",
                table: "Bảo Hiểm",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bảo dưỡng",
                table: "Bảo dưỡng",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bảo dưỡng_Xe_IdXe",
                table: "Bảo dưỡng",
                column: "IdXe",
                principalTable: "Xe",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Đăng kiểm_Xe_IdXe",
                table: "Đăng kiểm",
                column: "IdXe",
                principalTable: "Xe",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoá đơn chi tiết_Hoá đơn thuê xe_IdHoaDon",
                table: "Hoá đơn chi tiết",
                column: "IdHoaDon",
                principalTable: "Hoá đơn thuê xe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoá đơn chi tiết_Xe_IdXe",
                table: "Hoá đơn chi tiết",
                column: "IdXe",
                principalTable: "Xe",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoá đơn thuê xe_Khách hàng_IdKhachHang",
                table: "Hoá đơn thuê xe",
                column: "IdKhachHang",
                principalTable: "Khách hàng",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hoá đơn thuê xe_Nhân viên_IdNhanVien",
                table: "Hoá đơn thuê xe",
                column: "IdNhanVien",
                principalTable: "Nhân viên",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loại xe_Hãng Xe_IdHangXe",
                table: "Loại xe",
                column: "IdHangXe",
                principalTable: "Hãng Xe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Người thân_Khách hàng_IdKhachHang",
                table: "Người thân",
                column: "IdKhachHang",
                principalTable: "Khách hàng",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nhân viên_Chức Vụ_IdChucVu",
                table: "Nhân viên",
                column: "IdChucVu",
                principalTable: "Chức Vụ",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tài khoản_Nhân viên_IdNhanVien",
                table: "Tài khoản",
                column: "IdNhanVien",
                principalTable: "Nhân viên",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Xe_Loại xe_LoaiXeId",
                table: "Xe",
                column: "LoaiXeId",
                principalTable: "Loại xe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Xe_Màu sắc_IdMauSac",
                table: "Xe",
                column: "IdMauSac",
                principalTable: "Màu sắc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Xe bảo hiểm_Bảo Hiểm_IdHangBaoHiem",
                table: "Xe bảo hiểm",
                column: "IdHangBaoHiem",
                principalTable: "Bảo Hiểm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Xe bảo hiểm_Xe_IdXe",
                table: "Xe bảo hiểm",
                column: "IdXe",
                principalTable: "Xe",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
