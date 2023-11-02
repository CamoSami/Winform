using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects;
using WinformWithExternalLibrary.DataValidateObjects;

namespace WinformWithExternalLibrary.DataAccessObjects
{
	public class KhachHangDAO
	{
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

			return rowChanged > 0;
		}
	}
}
