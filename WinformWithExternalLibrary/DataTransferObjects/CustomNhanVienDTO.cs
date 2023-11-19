using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataTransferObjects
{
	public class CustomNhanVienDTO
	{
		public Guid NhanVienDTO_MaNhanVien { get; set; }

		public Guid NhanVienDTO_MaCongViec { get; set; }

		public string NhanVienDTO_TenNhanVien { get; set; }

		public string NhanVienDTO_Email { get; set; }

		public string NhanVienDTO_MatKhau { get; set; }

		public DateTime NhanVienDTO_NgaySinh { get; set; }

		public string NhanVienDTO_DiaChi { get; set; }

		public string NhanVienDTO_DienThoai { get; set; }

		public string NhanVienDTO_GioiTinh { get; set; }
		
		public string NhanVienDTO_TenCongViec { get; set; }
	}

}

