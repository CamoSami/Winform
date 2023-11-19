using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataValidateObjects.CustomValidation;

namespace WinformWithExternalLibrary.DataValidateObjects
{
	public class NhanVienThuNganHDBanDVO
	{
		//		TenNhanVien + NgaySinh
		[Required(
			ErrorMessage = "Hãy chọn nhân viên đang tạo hóa đơn"
			)]
		[NhanVienThuNganDVO_ExistedNhanVien(
			ErrorMessage = "Nhân viên không tồn tại"
			)]
		[DisplayName("Nhân viên")]
		public string NhanVienThuNganHDBanDVO_NhanVien { get; set; }

		public NhanVienThuNganHDBanDVO() { }

		public NhanVienThuNganHDBanDVO(string nhanVienThuNganHDBanDVO_NhanVien)
		{
			this.NhanVienThuNganHDBanDVO_NhanVien = nhanVienThuNganHDBanDVO_NhanVien;
		}
	}
}
