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
	public class HoaDonNhapDAO
	{
		public event EventHandler OnDAODatabaseChanged;

		public static HoaDonNhapDAO Instance { get; set; }

		public HoaDonNhapDAO() { }

		public bool InsertHoaDonNhap(HoaDonNhapDTO hoaDonNhapDTO)
		{
			string stringQuery = $"INSERT INTO {DataProvider.HOADONNHAP_TABLE} " +
					$"(MaHDNhap, MaNhaCungCap, MaNhanVien, NgayNhap, SoSanPham, TongTien) VALUES (" +
					$"{this.GetString(hoaDonNhapDTO.HoaDonNhapDTO_MaHDNhap)}," +
					$"{this.GetString(hoaDonNhapDTO.HoaDonNhapDTO_MaNhaCungCap)}," +
					$"{this.GetString(hoaDonNhapDTO.HoaDonNhapDTO_MaNhanVien)}," +
					$"{this.GetString(hoaDonNhapDTO.HoaDonNhapDTO_NgayNhap)}," +
					$"{this.GetString(hoaDonNhapDTO.HoaDonNhapDTO_SoSanPham)}," +
					$"{this.GetString(hoaDonNhapDTO.HoaDonNhapDTO_TongTien)}" +
					$")";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(stringQuery);

			if (rowChanged > 0)
			{
				this.OnDAODatabaseChanged?.Invoke(this, new EventArgs());
			}

			return rowChanged > 0;
		}

		public DataTable HoaDonNhapInformationFromSoDienThoai(string NhaCungCap_SoDienThoai)
		{
			Guid maNhaCungCap = NhaCungCapDAO.Instance.GetMaNhaCungCapWithPhoneNumbers(NhaCungCap_SoDienThoai);

			string query = $"SELECT MaHDNhap, NgayNhap, TongTien " +
				$"FROM {DataProvider.HOADONNHAP_TABLE} " +
				$"WHERE MaNhaCungCap = N'{maNhaCungCap}'";

			//Debug.WriteLine(query);

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

			return dataTable;
		}

		public bool IfHoaDonNhapInformationFromSoDienThoai(string NhaCungCap_SoDienThoai)
		{
			Guid maNhaCungCap = NhaCungCapDAO.Instance.GetMaNhaCungCapWithPhoneNumbers(NhaCungCap_SoDienThoai);

			string query = $"SELECT MaHDNhap, NgayNhap, TongTien " +
				$"FROM {DataProvider.HOADONNHAP_TABLE} " +
				$"WHERE MaNhaCungCap = N'{maNhaCungCap}'";

			//Debug.WriteLine(query);

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
