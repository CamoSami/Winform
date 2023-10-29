using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataTransferObjects
{
    
    public class DMSanPhamDTO
    {
		public Guid DMSanPhamDTO_MaDMSanPham { get; set; }

        public string DMSanPhamDTO_MaSanPham { get; set; }

		public string DMSanPhamDTO_TenSanPham { get; set; }

		public int DMSanPhamDTO_DonGiaBan { get; set; }
        
		public int DMSanPhamDTO_DonGiaNhap { get; set; }

		public int DMSanPhamDTO_SoLuongTonKho { get; set; } 

		public DateTime DMSanPhamDTO_ThoiGianBaoHanh { get; set; }

        public DMSanPhamDTO(){}
        
		public DMSanPhamDTO(string dMSanPhamDTO_MaSanPham, string dMSanPhamDTO_TenSanPham, int dMSanPhamDTO_GiaBan, int dMSanPhamDTO_GiaNhap, DateTime dMSanPhamDTO_TgBaoHanh)
        {
            this.DMSanPhamDTO_MaSanPham = dMSanPhamDTO_MaSanPham;
            this.DMSanPhamDTO_TenSanPham = dMSanPhamDTO_TenSanPham;
            this.DMSanPhamDTO_DonGiaBan = dMSanPhamDTO_GiaBan;
            this.DMSanPhamDTO_DonGiaNhap = dMSanPhamDTO_GiaNhap;
            this.DMSanPhamDTO_ThoiGianBaoHanh = dMSanPhamDTO_TgBaoHanh;
        }
    }
}
