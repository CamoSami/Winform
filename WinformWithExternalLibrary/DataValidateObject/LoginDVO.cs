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
			ErrorMessage = "Thiếu tên đăng nhập kìa!"
			)]
		[StringLength(
			maximumLength: 20,
			MinimumLength = 3,
			ErrorMessage = "Nhập tên đăng nhập từ 3-20 kí tự nhá ._."
			)]
		[DisplayName(
			"Tên Đăng Nhập"
			)]
		public string LoginDVO_LoginName { get; set; }



		[Required(
			ErrorMessage = "Thiếu mật khẩu kìa!"
			)]
		[StringLength(
			maximumLength: 20,
			MinimumLength = 3,
			ErrorMessage = "Nhập mật khẩu từ 3-20 kí tự nhá ._."
			)]
		[DisplayName(
			"Mật Khẩu"
			)]
		public string LoginDVO_Password { get; set; }

		public LoginDVO(string LoginDVO_LoginName, string LoginDVO_Password)
		{
			this.LoginDVO_LoginName = LoginDVO_LoginName;
			this.LoginDVO_Password = LoginDVO_Password;
		}

		public LoginDVO() { }
	}
}
