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
	public class ChiTietHDNhapDVO
	{
		[Required(
			ErrorMessage = "Hãy nhập mã sản phẩm"
			)]
		[ChiTietHDDVO_ExistedMaSanPham(
			ErrorMessage = "Mã sản phẩm không tồn tại"
			)]
		[DisplayName("Mã sản phẩm")]
		public string ChiTietHDNhapDVO_MaSanPham { get; set; }



		[Required(
			ErrorMessage = "Hãy nhập tên sản phẩm"
			)]
		[DisplayName("Tên sản phẩm")]
		public string ChiTietHDNhapDVO_TenSanPham { get; set; }



		[Required(
			ErrorMessage = "Hãy nhập số lượng"
			)]
		[Range(
			minimum: 1,
			maximum: int.MaxValue,
			ErrorMessage = "Số lượng phải lớn hơn 0")]
		[DisplayName("Số lượng")]
		public int ChiTietHDNhapDVO_SoLuong { get; set; }

		public ChiTietHDNhapDVO() { }

		public ChiTietHDNhapDVO(string chiTietHDNhapDVO_MaSanPham, string chiTietHDNhapDVO_TenSanPham, int chiTietHDNhapDVO_SoLuong)
		{
			this.ChiTietHDNhapDVO_MaSanPham = chiTietHDNhapDVO_MaSanPham;
			this.ChiTietHDNhapDVO_TenSanPham = chiTietHDNhapDVO_TenSanPham;
			this.ChiTietHDNhapDVO_SoLuong = chiTietHDNhapDVO_SoLuong;
		}
	}
}
