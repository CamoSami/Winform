using LiveChartsCore.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataTransferObjects;
using static WinformWithExternalLibrary.DataTransferObjects.PhanTichDTO;
using WinformWithExternalLibrary._DataProvider;

namespace WinformWithExternalLibrary.DataAccessObjects
{
 
    public class PhanTichDAO
	{
		public static PhanTichDAO Instance { get; set; }

        public PhanTichDAO() { }

        // Charts
        public List<RevenueResponseDTO> GetDailyRevenueByThisMonth()
        {
            List<RevenueResponseDTO> listRevenueThisMonth = new List<RevenueResponseDTO>();

            string query = "SELECT DATEPART(DAY, tHoaDonBan.NgayBan) AS Ngay, SUM(TongTien) AS DoanhThu " +
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

            string query = "SELECT DATEPART(DAY, tHoaDonBan.NgayBan) AS Ngay, SUM(TongTien) AS DoanhThu " +
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

        public List<InventoryArrangementResponseDTO> GetInventoryArrangementResponseDTOs()
        {
            string query = "SELECT MaSanPham, TenSanPham, SoLuongTonKho " +
                "FROM tDMSanPham " +
                "ORDER BY SoLuongTonKho DESC;";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            List<InventoryArrangementResponseDTO> inventoryArrangementResponseDTOs = new List<InventoryArrangementResponseDTO>();
            foreach (DataRow row in dataTable.Rows)
            {
                InventoryArrangementResponseDTO inventoryArrangementResponseDTO = new InventoryArrangementResponseDTO();

                inventoryArrangementResponseDTO.InventoryArrangementResponseDTO_MaSanPham = row[0].ToString();
                inventoryArrangementResponseDTO.InventoryArrangementResponseDTO_TenSanPham = (string)row[1];
                inventoryArrangementResponseDTO.InventoryArrangementResponseDTO_SoLuongTonKho = (int)row[2];

                inventoryArrangementResponseDTOs.Add(inventoryArrangementResponseDTO);
            }

            return inventoryArrangementResponseDTOs;
        }

        public List<SalaryArrangementResponseDTO> GetSalaryArrangementResponseDTOs()
        {
            string query = "SELECT * FROM tCongViec " +
                "ORDER BY MucLuong DESC";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            List<SalaryArrangementResponseDTO> salaryArrangementResponseDTOs = new List<SalaryArrangementResponseDTO>();
            foreach (DataRow row in dataTable.Rows)
            {
                SalaryArrangementResponseDTO salaryArrangementResponseDTO = new SalaryArrangementResponseDTO();

                salaryArrangementResponseDTO.SalaryArrangementResponseDTO_MaCongViec = row[0].ToString();
                salaryArrangementResponseDTO.SalaryArrangementResponseDTO_Luong = (long)row[1];
                salaryArrangementResponseDTO.SalaryArrangementResponseDTO_TenCongViec = (string)row[2];

                salaryArrangementResponseDTOs.Add(salaryArrangementResponseDTO);
            }

            return salaryArrangementResponseDTOs;
        }

        // Bill of sell
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
            string query = "SELECT SUM(TongTien) AS DoanhThuThangNay " +
                "FROM tHoaDonBan " +
                "WHERE YEAR(tHoaDonBan.NgayBan) = YEAR(GETDATE()) AND MONTH(tHoaDonBan.NgayBan) = MONTH(GETDATE())";

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

        public double GetDiscountTotalCurrentMonth()
        {
            string query = "SELECT SUM((tHoaDonBan.TongTien / (1 - tGiamGia.PhanTramGiamGia )) * tGiamGia.PhanTramGiamGia) " +
                "FROM tHoaDonBan " +
                "INNER JOIN tGiamGia " +
                "ON tHoaDonBan.MaGiamGia = tGiamGia.MaGiamGia " +
                "WHERE YEAR(tHoaDonBan.NgayBan) = YEAR(GETDATE()) AND MONTH(tHoaDonBan.NgayBan) = MONTH(GETDATE()) AND GETDATE() >= NgayBatDau AND GETDATE() <= NgayKetThuc;";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            double discountTotalCurrentMonth = 0;

            if (dataTable.Rows[0][0] != null)
            {
                if (double.TryParse(dataTable.Rows[0][0].ToString(), out double result))
                {
                    discountTotalCurrentMonth = result; 
                }
            }

            return Math.Round(discountTotalCurrentMonth);
        }

        public double GetPriceTotalCurrentMonth()
        {
            string query = "SELECT SUM(tHoaDonBan.TongTien / (1 - tGiamGia.PhanTramGiamGia )) AS TongTienThang " +
                "FROM tHoaDonBan " +
                "INNER JOIN tGiamGia " +
                "ON tHoaDonBan.MaGiamGia = tGiamGia.MaGiamGia " +
                "WHERE YEAR(tHoaDonBan.NgayBan) = YEAR(GETDATE()) AND MONTH(tHoaDonBan.NgayBan) = MONTH(GETDATE()) AND GETDATE() >= NgayBatDau AND GETDATE() <= NgayKetThuc;";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            double priceTotalCurrentMonth = 0;

            if (dataTable.Rows[0][0] != null)
            {
                if (double.TryParse(dataTable.Rows[0][0].ToString(), out double result))
                {
                    priceTotalCurrentMonth = result;
                }
            }

            return Math.Round(priceTotalCurrentMonth);
        }

        public DataTable GetBillsOfSellerInformationDataTable(string searchValue, string dateTimeConverted)
        {
            string searchQuery = "";
            string dateQuery = "";

            if (searchValue != "")
            {
                searchQuery = $" WHERE (MaHDBan LIKE '{searchValue}%' OR TenNhanVien LIKE N'%{searchValue}%' OR TenKhachHang LIKE N'%{searchValue}%' OR tKhachHang.DienThoai LIKE '{searchValue}%')";
            }

            if (searchValue != "" && dateTimeConverted != "")
            {
                dateQuery = $" AND CONVERT(DATE, NgayBan) = '{dateTimeConverted}';";
            }
            else if(searchValue == "" && dateTimeConverted != "")
            {
                dateQuery = $" WHERE CONVERT(DATE, NgayBan) = '{dateTimeConverted}';";
            }

            string query = "SELECT MaHDBan, TenNhanVien, tNhanVien.DienThoai AS DienThoaiNV, TenKhachHang, tKhachHang.DienThoai AS DienThoaiKH, SoSanPham, TenGiamGia, TongTien, NgayBan " +
            "FROM tHoaDonBan " +
            "INNER JOIN tKhachHang " +
            "ON tHoaDonBan.MaKhachHang = tKhachHang.MaKhachHang " +
            "INNER JOIN tNhanVien " +
            "ON tHoaDonBan.MaNhanVien = tNhanVien.MaNhanVien " +
            "LEFT JOIN tGiamGia " +
            "ON tHoaDonBan.MaGiamGia = tGiamGia.MaGiamGia" +
            (searchValue == "" && dateTimeConverted == "" ? "\n" :
                searchQuery
                + dateQuery
            ) + 
			" ORDER BY NgayBan DESC";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            return dataTable;
        }

        public List<BillsOfSellerInfoResponseDTO> GetBillsOfSellerInformation(string searchValue, string dateTimeConverted)
        {
            DataTable dataTable = this.GetBillsOfSellerInformationDataTable(searchValue, dateTimeConverted);

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
                billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_GiamGia = row[6].ToString();
                billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_TongTien = (long)row[7];
                billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_NgayBan = (DateTime)row[8];
                // Handle null value

                billsOfSellerInfoResponseDTOs.Add(billsOfSellerInfoResponseDTO);
            }
            return billsOfSellerInfoResponseDTOs;
        }

        public List<BillDetailInfomationDTO> GetBillsDetailInformation(string MaHoaDon)
        {
            string query = "SELECT tChiTietHDBan.MaDMSanPham AS MaDMSanPham, TenSanPham, SoLuong, ThanhTien FROM " +
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

        // Bill of import
        public int CountBillOfImportCurrentMonth()
        {
            string query = "SELECT COUNT(*) from tHoaDonNhap " +
                "WHERE YEAR(NgayNhap) = YEAR(GETDATE()) AND MONTH(NgayNhap) = MONTH(GETDATE());";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            int countBillOfImportCurrentMonth = (int)dataTable.Rows[0][0];

            return countBillOfImportCurrentMonth;
        }

        public long GetImportCostCurrentMonth()
        {
            string query = "SELECT SUM(TongTien) AS ChiPhiNhapKhauThangNay " +
                "FROM tHoaDonNhap " +
                "WHERE YEAR(tHoaDonNhap.NgayNhap) = YEAR(GETDATE()) AND MONTH(tHoaDonNhap.NgayNhap) = MONTH(GETDATE())";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            long importCostCurrentMonth = 0;

            if (dataTable.Rows[0][0] != null)
            {
                if (long.TryParse(dataTable.Rows[0][0].ToString(), out long result))
                {
                    importCostCurrentMonth = result;
                }
            }

            return importCostCurrentMonth;
        }

        public DataTable GetBillOfImportInfomationDataTable(string searchValue, string dateTimeConverted)
        {
            string searchQuery = "";
            string dateQuery = "";

            if (searchValue != "")
            {
                searchQuery = $" WHERE (MaHDNhap LIKE '{searchValue}%' OR TenNhanVien LIKE N'%{searchValue}%' OR TenNhaCungCap LIKE N'%{searchValue}%' " +
                    $"OR tNhaCungCap.DiaChi LIKE '%{searchValue}%' OR tNhaCungCap.DienThoai LIKE '{searchValue}%')";
            }

            if (searchValue != "" && dateTimeConverted != "")
            {
                dateQuery = $" AND CONVERT(DATE, NgayNhap) = '{dateTimeConverted}';";
            }
            else if (searchValue == "" && dateTimeConverted != "")
            {
                dateQuery = $" WHERE CONVERT(DATE, NgayNhap) = '{dateTimeConverted}';";
            }

            string query = "SELECT MaHDNhap, TenNhanVien, tNhanVien.DienThoai AS DienThoaiNV, TenNhaCungCap, tNhaCungCap.DiaChi AS DiaChiNCC, tNhaCungCap.DienThoai AS DienThoaiNCC, SoSanPham, TongTien, NgayNhap " +
                "FROM tHoaDonNhap " +
                "INNER JOIN tNhaCungCap " +
                "ON tHoaDonNhap.MaNhaCungCap = tNhaCungCap.MaNhaCungCap " +
                "INNER JOIN tNhanVien " +
                "ON tHoaDonNhap.MaNhanVien = tNhanVien.MaNhanVien" +
                (searchValue == "" && dateTimeConverted == "" ? "\n" :
                searchQuery
                + dateQuery
                ) + 
				" ORDER BY NgayNhap DESC";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            return dataTable;
        }

        public List<BillOfImportInfoResponseDTO> GetBillOfImportInformation(string searchValue, string dateTimeConverted)
        {
            DataTable dataTable = this.GetBillOfImportInfomationDataTable(searchValue, dateTimeConverted);

            List<BillOfImportInfoResponseDTO> billOfImportInfoResponseDTOs = new List<BillOfImportInfoResponseDTO>();
            foreach(DataRow row in dataTable.Rows)
            {
                BillOfImportInfoResponseDTO billOfImportInfoResponseDTO = new BillOfImportInfoResponseDTO();

                billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_MaHDNhap = row[0].ToString();
                billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_TenNhanVien = row[1].ToString();
                billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_DienThoaiNV = row[2].ToString();
                billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_TenNCC = row[3].ToString();
                billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_DiaChiNCC = row[4].ToString();
                billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_DienThoaiNCC = row[5].ToString();
                billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_SoSanPham = (int)row[6];
                billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_TongTien = (long)row[7];
                billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_NgayNhap = (DateTime)row[8];

                billOfImportInfoResponseDTOs.Add(billOfImportInfoResponseDTO);
            }

            return billOfImportInfoResponseDTOs;
        }

        public List<BillDetailInfomationDTO> GetBillOfImportDetailInformation(string MaHoaDon)
        {
            string query = "SELECT tChiTietHDNhap.MaDMSanPham AS MaDMSanPham, TenSanPham, SoLuong, ThanhTien FROM " +
                "tChiTietHDNhap " +
                "INNER JOIN tDMSanPham " +
                $"ON tDMSanPham.MaDMSanPham = tChiTietHDNhap.MaDMSanPham AND tChiTietHDNhap.MaHDNhap = '{MaHoaDon}';";
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

        // Customer analytics
        public List<string> GetCustomerPhoneNumberListNotInCurrentMonth()
        {
            string query = "SELECT DienThoai FROM tHoaDonBan " +
                "INNER JOIN tKhachHang " +
                "ON tHoaDonBan.MaKhachHang = tKhachHang.MaKhachHang " +
                "WHERE tKhachHang.MaKhachHang is not NULL AND (YEAR(tHoaDonBan.NgayBan) != YEAR(GETDATE()) OR (YEAR(tHoaDonBan.NgayBan) = YEAR(GETDATE()) AND MONTH(tHoaDonBan.NgayBan) != MONTH(GETDATE())));";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            List<string> customerPhoneNumers = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                customerPhoneNumers.Add(row[0].ToString().Trim());
            }

            return customerPhoneNumers;
        }

        public List<string> GetCustomerPhoneNumberListCurrentMonth()
        {
            string query = "SELECT DienThoai FROM tHoaDonBan " +
                "INNER JOIN tKhachHang " +
                "ON tHoaDonBan.MaKhachHang = tKhachHang.MaKhachHang " +
                "WHERE tKhachHang.MaKhachHang is not NULL AND YEAR(tHoaDonBan.NgayBan) = YEAR(GETDATE()) AND MONTH(tHoaDonBan.NgayBan) = MONTH(GETDATE());";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            List<string> customerPhoneNumersCurrentMonth = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                customerPhoneNumersCurrentMonth.Add(row[0].ToString().Trim());
            }

            return customerPhoneNumersCurrentMonth;
        }
    }
}
