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
	public class KhachHangDVO
	{
		[Required(
			ErrorMessage = "Vui lòng nhập họ tên"
			)]
		[StringLength(
			maximumLength: 40,
			MinimumLength = 4,
			ErrorMessage = "Nhập họ tên chỉ từ 4-40 kí tự"
			)]
		[DisplayName(
			"Họ tên"
			)]
		public string KhachHangDVO_TenKhachHang { get; set; }



		[Required(
			ErrorMessage = "Vui lòng nhập địa chỉ"
			)]
		[StringLength(
			maximumLength: 150,
			MinimumLength = 4,
			ErrorMessage = "Địa chỉ phải có từ 4-150 kí tự"
			)]
		[DisplayName(
			"Địa chỉ"
			)]
		public string KhachHangDVO_DiaChi { get; set; }



		[Required(
			ErrorMessage = "Vui lòng nhập số điện thoại"
			)]
		[StringLength(
			maximumLength: 10,
			MinimumLength = 10,
			ErrorMessage = "Số điện thoại chỉ 10 kí tự"
			)]
		[KhachHangDVO_UniqueDienThoai(
			ErrorMessage = "Số điện thoại vừa nhập đã tồn tại"
			)]
		[DisplayName(
			"Số điện thoại"
			)]
		public string KhachHangDVO_DienThoai { get; set; }

		public KhachHangDVO(string khachHangDVO_TenKhachHang, string khachHangDVO_DiaChi, string khachHangDVO_DienThoai)
		{
			this.KhachHangDVO_TenKhachHang = khachHangDVO_TenKhachHang;
			this.KhachHangDVO_DiaChi = khachHangDVO_DiaChi;
			this.KhachHangDVO_DienThoai = khachHangDVO_DienThoai;
		}

		public KhachHangDVO() { }
	}
}
