﻿USE master
GO
DROP DATABASE Database_QuanLyThuNhoiBong
GO

CREATE DATABASE Database_QuanLyThuNhoiBong
GO

USE Database_QuanLyThuNhoiBong
GO

CREATE TABLE tDMSanPham(
	MaDMSanPham UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	MaSanPham NVARCHAR(12) NOT NULL,
	TenSanPham NVARCHAR(200) NOT NULL,
	DonGiaBan BIGINT NOT NULL
		DEFAULT 0,
	DonGiaNhap BIGINT NOT NULL
		DEFAULT 0,
	SoLuongTonKho INT NOT NULL,
	ThoiGianBaoHanh DATETIME NULL,
);

CREATE TABLE tCongViec(
	MaCongViec UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	MucLuong BIGINT NOT NULL 
		DEFAULT 0,
	TenCongViec NVARCHAR(70) NOT NULL,
);

CREATE TABLE tNhanVien(
	MaNhanVien UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	MaCongViec UNIQUEIDENTIFIER NOT NULL,		
	TenNhanVien NVARCHAR(40) NOT NULL,
	Email NVARCHAR(30) NOT NULL,
	MatKhau NVARCHAR(20) NOT NULL,
	NgaySinh DATETIME NOT NULL,
	DiaChi NVARCHAR(150) NOT NULL,
	DienThoai CHAR(11) NOT NULL,
	GioiTinh NVARCHAR(10) NOT NULL,
	
	FOREIGN KEY(MaCongViec) REFERENCES tCongViec(MaCongViec),
);

CREATE TABLE tGiamGia(
	MaGiamGia UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	TenGiamGia NVARCHAR(50) NOT NULL,
	PhanTramGiamGia FLOAT NOT NULL,
	MaxGiamGia BIGINT NOT NULL,
	NgayBatDau DATETIME NOT NULL,
	NgayKetThuc DATETIME NOT NULL,
);

CREATE TABLE tNhaCungCap(
	MaNhaCungCap UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	TenNhaCungCap NVARCHAR(40) NOT NULL,
	DienThoai CHAR(11) NOT NULL,
	DiaChi NVARCHAR(150) NOT NULL,
);

CREATE TABLE tHoaDonNhap(
	MaHDNhap UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	MaNhaCungCap UNIQUEIDENTIFIER NOT NULL,
	MaNhanVien UNIQUEIDENTIFIER NOT NULL,
	SoSanPham INT NOT NULL,
	NgayNhap DATETIME NOT NULL,
	TongTien BIGINT NOT NULL,

	FOREIGN KEY(MaNhaCungCap) REFERENCES tNhaCungCap(MaNhaCungCap),
	FOREIGN KEY(MaNhanVien) REFERENCES tNhanVien(MaNhanVien),
);

CREATE TABLE tKhachHang(
	MaKhachHang UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	TenKhachHang NVARCHAR(40) NOT NULL,
	DiaChi NVARCHAR(150) NOT NULL,
	DienThoai CHAR(11) NOT NULL,
);

CREATE TABLE tHoaDonBan(
	MaHDBan UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	MaKhachHang UNIQUEIDENTIFIER NULL,
	MaNhanVien UNIQUEIDENTIFIER NOT NULL,
	MaGiamGia UNIQUEIDENTIFIER NULL,
	SoSanPham INT NOT NULL,
	NgayBan DATETIME NOT NULL,
	TongTien BIGINT NOT NULL,
	TongTienKhachTra BIGINT NOT NULL,

	FOREIGN KEY(MaKhachHang) REFERENCES tKhachHang(MaKhachHang),
	FOREIGN KEY(MaNhanVien) REFERENCES tNhanVien(MaNhanVien),
	FOREIGN KEY(MaGiamGia) REFERENCES tGiamGia(MaGiamGia),
);

CREATE TABLE tChiTietHDNhap(
	MaHDNhap UNIQUEIDENTIFIER NOT NULL,
	MaDMSanPham UNIQUEIDENTIFIER NOT NULL,
	SoLuong INT NOT NULL,
	ThanhTien BIGINT NOT NULL,

	CONSTRAINT PK_tChiTietHDNhap PRIMARY KEY(MaHDNhap, MaDMSanPham),
	FOREIGN KEY(MaHDNhap) REFERENCES tHoaDonNhap(MaHDNhap),
	FOREIGN KEY(MaDMSanPham) REFERENCES tDMSanPham(MaDMSanPham),
);

CREATE TABLE tChiTietHDBan(
	MaHDBan UNIQUEIDENTIFIER NOT NULL,
	MaDMSanPham UNIQUEIDENTIFIER NOT NULL,
	SoLuong INT NOT NULL,
	ThanhTien BIGINT NOT NULL,

	CONSTRAINT PK_tChiTietHDBan PRIMARY KEY(MaHDBan, MaDMSanPham),
	FOREIGN KEY(MaHDBan) REFERENCES tHoaDonBan(MaHDBan),
	FOREIGN KEY(MaDMSanPham) REFERENCES tDMSanPham(MaDMSanPham),
);
