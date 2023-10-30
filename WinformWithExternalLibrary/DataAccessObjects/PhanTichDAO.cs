using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects;

namespace WinformWithExternalLibrary.DataAccessObjects
{
	//		Bạn vẫn có thể cho cái này thành DTO:
	//			+ Nó chỉ làm việc bên Database
	//			+ Nó không xuất hiện ở Form, hay validate
    public class RevenueResponseDTO
    {
        public int RevenueResponseDTO_Ngay { get; set; }
        public long RevenueResponseDTO_DoanhThu { get; set; }
    }

    internal class PhanTichDAO
    {
        public static PhanTichDAO Instance { get; set; }

        public PhanTichDAO() { }

        public List<RevenueResponseDTO> GetDailyRevenueByThisMonth()
        {
            List<RevenueResponseDTO> listRevenueThisMonth = new List<RevenueResponseDTO>();

            string query = "SELECT DATEPART(DAY, tHoaDonBan.NgayBan) AS Ngay, SUM(TongTien - GiamGia) AS DoanhThu " +
                "FROM tHoaDonBan " +
                "WHERE YEAR(tHoaDonBan.NgayBan) = YEAR(GETDATE()) AND MONTH(tHoaDonBan.NgayBan) = MONTH(GETDATE()) " +
                "GROUP BY DATEPART(DAY, tHoaDonBan.NgayBan)";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                RevenueResponseDTO revanueResponseDTO = new RevenueResponseDTO();
                revanueResponseDTO.RevenueResponseDTO_Ngay = (int)row[0];
                revanueResponseDTO.RevenueResponseDTO_DoanhThu = (long)row[1];

                listRevenueThisMonth.Add(revanueResponseDTO);
            }

            Debug.WriteLine(listRevenueThisMonth.Count());
            return listRevenueThisMonth;
        }

        public List<RevenueResponseDTO> GetDailyRevenueByLastMonth()
        {
            List<RevenueResponseDTO> listRevenueLastMonth = new List<RevenueResponseDTO>();

            int lastMonth = DateTime.Now.Month - 1;
            int year = DateTime.Now.Year;

            if (lastMonth == 0)
            {
                lastMonth = 12;
                year--;
            }

            string query = "SELECT DATEPART(DAY, tHoaDonBan.NgayBan) AS Ngay, SUM(TongTien - GiamGia) AS DoanhThu " +
                "FROM tHoaDonBan " +
                $"WHERE YEAR(tHoaDonBan.NgayBan) = {year} AND MONTH(tHoaDonBan.NgayBan) = {lastMonth} " +
                "GROUP BY DATEPART(DAY, tHoaDonBan.NgayBan)";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                RevenueResponseDTO revenueResponseDTO = new RevenueResponseDTO();
                revenueResponseDTO.RevenueResponseDTO_Ngay = (int)row[0];
                revenueResponseDTO.RevenueResponseDTO_DoanhThu = (long)row[1];

                listRevenueLastMonth.Add(revenueResponseDTO);
            }

            Debug.WriteLine(listRevenueLastMonth.Count());
            return listRevenueLastMonth;
        }
    }
}
