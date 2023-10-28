using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataAccessObjects;
using System.Data;

namespace WinformWithExternalLibrary.DataTransferObjects
{
    public class NhanVienDTO
    {
		public Guid NhanVienDTO_MaNhanVien { get; set; }



        [Required(ErrorMessage = "Vui lòng nhập mã công việc")]
        [DisplayName("Mã công việc")]
        public Guid NhanVienDTO_MaCongViec { get; set; }



        [Required(ErrorMessage = "Vui lòng nhập tên nhân viên")]
        [StringLength(maximumLength: 40,
                       MinimumLength = 4,
                    ErrorMessage = "Tên nhân viên phải từ 4-40 kí tự")]
        [DisplayName("Tên nhân viên")]
        public string NhanVienDTO_TenNhanVien { get; set; }



        [Required(ErrorMessage = "Vui lòng nhập ngày sinh")]
        [DisplayName("Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime NhanVienDTO_NgaySinh { get; set; }



        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        [StringLength(maximumLength: 150,
                        MinimumLength = 4,
            ErrorMessage = "Nhập địa chỉ từ 4-150 kí tự")]
        [DisplayName("Địa chỉ")]
        public string NhanVienDTO_DiaChi { get; set; }



        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [StringLength(  maximumLength: 10,
                        MinimumLength = 10,
                        ErrorMessage = "Số điện thoại phải dài 10 kí tự")]
        [DisplayName("Số điện thoại")]
        public string NhanVienDTO_DienThoai { get; set; }



        [Required(ErrorMessage = "Vui lòng nhập giới tính")]
        [DisplayName("Giới tính")]
        public string NhanVienDTO_GioiTinh { get; set; }

        public NhanVienDTO(Guid nhanVienDTO_MaCongViec, string nhanVienDTO_TenNhanVien, DateTime nhanVienDTO_NgaySinh, string nhanVienDTO_DiaChi, string nhanVienDTO_DienThoai, string nhanVienDTO_GioiTinh)
        {
            this.NhanVienDTO_MaCongViec = nhanVienDTO_MaCongViec;
            this.NhanVienDTO_TenNhanVien = nhanVienDTO_TenNhanVien;
            this.NhanVienDTO_NgaySinh = nhanVienDTO_NgaySinh;
            this.NhanVienDTO_DiaChi = nhanVienDTO_DiaChi;
            this.NhanVienDTO_DienThoai = nhanVienDTO_DienThoai;
            this.NhanVienDTO_GioiTinh = nhanVienDTO_GioiTinh;
        }

        public NhanVienDTO() { }
    }
}
