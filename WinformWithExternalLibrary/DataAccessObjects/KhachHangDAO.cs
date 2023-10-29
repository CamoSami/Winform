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

		public bool IfPhoneNumberTaken(string KhachHangDVO_DienThoai)
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
							" (TenKhachHang, DiaChi, DienThoai) VALUES (" + 
							"N'" + khachHangDVO.KhachHangDVO_TenKhachHang + "'," +
							"N'" + khachHangDVO.KhachHangDVO_DiaChi + "'," +
							"N'" + khachHangDVO.KhachHangDVO_DienThoai + "'" +
							")";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(insertKhachHang);

			return rowChanged > 0;
		}
	}
}
