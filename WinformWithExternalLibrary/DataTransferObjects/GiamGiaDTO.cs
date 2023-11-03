using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataTransferObjects
{
	public class GiamGiaDTO
	{
		public Guid GiamGiaDTO_MaGiamGia { get; set; }

		public string GiamGiaDTO_TenGiamGia { get; set; }

		public float GiamGiaDTO_PhanTramGiamGia { get; set; }

		public long GiamGiaDTO_MaxGiamGia { get; set; }

		public DateTime GiamGiaDTO_NgayBatDau { get; set; }

		public DateTime GiamGiaDTO_NgayKetThuc { get; set; }

		public GiamGiaDTO() { }

		public GiamGiaDTO(Guid giamGiaDTO_MaGiamGia, string giamGiaDTO_TenGiamGia, float giamGiaDTO_PhanTramGiamGia, long giamGiaDTO_MaxGiamGia, DateTime giamGiaDTO_NgayBatDau, DateTime giamGiaDTO_NgayKetThuc)
		{
			this.GiamGiaDTO_MaGiamGia = giamGiaDTO_MaGiamGia;
			this.GiamGiaDTO_TenGiamGia = giamGiaDTO_TenGiamGia;
			this.GiamGiaDTO_PhanTramGiamGia = giamGiaDTO_PhanTramGiamGia;
			this.GiamGiaDTO_MaxGiamGia = giamGiaDTO_MaxGiamGia;
			this.GiamGiaDTO_NgayBatDau = giamGiaDTO_NgayBatDau;
			this.GiamGiaDTO_NgayKetThuc = giamGiaDTO_NgayKetThuc;
		}
	}
}
