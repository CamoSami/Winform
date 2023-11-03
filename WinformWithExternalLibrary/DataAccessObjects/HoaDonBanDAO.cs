using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using WinformWithExternalLibrary.DataTransferObjects;

namespace WinformWithExternalLibrary.DataAccessObjects
{
	public class HoaDonBanDAO
	{
		public static HoaDonBanDAO Instance { get; set; }

		public HoaDonBanDAO() { }

		public bool InsertHoaDonBan(HoaDonBanDTO hoaDonBanDTO)
		{
			if (hoaDonBanDTO.HoaDonBanDTO_MaKhachHang == Guid.Empty)
			{
				hoaDonBanDTO.HoaDonBanDTO_MaKhachHang = null;
			}
			if (hoaDonBanDTO.HoaDonBanDTO_MaGiamGia == Guid.Empty)
			{
				hoaDonBanDTO.HoaDonBanDTO_MaGiamGia = null;
			}


			string stringQuery = $"INSERT INTO {DataProvider.HOADONBAN_TABLE} " +
					$"(MaHDBan, MaNhanVien, MaKhachHang, MaGiamGia, SoSanPham, NgayBan, TongTien, TongTienKhachTra) VALUES (" +
					$"{this.GetString(hoaDonBanDTO.HoaDonBanDTO_MaHDBan)}," +
					$"{this.GetString(hoaDonBanDTO.HoaDonBanDTO_MaNhanVien)}," +
					$"{this.GetString(hoaDonBanDTO.HoaDonBanDTO_MaKhachHang)}," +
					$"{this.GetString(hoaDonBanDTO.HoaDonBanDTO_MaGiamGia)}," +
					$"{this.GetString(hoaDonBanDTO.HoaDonBanDTO_SoSanPham)}," +
					$"{this.GetString(hoaDonBanDTO.HoaDonBanDTO_NgayBan)}," +
					$"{this.GetString(hoaDonBanDTO.HoaDonBanDTO_TongTien)}," +
					$"{this.GetString(hoaDonBanDTO.HoaDonBanDTO_TongTienKhachTra)}" +
					$")";

			int temp = DataProvider.Instance.ExecuteNonQuery(stringQuery);

			return temp > 0;
		}



		private string GetString(dynamic obj)
		{
			if (obj == null)
			{
				return "NULL";
			}
			else
			{
				return "N'" + obj.ToString() + "'";
			}
		}
	}
}
