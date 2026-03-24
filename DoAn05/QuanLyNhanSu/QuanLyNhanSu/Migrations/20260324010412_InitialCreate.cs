using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhanSu.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaCV = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TenCv = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
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
                    MaPB = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TenPB = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBan", x => x.MaPB);
                });

            migrationBuilder.CreateTable(
                name: "HopDong",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    NgayVaoLam = table.Column<DateOnly>(type: "date", nullable: false),
                    HeSoLuong = table.Column<int>(type: "int", nullable: false),
                    MaCV = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    MaPB = table.Column<string>(type: "nvarchar(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDong", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HopDong_ChucVu_MaCV",
                        column: x => x.MaCV,
                        principalTable: "ChucVu",
                        principalColumn: "MaCV");
                    table.ForeignKey(
                        name: "FK_HopDong_Luong_HeSoLuong",
                        column: x => x.HeSoLuong,
                        principalTable: "Luong",
                        principalColumn: "HeSoLuong");
                    table.ForeignKey(
                        name: "FK_HopDong_PhongBan_MaPB",
                        column: x => x.MaPB,
                        principalTable: "PhongBan",
                        principalColumn: "MaPB");
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    MaPB = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    MaHD = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    HeSoLuong = table.Column<int>(type: "int", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    NgaySinh = table.Column<DateOnly>(type: "date", nullable: false),
                    SoCM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TrinhDoHV = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Hinh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TTHonNhan = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanVien_HopDong_MaHD",
                        column: x => x.MaHD,
                        principalTable: "HopDong",
                        principalColumn: "MaHD");
                    table.ForeignKey(
                        name: "FK_NhanVien_Luong_HeSoLuong",
                        column: x => x.HeSoLuong,
                        principalTable: "Luong",
                        principalColumn: "HeSoLuong");
                    table.ForeignKey(
                        name: "FK_NhanVien_PhongBan_MaPB",
                        column: x => x.MaPB,
                        principalTable: "PhongBan",
                        principalColumn: "MaPB");
                });

            migrationBuilder.CreateTable(
                name: "BaoHiem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    LoaiBaoHiem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoThe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayCap = table.Column<DateOnly>(type: "date", nullable: true),
                    NgayHetHan = table.Column<DateOnly>(type: "date", nullable: true),
                    NoiCap = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoHiem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaoHiem_NhanVien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "ChamCong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    Ngay = table.Column<DateOnly>(type: "date", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChamCong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChamCong_NhanVien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "ctChucVu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    MaCV = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    NgayBatDau = table.Column<DateOnly>(type: "date", nullable: true),
                    NgayKetThuc = table.Column<DateOnly>(type: "date", nullable: true),
                    LyDo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ctChucVu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ctChucVu_ChucVu_MaCV",
                        column: x => x.MaCV,
                        principalTable: "ChucVu",
                        principalColumn: "MaCV");
                    table.ForeignKey(
                        name: "FK_ctChucVu_NhanVien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "PhuCap",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    LoaiPC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tien = table.Column<int>(type: "int", nullable: true),
                    TuNgay = table.Column<DateOnly>(type: "date", nullable: true),
                    DenNgay = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuCap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhuCap_NhanVien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "Taikhoan",
                columns: table => new
                {
                    TenDangNhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenQuyenHan = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taikhoan", x => x.TenDangNhap);
                    table.ForeignKey(
                        name: "FK_Taikhoan_NhanVien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "ThuongPhat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    Loai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tien = table.Column<int>(type: "int", nullable: true),
                    LyDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ngay = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongPhat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThuongPhat_NhanVien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaoHiem_MaNhanVien",
                table: "BaoHiem",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ChamCong_MaNhanVien",
                table: "ChamCong",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ctChucVu_MaCV",
                table: "ctChucVu",
                column: "MaCV");

            migrationBuilder.CreateIndex(
                name: "IX_ctChucVu_MaNhanVien",
                table: "ctChucVu",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_HeSoLuong",
                table: "HopDong",
                column: "HeSoLuong");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_MaCV",
                table: "HopDong",
                column: "MaCV");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_MaPB",
                table: "HopDong",
                column: "MaPB");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_HeSoLuong",
                table: "NhanVien",
                column: "HeSoLuong");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaHD",
                table: "NhanVien",
                column: "MaHD");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaPB",
                table: "NhanVien",
                column: "MaPB");

            migrationBuilder.CreateIndex(
                name: "IX_PhuCap_MaNhanVien",
                table: "PhuCap",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_Taikhoan_MaNhanVien",
                table: "Taikhoan",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_ThuongPhat_MaNhanVien",
                table: "ThuongPhat",
                column: "MaNhanVien");
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
