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
            public double BillOfSellerInfoResponseDTO_GiamGia { get; set; }
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
    }
}
