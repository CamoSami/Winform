using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataTransferObjects
{
    public class CongViecDTO
    {
        [Required(ErrorMessage = "Thiếu mã công việc!")]
        [DisplayName("Mã công việc")]
        public int CongViecDTO_MaCongViec { get; set; }

        [Required(ErrorMessage = "Thiếu mức lương!")]
        [DisplayName("Mức lương")]
        public decimal CongViecDTO_MucLuong { get; set; }

        [Required(ErrorMessage = "Thiếu tên công việc!")]
        [StringLength(maximumLength: 40,
                        MinimumLength = 4,
                        ErrorMessage = "Nhập tên công việc từ 4-40 kí tự.")]
        [DisplayName("Tên công việc")]
        public string CongViecDTO_TenCongViec { get; set; }

        public CongViecDTO(int maCongViec, decimal mucLuong, string tenCongViec)
        {
            this.CongViecDTO_MaCongViec = maCongViec;
            this.CongViecDTO_MucLuong = mucLuong;
            this.CongViecDTO_TenCongViec = tenCongViec;
        }

        public CongViecDTO() { }
    }
}
