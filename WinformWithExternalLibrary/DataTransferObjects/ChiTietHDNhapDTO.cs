using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataTransferObjects
{
	public class ChiTietHDNhapDTO
	{
		public Guid ChiTietHDNhapDTO_MaHDNhap { get; set; }

		public Guid ChiTietHDNhapDTO_MaDMSanPham { get; set; }

		public int ChiTietHDNhapDTO_SoLuong { get; set; }

		public long ChiTietHDNhapDTO_ThanhTien { get; set; }

		public ChiTietHDNhapDTO() { }

		public ChiTietHDNhapDTO(Guid chiTietHDNhapDTO_MaHDNhap, Guid chiTietHDNhapDTO_MaDMSanPham, int chiTietHDNhapDTO_SoLuong, long chiTietHDNhapDTO_ThanhTien)
		{
			this.ChiTietHDNhapDTO_MaHDNhap = chiTietHDNhapDTO_MaHDNhap;
			this.ChiTietHDNhapDTO_MaDMSanPham = chiTietHDNhapDTO_MaDMSanPham;
			this.ChiTietHDNhapDTO_SoLuong = chiTietHDNhapDTO_SoLuong;
			this.ChiTietHDNhapDTO_ThanhTien = chiTietHDNhapDTO_ThanhTien;
		}
	}
}
