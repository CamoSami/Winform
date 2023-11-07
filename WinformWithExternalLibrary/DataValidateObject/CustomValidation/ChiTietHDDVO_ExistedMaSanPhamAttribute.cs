using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataAccessObjects;

namespace WinformWithExternalLibrary.DataValidateObject.CustomValidation
{
	public class ChiTietHDDVO_ExistedMaSanPhamAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value != null && value is string)
			{
				//Debug.WriteLine(value.ToString());

				string maSanPham = value.ToString();

				if (DMSanPhamDAO.Instance.CheckMaSanPhamExist(maSanPham))
				{
					//Debug.WriteLine("Success!");

					return ValidationResult.Success;
				}
			}

			return new ValidationResult(
				this.ErrorMessage,
				new List<string>() { "ChiTietHDBanDVO_MaSanPham", "ChiTietHDNhapDVO_MaSanPham" }
				);
		}
	}
}
