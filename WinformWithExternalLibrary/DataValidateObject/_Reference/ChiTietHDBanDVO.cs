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
	public class ChiTietHDBanDVO
	{
		[Required(ErrorMessage = "Vui lòng nhập mã hóa đơn bán")]
		[DisplayName("Mã hóa đơn bán")]
		public Guid ChiTietHDBanDTO_MaHDBan { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập mã danh mục sản phẩm")]
		[DisplayName("Mã danh mục sản phẩm")]
		public Guid ChiTietHDBanDTO_MaDMSanPham { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập số lượng")]
		[Range(
			minimum: 1,
			maximum: int.MaxValue,
			ErrorMessage = "Số lượng phải lớn hơn 0")]
		[DisplayName("Số lượng")]
		public int ChiTietHDBanDTO_SoLuong { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập thành tiền")]
		[DivisibleBy100(ErrorMessage = "Thành tiền phải chia hết cho 100")]
		[DisplayName("Thành tiền")]
		public int ChiTietHDBanDTO_ThanhTien { get; set; }

		public ChiTietHDBanDVO() { }

		public ChiTietHDBanDVO(Guid chiTietHDBanDTO_MaHDBan, Guid chiTietHDBanDTO_MaDMSanPham, int chiTietHDBanDTO_SoLuong, int chiTietHDBanDTO_ThanhTien)
		{
			this.ChiTietHDBanDTO_MaHDBan = chiTietHDBanDTO_MaHDBan;
			this.ChiTietHDBanDTO_MaDMSanPham = chiTietHDBanDTO_MaDMSanPham;
			this.ChiTietHDBanDTO_SoLuong = chiTietHDBanDTO_SoLuong;
			this.ChiTietHDBanDTO_ThanhTien = chiTietHDBanDTO_ThanhTien;
		}
	}
}
