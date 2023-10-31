using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataTransferObjects
{
	public class ChiTietHDBanDTO
	{
		public Guid ChiTietHDBanDTO_MaHDBan { get; set; }

		public Guid ChiTietHDBanDTO_MaDMSanPham { get; set; }

		public int ChiTietHDBanDTO_SoLuong { get; set; }

		public long ChiTietHDBanDTO_ThanhTien { get; set; }

		public ChiTietHDBanDTO() { }

		public ChiTietHDBanDTO(Guid chiTietHDBanDTO_MaHDBan, Guid chiTietHDBanDTO_MaDMSanPham, int chiTietHDBanDTO_SoLuong, int chiTietHDBanDTO_ThanhTien)
		{
			this.ChiTietHDBanDTO_MaHDBan = chiTietHDBanDTO_MaHDBan;
			this.ChiTietHDBanDTO_MaDMSanPham = chiTietHDBanDTO_MaDMSanPham;
			this.ChiTietHDBanDTO_SoLuong = chiTietHDBanDTO_SoLuong;
			this.ChiTietHDBanDTO_ThanhTien = chiTietHDBanDTO_ThanhTien;
		}
	}
}
