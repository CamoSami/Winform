using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataValidateObjects
{
	public class CongViecDVO
	{
		[Required(ErrorMessage = "Vui lòng nhập mã công việc.")]
		[DisplayName("Mã công việc")]
		public Guid CongViecDVO_MaCongViec { get; set; }

		[Required(ErrorMessage = "Vui lòng nhập tên công việc.")]
		[StringLength(40, MinimumLength = 4, ErrorMessage = "Tên công việc phải từ 4 đến 40 ký tự.")]
		[DisplayName("Tên công việc")]
		public string CongViecDVO_TenCongViec { get; set; }

		[Required(ErrorMessage = "Vui lòng nhập mức lương.")]
		[DisplayName("Mức lương")]
		public long CongViecDVO_MucLuong { get; set; }

		public CongViecDVO() { }

		public CongViecDVO(Guid maCongViec, string tenCongViec, long mucLuong)
		{
			this.CongViecDVO_MaCongViec = maCongViec;
			this.CongViecDVO_TenCongViec = tenCongViec;
			this.CongViecDVO_MucLuong = mucLuong;
		}
	}
}
