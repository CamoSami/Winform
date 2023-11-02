using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataValidateObjects.CustomValidation;

namespace WinformWithExternalLibrary.DataValidateObject
{
	public class TongTienKhachTraDVO
	{
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
