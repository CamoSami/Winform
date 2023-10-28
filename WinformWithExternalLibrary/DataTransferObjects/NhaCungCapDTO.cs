using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataTransferObjects
{
    public class NhaCungCapDTO
    {
		public Guid NhaCungCapDTO_MaNhaCungCap { get; set; }



		[Required(
            ErrorMessage = "Vui lòng nhập tên nhà cung cấp"
			)]
        [StringLength(
            maximumLength: 30,
            MinimumLength = 2,
            ErrorMessage = "Tên sản phẩm phải có độ dài từ 2 đến 30 ký tự"
			)]
        [DisplayName(
            "Tên nhà cung cấp"
            )]
        public string NhaCungCapDTO_TenNhaCungCap { get; set; }



        [Required(
            ErrorMessage = "Vui lòng nhập số điện thoại"
			)]
        [StringLength(
            maximumLength: 10,
            MinimumLength = 10,
            ErrorMessage = "Số điện thoại phải có độ dài 10 chữ số"
            )]
        [DisplayName(
            "Số điện thoại"
            )]
        public string NhaCungCapDTO_DienThoai { get; set; }


        [Required(
            ErrorMessage = "Vui lòng nhập địa chỉ"
			)]
        [StringLength(
            maximumLength: 150,
            MinimumLength = 4,
            ErrorMessage = "Địa chỉ phải có độ dài từ 4 đến 150 ký tự"
			)]
        [DisplayName(
            "Địa chỉ"
            )]
        public string NhaCungCapDTO_DiaChi { get; set; }

		public NhaCungCapDTO() { }

		public NhaCungCapDTO(string nhaCungCapDTO_TenNhaCungCap, string nhaCungCapDTO_DienThoai, string nhaCungCapDTO_DiaChi)
		{
			this.NhaCungCapDTO_TenNhaCungCap = nhaCungCapDTO_TenNhaCungCap;
			this.NhaCungCapDTO_DienThoai = nhaCungCapDTO_DienThoai;
			this.NhaCungCapDTO_DiaChi = nhaCungCapDTO_DiaChi;
		}
	}
}
