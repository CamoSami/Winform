using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataTransferObjects
{
    public class NhanVienDTO
    {
        [Required(ErrorMessage = "Thiếu mã nhân viên!")]
        [DisplayName("Mã nhân viên")]
        public int NhanVienDTO_MaNhanVien { get; set; }

        [Required(ErrorMessage = "Thiếu mã công việc!")]
        [DisplayName("Mã công việc")]
        public int NhanVienDTO_MaCongViec { get; set; }

        [Required(ErrorMessage = "Thiếu tên nhân viên!")]
        [StringLength(maximumLength: 40,
                       MinimumLength = 4,
                    ErrorMessage = "Nhập tên nhân viên từ 4-40 kí tự.")]
        [DisplayName("Tên nhân viên")]
        public string NhanVienDTO_TenNhanVien { get; set; }

        [Required(ErrorMessage = "Thiếu ngày sinh!")]
        [DisplayName("Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime NhanVienDTO_NgaySinh { get; set; }

        [Required(ErrorMessage = "Thiếu địa chỉ!")]
        [StringLength(maximumLength: 100,
                        MinimumLength = 4,
            ErrorMessage = "Nhập địa chỉ từ 4-100 kí tự.")]
        [DisplayName("Địa chỉ")]
        public string NhanVienDTO_DiaChi { get; set; }

        [Required(ErrorMessage = "Thiếu số điện thoại!")]
        [StringLength(  maximumLength: 10,
                        MinimumLength = 10,
                        ErrorMessage = "Nhập số điện thoại 10 kí tự.")]
        [DisplayName("Số điện thoại")]
        public string NhanVienDTO_DienThoai { get; set; }

        [Required(ErrorMessage = "Thiếu giới tính!")]
        [DisplayName("Giới tính")]
        public string NhanVienDTO_GioiTinh { get; set; }

        public NhanVienDTO(int maNhanVien, int maCongViec, string tenNhanVien, DateTime ngaySinh, string diaChi, string dienThoai, string gioiTinh)
        {
            this.NhanVienDTO_MaNhanVien = maNhanVien;
            this.NhanVienDTO_MaCongViec = maCongViec;
            this.NhanVienDTO_TenNhanVien = tenNhanVien;
            this.NhanVienDTO_NgaySinh = ngaySinh;
            this.NhanVienDTO_DiaChi = diaChi;
            this.NhanVienDTO_DienThoai = dienThoai;
            this.NhanVienDTO_GioiTinh = gioiTinh;
        }

        public NhanVienDTO() { }
    }
}
