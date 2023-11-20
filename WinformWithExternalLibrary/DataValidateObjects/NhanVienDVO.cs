using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataValidateObjects.CustomValidation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using System.Net.Mail;


namespace WinformWithExternalLibrary.DataValidateObjects
{
	internal class NhanVienDVO
	{
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
		[DisplayName("Email")]
		public string NhanVienDVO_Email { get; set; }

		public NhanVienDVO(string nhanVienDVO_TenNhanVien, DateTime nhanVienDVO_NgaySinh, string nhanVienDVO_GioiTinh, string nhanVienDVO_SoDienThoai, string nhanVienDVO_DiaChi, string nhanVienDVO_MaCongViec, string nhanVienDVO_Email)
		{
			this.NhanVienDVO_TenNhanVien = nhanVienDVO_TenNhanVien;
			this.NhanVienDVO_NgaySinh = nhanVienDVO_NgaySinh;
			this.NhanVienDVO_GioiTinh = nhanVienDVO_GioiTinh;
			this.NhanVienDVO_SoDienThoai = nhanVienDVO_SoDienThoai;
			this.NhanVienDVO_DiaChi = nhanVienDVO_DiaChi;
			this.NhanVienDVO_TenCongViec = nhanVienDVO_MaCongViec;
			this.NhanVienDVO_Email = nhanVienDVO_Email;
		}

		public NhanVienDVO() {}
	}
}
