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
                name: "Bao_Hiem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiBaoHiem = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ThoiHan = table.Column<DateTime>(type: "DateTime", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bao_Hiem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chuc_Vu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenChucVu = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chuc_Vu", x => x.Id);
                });

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
                name: "Hang_Xe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hang_Xe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Khach_hang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "Bit", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khach_hang", x => x.Id);
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
                name: "Mau_sac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMauSac = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mau_sac", x => x.Id);
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
                name: "Nhan_vien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "Bit", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhan_vien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nhan_vien_Chuc_Vu_IdChucVu",
                        column: x => x.IdChucVu,
                        principalTable: "Chuc_Vu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loai_xe",
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
                    table.PrimaryKey("PK_Loai_xe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loai_xe_Hang_Xe_IdHangXe",
                        column: x => x.IdHangXe,
                        principalTable: "Hang_Xe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nguoi_than",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CCCD = table.Column<string>(type: "varchar(50)", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nguoi_than", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nguoi_than_Khach_hang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "Khach_hang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hoa_don_thue_xe",
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
                    table.PrimaryKey("PK_Hoa_don_thue_xe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hoa_don_thue_xe_Khach_hang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "Khach_hang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hoa_don_thue_xe_Nhan_vien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "Nhan_vien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tai_khoan",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tai_khoan", x => x.username);
                    table.ForeignKey(
                        name: "FK_Tai_khoan_Nhan_vien_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "Nhan_vien",
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
                    SoCongTo = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdLoaiXe = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiXeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xe", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Xe_Loai_xe_LoaiXeId",
                        column: x => x.LoaiXeId,
                        principalTable: "Loai_xe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Xe_Mau_sac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "Mau_sac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bao_Duong",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayDangKiem = table.Column<DateTime>(type: "DateTime", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ChiPhi = table.Column<decimal>(type: "Decimal", nullable: false),
                    SoCongToBaoDuong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdXe = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bao_Duong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bao_Duong_Xe_IdXe",
                        column: x => x.IdXe,
                        principalTable: "Xe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Đang_kiem",
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
                    table.PrimaryKey("PK_Đang_kiem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Đang_kiem_Xe_IdXe",
                        column: x => x.IdXe,
                        principalTable: "Xe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hoa_đon_chi_tiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "DateTime", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "DateTime", nullable: false),
                    TongTien = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    DonGia = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    TienCoc = table.Column<decimal>(type: "DECIMAL", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdXe = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoa_đon_chi_tiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hoa_đon_chi_tiet_Hoa_don_thue_xe_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "Hoa_don_thue_xe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hoa_đon_chi_tiet_Xe_IdXe",
                        column: x => x.IdXe,
                        principalTable: "Xe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Xe_bao_hiem",
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
                    table.PrimaryKey("PK_Xe_bao_hiem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Xe_bao_hiem_Bao_Hiem_IdHangBaoHiem",
                        column: x => x.IdHangBaoHiem,
                        principalTable: "Bao_Hiem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Xe_bao_hiem_Xe_IdXe",
                        column: x => x.IdXe,
                        principalTable: "Xe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Bao_Duong_IdXe",
                table: "Bao_Duong",
                column: "IdXe");

            migrationBuilder.CreateIndex(
                name: "IX_Chi Phi Phat Sinh_IdHDCT",
                table: "Chi Phi Phat Sinh",
                column: "IdHDCT");

            migrationBuilder.CreateIndex(
                name: "IX_Chi Phi Phat Sinh_IdLPP",
                table: "Chi Phi Phat Sinh",
                column: "IdLPP");

            migrationBuilder.CreateIndex(
                name: "IX_Đang_kiem_IdXe",
                table: "Đang_kiem",
                column: "IdXe");

            migrationBuilder.CreateIndex(
                name: "IX_Hoa_đon_chi_tiet_IdHoaDon",
                table: "Hoa_đon_chi_tiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_Hoa_đon_chi_tiet_IdXe",
                table: "Hoa_đon_chi_tiet",
                column: "IdXe");

            migrationBuilder.CreateIndex(
                name: "IX_Hoa_don_thue_xe_IdKhachHang",
                table: "Hoa_don_thue_xe",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_Hoa_don_thue_xe_IdNhanVien",
                table: "Hoa_don_thue_xe",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_Loai_xe_IdHangXe",
                table: "Loai_xe",
                column: "IdHangXe");

            migrationBuilder.CreateIndex(
                name: "IX_Nguoi_than_IdKhachHang",
                table: "Nguoi_than",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_Nhan_vien_IdChucVu",
                table: "Nhan_vien",
                column: "IdChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_Tai_khoan_IdNhanVien",
                table: "Tai_khoan",
                column: "IdNhanVien",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Xe_IdMauSac",
                table: "Xe",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_Xe_LoaiXeId",
                table: "Xe",
                column: "LoaiXeId");

            migrationBuilder.CreateIndex(
                name: "IX_Xe_bao_hiem_IdHangBaoHiem",
                table: "Xe_bao_hiem",
                column: "IdHangBaoHiem");

            migrationBuilder.CreateIndex(
                name: "IX_Xe_bao_hiem_IdXe",
                table: "Xe_bao_hiem",
                column: "IdXe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bao_Duong");

            migrationBuilder.DropTable(
                name: "Chi Phi Phat Sinh");

            migrationBuilder.DropTable(
                name: "Đang_kiem");

            migrationBuilder.DropTable(
                name: "Nguoi_than");

            migrationBuilder.DropTable(
                name: "Tai_khoan");

            migrationBuilder.DropTable(
                name: "The Chap");

            migrationBuilder.DropTable(
                name: "Xe_bao_hiem");

            migrationBuilder.DropTable(
                name: "LoaiPhuPhi");

            migrationBuilder.DropTable(
                name: "Giay To The Chap");

            migrationBuilder.DropTable(
                name: "Hoa_đon_chi_tiet");

            migrationBuilder.DropTable(
                name: "Tai San The Chap");

            migrationBuilder.DropTable(
                name: "Bao_Hiem");

            migrationBuilder.DropTable(
                name: "Hoa_don_thue_xe");

            migrationBuilder.DropTable(
                name: "Xe");

            migrationBuilder.DropTable(
                name: "Khach_hang");

            migrationBuilder.DropTable(
                name: "Nhan_vien");

            migrationBuilder.DropTable(
                name: "Loai_xe");

            migrationBuilder.DropTable(
                name: "Mau_sac");

            migrationBuilder.DropTable(
                name: "Chuc_Vu");

            migrationBuilder.DropTable(
                name: "Hang_Xe");
        }
    }
}
