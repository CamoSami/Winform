using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects.CustomValidation;

namespace WinformWithExternalLibrary.DataTransferObjects
{
	public class HoaDonBanDTO
	{
		//		NOTE: NOT REQUIRED
		[DisplayName("Mã khách hàng")]
		public Guid HoaDonBanDTO_MaKhachHang { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập mã nhân viên")]
		[DisplayName("Mã nhân viên")]
		public Guid HoaDonBanDTO_MaNhanVien { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập ngày bán")]
		[DisplayName("Ngày bán")]
		public DateTime HoaDonBanDTO_NgayBan { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập số sản phẩm")]
		[Range(
			minimum: 1,
			maximum: int.MaxValue,
			ErrorMessage = "Số sản phẩm phải lớn hơn 0")]
		[DisplayName("Giảm giá")]
		public int HoaDonBanDTO_SoSanPham { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập giảm giá")]
		[DivisibleBy100(ErrorMessage = "Giảm giá phải chia hết cho 100")]
		[DisplayName("Giảm giá")]
		public int HoaDonBanDTO_GiamGia { get; set; }



		[Required(ErrorMessage = "Vui lòng nhập tổng tiền")]
		[DivisibleBy100(ErrorMessage = "Tổng tiền phải chia hết cho 100")]
		[DisplayName("Tổng tiền")]
		public int HoaDonBanDTO_TongTien { get; set; }

		public HoaDonBanDTO() { }

		public HoaDonBanDTO(Guid hoaDonBanDTO_MaKhachHang, Guid hoaDonBanDTO_MaNhanVien, DateTime hoaDonBanDTO_NgayBan, int hoaDonBanDTO_SoSanPham, int hoaDonBanDTO_GiamGia, int hoaDonBanDTO_TongTien)
		{
			this.HoaDonBanDTO_MaKhachHang = hoaDonBanDTO_MaKhachHang;
			this.HoaDonBanDTO_MaNhanVien = hoaDonBanDTO_MaNhanVien;
			this.HoaDonBanDTO_NgayBan = hoaDonBanDTO_NgayBan;
			this.HoaDonBanDTO_SoSanPham = hoaDonBanDTO_SoSanPham;
			this.HoaDonBanDTO_GiamGia = hoaDonBanDTO_GiamGia;
			this.HoaDonBanDTO_TongTien = hoaDonBanDTO_TongTien;
		}
	}
}