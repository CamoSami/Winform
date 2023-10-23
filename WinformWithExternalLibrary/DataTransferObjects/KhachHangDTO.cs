using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataTransferObjects
{
	public class KhachHangDTO
	{
		[Required(
			ErrorMessage = "Thiếu họ tên kìa!"
			)]
		[StringLength(
			maximumLength: 40,
			MinimumLength = 4,
			ErrorMessage = "Nhập họ tên chỉ từ 4-40 kí tự nhá ._."
			)]
		[DisplayName(
			"Họ tên"
			)]
		public string KhachHangDTO_TenKhachHang { get; set; }

		[Required(
			ErrorMessage = "Thiếu địa chỉ kìa!"
			)]
		[StringLength(
			maximumLength: 100,
			MinimumLength = 4,
			ErrorMessage = "Nhập địa chỉ chỉ từ 4-100 kí tự nhá ._."
			)]
		[DisplayName(
			"Địa chỉ"
			)]
		public string KhachHangDTO_DiaChi { get; set; }

		[Required(
			ErrorMessage = "Thiếu số điện thoại kìa!"
			)]
		[StringLength(
			maximumLength: 10,
			MinimumLength = 10,
			ErrorMessage = "Nhập số điện thoại chỉ 10 kí tự nhá ._."
			)]
		[DisplayName(
			"Số điện thoại"
			)]
		public string KhachHangDTO_DienThoai { get; set; }

		public KhachHangDTO(string khachHangDTO_TenKhachHang, string khachHangDTO_DiaChi, string khachHangDTO_DienThoai)
		{
			this.KhachHangDTO_TenKhachHang = khachHangDTO_TenKhachHang;
			this.KhachHangDTO_DiaChi = khachHangDTO_DiaChi;
			this.KhachHangDTO_DienThoai = khachHangDTO_DienThoai;
		}

		public KhachHangDTO() { }
	}
}
