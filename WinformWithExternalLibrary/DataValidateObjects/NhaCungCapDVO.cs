﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataValidateObjects.CustomValidation;

namespace WinformWithExternalLibrary.DataValidateObjects
{
    public class NhaCungCapDVO
    {
		[Required(
            ErrorMessage = "Vui lòng nhập tên nhà cung cấp"
			)]
        [StringLength(
            maximumLength: 30,
            MinimumLength = 4,
            ErrorMessage = "Tên nhà cung cấp phải có độ dài từ 4 đến 30 ký tự"
			)]
        [DisplayName(
            "Tên nhà cung cấp"
            )]
        public string NhaCungCapDVO_TenNhaCungCap { get; set; }



        [Required(
            ErrorMessage = "Vui lòng nhập số điện thoại"
			)]
        [StringLength(
            maximumLength: 10,
            MinimumLength = 10,
            ErrorMessage = "Số điện thoại phải có độ dài 10 chữ số"
            )]
		[NhaCungCapDVO_UniqueDienThoai(
			ErrorMessage = "Số điện thoại vừa nhập đã tồn tại"
			)]
		[DisplayName(
            "Số điện thoại"
            )]
        public string NhaCungCapDVO_DienThoai { get; set; }


        [Required(
            ErrorMessage = "Vui lòng nhập địa chỉ"
			)]
        [StringLength(
            maximumLength: 150,
            MinimumLength = 4,
            ErrorMessage = "Địa chỉ phải có độ dài từ 4 đến 150 ký tự"
			)]
        [DisplayName(
            "Địa chỉ"
            )]
        public string NhaCungCapDVO_DiaChi { get; set; }

		public NhaCungCapDVO() { }

		public NhaCungCapDVO(string nhaCungCapDVO_TenNhaCungCap, string nhaCungCapDVO_DienThoai, string nhaCungCapDVO_DiaChi)
		{
			this.NhaCungCapDVO_TenNhaCungCap = nhaCungCapDVO_TenNhaCungCap;
			this.NhaCungCapDVO_DienThoai = nhaCungCapDVO_DienThoai;
			this.NhaCungCapDVO_DiaChi = nhaCungCapDVO_DiaChi;
		}
	}
}
