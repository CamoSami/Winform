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
    public class TongTienKhachTraDVO_EligibleTongTienKhachTraAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
			//Debug.WriteLine("\n\n\n" + value.ToString());

			//		Not my job
			if (value == null || value.ToString() == "0")
			{
				return ValidationResult.Success;
			}

            if (value != null && value is long)
            {
                //Debug.WriteLine(value.ToString());

                if ((long)value >= FormMain.Instance.TabPageHoaDonBan_GetThanhToan())
                {
                    //Debug.WriteLine("Success!");

                    return ValidationResult.Success;
                }
            }

            return new ValidationResult(
                this.ErrorMessage,
                new List<string>() { "TongTienKhachTraDVO_TongTienKhachTra" }
                );
        }
    }
}
