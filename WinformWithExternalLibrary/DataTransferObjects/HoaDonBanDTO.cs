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
		[Required(
			ErrorMessage = "Thiếu ngày bán kìa!"
			)]
		[DisplayName(
			"Ngày Bán"
			)]
		public DateTime HoaDonBanDTO_NgayBan { get; set; }

		//[Required(
		//	ErrorMessage = "Thiếu tổng tiền kìa!"
		//	)]
		//[DisplayName(
		//	"Tổng Tiền"
		//	)]
		public int HoaDonBanDTO_TongTien { get; set; }

		//[Required(
		//	ErrorMessage = "Thiếu mã nhân viên kìa!"
		//	)]
		//[DisplayName(
		//	"Mã Nhân Viên"
		//	)]
		public Guid HoaDonBanDTO_MaNhanVien { get; set; }

		public HoaDonBanDTO() { }

		public HoaDonBanDTO(Guid hoaDonBanDTO_MaNhanVien, DateTime hoaDonBanDTO_NgayBan, int hoaDonBanDTO_TongTien)
		{
			this.HoaDonBanDTO_NgayBan = hoaDonBanDTO_NgayBan;
			this.HoaDonBanDTO_MaNhanVien = hoaDonBanDTO_MaNhanVien;
			this.HoaDonBanDTO_TongTien = hoaDonBanDTO_TongTien;
		}


	}
}