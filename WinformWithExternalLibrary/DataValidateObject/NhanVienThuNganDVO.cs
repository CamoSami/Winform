using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataValidateObject.CustomValidation;

namespace WinformWithExternalLibrary.DataValidateObject
{
	public class NhanVienThuNganDVO
	{
		//		TenNhanVien + NgaySinh
		[Required(
			ErrorMessage = "Hãy chọn nhân viên đang tạo hóa đơn"
			)]
		[NhanVienThuNganDVO_ExistedNhanVien(
			ErrorMessage = "Nhân viên không tồn tại"
			)]
		[DisplayName("Nhân viên")]
		public string NhanVienThuNganDVO_NhanVien { get; set; }

		public NhanVienThuNganDVO() { }

		public NhanVienThuNganDVO(string nhanVienThuNganDVO_NhanVien)
		{
			this.NhanVienThuNganDVO_NhanVien = nhanVienThuNganDVO_NhanVien;
		}
	}
}
