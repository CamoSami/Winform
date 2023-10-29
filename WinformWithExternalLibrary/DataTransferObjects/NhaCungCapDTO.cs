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

        public string NhaCungCapDTO_TenNhaCungCap { get; set; }

        public string NhaCungCapDTO_DienThoai { get; set; }

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
