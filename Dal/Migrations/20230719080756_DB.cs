using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dal.Migrations
{
    public partial class DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bảo Hiểm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiBaoHiem = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ThoiHan = table.Column<DateTime>(type: "DateTime", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bảo Hiểm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chức Vụ",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chức Vụ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hãng Xe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hãng Xe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Khách hàng",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "Bit", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SDT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khách hàng", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Màu sắc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMauSac = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Màu sắc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nhân viên",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "Bit", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SDT = table.Column<int>(type: "int", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "DateTime", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhân viên", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nhân viên_Chức Vụ_IdChucVu",
                        column: x => x.IdChucVu,
                        principalTable: "Chức Vụ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loại xe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LoaiNguyenLieu = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SoGhe = table.Column<int>(type: "int", nullable: false),
                    LoaiSoXe = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    NhienLieuTieuThu = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    IdHangXe = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loại xe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loại xe_Hãng Xe_IdHangXe",
                        column: x => x.IdHangXe,
                        principalTable: "Hãng Xe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Người thân",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SDT = table.Column<int>(type: "int", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Người thân", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Người thân_Khách hàng_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "Khách hàng",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hoá đơn thuê xe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "DateTime", nullable: false),
                    SoHopDong = table.Column<int>(type: "int", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoá đơn thuê xe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hoá đơn thuê xe_Khách hàng_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "Khách hàng",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hoá đơn thuê xe_Nhân viên_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "Nhân viên",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tài khoản",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tài khoản", x => x.username);
                    table.ForeignKey(
                        name: "FK_Tài khoản_Nhân viên_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "Nhân viên",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Xe",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BienSo = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SoKhung = table.Column<int>(type: "int", nullable: false),
                    SoMay = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdLoaiXe = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiXeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xe", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Xe_Loại xe_LoaiXeId",
                        column: x => x.LoaiXeId,
                        principalTable: "Loại xe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Xe_Màu sắc_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "Màu sắc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bảo dưỡng",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayDangKiem = table.Column<DateTime>(type: "DateTime", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ChiPhi = table.Column<decimal>(type: "Decimal", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdXe = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bảo dưỡng", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bảo dưỡng_Xe_IdXe",
                        column: x => x.IdXe,
                        principalTable: "Xe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Đăng kiểm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayDangKiem = table.Column<DateTime>(type: "DateTime", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "DateTime", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdXe = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Đăng kiểm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Đăng kiểm_Xe_IdXe",
                        column: x => x.IdXe,
                        principalTable: "Xe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hoá đơn chi tiết",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "DateTime", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "DateTime", nullable: false),
                    TongTien = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    DonGia = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    SoLuong = table.Column<int>(type: "Int", nullable: false),
                    PhuPhi = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdXe = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoá đơn chi tiết", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hoá đơn chi tiết_Hoá đơn thuê xe_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "Hoá đơn thuê xe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hoá đơn chi tiết_Xe_IdXe",
                        column: x => x.IdXe,
                        principalTable: "Xe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Xe bảo hiểm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "DateTime", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ChiPhi = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdXe = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHangBaoHiem = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xe bảo hiểm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Xe bảo hiểm_Bảo Hiểm_IdHangBaoHiem",
                        column: x => x.IdHangBaoHiem,
                        principalTable: "Bảo Hiểm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Xe bảo hiểm_Xe_IdXe",
                        column: x => x.IdXe,
                        principalTable: "Xe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bảo dưỡng_IdXe",
                table: "Bảo dưỡng",
                column: "IdXe");

            migrationBuilder.CreateIndex(
                name: "IX_Đăng kiểm_IdXe",
                table: "Đăng kiểm",
                column: "IdXe");

            migrationBuilder.CreateIndex(
                name: "IX_Hoá đơn chi tiết_IdHoaDon",
                table: "Hoá đơn chi tiết",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_Hoá đơn chi tiết_IdXe",
                table: "Hoá đơn chi tiết",
                column: "IdXe");

            migrationBuilder.CreateIndex(
                name: "IX_Hoá đơn thuê xe_IdKhachHang",
                table: "Hoá đơn thuê xe",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_Hoá đơn thuê xe_IdNhanVien",
                table: "Hoá đơn thuê xe",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_Loại xe_IdHangXe",
                table: "Loại xe",
                column: "IdHangXe");

            migrationBuilder.CreateIndex(
                name: "IX_Người thân_IdKhachHang",
                table: "Người thân",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_Nhân viên_IdChucVu",
                table: "Nhân viên",
                column: "IdChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_Tài khoản_IdNhanVien",
                table: "Tài khoản",
                column: "IdNhanVien",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Xe_IdMauSac",
                table: "Xe",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_Xe_LoaiXeId",
                table: "Xe",
                column: "LoaiXeId");

            migrationBuilder.CreateIndex(
                name: "IX_Xe bảo hiểm_IdHangBaoHiem",
                table: "Xe bảo hiểm",
                column: "IdHangBaoHiem");

            migrationBuilder.CreateIndex(
                name: "IX_Xe bảo hiểm_IdXe",
                table: "Xe bảo hiểm",
                column: "IdXe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bảo dưỡng");

            migrationBuilder.DropTable(
                name: "Đăng kiểm");

            migrationBuilder.DropTable(
                name: "Hoá đơn chi tiết");

            migrationBuilder.DropTable(
                name: "Người thân");

            migrationBuilder.DropTable(
                name: "Tài khoản");

            migrationBuilder.DropTable(
                name: "Xe bảo hiểm");

            migrationBuilder.DropTable(
                name: "Hoá đơn thuê xe");

            migrationBuilder.DropTable(
                name: "Bảo Hiểm");

            migrationBuilder.DropTable(
                name: "Xe");

            migrationBuilder.DropTable(
                name: "Khách hàng");

            migrationBuilder.DropTable(
                name: "Nhân viên");

            migrationBuilder.DropTable(
                name: "Loại xe");

            migrationBuilder.DropTable(
                name: "Màu sắc");

            migrationBuilder.DropTable(
                name: "Chức Vụ");

            migrationBuilder.DropTable(
                name: "Hãng Xe");
        }
    }
}
