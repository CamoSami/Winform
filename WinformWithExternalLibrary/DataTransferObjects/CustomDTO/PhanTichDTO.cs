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
            public string ProductsBestSellerResponseDTO_TenHangHoa { get; set; } = "";
            public int ProductsBestSellerResponseDTO_Thang { get; set; }
            public int ProductsBestSellerResponseDTO_SoLuongBan { get; set; } = 0;
        }
    }
}
