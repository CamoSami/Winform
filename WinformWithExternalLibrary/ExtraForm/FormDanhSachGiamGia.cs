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
using WinformWithExternalLibrary.DataValidateObjects;

namespace WinformWithExternalLibrary.ExtraForm
{
	public partial class FormDanhSachGiamGia : MaterialForm
	{
		//		m làm thêm nút load lại + nút xóa + nút Excel!

		private readonly List<TextBoxBase> listOfTextboxes = new List<TextBoxBase>();
		private readonly List<Label> listOfLabels = new List<Label>();
		private readonly List<bool> isInterracted = new List<bool>();

		public FormDanhSachGiamGia()
		{
			InitializeComponent();

			//		Attributes
			this.InitializeHardCodedAttributes();

			//		Events
			this.InitializeSpecializedEvent();

		}

		#region Initialize

		private void InitializeHardCodedAttributes()
		{
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

		#endregion

		#region Generalist Function

		private void InitializeSpecializedEvent()
		{
			this.Load += (obj, e) =>
			{
				this.ResetColorForLabel();
			};

			this.Load += (obj, e) => 
			{
				DataTable dataTable = GiamGiaDAO.Instance.GetAllGiamGia();

				this.LoadGiamGia(dataTable);
			};

			this.FormDanhSachGiamGia_btnThemGG.Click += (obj, e) =>
			{
				FormCreateGiamGia formCreateGiamGia = new FormCreateGiamGia();

				formCreateGiamGia.Show();
			};

			this.FormDanhSachGiamGia_btnSuaGG.Click += (obj, e) =>
			{
				if (this.FormDanhSachGiamGia_materialListView.SelectedIndices.Count <= 0)
				{
					this.ShowMessageBox("Hãy chọn mã giảm giá bạn muốn sửa!");

					//		Tránh chạy code bên dưới
					return;
				}

				ListViewItem listViewItem = this.FormDanhSachGiamGia_materialListView.SelectedItems[0];

				FormCreateGiamGiaDVO formCreateGiamGiaDVO = new FormCreateGiamGiaDVO();

				Guid maGiamGia = Guid.Parse(listViewItem.SubItems[1].Text);
				formCreateGiamGiaDVO.FormCreateGiamGiaDVO_TenGiamGia = listViewItem.SubItems[2].Text;
				formCreateGiamGiaDVO.FormCreateGiamGiaDVO_PhanTramGiamGia = float.Parse(listViewItem.SubItems[3].Text);
				formCreateGiamGiaDVO.FormCreateGiamGiaDVO_MaxGiamGia = long.Parse(listViewItem.SubItems[4].Text);
				formCreateGiamGiaDVO.FormCreateGiamGiaDVO_NgayBatDau = DateTime.Parse(listViewItem.SubItems[5].Text);
				formCreateGiamGiaDVO.FormCreateGiamGiaDVO_NgayKetThuc = DateTime.Parse(listViewItem.SubItems[6].Text);

				FormCreateGiamGia formCreateGiamGia = new FormCreateGiamGia(formCreateGiamGiaDVO, maGiamGia, true);

				formCreateGiamGia.Show();
			};
		}

		private void LoadGiamGia(System.Data.DataTable giamGia)
		{
			FormDanhSachGiamGia_materialListView.Items.Clear();
			ListViewItem items;

			int Count = 0;

			foreach (DataRow row in giamGia.Rows)
			{
				items = new ListViewItem();

				Count++;

				items.SubItems[0].Text = Count.ToString();

				for (int i = 0; i < giamGia.Columns.Count; i++)
				{
					items.SubItems.Add(row[i].ToString().Trim());
				}
				this.FormDanhSachGiamGia_materialListView.Items.Add(items);
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