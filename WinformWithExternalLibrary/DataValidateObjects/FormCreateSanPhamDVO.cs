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
			maximumLength:  50, 
			MinimumLength =  3, 
			ErrorMessage = "Tên sản phẩm phải có độ dài từ 3 đến 50 ký tự"
			)]
        [DisplayName ("Tên sản phẩm")]
		public string FormCreateSanPhamDVO_TenSanPham { get; set; }



        [Required(
            ErrorMessage = "Vui lòng nhập đơn giá bán"
        )]
        [DivisibleBy100(
			ErrorMessage = "Đơn giá phải chia hết cho 100"
			)]
		[Range(
			minimum: 1,
			maximum: int.MaxValue,
			ErrorMessage = "Đon giá bán phải lớn hơn 0"
			)]
		[DisplayName("Đơn giá bán")]
		public int FormCreateSanPhamDVO_DonGiaBan { get; set; }
        


        [Required(
            ErrorMessage = "Vui lòng nhập đơn giá nhập"
        )]
        [DivisibleBy100(
			ErrorMessage = "Đơn giá phải chia hết cho 100"
			)]
		[Range(
			minimum: 1,
			maximum: int.MaxValue,
			ErrorMessage = "Đon giá nhập phải lớn hơn 0"
			)]
		[DisplayName("Đơn giá nhập")]
		public int FormCreateSanPhamDVO_DonGiaNhap { get; set; }



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



        public FormCreateSanPhamDVO(){}
        
		public FormCreateSanPhamDVO(string dMSanPhamDTO_MaSanPham, string dMSanPhamDTO_TenSanPham, int dMSanPhamDTO_GiaBan, int dMSanPhamDTO_GiaNhap, DateTime dMSanPhamDTO_TgBaoHanh)
        {
            this.FormCreateSanPhamDVO_MaSanPham = dMSanPhamDTO_MaSanPham;
            this.FormCreateSanPhamDVO_TenSanPham = dMSanPhamDTO_TenSanPham;
            this.FormCreateSanPhamDVO_DonGiaBan = dMSanPhamDTO_GiaBan;
            this.FormCreateSanPhamDVO_DonGiaNhap = dMSanPhamDTO_GiaNhap;
            this.FormCreateSanPhamDVO_ThoiGianBaoHanh = dMSanPhamDTO_TgBaoHanh;
        }
    }
}
