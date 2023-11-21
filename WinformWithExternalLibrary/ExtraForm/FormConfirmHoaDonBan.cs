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
using WinformWithExternalLibrary.DataValidateObjects;
using WinformWithExternalLibrary.DataValidateObjects;

namespace WinformWithExternalLibrary.ExtraForm
{
	public partial class FormConfirmHoaDonBan : MaterialForm
	{
		private readonly List<TextBoxBase> listOfTextboxes = new List<TextBoxBase>();
		private readonly List<Label> listOfLabels = new List<Label>();
		private readonly List<bool> isInterracted = new List<bool>();

		private bool hasDone = false;

		private HoaDonBanDVO hoaDonBanDVO;
		private NhanVienThuNganHDBanDVO nhanVienThuNganDVO;

		public FormConfirmHoaDonBan(HoaDonBanDVO hoaDonBanDVO, NhanVienThuNganHDBanDVO nhanVienThuNganDVO)
		{
			this.InitializeComponent();

			//		Material Skin Manager
			MaterialSkinManager.Instance.AddFormToManage(this);

			this.hoaDonBanDVO = hoaDonBanDVO;
			this.nhanVienThuNganDVO = nhanVienThuNganDVO;

			//		Attributes
			this.InitializeHardCodedAttributes();

			//		Events
			this.InitializeAutomaticEventAndList();
			this.InitializeSpecializedEvent();
		}

		#region Initialize

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Enter)
			{
				this.TrySubmittingInput(false);
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void InitializeHardCodedAttributes()
		{
			//		Label for Focus
			this.LabelForFocus.Text = "";

			//		Text
			this.FormConfirmHoaDonBan_NhanVien.Text = "Nhân viên: " + this.nhanVienThuNganDVO.NhanVienThuNganHDBanDVO_NhanVien;
			this.FormConfirmHoaDonBan_KhachHang.Text = "Khách hàng: " + this.hoaDonBanDVO.HoaDonBanDVO_TenKhachHang;
			this.FormConfirmHoaDonBan_TongTien.Text = "Tồng tiền: " + this.hoaDonBanDVO.HoaDonBanDVO_TongTien.ToString();
			this.FormConfirmHoaDonBan_ThanhToan.Text = "Thanh toán: " + this.hoaDonBanDVO.HoaDonBanDVO_ThanhToan.ToString();

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
					tempLabel.Cursor = Cursors.Default;

					//		For Validation
					tempLabel.ForeColor = Color.Red;
				}
				else if (control is TextBoxBase && control.Name.Contains("DVO"))
				{
					//		Casting
					TextBoxBase tempMaterialTextBox = control as TextBoxBase;

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
			//		TextBox
			this.TongTienKhachTraDVO_TongTienKhachTra.KeyPress += this.TextBoxBase_KeyPress_NumericOnly;

			//		Button
			//			Submit
			this.materialButtonSubmit.Click += (obj, e) =>
			{
				this.TrySubmittingInput(false);
			};

			this.materialButtonExport.Click += (obj, e) =>
			{
				this.TrySubmittingInput(true);
			};

			//		Form
			this.KeyPress += (obj, e) =>
			{
				if (char.IsDigit(e.KeyChar))
				{
					this.TongTienKhachTraDVO_TongTienKhachTra.Text = e.KeyChar.ToString();

					this.ActiveControl = this.TongTienKhachTraDVO_TongTienKhachTra;
					this.TongTienKhachTraDVO_TongTienKhachTra.SelectionStart = this.TongTienKhachTraDVO_TongTienKhachTra.Text.Length;
				}
			};

			FormMain.Instance.FormClosed += (obj, eventArgs) =>
			{
				this.Dispose();

				this.Close();

				Environment.Exit(0);
			};

			//			DirtyData check before closing
			this.FormClosing += (obj, e) =>
			{
				if (this.hasDone)
				{
					return;
				}

				//		DirtyData
				if (MaterialMessageBox.Show(
						text: "Bạn còn thông tin nhập dở, bạn muốn rời không?",
						caption: this.Text,
						buttons: MessageBoxButtons.YesNo,
						icon: MessageBoxIcon.Question,
						UseRichTextBox: false,
						buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
						)
					== DialogResult.Yes
					)
				{

				}
				else
				{
					this.TongTienKhachTraDVO_TongTienKhachTra_Validation.ForeColor = Color.Red;

					e.Cancel = true;
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
				this.ActiveControl = this.LabelForFocus;

				this.TopMost = true;

				this.Activate();
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

			if (FormMain.Instance.IsAutoValidate())
			{
				this.TryValidation(out _);
			}
		}

		#endregion

		#region Generalist Function

		private void TrySubmittingInput(bool inHoaDonBan)
		{
			//		Form is completed -> Interaction = true
			for (int i = 0; i < this.isInterracted.Count; i++)
			{
				this.isInterracted[i] = true;
			}

			//		Try validating
			if (!this.TryValidation(out dynamic baseDVO))
			{
				return;
			}

			//		Send Query
			//			TODO: Nhập HoaDonban
			FormMain.Instance.NhapHoaDonBan(this.hoaDonBanDVO, this.nhanVienThuNganDVO, baseDVO as TongTienKhachTraDVO, inHoaDonBan);

			this.hasDone = true;

			this.Close();
		}

		private bool TryValidation(out dynamic baseDVO)
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
				baseDVO = null;

				return false;
			}
			else
			{
				baseDVO = temp;

				return true;
			}
		}

		private dynamic GetInput()
		{
			if (!long.TryParse(this.GetTextboxTextIfPlaceholderThenEmpty(this.TongTienKhachTraDVO_TongTienKhachTra), out long tempTongTienKhachTra)) {
				return new TongTienKhachTraDVO();
			}

			return new TongTienKhachTraDVO(
				tongTienKhachTraDVO_TongTienKhachTra: tempTongTienKhachTra
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
			PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(typeof(TongTienKhachTraDVO))[textBox.Name];
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

        #endregion
    }
}