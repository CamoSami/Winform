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
	public class ChiTietHDNhapDAO
	{
		public event EventHandler OnDAONewInsert;

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
				this.OnDAONewInsert?.Invoke(this, EventArgs.Empty);
			}

			return temp > 0;
		}



		private string GetString(dynamic obj)
		{
			return "N'" + obj.ToString() + "'";
		}
	}
}
