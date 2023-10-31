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
	public class HoaDonBanDVO_ExistNhanVienAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value != null && value is string)
			{
				//Debug.WriteLine(value.ToString());

				string[] dividedString = value.ToString().Split('|');

				string tenNhanVien = dividedString[0].Trim();
				string ngaySinh = dividedString[1].Trim();

				if (!NhanVienDAO.Instance.CheckNhanVienByTenNhanVienAndNgaySinh(tenNhanVien, ngaySinh))
				{
					//Debug.WriteLine("Success!");

					return ValidationResult.Success;
				}
			}

			return new ValidationResult(
				this.ErrorMessage,
				new List<string>() {"HoaDonBanDVO_NhanVien"}
				);
		}
	}
}
