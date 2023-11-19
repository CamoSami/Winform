using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataAccessObjects;

namespace WinformWithExternalLibrary.DataValidateObjects.CustomValidation
{
	public class KhachHangDVO_UniqueDienThoaiAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value != null && value is string)
			{
				//Debug.WriteLine(value.ToString());

				if (!KhachHangDAO.Instance.IfPhoneNumberExist(value.ToString())) 
				{
					//Debug.WriteLine("Success!");

					return ValidationResult.Success;
				}
			}

			return new ValidationResult(
				this.ErrorMessage, 
				new List<string>() {"KhachHangDVO_DienThoai"}
				);
		}
	}
}
