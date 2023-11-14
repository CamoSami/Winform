using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using WinformWithExternalLibrary.DataTransferObjects;
using WinformWithExternalLibrary._DataProvider;
using System.Diagnostics;

namespace WinformWithExternalLibrary.DataAccessObjects
{
	public class HoaDonBanDAO
	{
		public event EventHandler OnDAODatabaseChanged;

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

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(stringQuery);

			if (rowChanged > 0)
			{
				this.OnDAODatabaseChanged?.Invoke(this, new EventArgs());
			}

			return rowChanged > 0;
		}

		public DataTable HoaDonBanInformationFromSoDienThoai(string KhachHang_SoDienThoai)
		{
			Guid maKhachHang = KhachHangDAO.Instance.GetMaKhachHangWithPhoneNumbers(KhachHang_SoDienThoai);

			string query = $"SELECT MaHDBan, NgayBan, TongTienKhachTra " +
				$"FROM {DataProvider.HOADONBAN_TABLE} " +
				$"WHERE MaKhachHang = N'{maKhachHang}'";
			
			Debug.WriteLine(maKhachHang);

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

			return dataTable;
		}

		public bool IfHoaDonBanInformationFromSoDienThoai(string KhachHang_SoDienThoai)
		{
			Guid maKhachHang = KhachHangDAO.Instance.GetMaKhachHangWithPhoneNumbers(KhachHang_SoDienThoai);

			string query = $"SELECT MaHDBan, NgayBan, TongTienKhachTra " +
				$"FROM {DataProvider.HOADONBAN_TABLE} " +
				$"WHERE MaKhachHang = N'{maKhachHang}'";

			Debug.WriteLine(maKhachHang);

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

			return dataTable.Rows.Count > 0;
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
