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
using System.Windows.Forms.VisualStyles;
using WinformWithExternalLibrary.DataAccessObjects;
using WinformWithExternalLibrary.DataTransferObjects;

namespace WinformWithExternalLibrary
{
	public partial class FormMain : MaterialForm
	{
		public static FormMain Instance { get; set; }

		private readonly List<List<TextBoxBase>> listOfTextboxes = new List<List<TextBoxBase>>();
		private readonly List<List<Label>> listOfLabels = new List<List<Label>>();
		private readonly List<List<bool>> isInterracted = new List<List<bool>>();

		public FormMain()
		{
			//		NOTE: THIS ALWAYS GO FIRST
			this.InitializeComponent();

			//		Data Access Objects
			this.InitializeDAOs();

			//		Attributes
			this.InitializeHardCodedAttributes();

			//		Events
			this.InitializeAutomaticEventAndList();
			this.InitializeSpecializedEvent();
		}



		//		Initializing
		private void InitializeDAOs()
		{
			KhachHangDAO.Instance = new KhachHangDAO();
		}

		private void InitializeHardCodedAttributes()
		{
			//		Material Skin Manager
			MaterialSkinManager.Instance.AddFormToManage(this);

			//		Font
			this.Font = FormLogin.Instance.GetFont();

			//		Generalist Attributes
			foreach (TabPage tabPage in this.materialTabControl1.TabPages) 
			{ 
				foreach (Control control in tabPage.Controls)
				{
					//		Label
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
					//		TextBoxBase (MaterialTextBox, ...)
					else if (control is TextBoxBase)
					{
						//		Casting
						TextBoxBase tempMaterialTextBox = control as TextBoxBase;

						//		If the TextBoxBase requires validation
						if (tempMaterialTextBox.Enabled == true)
						{
							//		Get the DisplayName attribute
							tempMaterialTextBox.Text = this.GetPlaceholder(tempMaterialTextBox);
						}
					}
					//		DateTimePicker
					else if (control is DateTimePicker)
					{
						//		Casting
						DateTimePicker tempDateTimePicker = control as DateTimePicker;

						//		Max Range = Now
						tempDateTimePicker.MaxDate = DateTime.Now;

						//		Current Day = Now
						tempDateTimePicker.Value = DateTime.Now;
					}
					//		MaterialListView
					else if (control is MaterialListView)
					{
						//		Casting
						MaterialListView tempMaterialListView = control as MaterialListView;

						//		Selectable
						tempMaterialListView.FullRowSelect = true;
						tempMaterialListView.MultiSelect = true;

						//		Design
						tempMaterialListView.GridLines = true;
						tempMaterialListView.BorderStyle = BorderStyle.FixedSingle;
					}
				}
			}
		}

		private void InitializeAutomaticEventAndList()
		{
			for (int i = 0; i < this.materialTabControl1.TabPages.Count; i++)
			{
				//		Add new Lists for the TabPage to manage
				this.listOfTextboxes.Add(new List<TextBoxBase>());
				this.listOfLabels.Add(new List<Label>());
				this.isInterracted.Add(new List<bool>());

				//		TODO: Add DirtyData check when leaving tabPage
				//		TODO: Add reset isInterracted when leaving/entering tabPage

				foreach (Control control in this.materialTabControl1.TabPages[i].Controls)
				{
					//		Label
					if (control is Label)
					{
						//		Casting
						Label tempLabel = control as Label;

						//		Add to List
						this.listOfLabels[i].Add(tempLabel);
					}
					//		TextBoxBase (MaterialTextBox, ...)
					else if (control is TextBoxBase)
					{
						//		Casting
						TextBoxBase tempMaterialTextBox = control as TextBoxBase;

						//		If the TextBoxBase requires validation
						if (tempMaterialTextBox.Enabled == true)
						{
							//		Adding in the list
							this.isInterracted[i].Add(false);
							this.listOfTextboxes[i].Add(tempMaterialTextBox);

							//		Assigning generalist Events
							tempMaterialTextBox.GotFocus += this.MaterialTextBox_GotFocus;
							tempMaterialTextBox.LostFocus += this.MaterialTextBox_LostFocus;
						}
					}
					//		DateTimePicker
					else if (control is DateTimePicker)
					{
						//		Casting
						DateTimePicker tempDateTimePicker = control as DateTimePicker;

						//		Event
						tempDateTimePicker.ValueChanged += (obj, e) =>
						{
							this.TryValidation();
						};
					}
				}
			}
		}

		private void InitializeSpecializedEvent()
		{
			//		Form
			this.FormClosing += (obj, e) =>
			{
				//		TODO: if data not saved (DirtyData) -> ask if want to save

				if (e.Cancel == false)
				{
					Instance = null;

					this.Dispose();

					this.Close();
				}
			};

			this.Load += (obj, e) =>
			{
				this.FormBorderStyle = FormBorderStyle.None;
				this.WindowState = FormWindowState.Maximized;

				this.MinimumSize = this.Size;
				this.MaximumSize = this.Size;
			};

			//		Test 
			this.materialButtonTaoMoiKhachHang.Click += (obj, e) =>
			{
				FormCreateKhachHang formCreateKhachHang = new FormCreateKhachHang
				(
				onlyOnce: true
				);

				formCreateKhachHang.Show();
			};

			this.materialButtonTest.Click += (obj, e) =>
			{
				//		TODO: Create a Form and measure its Size
				//			TODO: What if create a Winform with a TabControl to make it easier?
			};
		}



		//		Event Section
		private void MaterialTextBox_GotFocus(object sender, EventArgs e)
		{
			int selectedIndex = this.GetTabPageControlSelectedIndex();
			TextBoxBase textboxTemp = sender as TextBoxBase;

			this.isInterracted
					[selectedIndex]
					[this.listOfTextboxes[selectedIndex].IndexOf(textboxTemp)] = true;

			textboxTemp.Text = this.GetTextboxTextIfPlaceholderThenEmpty(textboxTemp);
		}

		private void MaterialTextBox_LostFocus(object sender, EventArgs e)
		{
			TextBoxBase textboxTemp = sender as TextBoxBase;

			textboxTemp.Text = this.GetTextboxTextIfEmptyThenPlaceholder(textboxTemp);

			this.TryValidation();
		}


		//		Generalist Functions
		private bool TryValidation()
		{
			//		Selected TabPage
			int selectedIndex = this.GetTabPageControlSelectedIndex();

			//		Reset Validation
			foreach (Label label in this.listOfLabels[selectedIndex])
			{
				label.Text = "";
			}

			//		New Object
			dynamic tempObject = this.GetInput();

			List<ValidationResult> results = new List<ValidationResult>();

			//		Try Validating
			if (!Validator.TryValidateObject(tempObject, new ValidationContext(tempObject), results, true))
			{
				foreach (ValidationResult result in results)
				{
					for (int i = 0; i < this.listOfTextboxes.Count; i++)
					{
						if (result.MemberNames.Contains(this.listOfTextboxes[selectedIndex][i].Name) &&
							this.CheckIfTextboxInterracted(this.listOfTextboxes[selectedIndex][i]))
						{
							this.SetStringLabelForTextbox(this.listOfTextboxes[selectedIndex][i], result.ErrorMessage);
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
			int selectedIndex = this.GetTabPageControlSelectedIndex();

			return this.isInterracted
					[selectedIndex]
					[this.listOfTextboxes[selectedIndex].IndexOf(textBox)];
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
			//		Get Type + Attribute Name
			//			NOTE: The name of the Textbox == Attribute Name
			Type propertyType = this.GetBaseDTOFromTabPage().GetType();
			string propertyName = textBox.Name;

			//		
			PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(propertyType)[propertyName];
			DisplayNameAttribute displayNameAttribute = (DisplayNameAttribute)propertyDescriptor.Attributes[typeof(DisplayNameAttribute)];

			return displayNameAttribute.DisplayName;
		}

		private void SetStringLabelForTextbox(TextBoxBase textBox, string text)
		{
			int selectedIndex = this.GetTabPageControlSelectedIndex();

			this.listOfLabels
					[selectedIndex]
					[this.listOfTextboxes[selectedIndex].IndexOf(textBox)]
					.Text = text;
		}

		private dynamic GetInput()
		{
			//		TODO: If Else XD

			//return new KhachHangDTO(
			//	khachHangDTO_Name: this.GetTextboxTextIfPlaceholderThenEmpty(this.KhachHangDTO_Name),
			//	khachHangDTO_Address: this.GetTextboxTextIfPlaceholderThenEmpty(this.KhachHangDTO_Address),
			//	khachHangDTO_PhoneNumber: this.GetTextboxTextIfPlaceholderThenEmpty(this.KhachHangDTO_PhoneNumber)
			//	);

			//		TESTING
			if (this.materialTabControl1.SelectedTab == this.tabPageHoaDonBan)
			{
				return new HoaDonBanDTO(
					hoaDonBanDTO_MaNhanVien: Guid.NewGuid(),
					hoaDonBanDTO_NgayBan: this.dateTimePicker1.Value,
					hoaDonBanDTO_TongTien: 0
					);
			}

			return new KhachHangDTO();
		}

		private dynamic GetBaseDTOFromTabPage()
		{
			if (this.materialTabControl1.SelectedTab == this.tabPageHoaDonBan)
			{
				return new HoaDonBanDTO();
			}

			return null;
		}

		private int GetTabPageControlSelectedIndex()
		{
			return this.materialTabControl1.SelectedIndex;
		}
	}
}
