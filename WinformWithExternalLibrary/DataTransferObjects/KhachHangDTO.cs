using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects.CustomValidation;

namespace WinformWithExternalLibrary.DataTransferObjects
{
	public class KhachHangDTO
	{
		public Guid KhachHangDTO_MaKhachHang { get; set; }



		[Required(
			ErrorMessage = "Vui lòng nhập họ tên"
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
		public string KhachHangDTO_DiaChi { get; set; }



		[Required(
			ErrorMessage = "Vui lòng nhập số điện thoại"
			)]
		[StringLength(
			maximumLength: 10,
			MinimumLength = 10,
			ErrorMessage = "Số điện thoại chỉ 10 kí tự"
			)]
		[KhachHangDTO_UniqueDienThoai(
			ErrorMessage = "Số điện thoại vừa nhập đã tồn tại"
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
