using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WinformWithExternalLibrary.DataValidateObjects
{
	public class LoginDVO
	{
		[Required(
			ErrorMessage = "Thiếu tên đăng nhập"
			)]
		[StringLength(
			maximumLength: 30,
			MinimumLength = 3,
			ErrorMessage = "Nhập tên đăng nhập từ 3-30 kí tự"
			)]
		[DisplayName(
			"Tên Đăng Nhập"
			)]
		public string LoginDVO_Email { get; set; }



		[Required(
			ErrorMessage = "Thiếu mật khẩu"
			)]
		[StringLength(
			maximumLength: 20,
			MinimumLength = 3,
			ErrorMessage = "Nhập mật khẩu từ 3-20 kí tự"
			)]
		[DisplayName(
			"Mật Khẩu"
			)]
		public string LoginDVO_MatKhau { get; set; }

		public LoginDVO(string LoginDVO_LoginName, string LoginDVO_Password)
		{
			this.LoginDVO_Email = LoginDVO_LoginName;
			this.LoginDVO_MatKhau = LoginDVO_Password;
		}

		public LoginDVO() { }
	}
}
