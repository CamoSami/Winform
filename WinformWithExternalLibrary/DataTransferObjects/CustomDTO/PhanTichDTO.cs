using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataTransferObjects.CustomDTO
{
    public class PhanTichDTO
    {
        public class RevenueResponseDTO
        {
            public int RevenueResponseDTO_Ngay { get; set; }
            public long RevenueResponseDTO_DoanhThu { get; set; }
        }

        public class ProductsBestSellerResponseDTO
        {
            public string ProductsBestSellerResponseDTO_MaSanPham { get; set; }
            public string ProductsBestSellerResponseDTO_TenSanPham { get; set; } = "";
            public int ProductsBestSellerResponseDTO_Thang { get; set; }
            public int ProductsBestSellerResponseDTO_SoLuongBan { get; set; } = 0;
        }

        public class BillsOfSellerInfoResponseDTO
        {
            public string BillOfSellerInfoResponseDTO_MaHDBan { get; set; }
            public string BillOfSellerInfoResponseDTO_TenNhanVien { get; set; }
            public string BillOfSellerInfoResponseDTO_DienThoaiNV { get; set; }
            public string BillOfSellerInfoResponseDTO_TenKhachHang { get; set; }
            public string BillOfSellerInfoResponseDTO_DienThoaiKH { get; set; }
            public int BillOfSellerInfoResponseDTO_SoSanPham { get; set; }
            public string BillOfSellerInfoResponseDTO_GiamGia { get; set; }
            public long BillOfSellerInfoResponseDTO_TongTien { get; set; }
            public DateTime BillOfSellerInfoResponseDTO_NgayBan { get; set; }
        }

        public class BillDetailInfomationDTO
        {
            public string BillDetailInfomationDTO_MaDMSanPham { get; set; }
            public string BillDetailInfomationDTO_TenHangHoa {  get; set; }
            public int BillDetailInfomationDTO_SoLuong {  get; set; }
            public long BillDetailInfomationDTO_ThanhTien { get; set; }
        }

        public class BillOfImportInfoResponseDTO
        {
            public string BillOfImportInfoResponseDTO_MaHDNhap { get; set; }
            public string BillOfImportInfoResponseDTO_TenNhanVien { get; set; }
            public string BillOfImportInfoResponseDTO_DienThoaiNV { get; set; }
            public string BillOfImportInfoResponseDTO_TenNCC { get; set; }
            public string BillOfImportInfoResponseDTO_DiaChiNCC { get; set; }
            public string BillOfImportInfoResponseDTO_DienThoaiNCC { get; set; }
            public int BillOfImportInfoResponseDTO_SoSanPham { get; set; }
            public long BillOfImportInfoResponseDTO_TongTien { get; set; }
            public DateTime BillOfImportInfoResponseDTO_NgayNhap { get; set; }
        }

        public class InventoryArrangementResponseDTO
        {
            public string InventoryArrangementResponseDTO_MaSanPham { get; set; }
            public string InventoryArrangementResponseDTO_TenSanPham { get; set; } = "";
            public int InventoryArrangementResponseDTO_SoLuongTonKho { get; set; } = 0;
        }

        public class SalaryArrangementResponseDTO
        {
            public string SalaryArrangementResponseDTO_MaCongViec { get; set; }
            public long SalaryArrangementResponseDTO_Luong { get; set; } = 0;
            public string SalaryArrangementResponseDTO_TenCongViec { get; set; } = "";
        }
    }
}
