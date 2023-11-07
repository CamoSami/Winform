using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects;
using WinformWithExternalLibrary._DataProvider;

namespace WinformWithExternalLibrary.DataAccessObjects
{
	public class GiamGiaDAO
	{
		public static GiamGiaDAO Instance { get; set; }

		public GiamGiaDAO() { }

		public DataTable GetDetailGiamGia(string tenGiamGia)
		{


			string queryString = $"SELECT MaxGiamGia, PhanTramGiamGia FROM {DataProvider.GIAMGIA_TABLE} WHERE TenGiamGia = {this.GetString(tenGiamGia)}";

			return DataProvider.Instance.ExecuteQuery(queryString);
		}

		public string GetEligibleTenGiamGia()
		{
			string queryString = $"SELECT TenGiamGia FROM {DataProvider.GIAMGIA_TABLE} WHERE " +
				$"NgayBatDau < {this.GetString(DateTime.Now)} AND NgayKetThuc > {this.GetString(DateTime.Now)}";

			object obj = DataProvider.Instance.ExecuteScalar(queryString);

			return obj != null ? obj.ToString() : "";
		}

		public Guid GetMaGiamGia(string tenGiamGia)
		{
			string queryString = $"SELECT MaGiamGia FROM {DataProvider.GIAMGIA_TABLE} WHERE TenGiamGia = {this.GetString(tenGiamGia)}";

			object obj = DataProvider.Instance.ExecuteScalar(queryString);

			return obj != null ? Guid.Parse(obj.ToString()) : Guid.Empty;
		}

		public long GetMaxGiamGia(string tenGiamGia)
		{
			string queryString = $"SELECT MaxGiamGia FROM {DataProvider.GIAMGIA_TABLE} WHERE TenGiamGia = {this.GetString(tenGiamGia)}";

			object obj = DataProvider.Instance.ExecuteScalar(queryString);

			return obj != null ? long.Parse(obj.ToString()) : 0;
		}

		public float GetPhanTramGiamGia(string tenGiamGia)
		{
			string queryString = $"SELECT PhanTramGiamGia FROM {DataProvider.GIAMGIA_TABLE} WHERE TenGiamGia = {this.GetString(tenGiamGia)}";

			object obj = DataProvider.Instance.ExecuteScalar(queryString);

			return obj != null ? float.Parse(obj.ToString()) : 0;
		}

		public bool CheckIfGiamGiaEligible(string tenGiamGia)
		{
			string queryString = $"SELECT * FROM {DataProvider.GIAMGIA_TABLE} WHERE TenGiamGia = {this.GetString(tenGiamGia)} " +
				$"AND NgayBatDau < {this.GetString(DateTime.Now)} AND NgayKetThuc > {this.GetString(DateTime.Now)}";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(queryString);

			return dataTable.Rows.Count > 0;
		}

		public bool CheckIfGiamGiaExists(string tenGiamGia)
		{
			string queryString = $"SELECT * FROM {DataProvider.GIAMGIA_TABLE} WHERE TenGiamGia = {this.GetString(tenGiamGia)}";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(queryString);

			return dataTable.Rows.Count > 0;
		}



		private string GetString(object obj)
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
