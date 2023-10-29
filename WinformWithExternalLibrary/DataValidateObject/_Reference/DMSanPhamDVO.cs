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
    
    public class DMSanPhamDVO
    {
		[Required(
            ErrorMessage = "Vui lòng nhập mã của sản phẩm"
        )]
        [DisplayName("Mã sản phẩm")]
        public string DMSanPhamDTO_MaSanPham { get; set; }



        [Required(
            ErrorMessage = "Vui lòng nhập tên sản phẩm"
        )]
        [StringLength(
			maximumLength:  50, 
			MinimumLength =  3, 
			ErrorMessage = "Tên sản phẩm phải có độ dài từ 3 đến 50 ký tự"
			)]
        [DisplayName ("Tên sản phẩm")]
		public string DMSanPhamDTO_TenSanPham { get; set; }



        [Required(
            ErrorMessage = "Vui lòng nhập đơn giá bán"
        )]
        [DivisibleBy100(ErrorMessage = "Đơn giá bán phải chia hết cho 100")]
        [DisplayName("Đơn giá bán")]
		public int DMSanPhamDTO_DonGiaBan { get; set; }
        


        [Required(
            ErrorMessage = "Vui lòng nhập đơn giá nhập"
        )]
        [DivisibleBy100(ErrorMessage = "Đơn giá nhập phải chia hết cho 100")]
        [DisplayName("Đơn giá nhập")]
		public int DMSanPhamDTO_DonGiaNhap { get; set; }



		[Required(
			ErrorMessage = "Vui lòng nhập số lượng tồn kho"
			)]
		[Range(
			minimum: 1,
			maximum: int.MaxValue,
			ErrorMessage = "Số lượng tồn kho pải lớn hơn 0"
			)]
		[DisplayName("Số lượng tồn kho")]
		public int DMSanPhamDTO_SoLuongTonKho { get; set; } 



        [Required(
            ErrorMessage = "Vui lòng nhập thời gian bảo hành"
        )]
        [DisplayName("Thời gian bảo hành")]
		public DateTime DMSanPhamDTO_ThoiGianBaoHanh { get; set; }



        public DMSanPhamDVO(){}
        
		public DMSanPhamDVO(string dMSanPhamDTO_MaSanPham, string dMSanPhamDTO_TenSanPham, int dMSanPhamDTO_GiaBan, int dMSanPhamDTO_GiaNhap, DateTime dMSanPhamDTO_TgBaoHanh)
        {
            this.DMSanPhamDTO_MaSanPham = dMSanPhamDTO_MaSanPham;
            this.DMSanPhamDTO_TenSanPham = dMSanPhamDTO_TenSanPham;
            this.DMSanPhamDTO_DonGiaBan = dMSanPhamDTO_GiaBan;
            this.DMSanPhamDTO_DonGiaNhap = dMSanPhamDTO_GiaNhap;
            this.DMSanPhamDTO_ThoiGianBaoHanh = dMSanPhamDTO_TgBaoHanh;
        }
    }
}
