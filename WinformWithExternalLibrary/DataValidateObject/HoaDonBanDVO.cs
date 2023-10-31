using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataValidateObject
{
	public class HoaDonBanDVO
	{
		//		TenNhanVien + NgaySinh
		//		TODO: Custom Validation: Exists
		[Required(
			ErrorMessage = "Hãy chọn nhân viên đang tạo hóa đơn"
			)]
		[DisplayName("Nhân viên")]
		public string HoaDonBanDVO_NhanVien { get; set; }



		//		TODO: Custom Validation: Exists
		[Required(
			ErrorMessage = "Hãy nhập mã sản phẩm"
			)]
		[DisplayName("Mã sản phẩm")]
		public string HoaDonBanDVO_MaSanPham { get; set; }



		[DisplayName("Tên sản phẩm")]
		public string HoaDonBanDVO_TenSanPham { get; set; }



		[Required(
			ErrorMessage = "Hãy nhập số lượng"
			)]
		[Range(
			minimum: 1,
			maximum: int.MaxValue,
			ErrorMessage = "Số lượng phải lớn hơn 0")]
		[DisplayName("Số lượng")]
		public int HoaDonBanDVO_SoLuong { get; set; }



		//		TODO: Custom Validation: Exists or Blank
		[DisplayName("Điện thoại khách hàng")]
		public string HoaDonBanDVO_DienThoaiKhachHang { get; set; }



		[DisplayName("Tên khách hàng")]
		public string HoaDonBanDVO_TenKhachHang { get; set; }



		//		TODO: MaGiamGia
		[DisplayName("Giảm giá")]
		public string HoaDonBanDVO_GiamGia { get; set; }



		[Required(
			ErrorMessage = "Hãy nhập tổng tiền"
			)]
		[DisplayName("Tổng tiền")]
		public long HoaDonBanDVO_TongTien { get; set; }

		public HoaDonBanDVO() { }

		public HoaDonBanDVO(string hoaDonBanDVO_NhanVien, string hoaDonBanDVO_MaSanPham, string hoaDonBanDVO_TenSanPham, int hoaDonBanDVO_SoLuong, string hoaDonBanDVO_DienThoaiKhachHang, string hoaDonBanDVO_TenKhachHang, string hoaDonBanDVO_GiamGia, long hoaDonBanDVO_TongTien)
		{
			this.HoaDonBanDVO_NhanVien = hoaDonBanDVO_NhanVien;
			this.HoaDonBanDVO_MaSanPham = hoaDonBanDVO_MaSanPham;
			this.HoaDonBanDVO_TenSanPham = hoaDonBanDVO_TenSanPham;
			this.HoaDonBanDVO_SoLuong = hoaDonBanDVO_SoLuong;
			this.HoaDonBanDVO_DienThoaiKhachHang = hoaDonBanDVO_DienThoaiKhachHang;
			this.HoaDonBanDVO_TenKhachHang = hoaDonBanDVO_TenKhachHang;
			this.HoaDonBanDVO_GiamGia = hoaDonBanDVO_GiamGia;
			this.HoaDonBanDVO_TongTien = hoaDonBanDVO_TongTien;
		}
	}
}
