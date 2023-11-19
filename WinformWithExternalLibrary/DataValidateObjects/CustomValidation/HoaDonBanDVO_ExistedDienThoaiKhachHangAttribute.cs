using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataAccessObjects;

namespace WinformWithExternalLibrary.DataValidateObjects.CustomValidation
{
	public class HoaDonBanDVO_ExistedDienThoaiKhachHangAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			//		Not my job
			if (value.ToString() == "")
			{
				return ValidationResult.Success;
			}

			if (value != null && value is string)
			{
				//Debug.WriteLine(value.ToString());

				if (KhachHangDAO.Instance.IfPhoneNumberExist(value.ToString()))
				{
					//Debug.WriteLine("Success!");

					return ValidationResult.Success;
				}
			}

			return new ValidationResult(
				this.ErrorMessage,
				new List<string>() { "HoaDonBanDVO_DienThoaiKhachHang" }
				);
		}
	}
}
