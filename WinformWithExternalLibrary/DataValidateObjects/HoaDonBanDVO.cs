using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataValidateObjects.CustomValidation;

namespace WinformWithExternalLibrary.DataValidateObjects
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



		[HoaDonBanDVO_EligibleTenGiamGia(
			ErrorMessage = "Tên giảm giá không áp dụng được"
			)]
		[HoaDonBanDVO_ExistedTenGiamGia(
			ErrorMessage = "Tên giảm giá không tồn tại"
			)]
		[DisplayName("Tên giảm giá")]
		public string HoaDonBanDVO_TenGiamGia { get; set; }



		[DisplayName("Tổng tiền")]
		public long HoaDonBanDVO_TongTien { get; set; }



		[DisplayName("Thanh toán")]
		public long HoaDonBanDVO_ThanhToan { get; set; }

		public HoaDonBanDVO() { }

		public HoaDonBanDVO(string hoaDonBanDVO_DienThoaiKhachHang, string hoaDonBanDVO_TenKhachHang, string hoaDonBanDVO_TenGiamGia, long hoaDonBanDVO_TongTien, long hoaDonBanDVO_ThanhToan)
		{
			this.HoaDonBanDVO_DienThoaiKhachHang = hoaDonBanDVO_DienThoaiKhachHang;
			this.HoaDonBanDVO_TenKhachHang = hoaDonBanDVO_TenKhachHang;
			this.HoaDonBanDVO_TenGiamGia = hoaDonBanDVO_TenGiamGia;
			this.HoaDonBanDVO_TongTien = hoaDonBanDVO_TongTien;
			this.HoaDonBanDVO_ThanhToan = hoaDonBanDVO_ThanhToan;
		}
	}
}
