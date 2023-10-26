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
        [Required(
            ErrorMessage = "Chưa có tên nhà cung cấp, kiểm tra lại nhé!!"
            )]
        [StringLength(
            maximumLength: 30,
            MinimumLength = 2,
            ErrorMessage = "Ơ, nhà cung cấp chỉ có 2-30 kí tự mà -_-"
            )]
        [DisplayName(
            "Họ tên"
            )]
        public string NhaCungCapDTO_TenNhaCungCap { get; set; }



        [Required(
            ErrorMessage = "Bạn ơi, bạn bị thiếu số điện thoại rồi ạ!"
            )]
        [StringLength(
            maximumLength: 10,
            MinimumLength = 10,
            ErrorMessage = "Số điện thoại phải có 10 chữ số nhé bạn!!"
            )]
        [DisplayName(
            "Số điện thoại nhà cung cấp"
            )]
        public string NhaCungCapDTO_DienThoai { get; set; }


        [Required(
            ErrorMessage = "Cốc cốc, bạn gì ơi, hình như bạn chưa nhập địa chỉ :))"
            )]
        [StringLength(
            maximumLength: 100,
            MinimumLength = 4,
            ErrorMessage = "Hãy nhớ rằng địa chỉ phải được nhập từ 4-100 kí tự nhá :(("
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
