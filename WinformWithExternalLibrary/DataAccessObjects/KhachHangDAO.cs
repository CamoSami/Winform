using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects;
using WinformWithExternalLibrary.DataValidateObject;
using WinformWithExternalLibrary._DataProvider;

namespace WinformWithExternalLibrary.DataAccessObjects
{
	public class KhachHangDAO
	{
		public event EventHandler OnDAODatabaseChanged;

		public static KhachHangDAO Instance { get; set; }

		public KhachHangDAO() { }

		public Guid GetMaKhachHangWithPhoneNumbers(string dienThoai)
		{
			string selectMaKhachHang = $"SELECT MaKhachHang FROM " +
				$"{DataProvider.KHACHHANG_TABLE} " +
				$"WHERE DienThoai = '{dienThoai}'";

			object temp = DataProvider.Instance.ExecuteScalar(selectMaKhachHang);

			return temp != null ? Guid.Parse(temp.ToString()) : Guid.Empty;
		}

		public string GetTenKhachHangWithPhoneNumber(string dienThoai)
		{
			string selectTenKhachHang = $"SELECT TenKhachHang FROM " +
				$"{DataProvider.KHACHHANG_TABLE} " +
				$"WHERE DienThoai = '{dienThoai}'";

			object temp = DataProvider.Instance.ExecuteScalar(selectTenKhachHang);

			return temp != null ? temp.ToString().Trim() : "";
		}

		public List<string> GetPhoneNumberList()
		{
			string selectDienThoai = $"SELECT DienThoai FROM " +
				$"{DataProvider.KHACHHANG_TABLE}";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(selectDienThoai);

			List<string> dienThoais = new List<string>();

			foreach (DataRow row in dataTable.Rows)
			{
				dienThoais.Add(row[0].ToString().Trim());
			}

			return dienThoais;
		}

		public bool IfPhoneNumberExist(string KhachHangDVO_DienThoai)
		{
			string selectDienThoai = "SELECT * FROM " +
							DataProvider.KHACHHANG_TABLE +
							" WHERE DienThoai = " +
							"'" + KhachHangDVO_DienThoai + "'";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(selectDienThoai);

			//Debug.WriteLine(dataTable.Rows.Count);

			return dataTable.Rows.Count > 0;
		}

		public bool InsertKhachHang(dynamic baseDTO)
		{
			KhachHangDVO khachHangDVO = baseDTO as KhachHangDVO;

			string insertKhachHang = "INSERT INTO " +
							DataProvider.KHACHHANG_TABLE +
							" (MaKhachHang, TenKhachHang, DiaChi, DienThoai) VALUES (" +
							"N'" + Guid.NewGuid() + "'," + 
							"N'" + khachHangDVO.KhachHangDVO_TenKhachHang + "'," +
							"N'" + khachHangDVO.KhachHangDVO_DiaChi + "'," +
							"N'" + khachHangDVO.KhachHangDVO_DienThoai + "'" +
							")";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(insertKhachHang);

			if (rowChanged > 0)
			{
				this.OnDAODatabaseChanged?.Invoke(this, new EventArgs());
			}

			return rowChanged > 0;
		}

		public DataTable QueryFullKhachHang()
		{
			string query = $"SELECT * FROM {DataProvider.KHACHHANG_TABLE}";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

			return dataTable;
		}

		public bool UpdateKhachHang(string TenKhachHang, string DiaChi, string DienThoai)
		{
			string query = $"UPDATE {DataProvider.KHACHHANG_TABLE} " +
				$"SET TenKhachHang = N'{TenKhachHang}', DiaChi = N'{DiaChi}' " +
				$"WHERE DienThoai = N'{DienThoai}'";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(query);

			if (rowChanged > 0)
			{
				this.OnDAODatabaseChanged?.Invoke(this, new EventArgs());
			}

			return rowChanged > 0;
		}

		public bool UpdateKhachHangFull(dynamic baseDTO, string DienThoai)
		{
			KhachHangDVO khachHangDVO = baseDTO as KhachHangDVO;

			Guid KhachHangDVO_MaKhachHang = Guid.NewGuid();

			string update = $"UPDATE {DataProvider.KHACHHANG_TABLE} " +
				$"SET TenKhachHang = N'{khachHangDVO.KhachHangDVO_TenKhachHang}', " +
				$"DiaChi = N'{khachHangDVO.KhachHangDVO_DiaChi}', " +
				$"DienThoai = N'{khachHangDVO.KhachHangDVO_DienThoai}' " +
				$"WHERE DienThoai = N'{DienThoai}'";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(update);

			if (rowChanged > 0)
			{
				this.OnDAODatabaseChanged?.Invoke(this, new EventArgs());
			}

			return rowChanged > 0;
		}

		public DataTable KhachHangInformationFromSearch(KhachHangDVO khachHangDVO)
		{
			string temp = "";

			if (khachHangDVO.KhachHangDVO_TenKhachHang != "")
			{
				if (temp != "")
				{
					temp += " AND";
				}

				temp += $" TenKhachHang LIKE N'%{khachHangDVO.KhachHangDVO_TenKhachHang}%'";
			}
			if (khachHangDVO.KhachHangDVO_DiaChi!= "")
			{
				if (temp != "")
				{
					temp += " AND";
				}

				temp += $" DiaChi LIKE N'%{khachHangDVO.KhachHangDVO_DiaChi}%'";
			}
			if (khachHangDVO.KhachHangDVO_DienThoai != "")
			{
				if (temp != "")
				{
					temp += " AND";
				}

				temp += $" DienThoai LIKE N'%{khachHangDVO.KhachHangDVO_DienThoai}%'";
			}

			if (temp == "")
			{
				return new DataTable();
			}

			string selectKhachHang = $"SELECT * FROM {DataProvider.KHACHHANG_TABLE} WHERE" + temp;

			Debug.WriteLine(selectKhachHang);

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(selectKhachHang);

			return dataTable;
		}

		public DataTable KhachHangInformationFromPhoneNumber(string KhachHangDVO_DienThoai)
		{
			string selectKhachHang = "SELECT * FROM " +
							DataProvider.KHACHHANG_TABLE +
							" WHERE DienThoai = " +
							"'" + KhachHangDVO_DienThoai + "'";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(selectKhachHang);

			return dataTable;
		}

		public DataTable KhachHangInformationFromName(string KhachHangDVO_TenKhachHang)
		{
			string selectKhachHang = "SELECT * FROM " +
							DataProvider.KHACHHANG_TABLE +
							" WHERE TenKhachHang = " +
							"N'" + KhachHangDVO_TenKhachHang + "'";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(selectKhachHang);

			return dataTable;
		}
	}
}
