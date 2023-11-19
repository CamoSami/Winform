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
	public class NhanVienThuNganHDNhapDVO
	{
		//		TenNhanVien + NgaySinh
		[Required(
			ErrorMessage = "Hãy chọn nhân viên đang tạo hóa đơn"
			)]
		[NhanVienThuNganDVO_ExistedNhanVien(
			ErrorMessage = "Nhân viên không tồn tại"
			)]
		[DisplayName("Nhân viên")]
		public string NhanVienThuNganHDNhapDVO_NhanVien { get; set; }

		public NhanVienThuNganHDNhapDVO() { }

		public NhanVienThuNganHDNhapDVO(string nhanVienThuNganHDNhapDVO_NhanVien)
		{
			this.NhanVienThuNganHDNhapDVO_NhanVien = nhanVienThuNganHDNhapDVO_NhanVien;
		}
	}
}
