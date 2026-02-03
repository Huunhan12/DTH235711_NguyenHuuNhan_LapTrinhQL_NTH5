USE QLBH;
SET SQL_SAFE_UPDATES = 0;

-- Xóa dữ liệu các bảng cũ (Nếu có)
DELETE FROM HoaDon_ChiTiet;
DELETE FROM HoaDon;
DELETE FROM SanPham;
DELETE FROM HangSanXuat;
DELETE FROM LoaiSanPham;
DELETE FROM NhanVien;
DELETE FROM KhachHang;
SET SQL_SAFE_UPDATES = 1;

-- Reset identity
ALTER TABLE HoaDon_ChiTiet AUTO_INCREMENT = 1;
ALTER TABLE HoaDon AUTO_INCREMENT = 1;
ALTER TABLE SanPham AUTO_INCREMENT = 1;
ALTER TABLE HangSanXuat AUTO_INCREMENT = 1;
ALTER TABLE LoaiSanPham AUTO_INCREMENT = 1;
ALTER TABLE NhanVien AUTO_INCREMENT = 1;
ALTER TABLE KhachHang AUTO_INCREMENT = 1;


INSERT INTO HangSanXuat (ID, TenHangSanXuat) VALUES
(1, 'Acer'),
(2, 'Apple'),
(3, 'Asus'),
(4, 'Dell'),
(5, 'HP'),
(6, 'Huawei'),
(7, 'Itel'),
(8, 'Lenovo'),
(9, 'LG'),
(10, 'Masstel'),
(11, 'Mobell'),
(12, 'MSI'),
(13, 'Nokia'),
(14, 'Oneplus'),
(15, 'Oppo'),
(16, 'Realme'),
(17, 'Samsung'),
(18, 'Vivo'),
(19, 'Xiaomi');


INSERT INTO NhanVien
(HoVaTen, DienThoai, DiaChi, TenDangNhap, MatKhau, QuyenHan)
VALUES
('Nguyễn Văn An', '0123456888', 'Long Xuyên', 'admin',
 '$2a$11$XGOVk9m4HqzXBlwVvhKN/ur8FS/keV9QyuCwikTL67sL0gqNUupMa', 1),

('Hoàng Thảo My', '0123456999', 'Châu Thành', 'user',
 '$2a$11$c1syEtekaZ6OJrX77mGoJ.6mu4YuUjUHvKrliW8oOU3M3u7I6zyuy', 0);


INSERT INTO KhachHang (HoVaTen, DienThoai, DiaChi) VALUES
('Lê Thị Kim Yến', '0123456777', 'Chợ Mới'),
('Võ Huỳnh Đông', '0123456555', 'Lấp Vò - Đồng Tháp'),
('Nguyễn Huỳnh Minh Trí', '0123456444', 'Phú Hòa');


INSERT INTO LoaiSanPham (ID, TenLoai) VALUES
(1, 'Điện thoại'),
(2, 'Máy tính bảng'),
(3, 'Máy tính xách tay');


INSERT INTO SanPham
(LoaiSanPhamID, HangSanXuatID, TenSanPham, DonGia, SoLuong, HinhAnh)
VALUES
(1, 2, 'iPhone 15', 22990000, 100, 'iphone-15.jpg'),
(1, 2, 'iPhone 15 Plus', 25990000, 100, 'iphone-15-plus.jpg'),
(1, 2, 'iPhone 15 Pro', 27990000, 100, 'iphone-15-pro.jpg'),
(1, 2, 'iPhone 15 Pro Max', 34990000, 100, 'iphone-15-pro-max.jpg');

SELECT * FROM HangSanXuat;
SELECT * FROM NhanVien;
SELECT * FROM KhachHang;
SELECT * FROM LoaiSanPham;
SELECT * FROM SanPham;
