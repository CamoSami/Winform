﻿USE MASTER
GO
USE Database_QuanLyThuNhoiBong
GO

SELECT * FROM tDMSanPham;
SELECT * FROM tCongViec;
SELECT * FROM tNhanVien;
SELECT * FROM tNhaCungCap;
SELECT * FROM tKhachHang;
SELECT * FROM tHoaDonNhap;
SELECT * FROM tChiTietHDNhap;
SELECT * FROM tHoaDonBan;
SELECT * FROM tChiTietHDBan;
SELECT * FROM tGiamGia;

DELETE FROM tDMSanPham;
DELETE FROM tKhachHang;

SELECT Count(DISTINCT MaSanPham) AS CountMSP FROM tDMSanPham HAVING Count(MaSanPham) > 1

SELECT * FROM tHoaDonBan WHERE Day(NgayBan) = 6;

SELECT * FROM tChiTietHDBan WHERE MaHDBan LIKE 'F198F9A5%';

SELECT * FROM tKhachHang WHERE TenKhachHang LIKE '%Hiếu%'

SELECT * FROM tKhachHang WHERE MaKhachHang = 'AAD4683A-B2A3-4F13-9E8C-C3FCBA3D2836';

SELECT * FROM tDMSanPham WHERE MaSanPham = '202892409170';

INSERT INTO tKhachHang (TenKhachHang, DiaChi, DienThoai) VALUES (N'Ngô Sách Minh Hiếu', N'Làng Vòng, Cầu Giấy, Hà Nội', '0977255636')
