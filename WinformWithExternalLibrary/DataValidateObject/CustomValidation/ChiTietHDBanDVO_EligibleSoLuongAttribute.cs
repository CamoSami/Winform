using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WinformWithExternalLibrary.DataAccessObjects;

namespace WinformWithExternalLibrary.DataValidateObject.CustomValidation
{
	public class ChiTietHDBanDVO_EligibleSoLuongAttribute : CompareAttribute
	{
		public ChiTietHDBanDVO_EligibleSoLuongAttribute(string otherProperty) : base(otherProperty)
		{

		}

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			PropertyInfo maSanPhamInfo = validationContext.ObjectType.GetProperty(base.OtherProperty);
			object maSanPham = maSanPhamInfo.GetValue(validationContext.ObjectInstance, null);

			//		Not my work
			if (maSanPham == null || value == null || !DMSanPhamDAO.Instance.CheckMaSanPhamExist(maSanPham.ToString()))
			{
				return ValidationResult.Success;
			}

			if (value != null && value is int number)
			{
				if (number <= DMSanPhamDAO.Instance.GetSoLuongTonKhoByMaSanPham(maSanPham.ToString()))
				{
					return ValidationResult.Success;
				}
			}

			//Debug.WriteLine("MaSanPham: " + (maSanPham != null ? maSanPham.ToString() : "null") + ", SoLuong: " + value);

			return new ValidationResult(
				this.ErrorMessage,
				new List<string>() { "ChiTietHDBanDVO_SoLuong" }
				);
		}
	}
}
