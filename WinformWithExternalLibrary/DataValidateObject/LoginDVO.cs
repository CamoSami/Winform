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
		public string LoginDTO_LoginName { get; set; }



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
		public string LoginDTO_Password { get; set; }

		public LoginDVO(string LoginDTO_LoginName, string LoginDTO_Password)
		{
			this.LoginDTO_LoginName = LoginDTO_LoginName;
			this.LoginDTO_Password = LoginDTO_Password;
		}

		public LoginDVO() { }
	}
}
