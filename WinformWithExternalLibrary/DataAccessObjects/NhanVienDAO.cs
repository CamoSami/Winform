using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using WinformWithExternalLibrary.DataTransferObjects;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Diagnostics;
using WinformWithExternalLibrary.DataValidateObjects;
using MaterialSkin.Controls;
using WinformWithExternalLibrary.DataValidateObject;
using WinformWithExternalLibrary._DataProvider;

namespace WinformWithExternalLibrary.DataAccessObjects
{
    public class NhanVienDAO
	{
		public event EventHandler OnDAODatabaseChanged;

		public static NhanVienDAO Instance { get; set; }

        public NhanVienDAO() { }

		//		MinhHieu Add: Lấy danh sách TenNhanVien và NgaySinh nhân viên
		public List<string> GetTenNhanVienAndNgaySinhList()
		{
			string queryListNV = $"SELECT TenNhanVien, NgaySinh FROM {DataProvider.NHANVIEN_TABLE}";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(queryListNV);

			List<string> listNV = new List<string>();

			foreach (DataRow dataRow in dataTable.Rows)
			{
				listNV.Add(dataRow[0].ToString() + " | " + dataRow[1].ToString());
			}

			return listNV;
		}

		//		MinhHieu Add: Tìm MaNhanVien theo TenNhanVien và NgaySinh
		public Guid GetMaNhanVienByTenNhanVienAndNgaySinh(string nhanVien)
		{
			string tenNhanVien = nhanVien.Split('|')[0].Trim();
			string ngaySinh = nhanVien.Split('|')[1].Trim();

			string queryTimNV = $"SELECT MaNhanVien FROM {DataProvider.NHANVIEN_TABLE} " +
				$"WHERE TenNhanVien = N'{tenNhanVien}' AND NgaySinh = '{ngaySinh}'";

			object obj = DataProvider.Instance.ExecuteScalar(queryTimNV);

			if (obj == null)
			{
				MaterialMessageBox.Show(
					text: "Tên nhân viên đã nhập không tồn tại",
					caption: this.GetType().ToString(),
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);
			}

			return Guid.Parse(obj.ToString());
		}

		//		MinhHieu Add: Tìm nhân viên theo TenNhanVien và NgaySinh
		public bool CheckNhanVienByTenNhanVienAndNgaySinh(string tenNhanVien, string ngaySinh)
		{
			if (!DateTime.TryParse(ngaySinh, out DateTime ngaySinhNhanVien))
			{
				return false;
			}

			string queryTimNV = $"SELECT * FROM {DataProvider.NHANVIEN_TABLE} " +
				$"WHERE TenNhanVien = N'{tenNhanVien}' AND NgaySinh = '{ngaySinhNhanVien}'";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(queryTimNV);

			return dataTable.Rows.Count > 0;
		}

		//		MinhHieu Add: Tìm xem có tài khoản nhân viên không
		public bool CheckNhanVienLogin(LoginDVO loginDVO)
		{
			string queryTimNV = $"SELECT * FROM {DataProvider.NHANVIEN_TABLE} " +
				$"WHERE Email = '{loginDVO.LoginDVO_Email}' AND MatKhau = '{loginDVO.LoginDVO_MatKhau}'";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(queryTimNV);

			return dataTable.Rows.Count > 0;
		}

        //Có nút tạo mới Nhân viên
        public bool InsertNhanVien(dynamic baseDTO)
        {
            NhanVienDTO NhanVienDTO = baseDTO as NhanVienDTO;
            
			//		Fix: Insert MaNhanVien, Email, MatKhau
			string insertNhanVien = "Insert into " +
                                DataProvider.NHANVIEN_TABLE +
                                " (MaNhanVien, MaCongViec, TenNhanVien, Email, MatKhau, NgaySinh, DiaChi, DienThoai, GioiTinh) VALUES (" +
                                    "N'" + NhanVienDTO.NhanVienDTO_MaNhanVien + "'," +
									"N'" + NhanVienDTO.NhanVienDTO_MaCongViec + "'," +
                                    "N'" + NhanVienDTO.NhanVienDTO_TenNhanVien + "'," +
									"N'" + NhanVienDTO.NhanVienDTO_Email + "'," +
									"N'" + NhanVienDTO.NhanVienDTO_MatKhau + "'," +
									"N'" + NhanVienDTO.NhanVienDTO_NgaySinh + "'," +
                                    "N'" + NhanVienDTO.NhanVienDTO_DiaChi + "'," +
                                    "N'" + NhanVienDTO.NhanVienDTO_DienThoai + "'," +
                                    "N'" + NhanVienDTO.NhanVienDTO_GioiTinh + "'" +
                                    ")";
            
			int rowChanged = DataProvider.Instance.ExecuteNonQuery(insertNhanVien);

			if (rowChanged > 0)
			{
				this.OnDAODatabaseChanged?.Invoke(this, new EventArgs());
			}

			return rowChanged > 0;
        }

        //Hiện danh sách nhân viên đã được nhập
        public List<NhanVienDTO> HienThiDanhSachNhanVien()
        {
            List<NhanVienDTO> danhSachNhanVien = new List<NhanVienDTO>();

            string query = "SELECT MaNhanVien, MaCongViec, TenNhanVien, NgaySinh, DiaChi, DienThoai, GioiTinh " +
							"FROM " + DataProvider.NHANVIEN_TABLE;

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in dataTable.Rows)
			{
				NhanVienDTO nhanVienDTO = new NhanVienDTO();

				nhanVienDTO.NhanVienDTO_MaNhanVien = (Guid)row[0];
				nhanVienDTO.NhanVienDTO_MaCongViec = (Guid)row[1];
				nhanVienDTO.NhanVienDTO_TenNhanVien = (string)row[2];
				nhanVienDTO.NhanVienDTO_NgaySinh = (DateTime)row[3];
				nhanVienDTO.NhanVienDTO_DiaChi = (string)row[4];
				nhanVienDTO.NhanVienDTO_DienThoai = (string)row[5];
				nhanVienDTO.NhanVienDTO_GioiTinh = (string)row[6];

				//Debug.WriteLine(nhanVienDTO.GetFullString());

				danhSachNhanVien.Add(nhanVienDTO);
			}

			return danhSachNhanVien;
        }        

    }

}
