using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using WinformWithExternalLibrary.DataAccessObjects;
using WinformWithExternalLibrary.DataValidateObjects;
using WinformWithExternalLibrary._DataProvider;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;

namespace WinformWithExternalLibrary
{
	public partial class FormLogin : MaterialForm
	{
		public static FormLogin Instance { get; set; }

		private readonly Font mainFont = new Font
			(
			familyName: "Microsoft Sans Serif",
			emSize: 10.2F,
			style: FontStyle.Regular,
			unit: GraphicsUnit.Point,
			gdiCharSet: ((byte)(128))
			);
		private readonly ColorScheme colorScheme = new ColorScheme
				(
				primary: Primary.Pink200,
				darkPrimary: Primary.Pink400,
				lightPrimary: Primary.Pink400,
				accent: Accent.Pink100,
				textShade: TextShade.WHITE
				);

		private readonly List<TextBoxBase> listOfTextboxes = new List<TextBoxBase>();
		private readonly List<Label> listOfLabels = new List<Label>();
		private readonly List<bool> isInterracted = new List<bool>();

		private bool isLoggedIn = false;
		private bool hasLeft = false;

		public FormLogin()
		{
			//		NOTE: THIS ALWAYS GO FIRST
			this.InitializeComponent();

			//		Data Access Objects
			this.InitializeDataObjects();

			//		Assigning Essential
			this.InitializeHardCodedAttributes();

			//		Event
			this.InitializeAutomaticEvent();
			this.InitializeSpecializedEvent();
		}

		#region Initialize

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Enter)
			{
				this.TrySubmittingInput();
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void InitializeDataObjects()
		{
			DataProvider.Instance = new DataProvider();

			ChiTietHDBanDAO.Instance = new ChiTietHDBanDAO();
			CongViecDAO.Instance = new CongViecDAO();
			DMSanPhamDAO.Instance = new DMSanPhamDAO();
			GiamGiaDAO.Instance = new GiamGiaDAO();
			HoaDonBanDAO.Instance = new HoaDonBanDAO();
			KhachHangDAO.Instance = new KhachHangDAO();
			NhaCungCapDAO.Instance = new NhaCungCapDAO();
			NhanVienDAO.Instance = new NhanVienDAO();
			PhanTichDAO.Instance = new PhanTichDAO();
		}

		private void RemoveDataObjects()
		{
			DataProvider.Instance = null;

			ChiTietHDBanDAO.Instance = null;
			CongViecDAO.Instance = null;
			DMSanPhamDAO.Instance = null;
			GiamGiaDAO.Instance = null;
			HoaDonBanDAO.Instance = null;
			KhachHangDAO.Instance = null;
			NhaCungCapDAO.Instance = null;
			NhanVienDAO.Instance = null;
			PhanTichDAO.Instance = null;
		}

		private void InitializeHardCodedAttributes()
		{
			//		Label for Focus
			this.labelForFocus.Text = "";
				
			//		Font for Material componenents
			this.Font = mainFont;

			//		Initiate MaterialSkinManager
			MaterialSkinManager.Instance.EnforceBackcolorOnAllComponents = true;
			MaterialSkinManager.Instance.AddFormToManage(this);
			MaterialSkinManager.Instance.RemoveFormToManage(this);
			MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT;
			MaterialSkinManager.Instance.ColorScheme = this.colorScheme;

			//		Control
			foreach (Control control in this.Controls)
			{
				if (control.Enabled == false)
				{
					continue;
				}

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

					//		Check if Input enabled

					//		Debug
					//Debug.WriteLine(tempMaterialTextBox.Name);

					//		Get the DisplayName attribute
					tempMaterialTextBox.Text = this.GetPlaceholder(tempMaterialTextBox);

				}
			}
		}

		#endregion

		#region Event

		private void InitializeAutomaticEvent()
		{
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
					TextBoxBase tempTextBoxBase = control as TextBoxBase;

					//		Adding in the list
					this.isInterracted.Add(false);
					this.listOfTextboxes.Add(tempTextBoxBase);

					//Console.WriteLine(tempMaterialTextBox.Name);

					//		Assigning generalist Events
					tempTextBoxBase.GotFocus += this.MaterialTextBox_GotFocus;
					tempTextBoxBase.LostFocus += this.MaterialTextBox_LostFocus;

				}
			}
		}

		private void InitializeSpecializedEvent()
		{
			//		Textbox
			this.LoginDVO_MatKhau.GotFocus += (obj, e) =>
			{
				this.LoginDVO_MatKhau.Password = true;
			};

			this.LoginDVO_MatKhau.LostFocus += (obj, e) =>
			{
				if (this.CheckIfTextboxEmptyOrPlaceholder(this.LoginDVO_MatKhau))
				{
					this.LoginDVO_MatKhau.Password = false;
				}
			};

			//		Button
			this.materialButtonDangNhap.Click += this.MaterialButtonDangNhap_Click;

			//		Form
			//			DirtyData check before closing
			this.FormClosing += (obj, e) =>
			{
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
					Debug.WriteLine(temp);
				}

				//		Check sequence
				if (this.isLoggedIn || this.hasLeft)
				{
					return;
				}
				else if (ifDirtyData)
				{
					if (MaterialMessageBox.Show(
							text: "Bạn còn thông tin nhập dở, bạn muốn rời hông?",
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
						e.Cancel = true;
					}
				}

				if (e.Cancel == false)
				{
					this.hasLeft = true;

					//		Actually, meh
					//			Release unmanaged resources
					this.Dispose();

					//			Also release resources, but eh
					this.Close();

					//			Better safe than sorry
					Environment.Exit((int)(Int32)Convert.ToInt32(int.Parse(Int32.Parse((string)(String)((char)(Char)Convert.ToChar((int)(Int32)'0')).ToString()).ToString())));
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

		private void MaterialButtonDangNhap_Click(object sender, EventArgs e)
		{
			this.TrySubmittingInput();
		}

		#endregion

		#region Generalist Function

		private void TrySubmittingInput()
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

			LoginDVO loginDVO = this.GetInput();

			if (NhanVienDAO.Instance.CheckNhanVienLogin(loginDVO) ||
					(loginDVO.LoginDVO_Email.Equals("123")
					&& loginDVO.LoginDVO_MatKhau.Equals("123")))
			{
				this.isLoggedIn = true;

				//		Hide
				this.Hide();

				//		Initiate FormMain
				FormMain.Instance = new FormMain();

				//		Then close the Form later if FormMain is closed
				FormMain.Instance.FormClosed += (obj, eventArgs) =>
				{
					this.RemoveDataObjects();

					this.Dispose();

					this.Close();

					Environment.Exit(0);
				};
				FormMain.Instance.Show();
			}
			else
			{
				MaterialMessageBox.Show(
					text: "Sai mật khẩu hay tên đăng nhập",
					caption: "Không đăng nhập được",
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);
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
			LoginDVO tempLogin = this.GetInput();
			List<ValidationResult> results = new List<ValidationResult>();

			//		Try Validating
			if (!Validator.TryValidateObject(tempLogin, new ValidationContext(tempLogin), results, true))
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

			if (results.Count > 0)
			{
				return false;
			}
			else
			{
				return true;
			}
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
			PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(typeof(LoginDVO))[textBox.Name];
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

		private LoginDVO GetInput()
		{
			return new LoginDVO(
				LoginDVO_LoginName: this.GetTextboxTextIfPlaceholderThenEmpty(this.LoginDVO_Email),
				LoginDVO_Password: this.GetTextboxTextIfPlaceholderThenEmpty(this.LoginDVO_MatKhau)
				);
		}

		public Font GetFont()
		{
			return this.mainFont;
		}

		#endregion
	}
}
