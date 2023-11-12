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
	public class ChiTietHDNhapDAO
	{
		public event EventHandler OnDAODatabaseChanged;

		public static ChiTietHDNhapDAO Instance { get; set; }

		public ChiTietHDNhapDAO() { }

		public bool InsertChiTietHDNhap(ChiTietHDNhapDTO chiTietHDNhapDTO)
		{
			string queryString = $"INSERT INTO {DataProvider.CHITIETHDNHAP_TABLE} " +
				$"(MaHDNhap, MaDMSanPham, SoLuong, ThanhTien) VALUES (" +
				$"{this.GetString(chiTietHDNhapDTO.ChiTietHDNhapDTO_MaHDNhap)}," +
				$"{this.GetString(chiTietHDNhapDTO.ChiTietHDNhapDTO_MaDMSanPham)}," +
				$"{this.GetString(chiTietHDNhapDTO.ChiTietHDNhapDTO_SoLuong)}," +
				$"{this.GetString(chiTietHDNhapDTO.ChiTietHDNhapDTO_ThanhTien)}," +
				$")";

			int temp = DataProvider.Instance.ExecuteNonQuery(queryString);

			if (temp > 0) 
			{
				this.OnDAODatabaseChanged?.Invoke(this, EventArgs.Empty);
			}

			return temp > 0;
		}

		public DataTable HoaDonInformationFromMaHoaDon(string MaHoaDonNhap)
		{
			string query = $"SELECT {DataProvider.CHITIETHDNHAP_TABLE}.MaDMSanPham, TenSanPham, SoLuong, ThanhTien " +
				$"FROM {DataProvider.CHITIETHDNHAP_TABLE} INNER JOIN {DataProvider.DMSANPHAM_TABLE} " +
					$"ON {DataProvider.CHITIETHDNHAP_TABLE}.MaDMSanPham = {DataProvider.DMSANPHAM_TABLE}.MaDMSanPham " +
				$"WHERE {DataProvider.CHITIETHDNHAP_TABLE}.MaHDNhap = N'{MaHoaDonNhap}'";

			Debug.WriteLine(query);

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

			return dataTable;
		}



		private string GetString(dynamic obj)
		{
			return "N'" + obj.ToString() + "'";
		}
	}
}
