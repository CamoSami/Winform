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
	public class GiamGiaDAO
	{
		public event EventHandler OnDAODatabaseChanged;

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

		//Hạnh add
		public DataTable GetAllGiamGia()
		{
			string query = $"SELECT MaGiamGia, TenGiamGia, PhanTramGiamGia, MaxGiamGia, NgayBatDau, NgayKetThuc " +
				$"FROM {DataProvider.GIAMGIA_TABLE} ";
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
			return dataTable;
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

		public bool InsertGiamGia(dynamic baseDTO)
		{
			GiamGiaDTO giamGiaDTO = baseDTO as GiamGiaDTO;

			string insertGiamGia = $"INSERT INTO {DataProvider.GIAMGIA_TABLE}" +
								$" (MaGiamGia, TenGiamGia, PhanTramGiamGia, MaxGiamGia, NgayBatDau, NgayKetThuc) VALUES (" +
								$"{this.GetString(giamGiaDTO.GiamGiaDTO_MaGiamGia)}," +
								$"{this.GetString(giamGiaDTO.GiamGiaDTO_TenGiamGia)}," +
								$"{this.GetString(giamGiaDTO.GiamGiaDTO_PhanTramGiamGia)}," +
								$"{this.GetString(giamGiaDTO.GiamGiaDTO_MaxGiamGia)}," +
								$"{this.GetString(giamGiaDTO.GiamGiaDTO_NgayBatDau)}," +
								$"{this.GetString(giamGiaDTO.GiamGiaDTO_NgayKetThuc)}" +
								$")";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(insertGiamGia);

			if (rowChanged > 0)
			{
				this.OnDAODatabaseChanged?.Invoke(this, EventArgs.Empty);
			}

			return rowChanged > 0;
		}

		public bool DeleteGiamGia(Guid maGiamGia)
		{
			string query = $"DELETE FROM {DataProvider.GIAMGIA_TABLE} WHERE MaGiamGia = {this.GetString(maGiamGia)} ";
		
			//Debug.WriteLine(query);

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(query);
			
			return rowChanged > 0;
		}

		//Hạnh add
		public bool UpdateGiamGia(GiamGiaDTO giamGiaDTO, Guid MaGiamGia)
		{
			string updateGG = $"UPDATE {DataProvider.GIAMGIA_TABLE} " +
				$"SET " +
				$"TenGiamGia = {this.GetString(giamGiaDTO.GiamGiaDTO_TenGiamGia)}, " +
				$"PhanTramGiamGia = {this.GetString(giamGiaDTO.GiamGiaDTO_PhanTramGiamGia)}, " +
				$"MaxGiamGia = {this.GetString(giamGiaDTO.GiamGiaDTO_MaxGiamGia)}, " +
				$"NgayBatDau = {this.GetString(giamGiaDTO.GiamGiaDTO_NgayBatDau)}, " +
				$"NgayKetThuc = {this.GetString(giamGiaDTO.GiamGiaDTO_NgayKetThuc)} " +
				$"WHERE MaGiamGia = {this.GetString(MaGiamGia)}";
			
			int rowChanged = DataProvider.Instance.ExecuteNonQuery(updateGG);

			return rowChanged > 0;
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
