using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects;

namespace WinformWithExternalLibrary.DataAccessObjects
{
	public class KhachHangDAO
	{
		public static KhachHangDAO Instance { get; set; }

		public KhachHangDAO() { }

		public bool IfPhoneNumberTaken(dynamic baseDTO)
		{
			KhachHangDTO khachHangDTO = baseDTO as KhachHangDTO;

			string selectPhoneNumber = "SELECT * FROM " +
							DataProvider.KHACHHANG_TABLE +
							" WHERE DienThoai = " +
							"'" + khachHangDTO.KhachHangDTO_DienThoai + "'";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(selectPhoneNumber);

			return dataTable.Rows.Count > 0;
		}

		public bool InsertKhachHang(dynamic baseDTO)
		{
			KhachHangDTO khachHangDTO = baseDTO as KhachHangDTO;

			string insertKhachHang = "INSERT INTO " +
							DataProvider.KHACHHANG_TABLE +
							" (TenKhachHang, DiaChi, DienThoai) VALUES (" + 
							"N'" + khachHangDTO.KhachHangDTO_TenKhachHang + "'," +
							"N'" + khachHangDTO.KhachHangDTO_DiaChi + "'," +
							"N'" + khachHangDTO.KhachHangDTO_DienThoai + "'" +
							")";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(insertKhachHang);

			return rowChanged > 0;
		}
	}
}
