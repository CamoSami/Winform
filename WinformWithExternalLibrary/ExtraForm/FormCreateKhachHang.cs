using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformWithExternalLibrary.DataAccessObjects;
using WinformWithExternalLibrary.DataTransferObjects;

namespace WinformWithExternalLibrary
{
	public partial class FormCreateKhachHang : MaterialForm
	{
		private readonly List<TextBoxBase> listOfTextboxes = new List<TextBoxBase>();
		private readonly List<Label> listOfLabels = new List<Label>();
		private readonly List<bool> isInterracted = new List<bool>();

		private bool hasDone = false;
		private bool onlyOnce;

		public FormCreateKhachHang(bool onlyOnce)
		{
			//		Assigning value
			this.onlyOnce = onlyOnce;


			//		Componenets
			this.InitializeComponent();

			//		Attributes
			this.InitializeHardCodedAttributes();

			//		Events
			this.InitializeAutomaticEventAndList();
			this.InitializeSpecializedEvent();
		}

		private void InitializeHardCodedAttributes()
		{
			//		Form
			this.Font = FormLogin.Instance.GetFont();

			//		Control
			foreach (Control control in this.Controls)
			{
				if (control is Label)
				{
					//		Casting
					Label tempLabel = control as Label;

					//		Clear its Text
					tempLabel.Text = "";

					//		Hardcode if the Label only for Focusing
					if (tempLabel == this.labelForFocus)
					{
						continue;
					}

					//		Label for Validation
					tempLabel.ForeColor = Color.Red;
				}
				else if (control is TextBoxBase)
				{
					//		Casting
					TextBoxBase tempMaterialTextBox = control as TextBoxBase;

					//		Check if Input enabled
					if (tempMaterialTextBox.Enabled == true)
					{
						//		Debug
						//Debug.WriteLine(tempMaterialTextBox.Name);

						//		Get the DisplayName attribute
						tempMaterialTextBox.Text = this.GetPlaceholder(tempMaterialTextBox);
					}
				}
			}
		}

		private void InitializeAutomaticEventAndList()
		{
			//		Auto Event
			foreach (Control control in this.Controls)
			{
				if (control is Label)
				{
					//		Hardcode if the Label only for Focusing
					if (control == this.labelForFocus)
					{
						continue;
					}

					Label tempLabel = control as Label;

					this.listOfLabels.Add(tempLabel);
				}
				else if (control is TextBoxBase)
				{
					//		Casting
					TextBoxBase tempMaterialTextBox = control as TextBoxBase;

					//		Check if Input enabled
					if (tempMaterialTextBox.Enabled == true)
					{
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
		}

		private void InitializeSpecializedEvent()
		{
			//		TextBox
			this.KhachHangDTO_DienThoai.KeyPress += this.TextBoxBase_KeyPress_NumericOnly;
			this.KhachHangDTO_TenKhachHang.KeyPress += this.TextBoxBase_KeyPress_AlphabetOnly;

			//		Button
			//			Submit
			this.materialButtonSubmit.Click += (obj, e) => 
			{
				//		Form is completed -> Interaction = true
				for (int i = 0; i < this.isInterracted.Count; i++)
				{
					this.isInterracted[i] = true;
				}

				//		Try validating
				if (!this.TryValidation())
				{
					return;
				}

				//		Send Query
				if (KhachHangDAO.Instance.InsertKhachHang(this.GetInput() as KhachHangDTO))
				{
					MaterialMessageBox.Show(
						text: "Dữ liệu khách hàng đã được nhập thành công O~O",
						caption: this.Text,
						UseRichTextBox: false,
						buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
						);

					this.hasDone = true;

					//		TODO: Send PhoneNumbers back to HoaDonBan or something
					if (this.onlyOnce)
					{
						this.Close();
					}
				}
				else
				{
					MaterialMessageBox.Show(
						text: "Có vấn đề j đó vừa xảy ra ._.",
						caption: this.Text,
						UseRichTextBox: false,
						buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
						);
				}
			};

			//		Form
			//			DirtyData check before closing
			this.FormClosing += (obj, e) => 
			{
				if (this.hasDone && this.onlyOnce)
				{
					return;
				}

				//		Check if unsaved data
				bool ifDirtyData = false;

				foreach (Control temp in this.Controls)
				{
					if (temp is TextBoxBase)
					{
						TextBoxBase tempTextBox = temp as TextBoxBase;

						if (!this.CheckIfTextboxEmptyOrPlaceholder(tempTextBox))
						{
							ifDirtyData = true;

							break;
						}
					}
					//Debug.WriteLine(temp);
				}

				if (ifDirtyData)
				{
					if (MaterialMessageBox.Show(
							text: "Bạn còn thông tin nhập dở, bạn muốn rời hông?",
							caption: this.Text,
							buttons: MessageBoxButtons.YesNo,
							icon: MessageBoxIcon.Question,
							UseRichTextBox: false,
							buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
							)
						== DialogResult.No
						)
					{
						e.Cancel = true;
					}
				}

				//		No DirtyData OR confirmed Leave
				if (e.Cancel == false)
				{
					//		Actually, meh
					//			Release unmanaged resources
					this.Dispose();

					//			Also release resources, but eh
					this.Close();
				}
			};

			//			Upon clicking the Form => Textbox loses Focus
			this.Click += (obj, e) =>
			{
				this.ActiveControl = null;
			};

			//			Upon loading the Form => Textbox loses Focus
			this.Load += (obj, e) =>
			{
				this.ActiveControl = this.labelForFocus;
			};
		}



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

		private void MaterialButtonSubmit_Click(object sender, EventArgs e)
		{
			
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
						}
					}
				}
			}

			//		Exception
			if (KhachHangDAO.Instance.IfPhoneNumberTaken(temp))
			{
				this.label2.Text = "Đã tồn tại số điện thoại này!";

				return false;
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
			return new KhachHangDTO(
				khachHangDTO_TenKhachHang: this.GetTextboxTextIfPlaceholderThenEmpty(this.KhachHangDTO_TenKhachHang),
				khachHangDTO_DiaChi: this.GetTextboxTextIfPlaceholderThenEmpty(this.KhachHangDTO_DiaChi),
				khachHangDTO_DienThoai: this.GetTextboxTextIfPlaceholderThenEmpty(this.KhachHangDTO_DienThoai)
				);
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
			PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(typeof(KhachHangDTO))[textBox.Name];
			DisplayNameAttribute displayNameAttribute = (DisplayNameAttribute)propertyDescriptor.Attributes[typeof(DisplayNameAttribute)];

			return displayNameAttribute.DisplayName;
		}

		private void SetStringLabelForTextbox(TextBoxBase textBox, string text)
		{
			this.listOfLabels[this.listOfTextboxes.IndexOf(textBox)].Text = text;
		}
	}
}
