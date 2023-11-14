using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataValidateObjects.CustomValidation;


namespace WinformWithExternalLibrary.DataValidateObject
{
    public class DMSanPhamDVO
    {
		[Required(
			ErrorMessage = "Hãy nhập mã sản phẩm"
			)]
        [DisplayName("Mã sản phẩm")]
        public string DMSanPhamDVO_MaSanPham { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string DMSanPhamDVO_TenSanPham { get; set; }

        [DisplayName("Min")]
        public int DMSanPhamDVO_DonGiaBanMin { get; set; }

        [DisplayName("Max")]
        public int DMSanPhamDVO_DonGiaBanMax { get; set; }

        [DisplayName("Min")]
        public int DMSanPhamDVO_DonGiaNhapMin { get; set; }

        [DisplayName("Max")]
        public int DMSanPhamDVO_DonGiaNhapMax { get; set; }

        [DisplayName("Min")]
        public int DMSanPhamDVO_SoLuongTonKhoMin { get; set; }

        [DisplayName("Max")]
        public int DMSanPhamDVO_SoLuongTonKhoMax { get; set; }

        [DisplayName("Min")]
        public DateTime DMSanPhamDVO_ThoiGianBaoHanhMin { get; set; }

        [DisplayName("Max")]
        public DateTime DMSanPhamDVO_ThoiGianBaoHanhMax { get; set; }

		public DMSanPhamDVO() { }

		public DMSanPhamDVO(string dMSanPhamDVO_MaSanPham, string dMSanPhamDVO_TenSanPham, int dMSanPhamDVO_DonGiaBanMin, int dMSanPhamDVO_DonGiaBanMax, int dMSanPhamDVO_DonGiaNhapMin, int dMSanPhamDVO_DonGiaNhapMax, int dMSanPhamDVO_SoLuongTonKhoMin, int dMSanPhamDVO_SoLuongTonKhoMax, DateTime dMSanPhamDVO_ThoiGianBaoHanhMin, DateTime dMSanPhamDVO_ThoiGianBaoHanhMax)
		{
			this.DMSanPhamDVO_MaSanPham = dMSanPhamDVO_MaSanPham;
			this.DMSanPhamDVO_TenSanPham = dMSanPhamDVO_TenSanPham;
			this.DMSanPhamDVO_DonGiaBanMin = dMSanPhamDVO_DonGiaBanMin;
			this.DMSanPhamDVO_DonGiaBanMax = dMSanPhamDVO_DonGiaBanMax;
			this.DMSanPhamDVO_DonGiaNhapMin = dMSanPhamDVO_DonGiaNhapMin;
			this.DMSanPhamDVO_DonGiaNhapMax = dMSanPhamDVO_DonGiaNhapMax;
			this.DMSanPhamDVO_SoLuongTonKhoMin = dMSanPhamDVO_SoLuongTonKhoMin;
			this.DMSanPhamDVO_SoLuongTonKhoMax = dMSanPhamDVO_SoLuongTonKhoMax;
			this.DMSanPhamDVO_ThoiGianBaoHanhMin = dMSanPhamDVO_ThoiGianBaoHanhMin;
			this.DMSanPhamDVO_ThoiGianBaoHanhMax = dMSanPhamDVO_ThoiGianBaoHanhMax;
		}
	}
}
