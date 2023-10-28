using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects.CustomValidation;

namespace WinformWithExternalLibrary.DataTransferObjects
{
	public class HoaDonNhapDTO
	{
		//		TODO: custom Attribute that uses DAO to detect if the Guid/PhoneNumber entered can be found in the DTB

		public Guid HoaDonNhapDTO_MaHDNhap { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập mã nhà cung cấp")]
		[DisplayName("Mã nhà cung cấp")]
		public Guid HoaDonNhapDTO_MaNhaCungCap { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập mã nhân viên")]
		[DisplayName("Mã nhân viên")]
		public Guid HoaDonNhapDTO_MaNhanVien { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập ngày nhập")]
		[DisplayName("Ngày nhập")]
		public DateTime HoaDonNhapDTO_NgayNhap { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập số sản phẩm")]
		[Range(
			minimum: 1, 
			maximum: int.MaxValue, 
			ErrorMessage = "Số sản phẩm phải lớn hơn 0")]
		[DisplayName("Giảm giá")]
		public int HoaDonNhapDTO_SoSanPham { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập giảm giá")]
		[DivisibleBy100(ErrorMessage = "Giảm giá phải chia hết cho 100")]
		[DisplayName("Giảm giá")]
		public int HoaDonNhapDTO_GiamGia { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập tổng tiền")]
		[DivisibleBy100(ErrorMessage = "Tổng tiền phải chia hết cho 100")]
		[DisplayName("Tổng tiền")]
		public int HoaDonNhapDTO_TongTien { get; set; }

		public HoaDonNhapDTO() { }

		public HoaDonNhapDTO(Guid hoaDonNhapDTO_MaNhaCungCap, Guid hoaDonNhapDTO_MaNhanVien, DateTime hoaDonNhapDTO_NgayNhap, int hoaDonNhapDTO_SoSanPham, int hoaDonNhapDTO_GiamGia, int hoaDonNhapDTO_TongTien)
		{
			this.HoaDonNhapDTO_MaNhaCungCap = hoaDonNhapDTO_MaNhaCungCap;
			this.HoaDonNhapDTO_MaNhanVien = hoaDonNhapDTO_MaNhanVien;
			this.HoaDonNhapDTO_NgayNhap = hoaDonNhapDTO_NgayNhap;
			this.HoaDonNhapDTO_SoSanPham = hoaDonNhapDTO_SoSanPham;
			this.HoaDonNhapDTO_GiamGia = hoaDonNhapDTO_GiamGia;
			this.HoaDonNhapDTO_TongTien = hoaDonNhapDTO_TongTien;
		}
	}
}
