using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataValidateObject.CustomValidation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using System.Net.Mail;


namespace WinformWithExternalLibrary.DataValidateObject
{
	internal class NhanVienDVO
	{
		[Required(ErrorMessage = "Hãy chọn nhân viên muốn sửa thông tin")]
		[DisplayName("Tên / Mã Nhân viên")]
		public string NhanVienDVO_SelectNhanVien { get; set; }

		[Required(ErrorMessage = "Vui lòng nhập tên nhân viên.")]
		[StringLength(40, MinimumLength = 4, ErrorMessage = "Tên nhân viên phải từ 4 đến 40 ký tự.")]
		[DisplayName("Tên nhân viên")]
		public string NhanVienDVO_TenNhanVien { get; set; }

		[Required(ErrorMessage = "Vui lòng nhập ngày sinh.")]
		[DataType(DataType.Date, ErrorMessage = "Ngày sinh không hợp lệ.")]
		[DisplayName("Ngày sinh")]
		public DateTime NhanVienDVO_NgaySinh { get; set; }

		[Required(ErrorMessage = "Vui lòng chọn giới tính.")]
		[DisplayName("Giới tính")]
		public string NhanVienDVO_GioiTinh { get; set; }

		[Required(ErrorMessage = "Vui lòng nhập số điện thoại.")]
		[StringLength(10, MinimumLength = 10, ErrorMessage = "Số điện thoại phải có 10 ký tự.")]
		[DisplayName("Số điện thoại")]
		public string NhanVienDVO_SoDienThoai { get; set; }

		[Required(ErrorMessage = "Vui lòng nhập địa chỉ.")]
		[StringLength(150, MinimumLength = 4, ErrorMessage = "Địa chỉ phải từ 4 đến 150 ký tự.")]
		[DisplayName("Địa chỉ")]
		public string NhanVienDVO_DiaChi { get; set; }

		[Required(ErrorMessage = "Vui lòng nhập tên công việc.")]
		[DisplayName("Tên công việc")]
		public string NhanVienDVO_TenCongViec { get; set; }

		[Required(ErrorMessage = "Vui lòng nhập địa chỉ email.")]
		[EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ.")]
		[RegularExpression(
			@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
			ErrorMessage = ""
			)]
		[DisplayName("Email")]
		public string NhanVienDVO_Email { get; set; }

		//public bool IsEmailValid()
		//{
		//	if (NhanVienDVO_Email == null)
		//		return false;

		//	string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
		//	return Regex.IsMatch(NhanVienDVO_Email, emailPattern);
		//}

		public NhanVienDVO(string nhaVienDVO_SelectNhanVien, string nhanVienDVO_TenNhanVien, DateTime nhanVienDVO_NgaySinh, string nhanVienDVO_GioiTinh, string nhanVienDVO_SoDienThoai, string nhanVienDVO_DiaChi, string nhanVienDVO_MaCongViec, string nhanVienDVO_Email)
		{
			NhanVienDVO_SelectNhanVien = nhaVienDVO_SelectNhanVien;
			NhanVienDVO_TenNhanVien = nhanVienDVO_TenNhanVien;
			NhanVienDVO_NgaySinh = nhanVienDVO_NgaySinh;
			NhanVienDVO_GioiTinh = nhanVienDVO_GioiTinh;
			NhanVienDVO_SoDienThoai = nhanVienDVO_SoDienThoai;
			NhanVienDVO_DiaChi = nhanVienDVO_DiaChi;
			NhanVienDVO_TenCongViec = nhanVienDVO_MaCongViec;
			NhanVienDVO_Email = nhanVienDVO_Email;
		}

		public NhanVienDVO() {}
	}
}
