using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects;

namespace WinformWithExternalLibrary.DataAccessObjects
{
    public class DMSanPhamDAO
    {
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

            string insertSanPham = $"INSERT INTO TABLE {DataProvider.DMSANPHAM_TABLE} " +
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

            return rowChanged > 0;
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

        public bool DeleteSanPham(string maSanPham)
        {
			string deleteSanPham = $"DELETE FROM {DataProvider.DMSANPHAM_TABLE} " +
                                   $"WHERE MaSanPham  = {this.GetString(maSanPham)}";
            
			int rowChanged = DataProvider.Instance.ExecuteNonQuery(deleteSanPham);
            
			return rowChanged > 0;
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

			return (int)tempSoLuongTonKho;
		}



		private string GetString(dynamic obj)
		{
			return "N'" + obj.ToString() + "'";
		}

	}
}
