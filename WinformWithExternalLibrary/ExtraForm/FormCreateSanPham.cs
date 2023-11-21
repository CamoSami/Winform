using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformWithExternalLibrary.DataAccessObjects;
using WinformWithExternalLibrary.DataTransferObjects;
using WinformWithExternalLibrary.DataValidateObjects;
using WinformWithExternalLibrary.DataValidateObjects.CustomValidation;

namespace WinformWithExternalLibrary.ExtraForm
{
	public partial class FormCreateSanPham : MaterialForm
	{
		private readonly List<TextBoxBase> listOfTextboxes = new List<TextBoxBase>();
		private readonly List<Label> listOfLabels = new List<Label>();
		private readonly List<bool> isInterracted = new List<bool>();

		private bool isUpdate;
		private Guid maDMSanPham;
		private FormCreateSanPhamDVO formCreateSanPhamDVO;

		public FormCreateSanPham(FormCreateSanPhamDVO formCreateSanPhamDVO = null,
								Guid maDMSanPham = new Guid(),
								bool isUpdate = false)
		{
			InitializeComponent();

			//		Attributes
			this.InitializeHardCodedAttributes();

			//		Events
			this.InitializeAutomaticEventAndList();
			this.InitializeSpecializedEvent();

			this.isUpdate = isUpdate;
			this.maDMSanPham = maDMSanPham;
			this.formCreateSanPhamDVO = formCreateSanPhamDVO;

			if (this.isUpdate)
			{
				this.FormCreateSanPhamDVO_MaSanPham.Text = formCreateSanPhamDVO.FormCreateSanPhamDVO_MaSanPham;
				this.FormCreateSanPhamDVO_TenSanPham.Text = formCreateSanPhamDVO.FormCreateSanPhamDVO_TenSanPham;
				this.FormCreateSanPhamDVO_DonGiaBan.Text = formCreateSanPhamDVO.FormCreateSanPhamDVO_DonGiaBan.ToString();
				this.FormCreateSanPhamDVO_DonGiaNhap.Text = formCreateSanPhamDVO.FormCreateSanPhamDVO_DonGiaNhap.ToString();
				this.FormCreateSanPhamDVO_SoLuongTonKho.Text = formCreateSanPhamDVO.FormCreateSanPhamDVO_SoLuongTonKho.ToString();
				this.FormCreateSanPhamDVO_ThoiGianBaoHanh.Text = formCreateSanPhamDVO.FormCreateSanPhamDVO_ThoiGianBaoHanh.ToString();
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

			this.FormCreateSanPham_btnThemSanPham.Click += FormCreateSanPham_btnThemSanPham_Click;

			this.FormCreateSanPham_btnThietLapVeBanDau.Click += FormCreateSanPham_btnThietLapVeBanDau_Click;

			this.FormCreateSanPham_btnScanMaSanPham.Click += (obj, e) =>
			{
				FormScanBarCode formScanBarCode = new FormScanBarCode();

				formScanBarCode.OnScanBarcodeComplete += (objj, ee) =>
				{
					this.FormCreateSanPhamDVO_MaSanPham.Text = ee.maSanPham;
				};

				formScanBarCode.Show();
			};
		}

		private void FormCreateSanPham_btnThietLapVeBanDau_Click(object sender, EventArgs e)
		{
			if (this.ShowMessageBoxYesNo("Bạn có muốn thiết lập về giá trị ban đầu không ?", "Thông báo"))
			{
				if (!this.isUpdate)
				{
					this.FormCreateSanPhamDVO_MaSanPham.Text = this.GetPlaceholder(this.FormCreateSanPhamDVO_MaSanPham);
					this.FormCreateSanPhamDVO_TenSanPham.Text = this.GetPlaceholder(this.FormCreateSanPhamDVO_TenSanPham);
					this.FormCreateSanPhamDVO_DonGiaBan.Text = this.GetPlaceholder(this.FormCreateSanPhamDVO_DonGiaBan);
					this.FormCreateSanPhamDVO_DonGiaNhap.Text = this.GetPlaceholder(this.FormCreateSanPhamDVO_DonGiaNhap);
					this.FormCreateSanPhamDVO_SoLuongTonKho.Text = this.GetPlaceholder(this.FormCreateSanPhamDVO_SoLuongTonKho);
					this.FormCreateSanPhamDVO_ThoiGianBaoHanh.Value = DateTime.Now;
				}
				else
				{
					this.FormCreateSanPhamDVO_MaSanPham.Text = this.formCreateSanPhamDVO.FormCreateSanPhamDVO_MaSanPham;
					this.FormCreateSanPhamDVO_TenSanPham.Text = this.formCreateSanPhamDVO.FormCreateSanPhamDVO_TenSanPham;
					this.FormCreateSanPhamDVO_DonGiaBan.Text = this.formCreateSanPhamDVO.FormCreateSanPhamDVO_DonGiaBan.ToString();
					this.FormCreateSanPhamDVO_DonGiaNhap.Text = this.formCreateSanPhamDVO.FormCreateSanPhamDVO_DonGiaNhap.ToString();
					this.FormCreateSanPhamDVO_SoLuongTonKho.Text = this.formCreateSanPhamDVO.FormCreateSanPhamDVO_SoLuongTonKho.ToString();
					this.FormCreateSanPhamDVO_ThoiGianBaoHanh.Value = this.formCreateSanPhamDVO.FormCreateSanPhamDVO_ThoiGianBaoHanh;
				}
			}

		}

		private void FormCreateSanPham_btnThemSanPham_Click(object sender, EventArgs e)
		{
			if (this.ShowMessageBoxYesNo("Bạn có muốn lưu thay đổi không ?"))
			{
				if (this.TryValidation())
				{
					FormCreateSanPhamDVO formCreateSPDVO = this.GetInput();
					DMSanPhamDTO dMSanPhamDTO = new DMSanPhamDTO();

					if (!this.isUpdate)
					{
						dMSanPhamDTO.DMSanPhamDTO_MaDMSanPham = Guid.NewGuid();
					}
					else
					{
						dMSanPhamDTO.DMSanPhamDTO_MaDMSanPham = maDMSanPham;
					}

					dMSanPhamDTO.DMSanPhamDTO_MaSanPham = formCreateSPDVO.FormCreateSanPhamDVO_MaSanPham;
					dMSanPhamDTO.DMSanPhamDTO_TenSanPham = formCreateSPDVO.FormCreateSanPhamDVO_TenSanPham;
					dMSanPhamDTO.DMSanPhamDTO_DonGiaBan = formCreateSPDVO.FormCreateSanPhamDVO_DonGiaBan;
					dMSanPhamDTO.DMSanPhamDTO_DonGiaNhap = formCreateSPDVO.FormCreateSanPhamDVO_DonGiaNhap;
					dMSanPhamDTO.DMSanPhamDTO_SoLuongTonKho = formCreateSPDVO.FormCreateSanPhamDVO_SoLuongTonKho;
					dMSanPhamDTO.DMSanPhamDTO_ThoiGianBaoHanh = formCreateSPDVO.FormCreateSanPhamDVO_ThoiGianBaoHanh;

					if (this.isUpdate)
					{
						if (DMSanPhamDAO.Instance.UpdateSanPham(dMSanPhamDTO, this.maDMSanPham))
						{
							this.ShowMessageBox("Cập nhật sản phẩm thành công!");

							this.Close();
						}
						else
						{
							this.ShowMessageBox("Đã xảy ra lỗi gì đó", "!UpdateSanPham");
						}

						return;
					}

					if (DMSanPhamDAO.Instance.InsertSanPham(dMSanPhamDTO))
					{
						this.ShowMessageBox("Nhập sản phẩm thành công!");

						this.Close();
					}
					else
					{
						this.ShowMessageBox("Đã xảy ra lỗi gì đó", "!InsertSanPham");
					}
				}
			}
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

			if (FormMain.Instance.IsAutoValidate())
			{
				this.TryValidation();
			}
		}

		#endregion

		#region Generalist Function

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
					Debug.WriteLine(result.ErrorMessage);
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
					label.ForeColor = Color.Red;

					return;
				}
			}
		}

		private void ResetColorForLabel()
		{
			foreach (Label label in this.listOfLabels)
			{
				label.ForeColor = Color.Red;
			}
		}
		//       Hiện MessageBox với các lựa chọn Yes No cho TabPage
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

		//Hiện MessageBox cho TabPage
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

			//        Workaround a bug
			this.ResetColorForLabel();
		}

		#endregion
	}
}
