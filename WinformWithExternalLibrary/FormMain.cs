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
using WinformWithExternalLibrary.DataValidateObjects;
using WinformWithExternalLibrary.CustomComponent;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;
using System.Collections.ObjectModel;

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
			//		GenerateData
			//BogusAmogus bogusAmogus = new BogusAmogus();
			//bogusAmogus.GenerateFakeData();

			//		NOTE: THIS ALWAYS GO FIRST
			this.InitializeComponent();

			//		Specific
			this.Initialize_NgoSachMinhHieu();
			this.Initialize_TranHongThai();
			this.Initialize_NguyenHongSon();
			this.Initialize_NguyenThanhTruc();
			this.Initialize_VuHongHanh();

			//		Attributes
			this.InitializeHardCodedAttributes();

			//		Events
			this.InitializeAutomaticEventAndList();
			this.InitializeSpecializedEvent();
		}

		#region Initialize

		//		Initializing

		private void InitializeHardCodedAttributes()
		{
			//		Material Skin Manager
			MaterialSkinManager.Instance.AddFormToManage(this);

			//		Label(s) for Focus
			this.labelForFocus.Text = "";

			//		Font
			this.Font = FormLogin.Instance.GetFont();

			//		Generalist Attributes
			foreach (TabPage tabPage in this.materialTabControl1.TabPages) 
			{ 
				foreach (Control control in tabPage.Controls)
				{
					//		Label
					if (control is Label && control.Name.Contains("Validation"))
					{
						//		Casting
						Label tempLabel = control as Label;

						//		Clear its Text
						tempLabel.Text = "";

						//		For Validation
						tempLabel.ForeColor = Color.Red;
					}
					//		DateTimePicker
					else if (control is DateTimePicker)
					{
						//		Casting
						DateTimePicker tempDateTimePicker = control as DateTimePicker;

						//		Current Day = Now
						tempDateTimePicker.Value = DateTime.Now;

						//		Max Range = Now
						tempDateTimePicker.MaxDate = DateTime.Now;
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

				foreach (Control control in this.materialTabControl1.TabPages[i].Controls)
				{
					if (control.Enabled == false)
					{
						continue;
					}

					

					//		Label
					if (control is Label && control.Name.Contains("Validation"))
					{
						//		Casting
						Label tempLabel = control as Label;

						//		Add to List
						this.listOfLabels[i].Add(tempLabel);
					}
					//		TextBoxBase (MaterialTextBox, ...)
					else if (control is TextBoxBase && control.Name.Contains("DVO"))
					{
						//		Casting
						TextBoxBase tempMaterialTextBox = control as TextBoxBase;

						//		Adding in the list
						this.isInterracted[i].Add(false);
						this.listOfTextboxes[i].Add(tempMaterialTextBox);

						//		Assigning generalist Events
						tempMaterialTextBox.GotFocus += this.MaterialTextBox_GotFocus;
						tempMaterialTextBox.LostFocus += this.MaterialTextBox_LostFocus;
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

			//		TODO: Add Insert Placeholder when entering tabPage
			//		TODO: Add DirtyData check when leaving tabPage
			//		TODO: Add reset isInterracted when entering tabPage
			this.materialTabControl1.Selecting += (obj, e) => 
			{
				
			};
		}

		#endregion

		#region Ngô Sách Minh Hiếu

		private void Initialize_NgoSachMinhHieu()
		{

		}

		#endregion

		#region Trần Hồng Thái
		private void Initialize_TranHongThai()
		{
			this.InitializeAnalyticsForm();
		}

		private void InitializeAnalyticsForm()
		{
			this.InitializeChart1();
			this.InitializeChart2();
        }

		private void InitializeChart1()
		{
			// Chart 1
			cartesianChart1.Series = new ISeries[]
			{
                new ColumnSeries<double>
				{
					Values = new ObservableCollection<double> { 10, 10, 10, 10, 10, 10, 10 },
					Stroke = null,
					Fill = new SolidColorPaint(new SKColor(30, 30, 30, 30)),
					IgnoresBarPosition = true
				},
				new ColumnSeries<double>
				{
					Values = new ObservableCollection<double> { 3, 10, 5, 3, 7, 3, 8 },
					Stroke = null,
					Fill = new SolidColorPaint(SKColors.CornflowerBlue),
					IgnoresBarPosition = true
				}
            };
        }

		private void InitializeChart2()
		{
            // Chart 2
            cartesianChart2.Series = new ISeries[]
            {
                new LineSeries<int>
				{
					Values = new [] { 4, 4, 7, 2, 8 },
					GeometrySize = 10
				},
				new LineSeries<int>
				{
					Values = new [] { 7, 5, 3, 2, 6 },
					GeometrySize = 30
				}
            };
        }

		#endregion

		#region Nguyễn Hồng Sơn

		private void Initialize_NguyenHongSon()
		{

		}

		#endregion

		#region Nguyễn Thanh Trúc

		private void Initialize_NguyenThanhTruc()
		{

		}

		#endregion

		#region Vũ Hồng Hạnh

		private void Initialize_VuHongHanh()
		{

		}

		#endregion

		#region Event

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

		#endregion

		#region Generalist Function

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
			Type propertyType = this.GetBaseDVOFromTabPage().GetType();
			string propertyName = textBox.Name;

			//		
			PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(propertyType)[propertyName];
			DisplayNameAttribute displayNameAttribute = (DisplayNameAttribute)propertyDescriptor.Attributes[typeof(DisplayNameAttribute)];

			return displayNameAttribute.DisplayName;
		}

		private void SetStringLabelForTextbox(TextBoxBase textBox, string text)
		{
			int selectedIndex = this.GetTabPageControlSelectedIndex();
			string textBoxName = textBox.Name;

			foreach (Label label in this.listOfLabels[selectedIndex])
			{
				if (label.Name.Contains(textBoxName))
				{
					label.Text = text;

					return;
				}
			}
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
				//return new HoaDonBanDTO(
				//	hoaDonBanDTO_MaNhanVien: Guid.NewGuid(),
				//	hoaDonBanDTO_NgayBan: this.dateTimePicker1.Value,
				//	hoaDonBanDTO_TongTien: 0
				//	);
			}

			return null;
		}

		private dynamic GetBaseDVOFromTabPage()
		{
			//if (this.materialTabControl1.SelectedTab == this.tabPageHoaDonBan)
			//{
			//	return new HoaDonBanDTO();
			//}

			return null;
		}

		private int GetTabPageControlSelectedIndex()
		{
			return this.materialTabControl1.SelectedIndex;
		}

		#endregion
	}
}
