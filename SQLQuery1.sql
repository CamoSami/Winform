USE MASTER
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

DELETE FROM tDMSanPham;
DELETE FROM tKhachHang;

SELECT Count(DISTINCT MaSanPham) AS CountMSP FROM tDMSanPham HAVING Count(MaSanPham) > 1

INSERT INTO tKhachHang (TenKhachHang, DiaChi, DienThoai) VALUES (N'Ngô Sách Minh Hiếu', N'Làng Vòng, Cầu Giấy, Hà Nội', '0977255636')