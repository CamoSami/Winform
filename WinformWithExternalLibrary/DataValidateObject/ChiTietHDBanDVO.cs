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
	public class ChiTietHDBanDVO
	{
		[Required(
			ErrorMessage = "Hãy nhập mã sản phẩm"
			)]
		[ChiTietHDBanDVO_ExistedMaSanPham(
			ErrorMessage = "Mã sản phẩm không tồn tại"
			)]
		[DisplayName("Mã sản phẩm")]
		public string ChiTietHDBanDVO_MaSanPham { get; set; }



		[Required(
			ErrorMessage = "Hãy nhập tên sản phẩm"
			)]
		[DisplayName("Tên sản phẩm")]
		public string ChiTietHDBanDVO_TenSanPham { get; set; }



		[Required(
			ErrorMessage = "Hãy nhập số lượng"
			)]
		[Range(
			minimum: 1,
			maximum: int.MaxValue,
			ErrorMessage = "Số lượng phải lớn hơn 0")]
		[DisplayName("Số lượng")]
		public int ChiTietHDBanDVO_SoLuong { get; set; }

		public ChiTietHDBanDVO() { }

		public ChiTietHDBanDVO(string chiTietHDBanDVO_MaSanPham, string chiTietHDBanDVO_TenSanPham, int chiTietHDBanDVO_SoLuong)
		{
			this.ChiTietHDBanDVO_MaSanPham = chiTietHDBanDVO_MaSanPham;
			this.ChiTietHDBanDVO_TenSanPham = chiTietHDBanDVO_TenSanPham;
			this.ChiTietHDBanDVO_SoLuong = chiTietHDBanDVO_SoLuong;
		}
	}
}
