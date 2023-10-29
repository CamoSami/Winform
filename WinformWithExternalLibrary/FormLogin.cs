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

		private readonly List<TextBoxBase> listOfTextboxes = new List<TextBoxBase>();
		private readonly List<Label> listOfLabels = new List<Label>();
		private readonly List<bool> isInterracted = new List<bool>();

		private bool isLoggedIn = false;
		private bool hasLeft = false;

		public FormLogin()
		{
			//		NOTE: THIS ALWAYS GO FIRST
			this.InitializeComponent();

			//		Assigning Essential
			this.InitializeHardCodedAttributes();

			//		Event
			this.InitializeAutomaticEvent();
			this.InitializeSpecializedEvent();
		}

		#region Initialize

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
			MaterialSkinManager.Instance.ColorScheme = new ColorScheme
				(
				primary: Primary.Pink200,
				darkPrimary: Primary.Pink400,
				lightPrimary: Primary.Pink400,
				accent: Accent.Pink100,
				textShade: TextShade.WHITE
				);

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

		private void InitializeAutomaticEvent()
		{
			foreach (Control control in this.Controls)
			{
				if (control is Label && control.Name.Contains("Validation"))
				{
					Label tempLabel = control as Label;

					this.listOfLabels.Add(tempLabel);
				}
				else if (control is TextBoxBase)
				{
					//		
					TextBoxBase tempTextBoxBase = control as TextBoxBase;

					if (tempTextBoxBase.Enabled == true)
					{
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
		}

		private void InitializeSpecializedEvent()
		{
			//		Textbox
			this.LoginDTO_Password.GotFocus += (obj, e) =>
			{
				this.LoginDTO_Password.Password = true;
			};

			this.LoginDTO_Password.LostFocus += (obj, e) =>
			{
				if (this.CheckIfTextboxEmptyOrPlaceholder(this.LoginDTO_Password))
				{
					this.LoginDTO_Password.Password = false;
				}
			};

			//		Button
			this.materialButtonDangNhap.Click += this.MaterialButtonDangNhap_Click;

			this.materialButtonThoat.Click += this.MaterialButtonThoat_Click;

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
						== DialogResult.No
						)
					{
						e.Cancel = true;
					}
				}

				if (e.Cancel == false)
				{
					FormLogin.Instance = null;

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

		#endregion

		#region Event

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

		private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			
		}

		private void MaterialButtonThoat_Click(object sender, EventArgs e)
		{
			Instance = null;

			this.Close();
		}

		private void MaterialButtonDangNhap_Click(object sender, EventArgs e)
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

			//		[HARDCODE] Try comparing
			else if (this.CheckTextboxTextEqualToString(this.LoginDTO_LoginName, "123") &&
				this.CheckTextboxTextEqualToString(this.LoginDTO_Password, "123"))
			{
				//		[MAY NEED] Try Connecting => Login via Usernames and Password from DTB
				if (!this.InitiateAndTestDataProvider())
				{
					return;
				}

				MaterialMessageBox.Show(
					text: "Đăng nhập được rồi nè ~.~",
					caption: "~^~",
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);

				this.isLoggedIn = true;

				//		Hide
				this.Hide();

				//		Initiate FormMain
				FormMain.Instance = new FormMain();

				//		Then close the Form later if FormMain is closed
				FormMain.Instance.FormClosed += (obj, eventArgs) =>
				{
					this.Dispose();

					this.Close();

					Environment.Exit(0);
				};
				FormMain.Instance.Show();
			}
			else
			{
				MaterialMessageBox.Show(
					text: "Sai mật khẩu hay tên đăng nhập rồi ._.",
					caption: ".-.",
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);
			}
		}

		#endregion

		#region Generalist Function

		private bool InitiateAndTestDataProvider()
		{
			if (DataProvider.Instance == null)
			{
				DataProvider.Instance = new DataProvider();
			}

			return DataProvider.Instance.TestConnection();

			//Console.WriteLine(DataProvider.Instance.TestConnection());
		}

		private bool TryValidation()
		{
			//		Reset Validation
			foreach (Label label in this.listOfLabels)
			{
				label.Text = "";
			}

			//		New Object
			LoginDVO tempLogin = new LoginDVO(
				LoginDTO_LoginName: this.GetTextboxTextIfPlaceholderThenEmpty(this.LoginDTO_LoginName),
				LoginDTO_Password: this.GetTextboxTextIfPlaceholderThenEmpty(this.LoginDTO_Password)
				);
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

		public Font GetFont()
		{
			return this.mainFont;
		}

		#endregion
	}
}
