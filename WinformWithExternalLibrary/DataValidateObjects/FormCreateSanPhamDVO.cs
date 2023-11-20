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

	public class FormCreateSanPhamDVO
	{
		[Required(
			ErrorMessage = "Vui lòng nhập mã của sản phẩm"
		)]
		[DisplayName("Mã sản phẩm")]
		public string FormCreateSanPhamDVO_MaSanPham { get; set; }

		[Required(
			ErrorMessage = "Vui lòng nhập tên sản phẩm"
		)]
		[StringLength(
			maximumLength: 200,
			MinimumLength = 3,
			ErrorMessage = "Tên sản phẩm phải có độ dài từ 3 đến 200 ký tự"
			)]
		[DisplayName("Tên sản phẩm")]
		public string FormCreateSanPhamDVO_TenSanPham { get; set; }



		[Required(
			ErrorMessage = "Vui lòng nhập đơn giá bán"
		)]
		[DivisibleBy100(
			ErrorMessage = "Đơn giá bán phải chia hết cho 100"
			)]
		[Range(
			minimum: 1,
			maximum: int.MaxValue,
			ErrorMessage = "Đơn giá bán phải lớn hơn 0"
			)]
		[DisplayName("Đơn giá bán")]
		public long FormCreateSanPhamDVO_DonGiaBan { get; set; }


		[Required(
			ErrorMessage = "Vui lòng nhập đơn giá nhập"
		)]
		[DivisibleBy100DGN(
			ErrorMessage = "Đơn giá nhập phải chia hết cho 100"
			)]
		[Range(
			minimum: 1,
			maximum: int.MaxValue,
			ErrorMessage = "Đon giá nhập phải lớn hơn 0"
			)]
		[DisplayName("Đơn giá nhập")]
		public long FormCreateSanPhamDVO_DonGiaNhap { get; set; }



		[Required(
			ErrorMessage = "Vui lòng nhập số lượng tồn kho"
			)]
		[Range(
			minimum: 1,
			maximum: int.MaxValue,
			ErrorMessage = "Số lượng tồn kho phải lớn hơn 0"
			)]
		[DisplayName("Số lượng tồn kho")]
		public int FormCreateSanPhamDVO_SoLuongTonKho { get; set; }



		[Required(
			ErrorMessage = "Vui lòng nhập thời gian bảo hành"
		)]
		[DisplayName("Thời gian bảo hành")]
		public DateTime FormCreateSanPhamDVO_ThoiGianBaoHanh { get; set; }

		public FormCreateSanPhamDVO() { }

		public FormCreateSanPhamDVO(string dMSanPhamDTO_MaSanPham, string dMSanPhamDTO_TenSanPham, int dMSanPhamDTO_DonGiaBan, int dMSanPhamDTO_DonGiaNhap, DateTime dMSanPhamDTO_ThoiGianBaoHanh)
		{
			this.FormCreateSanPhamDVO_MaSanPham = dMSanPhamDTO_MaSanPham;
			this.FormCreateSanPhamDVO_TenSanPham = dMSanPhamDTO_TenSanPham;
			this.FormCreateSanPhamDVO_DonGiaBan = dMSanPhamDTO_DonGiaBan;
			this.FormCreateSanPhamDVO_DonGiaNhap = dMSanPhamDTO_DonGiaNhap;
			this.FormCreateSanPhamDVO_ThoiGianBaoHanh = dMSanPhamDTO_ThoiGianBaoHanh;
		}
	}
}
