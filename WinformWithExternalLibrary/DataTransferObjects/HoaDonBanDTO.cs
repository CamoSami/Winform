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

		public Guid? HoaDonBanDTO_MaGiamGia { get; set; }

		public DateTime HoaDonBanDTO_NgayBan { get; set; }

		public int HoaDonBanDTO_SoSanPham { get; set; }

		public long HoaDonBanDTO_TongTien { get; set; }

		public long HoaDonBanDTO_TongTienKhachTra { get; set; }

		public HoaDonBanDTO() 
		{
			this.HoaDonBanDTO_MaHDBan = Guid.NewGuid();
		}

		public HoaDonBanDTO(Guid hoaDonBanDTO_MaHDBan, Guid hoaDonBanDTO_MaKhachHang, Guid hoaDonBanDTO_MaNhanVien, Guid hoaDonBanDTO_MaGiamGia, DateTime hoaDonBanDTO_NgayBan, int hoaDonBanDTO_SoSanPham, long hoaDonBanDTO_TongTien, long hoaDonBanDTO_TongTienKhachTra)
		{
			this.HoaDonBanDTO_MaHDBan = hoaDonBanDTO_MaHDBan;
			this.HoaDonBanDTO_MaKhachHang = hoaDonBanDTO_MaKhachHang;
			this.HoaDonBanDTO_MaNhanVien = hoaDonBanDTO_MaNhanVien;
			this.HoaDonBanDTO_MaGiamGia = hoaDonBanDTO_MaGiamGia;
			this.HoaDonBanDTO_NgayBan = hoaDonBanDTO_NgayBan;
			this.HoaDonBanDTO_SoSanPham = hoaDonBanDTO_SoSanPham;
			this.HoaDonBanDTO_TongTien = hoaDonBanDTO_TongTien;
			this.HoaDonBanDTO_TongTienKhachTra = hoaDonBanDTO_TongTienKhachTra;
		}
	}
}