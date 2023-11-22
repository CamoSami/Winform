using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataValidateObjects.CustomValidation;

namespace WinformWithExternalLibrary.DataValidateObjects
{
    public class FormCreateGiamGiaDVO
    {
        [Required(ErrorMessage = "Hãy nhập tên giảm giá")]
        [DisplayName("Tên giảm giá")]
        public string FormCreateGiamGiaDVO_TenGiamGia { get; set; }

        [Required(ErrorMessage = "Hãy nhập phần trăm giảm giá")]
        [Range(
            minimum: 0.01,
            maximum: 0.99,
            ErrorMessage = "Phần trăm giảm giá phải nhỏ hơn 1")]
        [DisplayName("Phần trăm giảm giá")]
        public float FormCreateGiamGiaDVO_PhanTramGiamGia { get; set; }

        [Required(ErrorMessage = "Hãy nhập max giảm giá")]
        [DisplayName("Max giảm giá")]
        public long FormCreateGiamGiaDVO_MaxGiamGia { get; set; }

        [Required(ErrorMessage = "Hãy nhập ngày bắt đầu")]
        [DisplayName("Ngày bắt đầu")]
        public DateTime FormCreateGiamGiaDVO_NgayBatDau { get; set; }

        [Required(ErrorMessage = "Hãy nhập ngày kết thúc")]
        [DisplayName("Ngày kết thúc")]

        //[Check2Day(ErrorMessage = "Ngày kết thúc phải sau ngày bắt đầu")]
        public DateTime FormCreateGiamGiaDVO_NgayKetThuc { get; set; }
    }
}
