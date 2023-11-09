using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects;
using WinformWithExternalLibrary._DataProvider;
using System.Data;

namespace WinformWithExternalLibrary.DataAccessObjects
{
    public class CongViecDAO
    {
        public static CongViecDAO Instance { get; set; }
        public CongViecDAO() { }

		//		Hieu Add
		public List<string> GetTenCongViec()
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
                                    "N'" + CongViecDTO.CongViecDTO_MucLuong + "'" +
                                    "N'" + CongViecDTO.CongViecDTO_TenCongViec + "'" +        
                                    ")";
            
			int rowChanged = DataProvider.Instance.ExecuteNonQuery(insertCongViec);
            
			return rowChanged > 0;
        }

    }
}
