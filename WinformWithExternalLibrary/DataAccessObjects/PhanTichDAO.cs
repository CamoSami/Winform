using LiveChartsCore.Themes;
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

        public int CountBillOfSellCurrentMonth()
        {
            string query = "SELECT COUNT(*) from tHoaDonBan " +
                "WHERE YEAR(NgayBan) = YEAR(GETDATE()) AND MONTH(NgayBan) = MONTH(GETDATE());";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            int countBillOfSellCurrentMonth = (int)dataTable.Rows[0][0];

            return countBillOfSellCurrentMonth;
        }

        public long GetRevenueCurrentMonth()
        {
            string query = "WITH RevenueOneDays AS (" +
                "SELECT SUM(TongTien - GiamGia) AS DoanhThuNgay " +
                "FROM tHoaDonBan " +
                "WHERE YEAR(tHoaDonBan.NgayBan) = YEAR(GETDATE()) AND MONTH(tHoaDonBan.NgayBan) = MONTH(GETDATE())" +
                ")" +
                "SELECT SUM(DoanhThuNgay) AS DoanhThuThangNay " +
                "FROM RevenueOneDays;";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            long revenueCurrentMonth = 0;

            if (dataTable.Rows[0][0] != null)
            {
                if (long.TryParse(dataTable.Rows[0][0].ToString(), out long result))
                {
                    revenueCurrentMonth = result;
                }
            }

            return revenueCurrentMonth;
        }

        public long GetDiscountTotalCurrentMonth()
        {
            string query = "SELECT SUM(tHoaDonBan.GiamGia) AS TongTienGiamGiaThangNay " +
                "FROM tHoaDonBan " +
                "WHERE YEAR(tHoaDonBan.NgayBan) = YEAR(GETDATE()) AND MONTH(tHoaDonBan.NgayBan) = MONTH(GETDATE());";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            long discountTotalCurrentMonth = 0;

            if (dataTable.Rows[0][0] != null)
            {
                if (long.TryParse(dataTable.Rows[0][0].ToString(), out long result))
                {
                    discountTotalCurrentMonth = result; 
                }
            }

            return discountTotalCurrentMonth;
        }

        public long GetPriceTotalCurrentMonth()
        {
            string query = "SELECT SUM(tHoaDonBan.TongTien) AS TongTienThang " +
                "FROM tHoaDonBan " +
                "WHERE YEAR(tHoaDonBan.NgayBan) = YEAR(GETDATE()) AND MONTH(tHoaDonBan.NgayBan) = MONTH(GETDATE());";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            long priceTotalCurrentMonth = 0;

            if (dataTable.Rows[0][0] != null)
            {
                if (long.TryParse(dataTable.Rows[0][0].ToString(), out long result))
                {
                    priceTotalCurrentMonth = result;
                }
            }

            return priceTotalCurrentMonth;
        }

        public DataTable GetBillsOfSellerInformationDataTable()
        {
            string query = "SELECT MaHDBan, TenNhanVien, tNhanVien.DienThoai AS DienThoaiNV, TenKhachHang, tKhachHang.DienThoai AS DienThoaiKH, SoSanPham, GiamGia, TongTien, NgayBan " +
                "FROM tHoaDonBan " +
                "INNER JOIN tKhachHang " +
                "ON tHoaDonBan.MaKhachHang = tKhachHang.MaKhachHang " +
                "INNER JOIN tNhanVien " +
                "ON tHoaDonBan.MaNhanVien = tNhanVien.MaNhanVien;";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            return dataTable;
        }

        public List<BillsOfSellerInfoResponseDTO> GetBillsOfSellerInformation()
        {
            DataTable dataTable = this.GetBillsOfSellerInformationDataTable();

            List<BillsOfSellerInfoResponseDTO> billsOfSellerInfoResponseDTOs = new List<BillsOfSellerInfoResponseDTO>();
            foreach (DataRow row in dataTable.Rows)
            {
                BillsOfSellerInfoResponseDTO billsOfSellerInfoResponseDTO = new BillsOfSellerInfoResponseDTO();
                billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_MaHDBan = row[0].ToString();
                billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_TenNhanVien = row[1].ToString();
                billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_DienThoaiNV = row[2].ToString();
                billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_TenKhachHang = row[3].ToString();
                billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_DienThoaiKH = row[4].ToString();
                billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_SoSanPham = (int)row[5];
                billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_GiamGia = (long)row[6];
                billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_TongTien = (long)row[7];
                billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_NgayBan = (DateTime)row[8];

                billsOfSellerInfoResponseDTOs.Add(billsOfSellerInfoResponseDTO);
            }
            return billsOfSellerInfoResponseDTOs;
        }

        public List<BillDetailInfomationDTO> GetBillsDetailInformation(string MaHoaDon)
        {
            string query = "SELECT tChiTietHDBan.MaDMSanPham AS MaDMSanPham, TenHangHoa, SoLuong, ThanhTien FROM " +
                "tChiTietHDBan " +
                "INNER JOIN tDMSanPham " +
                $"ON tDMSanPham.MaDMSanPham = tChiTietHDBan.MaDMSanPham AND tChiTietHDBan.MaHDBan = '{MaHoaDon}'";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            List<BillDetailInfomationDTO> billDetailInfoResponseDTOs = new List<BillDetailInfomationDTO>();
            foreach (DataRow row in dataTable.Rows)
            {
                BillDetailInfomationDTO billDetailInfomationDTO = new BillDetailInfomationDTO();

                billDetailInfomationDTO.BillDetailInfomationDTO_MaDMSanPham = row[0].ToString();
                billDetailInfomationDTO.BillDetailInfomationDTO_TenHangHoa = row[1].ToString();
                billDetailInfomationDTO.BillDetailInfomationDTO_SoLuong = (int)row[2];
                billDetailInfomationDTO.BillDetailInfomationDTO_ThanhTien = (long)row[3];

                billDetailInfoResponseDTOs.Add(billDetailInfomationDTO);
            }

            return billDetailInfoResponseDTOs;
        }
    }
}
