using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects.CustomValidation;

namespace WinformWithExternalLibrary.DataTransferObjects
{
	public class ChiTietHDNhapDTO
	{
		[Required(ErrorMessage = "Vui lòng nhập mã hóa đơn nhập")]
		[DisplayName("Mã hóa đơn nhập")]
		public Guid ChiTietHDNhapDTO_MaHDNhap { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập mã danh mục sản phẩm")]
		[DisplayName("Mã danh mục sản phẩm")]
		public Guid ChiTietHDNhapDTO_MaDMSanPham { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập số lượng")]
		[Range(
			minimum: 1,
			maximum: int.MaxValue,
			ErrorMessage = "Số lượng phải lớn hơn 0")]
		[DisplayName("Số lượng")]
		public int ChiTietHDNhapDTO_SoLuong { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập thành tiền")]
		[DivisibleBy100(ErrorMessage = "Thành tiền phải chia hết cho 100")]
		[DisplayName("Thành tiền")]
		public int ChiTietHDNhapDTO_ThanhTien { get; set; }

		public ChiTietHDNhapDTO() { }

		public ChiTietHDNhapDTO(Guid chiTietHDNhapDTO_MaHDNhap, Guid chiTietHDNhapDTO_MaDMSanPham, int chiTietHDNhapDTO_SoLuong, int chiTietHDNhapDTO_ThanhTien)
		{
			this.ChiTietHDNhapDTO_MaHDNhap = chiTietHDNhapDTO_MaHDNhap;
			this.ChiTietHDNhapDTO_MaDMSanPham = chiTietHDNhapDTO_MaDMSanPham;
			this.ChiTietHDNhapDTO_SoLuong = chiTietHDNhapDTO_SoLuong;
			this.ChiTietHDNhapDTO_ThanhTien = chiTietHDNhapDTO_ThanhTien;
		}
	}
}
