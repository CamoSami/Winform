using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects;
using WinformWithExternalLibrary._DataProvider;
using WinformWithExternalLibrary.DataValidateObjects;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Diagnostics;

namespace WinformWithExternalLibrary.DataAccessObjects
{
	public class DMSanPhamDAO
	{
		public event EventHandler OnDAODatabaseChanged;

		public static DMSanPhamDAO Instance { get; set; }

		public DMSanPhamDAO() { }

		//		MinhHieu Add: Lấy List MaSanPham
		public List<string> GetMaSanPhamList()
		{
			string getMaSanPhams = $"SELECT MaSanPham FROM {DataProvider.DMSANPHAM_TABLE}";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(getMaSanPhams);

			List<string> list = new List<string>();

			foreach (DataRow dataRow in dataTable.Rows)
			{
				list.Add(dataRow[0].ToString());
			}

			return list;
		}

		//		MinhHieu Add: Lấy MaDMSanPham từ MaSanPham
		public Guid GetMaDMSanPhamFromMaSanPham(string maSanPham)
		{
			string getSanPham = $"SELECT MaDMSanPham FROM {DataProvider.DMSANPHAM_TABLE} " +
				$"WHERE MaSanPham = '{maSanPham}'";

			object maDMSanPham = DataProvider.Instance.ExecuteScalar(getSanPham);

			return maDMSanPham != null ? Guid.Parse(maDMSanPham.ToString()) : Guid.Empty;
		}

		//		MinhHieu Add: Xem MaSanPham có tồn tại hay không
		public bool CheckMaSanPhamExist(string maSanPham)
		{
			string getSanPham = $"SELECT * FROM {DataProvider.DMSANPHAM_TABLE} " +
				$"WHERE MaSanPham = '{maSanPham}'";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(getSanPham);

			return dataTable.Rows.Count > 0;
		}

		//		MinhHieu Add: Tìm TenSanPham theo MaSanPham
		public string GetTenSanPhamWithMaSanPham(string maSanPham)
		{
			string getTenSanPham = $"SELECT TenSanPham FROM {DataProvider.DMSANPHAM_TABLE} " +
				$"WHERE MaSanPham = '{maSanPham}'";

			object tenSanPham = DataProvider.Instance.ExecuteScalar(getTenSanPham);

			return tenSanPham != null ? tenSanPham.ToString() : "";
		}

		public bool InsertSanPham(dynamic baseDTO)
		{
			DMSanPhamDTO dMSanPhamDTO = baseDTO as DMSanPhamDTO;

			string insertSanPham = $"INSERT INTO {DataProvider.DMSANPHAM_TABLE}(MaDMSanPham, MaSanPham, TenSanPham, DonGiaBan, DonGiaNhap," +
				$"SoLuongTonKho, ThoiGianBaoHanh)" +
								   $"VALUES(" +
								   $"{this.GetString(dMSanPhamDTO.DMSanPhamDTO_MaDMSanPham)}, " +
								   $"{this.GetString(dMSanPhamDTO.DMSanPhamDTO_MaSanPham)}," +
								   $"{this.GetString(dMSanPhamDTO.DMSanPhamDTO_TenSanPham)}, " +
								   $"{this.GetString(dMSanPhamDTO.DMSanPhamDTO_DonGiaBan)}," +
								   $"{this.GetString(dMSanPhamDTO.DMSanPhamDTO_DonGiaNhap)}, " +
								   $"{this.GetString(dMSanPhamDTO.DMSanPhamDTO_SoLuongTonKho)}," +
								   $"{this.GetString(dMSanPhamDTO.DMSanPhamDTO_ThoiGianBaoHanh)}" +
								   $")";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(insertSanPham);

			if (rowChanged > 0)
			{
				this.OnDAODatabaseChanged?.Invoke(this, new EventArgs());
			}

			return rowChanged > 0;
		}

		//Lấy tất cả các sản phẩm hiện có
		public DataTable GetAllSanPham()
		{
			string getAllSanPham = $"SELECT MaSanPham, TenSanPham, DonGiaBan, DonGiaNhap, SoLuongTonKho, ThoiGianBaoHanh " +
									$"FROM {DataProvider.DMSANPHAM_TABLE} " +
									$"ORDER BY TenSanPham ";
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(getAllSanPham);
			return dataTable;
		}

		//Update sản phẩm
		//		HieuNote: thiếu dấu cách tiếp (t chỉ sửa dùng phương thức đã có để tiện đỡ Edit nhiều)
		public bool UpdateSanPham(DMSanPhamDTO dMSanPhamDTO, Guid MaDMSanPham)
		{
			string updateSP = $"UPDATE {DataProvider.DMSANPHAM_TABLE} " +
				$"SET MaSanPham = {this.GetString(dMSanPhamDTO.DMSanPhamDTO_MaSanPham)}, " +
				$"TenSanPham = {this.GetString(dMSanPhamDTO.DMSanPhamDTO_TenSanPham)}, " +
				$"DonGiaBan = {this.GetString(dMSanPhamDTO.DMSanPhamDTO_DonGiaBan)}, " +
				$"DonGiaNhap = {this.GetString(dMSanPhamDTO.DMSanPhamDTO_DonGiaNhap)}, " +
				$"SoLuongTonKho = {this.GetString(dMSanPhamDTO.DMSanPhamDTO_SoLuongTonKho)}, " +
				$"ThoiGianBaoHanh = {this.GetString(dMSanPhamDTO.DMSanPhamDTO_ThoiGianBaoHanh)} " +
				$"WHERE MaDMSanPham = {this.GetString(MaDMSanPham)}";
			int rowChanged = DataProvider.Instance.ExecuteNonQuery(updateSP);
			return rowChanged > 0;
		}

		//Tìm kiếm sản phẩm
		//		HieuNote: thiếu dấu cách và thừa AND nha =='
		public DataTable GetSanPham(string TSP, long DGBMin, long DGBMax, long DGNMin, long DGNMax,
			int SLTKMin, int SLTKMax, DateTime TGBHMin, DateTime TGBHMax)
		{
			string temp = "";
			if (TSP != "")
			{
				temp += $"TenSanPham LIKE N'%{TSP}%' ";
			}
			if (DGBMin != 0)
			{
				if (temp != "") temp += " AND ";
				temp += $"DonGiaBan >= {this.GetString(DGBMin)} ";
			}
			if (DGBMax != 0)
			{
				if (temp != "") temp += " AND ";
				temp += $"DonGiaBan <= {this.GetString(DGBMax)} ";
			}

			if (DGNMin != 0)
			{
				if (temp != "") temp += " AND ";
				temp += $"DonGiaNhap >= {this.GetString(DGNMin)} ";
			}
			if (DGNMax != 0)
			{
				if (temp != "") temp += " AND ";
				temp += $"DonGiaNhap <= {this.GetString(DGNMax)} ";
			}
			if (SLTKMin != 0)
			{
				if (temp != "") temp += " AND ";
				temp += $"SoLuongTonKho >= {this.GetString(SLTKMin)} ";
			}
			if (SLTKMax != 0)
			{
				if (temp != "") temp += " AND ";
				temp += $"SoLuongTonKho <= {this.GetString(SLTKMax)} ";
			}

			if (temp != "") temp += " AND ";

			if (TGBHMin <= TGBHMax)
			{
				temp += $"ThoiGianBaoHanh >= {this.GetString(TGBHMin)} AND ThoiGianBaoHanh <= {this.GetString(TGBHMax)} ";
			}
			else temp += $"ThoiGianBaoHanh >= {this.GetString(TGBHMax)} AND ThoiGianBaoHanh <= {this.GetString(TGBHMin)} ";


			string getSP = $"SELECT MaSanPham, TenSanPham, DonGiaBan, DonGiaNhap, SoLuongTonKho, ThoiGianBaoHanh " +
									$"FROM {DataProvider.DMSANPHAM_TABLE} WHERE " + temp +
									$"ORDER BY TenSanPham ";
			Debug.WriteLine(getSP);
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(getSP);

			return dataTable;
		}
		public DataTable GetSanPhamFromMSP(string MSP)
		{
			string getSP =
				$"SELECT MaSanPham, TenSanPham, DonGiaBan, DonGiaNhap, SoLuongTonKho, ThoiGianBaoHanh " +
				$"FROM {DataProvider.DMSANPHAM_TABLE} WHERE " +
				$"MaSanPham = {this.GetString(MSP)}";
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(getSP);
			return dataTable;
		}
		public int GetSoLuongTonKhoMax()
		{
			string getSLTKMax = $"SELECT MAX(SoLuongTonKho) FROM {DataProvider.DMSANPHAM_TABLE} GROUP BY MaSanPham ";
			object SLTKM = DataProvider.Instance.ExecuteScalar(getSLTKMax);
			return (int)SLTKM;
		}
		public long GetDonGiaBanMax()
		{
			string getDGBMax = $"SELECT MAX(DonGiaBan) FROM {DataProvider.DMSANPHAM_TABLE} GROUP BY MaSanPham ";
			object DGBM = DataProvider.Instance.ExecuteScalar(getDGBMax);
			return (long)DGBM;
		}
		public long GetDonGiaNhapMax()
		{
			string getDGNMax = $"SELECT MAX(DonGiaNhap) FROM {DataProvider.DMSANPHAM_TABLE} GROUP BY MaSanPham ";
			object DGNM = DataProvider.Instance.ExecuteScalar(getDGNMax);
			return (long)DGNM;
		}
		public DateTime GetThoiGianBaoHanhMin()
		{
			string getTGBHMin = $"SELECT MIN(ThoiGianBaoHanh) FROM {DataProvider.DMSANPHAM_TABLE} GROUP BY MaSanPham ";
			object TGBHMin = DataProvider.Instance.ExecuteScalar(getTGBHMin);
			return (DateTime)TGBHMin;
		}

		public DateTime GetThoiGianBaoHanhMax()
		{
			string getTGBHMax = $"SELECT MAX(ThoiGianBaoHanh) FROM {DataProvider.DMSANPHAM_TABLE} GROUP BY MaSanPham ";
			object TGBHMax = DataProvider.Instance.ExecuteScalar(getTGBHMax);
			return (DateTime)TGBHMax;
		}

		//Xóa sản phẩm
		public bool DeleteSanPham(string maSanPham)
		{
			string deleteSanPhamtrongSP = $"DELETE FROM {DataProvider.DMSANPHAM_TABLE} " +
								  $"WHERE MaSanPham  = {this.GetString(maSanPham)}";

			int rowChanged3 = DataProvider.Instance.ExecuteNonQuery(deleteSanPhamtrongSP);
			Debug.WriteLine(deleteSanPhamtrongSP);
			return
				rowChanged3 > 0;
		}

		public long GetDonGiaBanWithMaSanPham(string maSanPham)
		{
			string stringDonGiaBan = $"SELECT DonGiaBan " +
					 $"FROM {DataProvider.DMSANPHAM_TABLE} " +
					 $"WHERE MaSanPham = {this.GetString(maSanPham)}";

			object tempDonGiaBan = DataProvider.Instance.ExecuteScalar(stringDonGiaBan);

			if (tempDonGiaBan == null)
			{
				MaterialMessageBox.Show(
					text: "Mã sản phẩm đã nhập không tồn tại",
					caption: this.GetType().ToString(),
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);
			}

			return (long)tempDonGiaBan;
		}

		public long GetDonGiaNhapWithMaSanPham(string maSanPham)
		{
			string stringDonGiaNhap = $"SELECT DonGiaNhap " +
					 $"FROM {DataProvider.DMSANPHAM_TABLE} " +
					 $"WHERE MaSanPham = {this.GetString(maSanPham)}";

			object tempDonGiaNhap = DataProvider.Instance.ExecuteScalar(stringDonGiaNhap);

			if (tempDonGiaNhap == null)
			{
				MaterialMessageBox.Show(
					text: "Mã sản phẩm đã nhập không tồn tại",
					caption: this.GetType().ToString(),
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);
			}

			return (long)tempDonGiaNhap;
		}

		public int GetSoLuongTonKhoByMaSanPham(string maSanPham)
		{
			string stringSoLuongTonKho = $"SELECT SoLuongTonKho " +
					 $"FROM {DataProvider.DMSANPHAM_TABLE} " +
					 $"WHERE MaSanPham = {this.GetString(maSanPham)}";

			object tempSoLuongTonKho = DataProvider.Instance.ExecuteScalar(stringSoLuongTonKho);

			if (tempSoLuongTonKho == null)
			{
				MaterialMessageBox.Show(
					text: "Mã sản phẩm đã nhập không tồn tại",
					caption: this.GetType().ToString(),
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);
			}

			return tempSoLuongTonKho != null ? (int)tempSoLuongTonKho : 0;
		}

		public bool UpdateCongSoLuongTon(string maSanPham, int soLuongCanCong)
		{
			string updateSanPham = $"UPDATE {DataProvider.DMSANPHAM_TABLE} " +
								   $"SET SoLuongTonKho = SoLuongTonKho + {soLuongCanCong} " +
								   $"WHERE MaSanPham = {this.GetString(maSanPham)}";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(updateSanPham);

			return rowChanged > 0;
		}

		public bool UpdateTruSoLuongTon(string maSanPham, int soLuongCanTru)
		{
			string updateSanPham = $"UPDATE {DataProvider.DMSANPHAM_TABLE} " +
								   $"SET SoLuongTonKho = SoLuongTonKho - {soLuongCanTru} " +
								   $"WHERE MaSanPham = {this.GetString(maSanPham)}";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(updateSanPham);

			return rowChanged > 0;
		}


		private string GetString(dynamic obj)
		{
			return "N'" + obj.ToString() + "'";
		}

	}
}
