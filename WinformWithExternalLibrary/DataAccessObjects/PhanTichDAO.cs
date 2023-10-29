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
    public class RevenueResponse
    {
        public int Ngay { get; set; }
        public long DoanhThu { get; set; }
    }

    internal class PhanTichDAO
    {
        public static PhanTichDAO Instance { get; set; }

        public PhanTichDAO() { }

        public List<RevenueResponse> GetDailyRevenueByThisMonth()
        {
            List<RevenueResponse> listRevenueThisMonth = new List<RevenueResponse>();

            string query = "SELECT DATEPART(DAY, tHoaDonBan.NgayBan) AS Ngay, SUM(TongTien - GiamGia) AS DoanhThu " +
                "FROM tHoaDonBan " +
                "WHERE YEAR(tHoaDonBan.NgayBan) = YEAR(GETDATE()) AND MONTH(tHoaDonBan.NgayBan) = MONTH(GETDATE()) " +
                "GROUP BY DATEPART(DAY, tHoaDonBan.NgayBan)";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                RevenueResponse revanueResponse = new RevenueResponse();
                revanueResponse.Ngay = (int)row[0];
                revanueResponse.DoanhThu = (long)row[1];

                listRevenueThisMonth.Add(revanueResponse);
            }

            Debug.WriteLine(listRevenueThisMonth.Count());
            return listRevenueThisMonth;
        }

        public List<RevenueResponse> GetDailyRevenueByLastMonth()
        {
            List<RevenueResponse> listRevenueLastMonth = new List<RevenueResponse>();

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
                RevenueResponse revenueResponse = new RevenueResponse();
                revenueResponse.Ngay = (int)row[0];
                revenueResponse.DoanhThu = (long)row[1];

                listRevenueLastMonth.Add(revenueResponse);
            }

            Debug.WriteLine(listRevenueLastMonth.Count());
            return listRevenueLastMonth;
        }
    }
}
