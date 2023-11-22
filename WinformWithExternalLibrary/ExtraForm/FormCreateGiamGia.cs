using MaterialSkin;
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
using WinformWithExternalLibrary.DataValidateObjects;

namespace WinformWithExternalLibrary.ExtraForm
{
	public partial class FormCreateGiamGia : MaterialForm
	{
		private readonly List<TextBoxBase> listOfTextboxes = new List<TextBoxBase>();
		private readonly List<Label> listOfLabels = new List<Label>();
		private readonly List<bool> isInterracted = new List<bool>();

		private bool isUpdate;
		private Guid maGiamGia;
		private FormCreateGiamGiaDVO formCreateGiamGiaDVO;

		public FormCreateGiamGia(FormCreateGiamGiaDVO formCreateGiamGiaDVO = null,
								Guid maGiamGia = new Guid(),
								bool isUpdate = false)
		{
			this.InitializeComponent();

			//		Material Skin Manager
			MaterialSkinManager.Instance.AddFormToManage(this);

			//		Attributes
			this.InitializeHardCodedAttributes();

			//		Events
			this.InitializeAutomaticEventAndList();
			this.InitializeSpecializedEvent();

			this.isUpdate = isUpdate;
			this.maGiamGia = maGiamGia;
			this.formCreateGiamGiaDVO = formCreateGiamGiaDVO;

			if (this.isUpdate)
			{
				this.FormCreateGiamGiaDVO_TenGiamGia.Text = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_TenGiamGia;
				this.FormCreateGiamGiaDVO_PhanTramGiamGia.Text = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_PhanTramGiamGia.ToString();
				this.FormCreateGiamGiaDVO_MaxGiamGia.Text = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_MaxGiamGia.ToString();
				this.FormCreateGiamGiaDVO_NgayBatDau.Text = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_NgayBatDau.ToString();
				this.FormCreateGiamGiaDVO_NgayKetThuc.Text = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_NgayKetThuc.ToString();
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

			this.FormCreateGiamGia_btnTaoGiamGia.Click += FormCreateGiamGia_btnTaoGiamGia_Click;
			this.FormCreateGiamGia_btnThietLapVeBanDau.Click += FormCreateGiamGia_btnThietLapVeBanDau_Click;
			this.FormCreateGiamGiaDVO_NgayKetThuc.ValueChanged += FormCreateGiamGiaDVO_NgayKetThuc_ValueChanged;
		}

		private void FormCreateGiamGiaDVO_NgayKetThuc_ValueChanged(object sender, EventArgs e)
		{
			if (FormCreateGiamGiaDVO_NgayKetThuc.Value < FormCreateGiamGiaDVO_NgayBatDau.Value)
			{
				this.ShowMessageBox("Ngày kết thúc đang trước ngày bắt đầu");
				this.FormCreateGiamGiaDVO_NgayKetThuc.Focus();
			}
		}

		private void FormCreateGiamGia_btnThietLapVeBanDau_Click(object sender, EventArgs e)
		{
			if (this.ShowMessageBoxYesNo("Bạn có muốn thiết lập về giá trị ban đầu không ?", "Thông báo"))
			{
				if (!this.isUpdate)
				{
					this.FormCreateGiamGiaDVO_TenGiamGia.Text = "";
					this.FormCreateGiamGiaDVO_PhanTramGiamGia.Text = "";
					this.FormCreateGiamGiaDVO_MaxGiamGia.Text = "";
					this.FormCreateGiamGiaDVO_NgayBatDau.Text = "";
					this.FormCreateGiamGiaDVO_NgayKetThuc.Text = "";
				}
				else
				{
					this.FormCreateGiamGiaDVO_TenGiamGia.Text = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_TenGiamGia;
					this.FormCreateGiamGiaDVO_PhanTramGiamGia.Text = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_PhanTramGiamGia.ToString();
					this.FormCreateGiamGiaDVO_MaxGiamGia.Text = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_MaxGiamGia.ToString();
					this.FormCreateGiamGiaDVO_NgayBatDau.Text = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_NgayBatDau.ToString();
					this.FormCreateGiamGiaDVO_NgayKetThuc.Text = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_NgayKetThuc.ToString();
				}
			}
		}

		private void FormCreateGiamGia_btnTaoGiamGia_Click(object sender, EventArgs e)
		{
			if (this.ShowMessageBoxYesNo("Bạn có muốn lưu thay đổi không ?"))
			{
				if (this.TryValidation())
				{
					FormCreateGiamGiaDVO formCreateGiamGiaDVO = this.GetInput();
					GiamGiaDTO giamGiaDTO = new GiamGiaDTO();
					if (!this.isUpdate)
					{
						giamGiaDTO.GiamGiaDTO_MaGiamGia = Guid.NewGuid();
					}
					else
					{
						giamGiaDTO.GiamGiaDTO_MaGiamGia = maGiamGia;
					}
					giamGiaDTO.GiamGiaDTO_TenGiamGia = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_TenGiamGia;
					giamGiaDTO.GiamGiaDTO_PhanTramGiamGia = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_PhanTramGiamGia;
					giamGiaDTO.GiamGiaDTO_MaxGiamGia = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_MaxGiamGia;
					giamGiaDTO.GiamGiaDTO_NgayBatDau = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_NgayBatDau;
					giamGiaDTO.GiamGiaDTO_NgayKetThuc = formCreateGiamGiaDVO.FormCreateGiamGiaDVO_NgayKetThuc;



					if (this.isUpdate)
					{
						if (GiamGiaDAO.Instance.UpdateGiamGia(giamGiaDTO, this.maGiamGia))
						{
							this.ShowMessageBox("Cập nhật khuyến mạithành công!");
						}
						else
						{
							this.ShowMessageBox("Đã xảy ra lỗi gì đó", "!UpdateGiamGia");
						}
						this.Hide();
						return;
					}
					if (DMSanPhamDAO.Instance.InsertSanPham(giamGiaDTO))
					{
						this.ShowMessageBox("Nhập sản phẩm thành công!");
					}
					else
					{
						this.ShowMessageBox("Đã xảy ra lỗi gì đó", "!InsertSanPham");
					}
				}
				this.Hide();
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

			this.TryValidation();
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
			if (!float.TryParse(this.GetTextboxTextIfPlaceholderThenEmpty(this.FormCreateGiamGiaDVO_PhanTramGiamGia), out float tempPhanTramGiamGia))
			{
				tempPhanTramGiamGia = 0;
			}

			if (!long.TryParse(this.GetTextboxTextIfPlaceholderThenEmpty(this.FormCreateGiamGiaDVO_MaxGiamGia), out long tempMaxGiamGia))
			{
				tempMaxGiamGia = 0;
			}

			return new FormCreateGiamGiaDVO
			{
				FormCreateGiamGiaDVO_TenGiamGia = this.GetTextboxTextIfPlaceholderThenEmpty(this.FormCreateGiamGiaDVO_TenGiamGia),
				FormCreateGiamGiaDVO_PhanTramGiamGia = tempPhanTramGiamGia,
				FormCreateGiamGiaDVO_MaxGiamGia = tempMaxGiamGia,
				FormCreateGiamGiaDVO_NgayBatDau = this.FormCreateGiamGiaDVO_NgayBatDau.Value,
				FormCreateGiamGiaDVO_NgayKetThuc = this.FormCreateGiamGiaDVO_NgayKetThuc.Value,
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
			PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(typeof(FormCreateGiamGiaDVO))[textBox.Name];
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
