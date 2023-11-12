using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects;
using WinformWithExternalLibrary._DataProvider;
using System.Diagnostics;

namespace WinformWithExternalLibrary.DataAccessObjects
{
	public class ChiTietHDBanDAO
	{
		public event EventHandler OnDAODatabaseChanged;

		public static ChiTietHDBanDAO Instance { get; set; }

		public ChiTietHDBanDAO() { }

		public bool InsertChiTietHDBan(ChiTietHDBanDTO chiTietHDBanDTO)
		{
			string queryString = $"INSERT INTO {DataProvider.CHITIETHDBAN_TABLE} " +
				$"(MaHDBan, MaDMSanPham, SoLuong, ThanhTien) VALUES (" +
				$"{this.GetString(chiTietHDBanDTO.ChiTietHDBanDTO_MaHDBan)}," +
				$"{this.GetString(chiTietHDBanDTO.ChiTietHDBanDTO_MaDMSanPham)}," +
				$"{chiTietHDBanDTO.ChiTietHDBanDTO_SoLuong}," +
				$"{chiTietHDBanDTO.ChiTietHDBanDTO_ThanhTien}" +
				$")";

			int temp = DataProvider.Instance.ExecuteNonQuery(queryString);

			if (temp > 0) 
			{
				this.OnDAODatabaseChanged?.Invoke(this, EventArgs.Empty);
			}

			return temp > 0;
		}

		public DataTable HoaDonInformationFromMaHoaDon(string MaHoaDonBan)
		{
			string query = $"SELECT {DataProvider.CHITIETHDBAN_TABLE}.MaDMSanPham, TenSanPham, SoLuong, ThanhTien " +
				$"FROM {DataProvider.CHITIETHDBAN_TABLE} INNER JOIN {DataProvider.DMSANPHAM_TABLE} " +
					$"ON {DataProvider.CHITIETHDBAN_TABLE}.MaDMSanPham = {DataProvider.DMSANPHAM_TABLE}.MaDMSanPham " +
				$"WHERE {DataProvider.CHITIETHDBAN_TABLE}.MaHDBan = N'{MaHoaDonBan}'";

			//Debug.WriteLine(MaHoaDonBan);

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

			return dataTable;
		}



		private string GetString(dynamic obj)
		{
			return "N'" + obj.ToString() + "'";
		}
	}
}
