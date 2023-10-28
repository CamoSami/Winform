using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects;

namespace WinformWithExternalLibrary.DataAccessObjects
{
    public class CongViecDAO
    {
        public static CongViecDAO Instance { get; set; }
        public CongViecDAO() { }

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
