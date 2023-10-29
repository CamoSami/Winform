using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataTransferObjects
{
	public class HoaDonNhapDTO
	{
		public Guid HoaDonNhapDTO_MaHDNhap { get; set; }

		public Guid HoaDonNhapDTO_MaNhaCungCap { get; set; }

		public Guid HoaDonNhapDTO_MaNhanVien { get; set; }

		public DateTime HoaDonNhapDTO_NgayNhap { get; set; }

		public int HoaDonNhapDTO_SoSanPham { get; set; }

		public int HoaDonNhapDTO_GiamGia { get; set; }

		public int HoaDonNhapDTO_TongTien { get; set; }

		public HoaDonNhapDTO() { }

		public HoaDonNhapDTO(Guid hoaDonNhapDTO_MaNhaCungCap, Guid hoaDonNhapDTO_MaNhanVien, DateTime hoaDonNhapDTO_NgayNhap, int hoaDonNhapDTO_SoSanPham, int hoaDonNhapDTO_GiamGia, int hoaDonNhapDTO_TongTien)
		{
			this.HoaDonNhapDTO_MaNhaCungCap = hoaDonNhapDTO_MaNhaCungCap;
			this.HoaDonNhapDTO_MaNhanVien = hoaDonNhapDTO_MaNhanVien;
			this.HoaDonNhapDTO_NgayNhap = hoaDonNhapDTO_NgayNhap;
			this.HoaDonNhapDTO_SoSanPham = hoaDonNhapDTO_SoSanPham;
			this.HoaDonNhapDTO_GiamGia = hoaDonNhapDTO_GiamGia;
			this.HoaDonNhapDTO_TongTien = hoaDonNhapDTO_TongTien;
		}
	}
}
