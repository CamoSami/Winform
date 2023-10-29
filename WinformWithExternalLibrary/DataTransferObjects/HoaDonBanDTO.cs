using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataTransferObjects
{
	public class HoaDonBanDTO
	{
		public Guid HoaDonBanDTO_MaHDBan { get; set; }

		public Guid? HoaDonBanDTO_MaKhachHang { get; set; }

		public Guid HoaDonBanDTO_MaNhanVien { get; set; }

		public DateTime HoaDonBanDTO_NgayBan { get; set; }

		public int HoaDonBanDTO_SoSanPham { get; set; }

		public int HoaDonBanDTO_GiamGia { get; set; }

		public int HoaDonBanDTO_TongTien { get; set; }

		public HoaDonBanDTO() 
		{
			this.HoaDonBanDTO_MaHDBan = Guid.NewGuid();
		}

		public HoaDonBanDTO(Guid hoaDonBanDTO_MaHDBan, Guid hoaDonBanDTO_MaKhachHang, Guid hoaDonBanDTO_MaNhanVien, DateTime hoaDonBanDTO_NgayBan, int hoaDonBanDTO_SoSanPham, int hoaDonBanDTO_GiamGia, int hoaDonBanDTO_TongTien)
		{
			this.HoaDonBanDTO_MaHDBan = hoaDonBanDTO_MaHDBan;
			this.HoaDonBanDTO_MaKhachHang = hoaDonBanDTO_MaKhachHang;
			this.HoaDonBanDTO_MaNhanVien = hoaDonBanDTO_MaNhanVien;
			this.HoaDonBanDTO_NgayBan = hoaDonBanDTO_NgayBan;
			this.HoaDonBanDTO_SoSanPham = hoaDonBanDTO_SoSanPham;
			this.HoaDonBanDTO_GiamGia = hoaDonBanDTO_GiamGia;
			this.HoaDonBanDTO_TongTien = hoaDonBanDTO_TongTien;
		}
	}
}