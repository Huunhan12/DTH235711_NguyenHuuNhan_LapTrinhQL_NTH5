using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhanSu.Migrations
{
    /// <inheritdoc />
    public partial class SuaLoiCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaCV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenCv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.MaCV);
                });

            migrationBuilder.CreateTable(
                name: "Luong",
                columns: table => new
                {
                    HeSoLuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LuongCB = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luong", x => x.HeSoLuong);
                });

            migrationBuilder.CreateTable(
                name: "PhongBan",
                columns: table => new
                {
                    MaPB = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenPB = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBan", x => x.MaPB);
                });

            migrationBuilder.CreateTable(
                name: "HopDong",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeSoLuong = table.Column<int>(type: "int", nullable: false),
                    MaCV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaPB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LuongHeSoLuong = table.Column<int>(type: "int", nullable: false),
                    ChucVuMaCV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhongBanMaPB = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDong", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HopDong_ChucVu_ChucVuMaCV",
                        column: x => x.ChucVuMaCV,
                        principalTable: "ChucVu",
                        principalColumn: "MaCV");
                    table.ForeignKey(
                        name: "FK_HopDong_Luong_LuongHeSoLuong",
                        column: x => x.LuongHeSoLuong,
                        principalTable: "Luong",
                        principalColumn: "HeSoLuong");
                    table.ForeignKey(
                        name: "FK_HopDong_PhongBan_PhongBanMaPB",
                        column: x => x.PhongBanMaPB,
                        principalTable: "PhongBan",
                        principalColumn: "MaPB");
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaPB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaHD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeSoLuong = table.Column<int>(type: "int", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoCM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrinhDoHV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TTHonNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhongBanMaPB = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LuongHeSoLuong = table.Column<int>(type: "int", nullable: false),
                    HopDongMaHD = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanVien_HopDong_HopDongMaHD",
                        column: x => x.HopDongMaHD,
                        principalTable: "HopDong",
                        principalColumn: "MaHD");
                    table.ForeignKey(
                        name: "FK_NhanVien_Luong_LuongHeSoLuong",
                        column: x => x.LuongHeSoLuong,
                        principalTable: "Luong",
                        principalColumn: "HeSoLuong");
                    table.ForeignKey(
                        name: "FK_NhanVien_PhongBan_PhongBanMaPB",
                        column: x => x.PhongBanMaPB,
                        principalTable: "PhongBan",
                        principalColumn: "MaPB");
                });

            migrationBuilder.CreateTable(
                name: "BaoHiem",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoHiem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BaoHiem_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "ChamCong",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChamCong", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChamCong_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "ctChucVu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaCV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LyDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ChucVuMaCV = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ctChucVu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ctChucVu_ChucVu_ChucVuMaCV",
                        column: x => x.ChucVuMaCV,
                        principalTable: "ChucVu",
                        principalColumn: "MaCV");
                    table.ForeignKey(
                        name: "FK_ctChucVu_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "PhuCap",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiPC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tien = table.Column<int>(type: "int", nullable: true),
                    TuNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DenNgay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuCap", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhuCap_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "Taikhoan",
                columns: table => new
                {
                    TenDangNhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenQuyenHan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taikhoan", x => x.TenDangNhap);
                    table.ForeignKey(
                        name: "FK_Taikhoan_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "ThuongPhat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tien = table.Column<int>(type: "int", nullable: true),
                    LyDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongPhat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ThuongPhat_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaoHiem_NhanVienMaNhanVien",
                table: "BaoHiem",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ChamCong_NhanVienMaNhanVien",
                table: "ChamCong",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ctChucVu_ChucVuMaCV",
                table: "ctChucVu",
                column: "ChucVuMaCV");

            migrationBuilder.CreateIndex(
                name: "IX_ctChucVu_NhanVienMaNhanVien",
                table: "ctChucVu",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_ChucVuMaCV",
                table: "HopDong",
                column: "ChucVuMaCV");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_LuongHeSoLuong",
                table: "HopDong",
                column: "LuongHeSoLuong");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_PhongBanMaPB",
                table: "HopDong",
                column: "PhongBanMaPB");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_HopDongMaHD",
                table: "NhanVien",
                column: "HopDongMaHD");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_LuongHeSoLuong",
                table: "NhanVien",
                column: "LuongHeSoLuong");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_PhongBanMaPB",
                table: "NhanVien",
                column: "PhongBanMaPB");

            migrationBuilder.CreateIndex(
                name: "IX_PhuCap_NhanVienMaNhanVien",
                table: "PhuCap",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_Taikhoan_NhanVienMaNhanVien",
                table: "Taikhoan",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ThuongPhat_NhanVienMaNhanVien",
                table: "ThuongPhat",
                column: "NhanVienMaNhanVien");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaoHiem");

            migrationBuilder.DropTable(
                name: "ChamCong");

            migrationBuilder.DropTable(
                name: "ctChucVu");

            migrationBuilder.DropTable(
                name: "PhuCap");

            migrationBuilder.DropTable(
                name: "Taikhoan");

            migrationBuilder.DropTable(
                name: "ThuongPhat");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "HopDong");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "Luong");

            migrationBuilder.DropTable(
                name: "PhongBan");
        }
    }
}
