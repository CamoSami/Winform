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
	public class HoaDonNhapDVO
	{
		[HoaDonNhapDVO_ExistedDienThoaiNhaCungCap(
			ErrorMessage = "Điện thoại nhà cung cấp không tồn tại"
			)]
		[Required(
			ErrorMessage = "Xin vui lòng nhập điện thoại nhà cung cấp"
			)]
		[DisplayName("Điện thoại nhà cung cấp")]
		public string HoaDonNhapDVO_DienThoaiNhaCungCap { get; set; }



		[DisplayName("Tên nhà cung cấp")]
		public string HoaDonNhapDVO_TenNhaCungCap { get; set; }



		[DisplayName("Tổng tiền")]
		public long HoaDonNhapDVO_TongTien { get; set; }

		public HoaDonNhapDVO() { }

		public HoaDonNhapDVO(string hoaDonNhapDVO_DienThoaiNhaCungCap, string hoaDonNhapDVO_TenNhaCungCap, long hoaDonNhapDVO_TongTien)
		{
			this.HoaDonNhapDVO_DienThoaiNhaCungCap = hoaDonNhapDVO_DienThoaiNhaCungCap;
			this.HoaDonNhapDVO_TenNhaCungCap = hoaDonNhapDVO_TenNhaCungCap;
			this.HoaDonNhapDVO_TongTien = hoaDonNhapDVO_TongTien;
		}
	}
}
