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
using WinformWithExternalLibrary._DataProvider;

namespace WinformWithExternalLibrary.DataAccessObjects
{
    public class NhanVienDAO
	{
		public event EventHandler OnDAODatabaseChanged;

		public static NhanVienDAO Instance { get; set; }

        public NhanVienDAO() { }

		// Kiểm tra nhân viên có trong bảng hóa đơn bán hoặc bảng hóa đơn nhập không 
		public bool IsInOtherTable(string employeeCode)
		{
			// Kiểm tra xem mã nhân viên có trong bảng HoaDonBan không
			string queryHoaDonBan = $"SELECT COUNT(*) FROM {DataProvider.HOADONBAN_TABLE} WHERE MaNhanVien = '{employeeCode}'";
			int countHoaDonBan = (int)DataProvider.Instance.ExecuteScalar(queryHoaDonBan);

			// Kiểm tra xem mã nhân viên có trong bảng HoaDonNhap không
			string queryHoaDonNhap = $"SELECT COUNT(*) FROM {DataProvider.HOADONNHAP_TABLE} WHERE MaNhanVien = '{employeeCode}'";
			int countHoaDonNhap = (int)DataProvider.Instance.ExecuteScalar(queryHoaDonNhap);

			// Trả về true nếu mã nhân viên tồn tại trong ít nhất một bảng, ngược lại trả về false
			return countHoaDonBan > 0 || countHoaDonNhap > 0;
		}

		//		Check MatKhau
		public bool CheckMatKhauNhanVien(Guid maNhanVien, string matKhau)
		{
			string queryListNV = $"SELECT MaNhanVien FROM {DataProvider.NHANVIEN_TABLE} " +
				$"WHERE MaNhanVien = {maNhanVien} " +
				$"AND MatKhau = {matKhau}";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(queryListNV);

			return dataTable.Rows.Count > 0;
		}

		//Lấy thông tin nhân viên
		public List<NhanVienDTO> GetListNV()
		{
			string querylistNV = $"SELECT  MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DienThoai, DiaChi, Email FROM {DataProvider.NHANVIEN_TABLE} ORDER BY TenNhanVien";

			//Debug.WriteLine(querylistNV);

			DataTable dtNV = DataProvider.Instance.ExecuteQuery(querylistNV);

			List<NhanVienDTO> listNVs = new List<NhanVienDTO>();

			foreach (DataRow dr in dtNV.Rows)
			{
				//Debug.WriteLine("new NhanVienDTO");

				NhanVienDTO nhanVienDTO = new NhanVienDTO();

				nhanVienDTO.NhanVienDTO_MaNhanVien = (Guid)dr[0];
				nhanVienDTO.NhanVienDTO_TenNhanVien = dr[1].ToString();
				nhanVienDTO.NhanVienDTO_NgaySinh = (DateTime)dr[2];
				nhanVienDTO.NhanVienDTO_GioiTinh = dr[3].ToString();
				nhanVienDTO.NhanVienDTO_DienThoai = dr[4].ToString();
				nhanVienDTO.NhanVienDTO_DiaChi = dr[5].ToString();
				nhanVienDTO.NhanVienDTO_Email = dr[6].ToString();

				listNVs.Add(nhanVienDTO);
			}

			return listNVs;
		}

		// Xóa nhân viên dựa vào mã nhân viên
		public bool XoaNhanVienTheoMa(string maNhanVien)
		{
			string query = $"DELETE FROM {DataProvider.NHANVIEN_TABLE} WHERE MaNhanVien = '{maNhanVien}'";
			int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query);

			if (rowsAffected > 0)
			{
				// Gửi sự kiện thông báo rằng cơ sở dữ liệu đã thay đổi
				this.OnDAODatabaseChanged?.Invoke(this, new EventArgs());

				return true; // Xóa thành công
			}

			return false; // Xóa không thành công
		}

		// Lấy nhân viên bằng mã nhân viên 
		public CustomNhanVienDTO GetNhanVienByID(Guid id)
		{
			string query = $"SELECT MaNhanVien,TenNhanVien, NgaySinh, DienThoai, GioiTinh, DiaChi, TenCongViec, Email " +
						   $"FROM {DataProvider.NHANVIEN_TABLE} " +
						   $"JOIN {DataProvider.CONGVIEC_TABLE} ON {DataProvider.NHANVIEN_TABLE}.MaCongViec = {DataProvider.CONGVIEC_TABLE}.MaCongViec " +
						   $"WHERE {DataProvider.NHANVIEN_TABLE}.MaNhanVien = '{id}'";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

			if (dataTable.Rows.Count > 0)
			{
				DataRow dataRow = dataTable.Rows[0];

				// Tạo đối tượng NhanVienDTOcustom và gán giá trị từ dòng dữ liệu
				CustomNhanVienDTO nhanVienDTOcustom = new CustomNhanVienDTO
				{
					NhanVienDTO_MaNhanVien = (Guid)dataRow["MaNhanVien"],
					NhanVienDTO_TenNhanVien = dataRow["TenNhanVien"].ToString(),
					NhanVienDTO_NgaySinh = DateTime.Parse(dataRow["NgaySinh"].ToString()),
					NhanVienDTO_DienThoai = dataRow["DienThoai"].ToString(),
					NhanVienDTO_GioiTinh = dataRow["GioiTinh"].ToString(),
					NhanVienDTO_DiaChi = dataRow["DiaChi"].ToString(),
					NhanVienDTO_TenCongViec = dataRow["TenCongViec"].ToString(),
					NhanVienDTO_Email = dataRow["Email"].ToString(),
				};

				// Trả về đối tượng NhanVienDTOcustom
				return nhanVienDTOcustom;
			}

			// Trả về null nếu không tìm thấy nhân viên có mã tương ứng
			return null;


		}

		// Update bảng nhân viên 
		public bool UpdateNhanVien(NhanVienDTO nhanVienDTO)
		{

			string query = $"UPDATE {DataProvider.NHANVIEN_TABLE} " +
						   $"SET TenNhanVien = N'{nhanVienDTO.NhanVienDTO_TenNhanVien}', " +
						   $"NgaySinh = '{nhanVienDTO.NhanVienDTO_NgaySinh.ToString("yyyy-MM-dd")}', " +
						   $"DienThoai = N'{nhanVienDTO.NhanVienDTO_DienThoai}', " +
						   $"GioiTinh = N'{nhanVienDTO.NhanVienDTO_GioiTinh}', " +
						   $"DiaChi = N'{nhanVienDTO.NhanVienDTO_DiaChi}', " +
						   $"Email = N'{nhanVienDTO.NhanVienDTO_Email}' " +
						   $"WHERE MaNhanVien = '{nhanVienDTO.NhanVienDTO_MaNhanVien}'";

			int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query);

			return rowsAffected > 0;


		}

		public DataTable GetNhanVienWithInput(string input)
		{
			string query;

			if (input != "")
			{
				query = $"SELECT MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DienThoai, DiaChi, Email" +
					$" FROM {DataProvider.NHANVIEN_TABLE} WHERE TenNhanVien LIKE N'%{input}%' ORDER BY TenNhanVien";
			}
			else
			{
				query = $"SELECT MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DienThoai, DiaChi, Email" +
					$" FROM {DataProvider.NHANVIEN_TABLE} ORDER BY TenNhanVien";
			}

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

			return dataTable;
		}

		// Tìm Nhân Viên theo  tên nhân viên
		public List<NhanVienDTO> TimNhanVienTheoMaNhanVienHoacTenNhanVien(string input)
		{
			string query = $"SELECT MaNhanVien, TenNhanVien, NgaySinh, GioiTinh, DienThoai, DiaChi, Email" +
				$" FROM {DataProvider.NHANVIEN_TABLE} WHERE TenNhanVien LIKE N'%{input}%' ORDER BY TenNhanVien";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

			List<NhanVienDTO> listNhanVien = new List<NhanVienDTO>();

			foreach (DataRow row in dataTable.Rows)
			{
				NhanVienDTO nhanVien = new NhanVienDTO();

				nhanVien.NhanVienDTO_MaNhanVien = (Guid)row["MaNhanVien"];
				nhanVien.NhanVienDTO_TenNhanVien = row["TenNhanVien"].ToString();
				nhanVien.NhanVienDTO_NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
				nhanVien.NhanVienDTO_GioiTinh = row["GioiTinh"].ToString();
				nhanVien.NhanVienDTO_DienThoai = row["DienThoai"].ToString();
				nhanVien.NhanVienDTO_DiaChi = row["DiaChi"].ToString();
				nhanVien.NhanVienDTO_Email = row["EMail"].ToString();

				listNhanVien.Add(nhanVien);
			}

			return listNhanVien;
		}


		//		MinhHieu Add: Lấy danh sách TenNhanVien và NgaySinh nhân viên
		public List<string> GetTenNhanVienAndNgaySinhList()
		{
			string queryListNV = $"SELECT TenNhanVien, NgaySinh FROM {DataProvider.NHANVIEN_TABLE} ORDER BY TenNhanVien";

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
							"FROM " + DataProvider.NHANVIEN_TABLE + " ORDER BY TenNhanVien";

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
