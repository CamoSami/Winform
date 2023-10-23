using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WinformWithExternalLibrary.DataTransferObjects
{
	public class LoginDTO
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
		public string LoginDTO_loginName { get; set; }

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
		public string LoginDTO_password { get; set; }

		public LoginDTO(string LoginDTO_loginName, string LoginDTO_password)
		{
			this.LoginDTO_loginName = LoginDTO_loginName;
			this.LoginDTO_password = LoginDTO_password;
		}

		public LoginDTO() { }
	}
}
