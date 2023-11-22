using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformWithExternalLibrary.DataValidateObjects.CustomValidation
{
	public class DivisibleBy100Attribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value != null)
			{
				if (long.TryParse(value.ToString(), out var longValue))
				{
					if (longValue % 100 == 0 && longValue != 0)
					{
						return ValidationResult.Success;
					}
				}
			}

			return new ValidationResult(
				this.ErrorMessage, 
				new List<string>() { 
					"TongTienKhachTraDVO_TongTienKhachTra",
					"FormCreateSanPhamDVO_DonGiaBan"
					}
				);
		}
	}
}
