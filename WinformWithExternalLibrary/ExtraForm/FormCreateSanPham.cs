using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformWithExternalLibrary.DataAccessObjects;
using WinformWithExternalLibrary.DataTransferObjects;
using WinformWithExternalLibrary.DataValidateObjects;

namespace WinformWithExternalLibrary.ExtraForm
{
	public partial class FormCreateSanPham : MaterialForm
	{
		private readonly List<TextBoxBase> listOfTextboxes = new List<TextBoxBase>();
		private readonly List<Label> listOfLabels = new List<Label>();
		private readonly List<bool> isInterracted = new List<bool>();

		private bool isUpdate;
		private Guid maDMSanPham;

		public FormCreateSanPham(FormCreateSanPhamDVO formCreateSanPhamDVO = null, Guid maDMSanPham = new Guid(), bool isUpdate = false)
		{
			InitializeComponent();

			//		Material Skin Manager
			MaterialSkinManager.Instance.AddFormToManage(this);

			//		Attributes
			this.InitializeHardCodedAttributes();

			//		Events
			this.InitializeAutomaticEventAndList();
			this.InitializeSpecializedEvent();

			this.isUpdate = isUpdate;
			this.maDMSanPham = maDMSanPham;

			if (this.isUpdate)
			{
				//this.FormCreateSanPhamDVO_MaSanPham.Text = formCreateSanPhamDVO.FormCreateSanPhamDVO_MaSanPham;
				//this.FormCreateSanPhamDVO_TenSanPham.Text = formCreateSanPhamDVO.FormCreateSanPhamDVO_TenSanPham;
				//this.FormCreateSanPhamDVO_DonGiaBan =
				//this.FormCreateSanPhamDVO_DonGiaNhap =
				//this.FormCreateSanPhamDVO_SoLuongTonKho =
				//this.FormCreateSanPhamDVO_ThoiGianBaoHanh = 
			}
		}

		#region Initialize

		private void InitializeHardCodedAttributes()
		{
			//		Label for Focus
			this.LabelForFocus.Text = "";

			//		Form
			this.Font = FormLogin.Instance.GetFont();

			//		Control
			foreach (Control control in this.Controls)
			{
				if (control is Label && control.Name.Contains("Validation"))
				{
					//		Casting
					Label tempLabel = control as Label;

					//		Clear its Text
					tempLabel.Text = "";

					//		For Validation
					tempLabel.ForeColor = Color.Red;
				}
				else if (control is TextBoxBase && control.Name.Contains("DVO"))
				{
					//		Casting
					TextBoxBase tempMaterialTextBox = control as TextBoxBase;

					//		Check if Input enabled

					//		Debug
					//Debug.WriteLine(tempMaterialTextBox.Name);

					//		Get the DisplayName attribute
					tempMaterialTextBox.Text = this.GetPlaceholder(tempMaterialTextBox);

				}
			}
		}

		private void InitializeAutomaticEventAndList()
		{
			//		Auto Event
			foreach (Control control in this.Controls)
			{
				if (control is Label && control.Name.Contains("Validation"))
				{
					Label tempLabel = control as Label;

					this.listOfLabels.Add(tempLabel);
				}
				else if (control is TextBoxBase && control.Name.Contains("DVO"))
				{
					//		Casting
					TextBoxBase tempMaterialTextBox = control as TextBoxBase;

					//		Check if Input enabled

					//		Adding in the list
					this.isInterracted.Add(false);
					this.listOfTextboxes.Add(tempMaterialTextBox);

					//		Debug
					//Debug.WriteLine(tempMaterialTextBox.Name);

					//		Assigning generalist Events
					tempMaterialTextBox.GotFocus += this.MaterialTextBox_GotFocus;
					tempMaterialTextBox.LostFocus += this.MaterialTextBox_LostFocus;

				}
			}
		}

		private void InitializeSpecializedEvent()
		{
			this.Load += (obj, e) =>
			{
				this.ResetColorForLabel();
			};

			this.materialButtonThemSanPham.Click += (obj, e) =>
			{
				if (this.TryValidation())
				{
					FormCreateSanPhamDVO formCreateSanPhamDVO = this.GetInput();

					DMSanPhamDTO dMSanPhamDTO = new DMSanPhamDTO();

					dMSanPhamDTO.DMSanPhamDTO_MaDMSanPham = Guid.NewGuid();
					dMSanPhamDTO.DMSanPhamDTO_MaSanPham = formCreateSanPhamDVO.FormCreateSanPhamDVO_MaSanPham;
					dMSanPhamDTO.DMSanPhamDTO_TenSanPham = formCreateSanPhamDVO.FormCreateSanPhamDVO_TenSanPham;
					dMSanPhamDTO.DMSanPhamDTO_DonGiaBan = formCreateSanPhamDVO.FormCreateSanPhamDVO_DonGiaBan;
					dMSanPhamDTO.DMSanPhamDTO_DonGiaNhap = formCreateSanPhamDVO.FormCreateSanPhamDVO_DonGiaNhap;
					dMSanPhamDTO.DMSanPhamDTO_SoLuongTonKho = formCreateSanPhamDVO.FormCreateSanPhamDVO_SoLuongTonKho;
					dMSanPhamDTO.DMSanPhamDTO_ThoiGianBaoHanh = formCreateSanPhamDVO.FormCreateSanPhamDVO_ThoiGianBaoHanh;

					if (this.isUpdate)
					{
						//if (DMSanPhamDAO.Instance.UpdateSanPham(dMSanPhamDTO, this.maDMSanPham))
						//{
						//	this.ShowMessageBox("Cập nhật sản phẩm thành công!");
						//}
						//else
						//{
						//	this.ShowMessageBox("Đã xảy ra lỗi gì đó", "!UpdateSanPham");
						//}

						//return;
					}

					if (DMSanPhamDAO.Instance.InsertSanPham(dMSanPhamDTO))
					{
						this.ShowMessageBox("Nhập sản phẩm thành công!");
					}
					else
					{
						this.ShowMessageBox("Đã xảy ra lỗi gì đó", "!InsertSanPham");
					}
				}
			};
		}

		#endregion

		#region Event

		private void TextBoxBase_KeyPress_AlphabetOnly(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) &&
				!char.IsWhiteSpace(e.KeyChar) &&
				!char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void TextBoxBase_KeyPress_NumericOnly(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) &&
				!char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void MaterialTextBox_GotFocus(object sender, EventArgs e)
		{
			TextBoxBase textboxTemp = sender as TextBoxBase;

			this.isInterracted[this.listOfTextboxes.IndexOf(textboxTemp)] = true;

			textboxTemp.Text = this.GetTextboxTextIfPlaceholderThenEmpty(textboxTemp);
		}

		private void MaterialTextBox_LostFocus(object sender, EventArgs e)
		{
			TextBoxBase textboxTemp = sender as TextBoxBase;

			textboxTemp.Text = this.GetTextboxTextIfEmptyThenPlaceholder(textboxTemp);

			this.TryValidation();
		}

		#endregion

		#region Generalist Function

		//		Hiện MessageBox với các lựa chọn Yes No cho TabPage
		private bool ShowMessageBoxYesNo(string message, string title = "")
		{
			bool ifYes = MaterialMessageBox.Show(
							text: message,
							caption: this.Text,
							buttons: MessageBoxButtons.YesNo,
							icon: MessageBoxIcon.Question,
							UseRichTextBox: false,
							buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
							)
						== DialogResult.Yes;

			this.ResetColorForLabel();

			return ifYes;
		}

		//		Hiện MessageBox cho TabPage
		private void ShowMessageBox(string message, string title = "")
		{

			if (title == "")
			{
				title = this.Text;
			}

			MaterialMessageBox.Show(
					text: message,
					caption: title,
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);

			//		Workaround a bug
			this.ResetColorForLabel();
		}

		private void ResetColorForLabel()
		{
			foreach (Label label in this.listOfLabels)
			{
				label.ForeColor = Color.Red;
			}
		}

		private bool TryValidation()
		{
			//		Reset Validation
			foreach (Label label in this.listOfLabels)
			{
				label.Text = "";
			}

			//		New Object
			dynamic temp = this.GetInput();
			List<ValidationResult> results = new List<ValidationResult>();

			//		Try Validating
			if (!Validator.TryValidateObject(temp, new ValidationContext(temp), results, true))
			{
				foreach (ValidationResult result in results)
				{
					for (int i = 0; i < this.listOfTextboxes.Count; i++)
					{
						if (result.MemberNames.Contains(this.listOfTextboxes[i].Name) &&
							this.CheckIfTextboxInterracted(this.listOfTextboxes[i]))
						{
							this.SetStringLabelForTextbox(this.listOfTextboxes[i], result.ErrorMessage);

							continue;
						}
					}
				}
			}

			//		Validated or not
			if (results.Count > 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		private dynamic GetInput()
		{
			if (!int.TryParse(this.GetTextboxTextIfPlaceholderThenEmpty(this.FormCreateSanPhamDVO_DonGiaBan), out int tempDonGiaBan))
			{
				tempDonGiaBan = 0;
			}

			if (!int.TryParse(this.GetTextboxTextIfPlaceholderThenEmpty(this.FormCreateSanPhamDVO_DonGiaNhap), out int tempDonGiaNhap))
			{
				tempDonGiaNhap = 0;
			}

			if (!int.TryParse(this.GetTextboxTextIfPlaceholderThenEmpty(this.FormCreateSanPhamDVO_SoLuongTonKho), out int tempSoLuongTonKho))
			{
				tempSoLuongTonKho = 0;
			}


			return new FormCreateSanPhamDVO
			{
				FormCreateSanPhamDVO_MaSanPham = this.GetTextboxTextIfPlaceholderThenEmpty(this.FormCreateSanPhamDVO_MaSanPham),
				FormCreateSanPhamDVO_TenSanPham = this.GetTextboxTextIfPlaceholderThenEmpty(this.FormCreateSanPhamDVO_TenSanPham),
				FormCreateSanPhamDVO_DonGiaBan = tempDonGiaBan,
				FormCreateSanPhamDVO_DonGiaNhap = tempDonGiaNhap,
				FormCreateSanPhamDVO_SoLuongTonKho = tempSoLuongTonKho,
				FormCreateSanPhamDVO_ThoiGianBaoHanh = this.FormCreateSanPhamDVO_ThoiGianBaoHanh.Value,
			};
		}

		private bool CheckIfTextboxInterracted(TextBoxBase textBox)
		{
			return this.isInterracted[this.listOfTextboxes.IndexOf(textBox)];
		}

		private bool CheckIfTextboxEmptyOrPlaceholder(TextBoxBase textBox)
		{
			return this.CheckTextboxTextEqualToString(textBox: textBox, text: "") ||
					this.CheckTextboxTextEqualToString(textBox: textBox, text: this.GetPlaceholder(textBox));
		}

		private bool CheckTextboxTextEqualToString(TextBoxBase textBox, string text)
		{
			return textBox.Text.Trim().Equals(text);
		}

		private string GetTextboxTextIfPlaceholderThenEmpty(TextBoxBase textBox)
		{
			return textBox.Text == this.GetPlaceholder(textBox) ? "" : textBox.Text;
		}

		private string GetTextboxTextIfEmptyThenPlaceholder(TextBoxBase textBox)
		{
			return textBox.Text == "" ? this.GetPlaceholder(textBox) : textBox.Text;
		}

		private string GetPlaceholder(TextBoxBase textBox)
		{
			PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(typeof(FormCreateSanPhamDVO))[textBox.Name];
			DisplayNameAttribute displayNameAttribute = (DisplayNameAttribute)propertyDescriptor.Attributes[typeof(DisplayNameAttribute)];

			return displayNameAttribute.DisplayName;
		}

		private void SetStringLabelForTextbox(TextBoxBase textBox, string text)
		{
			string textBoxName = textBox.Name;

			foreach (Label label in this.listOfLabels)
			{
				if (label.Name.Contains(textBoxName))
				{
					label.Text = text;

					return;
				}
			}
		}

		#endregion
	}
}
