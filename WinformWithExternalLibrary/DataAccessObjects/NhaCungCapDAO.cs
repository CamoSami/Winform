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
using WinformWithExternalLibrary._DataProvider;

namespace WinformWithExternalLibrary.DataAccessObjects
{
    public class NhaCungCapDAO
	{
		public event EventHandler OnDAODatabaseChanged;

		public static NhaCungCapDAO Instance { get; set; }

        public NhaCungCapDAO() { }

		public bool DeleteNhaCungCap(Guid maNhaCungCap)
		{
			string xoaNhaCungCap = $"DELETE FROM {DataProvider.NHACUNGCAP_TABLE} " +
				$"WHERE MaNhaCungCap = '{maNhaCungCap}'";

			Debug.WriteLine(xoaNhaCungCap);
			int rowChanged = DataProvider.Instance.ExecuteNonQuery(xoaNhaCungCap);

			return rowChanged > 0;
		}

		public bool CheckIfNhaCungCapHasHDNhap(Guid maNhaCungCap)
		{
			string check = $"SELECT MaHDNhap FROM {DataProvider.HOADONNHAP_TABLE} " +
				$"WHERE MaNhaCungCap = '{maNhaCungCap}'";
			Debug.WriteLine(check);

			object temp = DataProvider.Instance.ExecuteScalar(check);

			return temp != null;
		}

		public Guid GetMaNhaCungCapWithPhoneNumbers(string phoneNumber)
		{
			string selectSupplier = $"SELECT MaNhaCungCap FROM " +
				$"{DataProvider.NHACUNGCAP_TABLE} " +
				$"WHERE DienThoai = '{phoneNumber}'";

			//Debug.WriteLine(selectSupplier);

			object supplier = DataProvider.Instance.ExecuteScalar(selectSupplier);

			if (supplier == null)
			{
				return Guid.Empty;
			}

			if (!Guid.TryParse(supplier.ToString(), out Guid result))
			{
				result = Guid.Empty;
			}

			return result;
		}

		public string GetNameWithPhoneNumber(string phoneNumber)
        {
			if (phoneNumber == null)
			{
				return "";
			}

            string selectSupplier = $"SELECT TenNhaCungCap FROM " +
                $"{DataProvider.NHACUNGCAP_TABLE} " +
                $"WHERE DienThoai = '{phoneNumber}'";
            
            object supplier = DataProvider.Instance.ExecuteScalar(selectSupplier);

            return supplier != null ? supplier.ToString().Trim() : "";
        }

        public List<string> GetPhoneNumbers()
        {
            string selectPhoneNumber = $"SELECT DienThoai FROM " +
                $"{DataProvider.NHACUNGCAP_TABLE}";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(selectPhoneNumber);
            
            List<string> phoneNumbers = new List<string>();

            foreach (DataRow row in dataTable.Rows)
            {
                phoneNumbers.Add(row[0].ToString().Trim());
            }

            return phoneNumbers;
        }

        public bool CheckIfPhoneNumberExist(string NhaCungCapDVO_DienThoai)
        {
            string selectPhoneNumber = $"SELECT * FROM " +
                $"{DataProvider.NHACUNGCAP_TABLE}" +
                $" WHERE DienThoai = " +
                $"'{NhaCungCapDVO_DienThoai}'";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(selectPhoneNumber);

            return dataTable.Rows.Count > 0;
        }

        public bool InsertNhaCungCap(dynamic baseDTO)
        {
            NhaCungCapDVO nhaCungCapDVO = baseDTO as NhaCungCapDVO;

			Guid NhaCungCapDVO_MaNhaCungCap = Guid.NewGuid();

			string insertSupplier = $"INSERT INTO " +
                $"{DataProvider.NHACUNGCAP_TABLE} " +
                $"(MaNhaCungCap, TenNhaCungCap, DienThoai, DiaChi) " +
                $"VALUES(" +
				$"N'{NhaCungCapDVO_MaNhaCungCap}'," +
				$"N'{nhaCungCapDVO.NhaCungCapDVO_TenNhaCungCap}'," +
                $" '{nhaCungCapDVO.NhaCungCapDVO_DienThoai}', " +
                $"N'{nhaCungCapDVO.NhaCungCapDVO_DiaChi}')";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(insertSupplier);

			if (rowChanged > 0)
			{
				this.OnDAODatabaseChanged?.Invoke(this, new EventArgs());
			}

			return rowChanged > 0;
		}

		public DataTable QueryAllNhaCungCap()
		{
			string query = $"SELECT * FROM {DataProvider.NHACUNGCAP_TABLE} ORDER BY TenNhaCungCap";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

			return dataTable;
		}

		public bool UpdateNhaCungCap(string TenNhaCungCap, string DiaChi, string DienThoai)
		{
			string query = $"UPDATE {DataProvider.NHACUNGCAP_TABLE} " +
				$"SET TenNhaCungCap = N'{TenNhaCungCap}' " +
				$"DiaChi = N'{DiaChi}' " +
				$"WHERE DienThoai = {DienThoai}";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(query);

			if (rowChanged > 0)
			{
				this.OnDAODatabaseChanged?.Invoke(this, new EventArgs());
			}

			return rowChanged > 0;
		}

		public DataTable NhaCungCapInformationFromPhoneNumber(string NhaCungCapDVO_DienThoai)
		{
			string selectDienThoai = "SELECT * FROM " +
							DataProvider.NHACUNGCAP_TABLE +
							" WHERE DienThoai = " +
							"'" + NhaCungCapDVO_DienThoai + "'";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(selectDienThoai);

			return dataTable;
		}

		public bool UpdateNhaCungCapFull(dynamic baseDTO, string DienThoai)
		{
			NhaCungCapDVO nhaCungCapDVO = baseDTO as NhaCungCapDVO;

			Guid NhaCungCapDVO_MaNhaCungCap = Guid.NewGuid();

			string update = $"UPDATE {DataProvider.NHACUNGCAP_TABLE} " +
				$"SET TenNhaCungCap = N'{nhaCungCapDVO.NhaCungCapDVO_TenNhaCungCap}', " +
				$"DiaChi = N'{nhaCungCapDVO.NhaCungCapDVO_DiaChi}', " +
				$"DienThoai = N'{nhaCungCapDVO.NhaCungCapDVO_DienThoai}' " +
				$"WHERE DienThoai = N'{DienThoai}'";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(update);

			if (rowChanged > 0)
			{
				this.OnDAODatabaseChanged?.Invoke(this, new EventArgs());
			}

			return rowChanged > 0;
		}

		public DataTable NhaCungCapInformationFromSearch(NhaCungCapDVO nhaCungCapDVO)
		{
			string temp = "";

			if (nhaCungCapDVO.NhaCungCapDVO_TenNhaCungCap != "")
			{
				if (temp != "")
				{
					temp += " AND";
				}

				temp += $" TenNhaCungCap LIKE N'%{nhaCungCapDVO.NhaCungCapDVO_TenNhaCungCap}%'";
			}
			if (nhaCungCapDVO.NhaCungCapDVO_DiaChi != "")
			{
				if (temp != "")
				{
					temp += " AND";
				}

				temp += $" DiaChi LIKE N'%{nhaCungCapDVO.NhaCungCapDVO_DiaChi}%'";
			}
			if (nhaCungCapDVO.NhaCungCapDVO_DienThoai != "")
			{
				if (temp != "")
				{
					temp += " AND";
				}

				temp += $" DienThoai LIKE N'%{nhaCungCapDVO.NhaCungCapDVO_DienThoai}%'";
			}

			if (temp == "")
			{
				return new DataTable();
			}

			string selectNhaCungCap = $"SELECT * FROM {DataProvider.NHACUNGCAP_TABLE} WHERE" + temp + " ORDER BY TenNhaCungCap";

			Debug.WriteLine(selectNhaCungCap);

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(selectNhaCungCap);

			return dataTable;
		}

		public DataTable NhaCungCapInformationFromName(string NhaCungCapDVO_TenNhaCungCap)
		{
			string selectNhaCungCap = "SELECT * FROM " +
							DataProvider.NHACUNGCAP_TABLE +
							" WHERE TenNhaCungCap = " +
							"N'" + NhaCungCapDVO_TenNhaCungCap + "' ORDER BY TenNhaCungCap";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(selectNhaCungCap);

			return dataTable;
		}
	}
}
