using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataValidateObject.CustomValidation;

namespace WinformWithExternalLibrary.DataValidateObject
{
	public class HoaDonBanDVO
	{
		[HoaDonBanDVO_ExistedDienThoaiKhachHang(
			ErrorMessage = "Điện thoại khách hàng vừa nhập không tồn tại"
			)]
		[DisplayName("Điện thoại khách hàng")]
		public string HoaDonBanDVO_DienThoaiKhachHang { get; set; }



		[DisplayName("Tên khách hàng")]
		public string HoaDonBanDVO_TenKhachHang { get; set; }



		//		TODO: Validate If Exist
		//		TODO: Validate If Eligible
		[DisplayName("Mã Giảm giá")]
		public Guid HoaDonBanDVO_MaGiamGia { get; set; }



		[Required(
			ErrorMessage = "Hãy nhập tổng tiền"
			)]
		[DisplayName("Tổng tiền")]
		public long HoaDonBanDVO_TongTien { get; set; }

		public HoaDonBanDVO() { }

		public HoaDonBanDVO(string hoaDonBanDVO_DienThoaiKhachHang, string hoaDonBanDVO_TenKhachHang, Guid hoaDonBanDVO_MaGiamGia, long hoaDonBanDVO_TongTien)
		{
			this.HoaDonBanDVO_DienThoaiKhachHang = hoaDonBanDVO_DienThoaiKhachHang;
			this.HoaDonBanDVO_TenKhachHang = hoaDonBanDVO_TenKhachHang;
			this.HoaDonBanDVO_MaGiamGia = hoaDonBanDVO_MaGiamGia;
			this.HoaDonBanDVO_TongTien = hoaDonBanDVO_TongTien;
		}
	}
}
