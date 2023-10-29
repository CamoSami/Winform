using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataTransferObjects
{
	public class KhachHangDTO
	{
		public Guid KhachHangDTO_MaKhachHang { get; set; }

		public string KhachHangDTO_TenKhachHang { get; set; }

		public string KhachHangDTO_DiaChi { get; set; }

		public string KhachHangDTO_DienThoai { get; set; }

		public KhachHangDTO(string khachHangDTO_TenKhachHang, string khachHangDTO_DiaChi, string khachHangDTO_DienThoai)
		{
			this.KhachHangDTO_TenKhachHang = khachHangDTO_TenKhachHang;
			this.KhachHangDTO_DiaChi = khachHangDTO_DiaChi;
			this.KhachHangDTO_DienThoai = khachHangDTO_DienThoai;
		}

		public KhachHangDTO() { }
	}
}
