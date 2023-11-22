using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataAccessObjects;

namespace WinformWithExternalLibrary.DataValidateObjects.CustomValidation
{
	public class FormCreateSanPhamDVO_UniqueMaSanPhamAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value != null && value is string)
			{
				//Debug.WriteLine(value.ToString());

				if (!DMSanPhamDAO.Instance.CheckMaSanPhamExist(value.ToString()))
				{
					//Debug.WriteLine("Success!");

					return ValidationResult.Success;
				}
			}

			return new ValidationResult(
				this.ErrorMessage,
				new List<string>() { "FormCreateSanPhamDVO_MaSanPham" }
				);
		}
	}
}
