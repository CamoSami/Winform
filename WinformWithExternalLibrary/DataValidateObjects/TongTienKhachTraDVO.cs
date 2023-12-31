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
	public class TongTienKhachTraDVO
	{
		[Range(
			type: typeof(long),
			minimum: "1",
			maximum: "9223372036854775807",
			ErrorMessage = "Xin vui lòng nhập tổng tiền"
			)]
		[TongTienKhachTraDVO_EligibleTongTienKhachTra(
			ErrorMessage = "Tổng tiền không được ít hơn tiền thanh toán"
			)]
		[DivisibleBy100(
			ErrorMessage = "Tổng tiền vừa nhập không hợp lệ"
			)]
		[DisplayName("Tổng Tiền Khách Trả")]
		public long TongTienKhachTraDVO_TongTienKhachTra { get; set; }

		public TongTienKhachTraDVO() { }

		public TongTienKhachTraDVO(long tongTienKhachTraDVO_TongTienKhachTra)
		{
			this.TongTienKhachTraDVO_TongTienKhachTra = tongTienKhachTraDVO_TongTienKhachTra;
		}
	}
}
