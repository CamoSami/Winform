using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using WinformWithExternalLibrary.DataTransferObjects;
using WinformWithExternalLibrary._DataProvider;

namespace WinformWithExternalLibrary.DataAccessObjects
{
	public class HoaDonNhapDAO
	{
		public event EventHandler OnDAONewInsert;

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
				this.OnDAONewInsert?.Invoke(this, new EventArgs());
			}

			return rowChanged > 0;
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
