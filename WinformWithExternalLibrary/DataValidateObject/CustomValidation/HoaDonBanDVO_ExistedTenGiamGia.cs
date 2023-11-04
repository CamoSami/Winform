using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataAccessObjects;

namespace WinformWithExternalLibrary.DataValidateObject.CustomValidation
{
	public class HoaDonBanDVO_ExistedTenGiamGia : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value != null && value is string)
			{
				//		Not Required
				if (value.ToString() == "")
				{
					return ValidationResult.Success;
				}

				//Debug.WriteLine(value.ToString());

				if (GiamGiaDAO.Instance.CheckIfGiamGiaExists(value.ToString()))
				{
					//Debug.WriteLine("Success!");

					return ValidationResult.Success;
				}
			}

			return new ValidationResult(
				this.ErrorMessage,
				new List<string>() { "HoaDonBanDVO_TenGiamGia" }
				);
		}
	}
}
