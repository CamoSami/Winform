using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects;
using WinformWithExternalLibrary._DataProvider;
using System.Data;
using System.Diagnostics;

namespace WinformWithExternalLibrary.DataAccessObjects
{
    public class CongViecDAO
	{
		public event EventHandler OnDAODatabaseChanged;

		public static CongViecDAO Instance { get; set; }
        public CongViecDAO() { }

		//		Hieu Add
		public Guid GetMaCongViecFromTenCongViec(string tenCongViec)
		{
			string queryGetTenCongViec = $"SELECT MaCongViec FROM {DataProvider.CONGVIEC_TABLE} WHERE TenCongViec = N'{tenCongViec}'";

			object obj = DataProvider.Instance.ExecuteScalar(queryGetTenCongViec);
			Debug.WriteLine(queryGetTenCongViec);
			Debug.WriteLine(obj);

			if (obj == null)
			{
				return Guid.Empty;
			}

			if (!Guid.TryParse(obj.ToString(), out Guid result))
			{
				result = Guid.Empty;
			}

			return result;
		}

		//		Hieu Add
		public List<string> GetTenCongViecList()
		{
			string queryGetTenCongViec = $"SELECT TenCongViec FROM {DataProvider.CONGVIEC_TABLE} ";

			DataTable dataTable = DataProvider.Instance.ExecuteQuery(queryGetTenCongViec);

			List<string> result = new List<string>();

			foreach (DataRow row in dataTable.Rows)
			{
				result.Add(row[0].ToString());
			}

			return result;
		}

        public bool InsertCongViec(dynamic baseDTO)
        {
            CongViecDTO CongViecDTO = baseDTO as CongViecDTO;

            string insertCongViec = "Insert into " +
                                DataProvider.NHANVIEN_TABLE +
                                " (MaCongViec, MucLuong, TenCongViec) VALUES (" +
                                    "N'" + CongViecDTO.CongViecDTO_MaCongViec + "'" +
									"N'" + CongViecDTO.CongViecDTO_MucLuong + "'" +
                                    "N'" + CongViecDTO.CongViecDTO_TenCongViec + "'" +        
                                    ")";
            
			int rowChanged = DataProvider.Instance.ExecuteNonQuery(insertCongViec);

			if (rowChanged > 0)
			{
				this.OnDAODatabaseChanged?.Invoke(this, EventArgs.Empty);
			}
            
			return rowChanged > 0;
        }
    }
}
