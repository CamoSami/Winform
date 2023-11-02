using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects;
using static WinformWithExternalLibrary.DataTransferObjects.CustomDTO.PhanTichDTO;

namespace WinformWithExternalLibrary.DataAccessObjects
{
 
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

        public List<ProductsBestSellerResponseDTO> GetRankProductsByMonth(int rank)
        {
            List<ProductsBestSellerResponseDTO> productsBestSeller = new List<ProductsBestSellerResponseDTO>();

            string query = "WITH RankedProducts AS (" +
                "SELECT MaSanPham, TenSanPham, SUM(SoLuong) AS SoLuongBan, MONTH(NgayBan) AS Thang, ROW_NUMBER() OVER (PARTITION BY MONTH(NgayBan) ORDER BY SUM(SoLuong) DESC) AS RowNum" +
                " FROM tDMSanPham" +
                " INNER JOIN tChiTietHDBan ON tDMSanPham.MaDMSanPham = tChiTietHDBan.MaDMSanPham" +
                " INNER JOIN tHoaDonBan ON tChiTietHDBan.MaHDBan = tHoaDonBan.MaHDBan" +
                " WHERE YEAR(tHoaDonBan.NgayBan) = YEAR(GETDATE())" +
                " GROUP BY" +
				" MaSanPham, TenSanPham, MONTH(NgayBan))" +
                $"SELECT MaSanPham, TenSanPham, Thang, SoLuongBan FROM RankedProducts WHERE RowNum = {rank};";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                ProductsBestSellerResponseDTO productBestSeller = new ProductsBestSellerResponseDTO();
                productBestSeller.ProductsBestSellerResponseDTO_MaSanPham = (string)row[0];
                productBestSeller.ProductsBestSellerResponseDTO_TenSanPham = (string)row[1];
                productBestSeller.ProductsBestSellerResponseDTO_Thang = (int)row[2];
                productBestSeller.ProductsBestSellerResponseDTO_SoLuongBan = (int)row[3];

                productsBestSeller.Add(productBestSeller);
            }

            return productsBestSeller;
        }
    }
}
