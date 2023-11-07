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
	public class ChiTietHDBanDAO
	{
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

			return temp > 0;
		}



		private string GetString(dynamic obj)
		{
			return "N'" + obj.ToString() + "'";
		}
	}
}
