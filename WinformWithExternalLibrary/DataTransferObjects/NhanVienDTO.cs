﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataAccessObjects;
using System.Data;

namespace WinformWithExternalLibrary.DataTransferObjects
{
    public class NhanVienDTO
    {
		public Guid NhanVienDTO_MaNhanVien { get; set; }

        public Guid NhanVienDTO_MaCongViec { get; set; }

        public string NhanVienDTO_TenNhanVien { get; set; }

        public DateTime NhanVienDTO_NgaySinh { get; set; }

        public string NhanVienDTO_DiaChi { get; set; }

        public string NhanVienDTO_DienThoai { get; set; }

        public string NhanVienDTO_GioiTinh { get; set; }

        public NhanVienDTO(Guid nhanVienDTO_MaCongViec, string nhanVienDTO_TenNhanVien, DateTime nhanVienDTO_NgaySinh, string nhanVienDTO_DiaChi, string nhanVienDTO_DienThoai, string nhanVienDTO_GioiTinh)
        {
            this.NhanVienDTO_MaCongViec = nhanVienDTO_MaCongViec;
            this.NhanVienDTO_TenNhanVien = nhanVienDTO_TenNhanVien;
            this.NhanVienDTO_NgaySinh = nhanVienDTO_NgaySinh;
            this.NhanVienDTO_DiaChi = nhanVienDTO_DiaChi;
            this.NhanVienDTO_DienThoai = nhanVienDTO_DienThoai;
            this.NhanVienDTO_GioiTinh = nhanVienDTO_GioiTinh;
        }

        public NhanVienDTO() { }
    }
}
