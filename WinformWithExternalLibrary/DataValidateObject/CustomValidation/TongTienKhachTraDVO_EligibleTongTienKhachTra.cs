﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataAccessObjects;

namespace WinformWithExternalLibrary.DataValidateObject.CustomValidation
{
    public class TongTienKhachTraDVO_EligibleTongTienKhachTraAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && value is long)
            {
                //Debug.WriteLine(value.ToString());

                if ((long)value >= FormMain.Instance.GetThanhToan())
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
