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
using WinformWithExternalLibrary._DataProvider;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;
using System.Collections.ObjectModel;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.Measure;
using WinformWithExternalLibrary.DataTransferObjects;
using static WinformWithExternalLibrary.DataTransferObjects.PhanTichDTO;
using System.Diagnostics;
using System.Windows.Controls.Primitives;
using WinformWithExternalLibrary._Utilities;
using WinformWithExternalLibrary.ExtraForm;
using System.Runtime.Remoting.Channels;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace WinformWithExternalLibrary
{
	public partial class FormMain : MaterialForm
	{
		//		Instance
		public static FormMain Instance { get; set; }

		//		Sort
		private readonly List<List<Control>> listOfControlsDVO = new List<List<Control>>();
		private readonly List<List<Label>> listOfLabelsDVO = new List<List<Label>>();
		private readonly List<List<bool>> isInterracted = new List<List<bool>>();

		//		Utilities
		private readonly FormatValues formatValues = new FormatValues();
		private readonly GetDateTime getDateTime = new GetDateTime();
		private readonly ExportTableData exportTableData = new ExportTableData();

		//		Miscellaneous
		//			For Settings
		private bool IfAutoValidate = false;
		//			For DirtyData Check
		private int lastTabPageIndex = 0;
		private readonly DateTime defaultDateTime = new DateTime
			(
				day: DateTime.Now.Day,
				month: DateTime.Now.Month,
				year: DateTime.Now.Year
			);

		public FormMain()
		{
			//		NOTE: THIS ALWAYS GO FIRST
			this.InitializeComponent();

			//		Attributes
			this.InitializeHardCodedAttributes();

			//		Events
			this.InitializeAutomaticEventAndList();
			this.InitializeSpecializedEvent();
			this.InitializeAutoDataSourceUpdate();
			this.InitializeContextMenuStrip();

			//		Specific
			this.Initialize_NgoSachMinhHieu();
			this.Initialize_TranHongThai();
			this.Initialize_NguyenHongSon();
			this.Initialize_BuiThiThanhTruc();
			this.Initialize_VuHongHanh();
		}

		#region Initialize

		//		Initializing
		private void InitializeContextMenuStrip()
		{
			this.ContextMenuStrip = this.contextMenuStrip;

			foreach (TabPage tabPage in this.materialTabControl.TabPages)
			{
				tabPage.ContextMenuStrip = this.contextMenuStrip;
			}

			this.darkModeToolStripMenuItem.Click += (obj, e) =>
			{
				if (this.darkModeToolStripMenuItem.Checked == true)
				{
					MaterialSkinManager.Instance.ColorScheme = FormLogin.Instance.GetColorScheme(isDark: true);
					MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.DARK;

					this.contextMenuStrip.ForeColor = Color.White;

					this.ResetColorForLabel(-1, ifAllTabPage: true);
				}
				else
				{
					MaterialSkinManager.Instance.ColorScheme = FormLogin.Instance.GetColorScheme(isDark: false);
					MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT;

					this.contextMenuStrip.ForeColor = Color.Black;

					this.ResetColorForLabel(-1, ifAllTabPage: true);
				}
			};

			this.autoValidationToolStripMenuItem.Click += (obj, e) =>
			{
				this.IfAutoValidate = this.autoValidationToolStripMenuItem.Checked;
			};
		}

		private void InitializeHardCodedAttributes()
		{
			//		Material Skin Manager
			MaterialSkinManager.Instance.AddFormToManage(this);

			//		Label(s) for Focus
			this.LabelForFocus.Text = "";

			//		Font
			this.Font = FormLogin.Instance.GetFont();

			//		Generalist Attributes
			foreach (TabPage tabPage in this.materialTabControl.TabPages)
			{
				foreach (Control control in tabPage.Controls)
				{
					//Debug.WriteLine(control.Name);

					//		Label
					if (control is Label label && label.Name.Contains("Validation"))
					{
						//		Reset
						label.Text = "";

						//		For Validation
						label.ForeColor = Color.Red;
						label.Cursor = Cursors.Default;
					}
					//		ComboBox
					else if (control is ComboBox comboBox)
					{
						//		Hardcode
						comboBox.DropDownStyle = ComboBoxStyle.DropDown;
						comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
						comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
						comboBox.SelectedIndex = -1;
						comboBox.Text = "";
					}
					//		RJDatePicker
					else if (control is RJDatePicker rJDatePicker)
					{
						//		Current Day = Now
						rJDatePicker.Value = this.defaultDateTime;

						rJDatePicker.SkinColor = System.Drawing.Color.PaleVioletRed;
						rJDatePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
					}
					//		DateTimePicker
					else if (control is DateTimePicker dateTimePicker)
					{
						//		Current Day = Now
						dateTimePicker.Value = this.defaultDateTime;

						//		Max Range = Now
						dateTimePicker.MaxDate = this.defaultDateTime;
					}
					//		MaterialListView
					else if (control is MaterialListView materialListView)
					{
						//		Selectable
						materialListView.FullRowSelect = true;
						materialListView.MultiSelect = true;

						//		Design
						materialListView.GridLines = true;
						materialListView.BorderStyle = BorderStyle.FixedSingle;

						//		Extra
						materialListView.Scrollable = true;
					}
				}
			}
		}

		private void InitializeAutomaticEventAndList()
		{
			for (int i = 0; i < this.materialTabControl.TabPages.Count; i++)
			{
				//		Add new Lists for the TabPage to manage
				this.listOfControlsDVO.Add(new List<Control>());
				this.listOfLabelsDVO.Add(new List<Label>());
				this.isInterracted.Add(new List<bool>());

				//		Reset ActiveControl
				this.materialTabControl.TabPages[i].Click += (obj, e) =>
				{
					this.ActiveControl = null;
				};

				foreach (Control control in this.materialTabControl.TabPages[i].Controls)
				{
					//		Label
					if (control is Label tempLabel && control.Name.Contains("Validation"))
					{
						//		Reset ActiveControl
						tempLabel.Click += (obj, e) =>
						{
							this.ActiveControl = null;
						};

						//		Add to List
						this.listOfLabelsDVO[i].Add(tempLabel);
					}
					//		Validate Control
					else if (control.Name.Contains("DVO"))
					{
						//Debug.WriteLine("\n" + control.Name);

						if (control is DateTimePicker dateTimePicker)
						{
							//		Adding in the list
							this.isInterracted[i].Add(false);
							this.listOfControlsDVO[i].Add(control);

							//		Event
							dateTimePicker.ValueChanged += (obj, e) =>
							{
								this.TryValidationFromControl(dateTimePicker, onlyOneControl: true, out _);
							};

							continue;
						}

						//		Get Placeholder
						control.Text = this.GetPlaceholderForControl(control);

						//		Adding in the list
						this.isInterracted[i].Add(false);
						this.listOfControlsDVO[i].Add(control);

						//		Assigning generalist Events
						control.GotFocus += this.ControlForInput_GotFocus;
						control.LostFocus += this.ControlForInput_LostFocus;
					}
				}
			}
		}

		private void InitializeSpecializedEvent()
		{
			//		Form
			this.FormClosing += (obj, e) =>
			{
				if (this.CheckIfDirtyData(this.lastTabPageIndex))
				{
					if (!this.ShowMessageBoxYesNo("Bạn còn thông tin nhập dở, bạn có muốn tắt form không?", this.lastTabPageIndex))
					{
						e.Cancel = true;

						return;
					}
				}

				if (e.Cancel == false)
				{
					Instance = null;

					this.Dispose();

					this.Close();
				}
			};

			//		Set to FullScreen
			//		Set MaximumSize and MinimumSize to FullScreen
			//		Set ActiveControl to nothing
			this.Load += (obj, e) =>
			{
				this.FormBorderStyle = FormBorderStyle.None;
				this.WindowState = FormWindowState.Maximized;

				this.MinimumSize = this.Size;
				this.MaximumSize = this.Size;

				this.ActiveControl = this.LabelForFocus;
			};

			//		Set ActiveControl to nothing
			this.Click += (obj, e) =>
			{
				this.ActiveControl = null;
			};

			this.materialTabControl.Selecting += (obj, e) =>
			{
				if (this.CheckIfDirtyData(this.lastTabPageIndex))
				{
					if (!this.ShowMessageBoxYesNo("Bạn còn thông tin nhập dở, bạn có muốn rời tab không?", this.lastTabPageIndex))
					{
						e.Cancel = true;

						return;
					}
					else
					{
						this.ResetInputForTabPage(this.lastTabPageIndex);
						this.ResetValidationForTabPage(this.lastTabPageIndex);
					}
				}

				this.lastTabPageIndex = this.GetTabPageControlSelectedIndex();

				this.ResetInputForTabPage(this.lastTabPageIndex);
				this.ResetValidationForTabPage(this.lastTabPageIndex);

				this.ResetColorForLabel(this.lastTabPageIndex);
			};
		}

		private void InitializeAutoDataSourceUpdate()
		{
			ChiTietHDBanDAO.Instance.OnDAODatabaseChanged += (obj, e) =>
			{

			};
			ChiTietHDNhapDAO.Instance.OnDAODatabaseChanged += (obj, e) =>
			{

			};
			CongViecDAO.Instance.OnDAODatabaseChanged += (obj, e) =>
			{

			};
			DMSanPhamDAO.Instance.OnDAODatabaseChanged += (obj, e) =>
			{
				this.UpdateDataSource(ChiTietHDBanDVO_MaSanPham, DMSanPhamDAO.Instance.GetMaSanPhamList);
				this.UpdateDataSource(ChiTietHDNhapDVO_MaSanPham, DMSanPhamDAO.Instance.GetMaSanPhamList);
			};
			GiamGiaDAO.Instance.OnDAODatabaseChanged += (obj, e) =>
			{

			};
			HoaDonBanDAO.Instance.OnDAODatabaseChanged += (obj, e) =>
			{

			};
			HoaDonNhapDAO.Instance.OnDAODatabaseChanged += (obj, e) =>
			{

			};
			KhachHangDAO.Instance.OnDAODatabaseChanged += (obj, e) =>
			{
				this.UpdateDataSource(HoaDonBanDVO_DienThoaiKhachHang, KhachHangDAO.Instance.GetPhoneNumberList);
			};
			NhaCungCapDAO.Instance.OnDAODatabaseChanged += (obj, e) =>
			{
				this.UpdateDataSource(this.HoaDonNhapDVO_DienThoaiNhaCungCap, NhaCungCapDAO.Instance.GetPhoneNumbers);
			};
			NhanVienDAO.Instance.OnDAODatabaseChanged += (obj, e) =>
			{
				this.UpdateDataSource(this.NhanVienThuNganHDNhapDVO_NhanVien, NhanVienDAO.Instance.GetTenNhanVienAndNgaySinhList);
				this.UpdateDataSource(this.NhanVienThuNganHDBanDVO_NhanVien, NhanVienDAO.Instance.GetTenNhanVienAndNgaySinhList);
			};
		}

		#endregion

		#region Event

		private void ControlForInput_GotFocus(object sender, EventArgs e)
		{
			//Debug.WriteLine("Triggered!");

			int selectedIndex = this.GetTabPageControlSelectedIndex();
			Control controlTemp = sender as Control;

			this.isInterracted
					[selectedIndex]
					[this.listOfControlsDVO[selectedIndex].IndexOf(controlTemp)] = true;

			controlTemp.Text = this.GetControlTextIfPlaceholderThenEmpty(controlTemp);
		}

		private void ControlForInput_LostFocus(object sender, EventArgs e)
		{
			Control control = sender as Control;

			control.Text = this.GetControlTextIfEmptyThenPlaceholder(control);

			if (this.IfAutoValidate)
			{
				this.TryValidationFromControl(
						control: control,
						onlyOneControl: true,
						out _);
			}
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

		#endregion

		#region Ngô Sách Minh Hiếu

		//		Variable
		private double TabPageHoaDonBan_phanTramGiamGia = 0f;
		private long TabPageHoaDonBan_maxGiamGia = 0;

		//		Initialize
		private void Initialize_NgoSachMinhHieu()
		{
			this.Initialize_HoaDonBan();
			this.Initialize_HoaDonNhap();
		}

		#region HoaDonNhap

		private void Initialize_HoaDonNhap()
		{
			this.UpdateDataSource(this.NhanVienThuNganHDNhapDVO_NhanVien, NhanVienDAO.Instance.GetTenNhanVienAndNgaySinhList);
			this.UpdateDataSource(this.ChiTietHDNhapDVO_MaSanPham, DMSanPhamDAO.Instance.GetMaSanPhamList);
			this.UpdateDataSource(this.HoaDonNhapDVO_DienThoaiNhaCungCap, NhaCungCapDAO.Instance.GetPhoneNumbers);

			//		Event For Validate Controls
			//			TabPageHoaDonNhap_MaterialListView
			this.TabPageHoaDonNhap_MaterialListView.SelectedIndexChanged += (obj, e) =>
			{
				//		Nothing
				if (this.TabPageHoaDonNhap_MaterialListView.SelectedIndices.Count <= 0)
				{
					return;
				}

				//		Update Controls
				int index = this.TabPageHoaDonNhap_MaterialListView.SelectedIndices[0];

				if (index >= 0)
				{
					ListViewItem listViewItem = this.TabPageHoaDonNhap_MaterialListView.Items[index];

					this.ChiTietHDNhapDVO_MaSanPham.Text = listViewItem.SubItems[1].Text;
					this.ChiTietHDNhapDVO_TenSanPham.Text = listViewItem.SubItems[2].Text;
					this.ChiTietHDNhapDVO_SoLuong.Text = listViewItem.SubItems[3].Text;
				}

				//		Update Focus
				this.ActiveControl = this.ChiTietHDNhapDVO_MaSanPham;
			};

			//			HoaDonNhapDVO_DienThoaiNhaCungCap
			this.HoaDonNhapDVO_DienThoaiNhaCungCap.KeyPress += this.TextBoxBase_KeyPress_NumericOnly;
			//				Auto Completion
			this.HoaDonNhapDVO_DienThoaiNhaCungCap.LostFocus += (obj, e) =>
			{
				if (this.TryValidationFromControl(
						control: obj as Control,
						onlyOneControl: true,
						baseDVO: out _))
				{
					Control control = obj as Control;

					this.HoaDonNhapDVO_TenNhaCungCap.Text = NhaCungCapDAO.Instance.GetNameWithPhoneNumber(this.HoaDonNhapDVO_DienThoaiNhaCungCap.Text);
				}
			};
			this.HoaDonNhapDVO_DienThoaiNhaCungCap.SelectedIndexChanged += (obj, e) =>
			{
				if (this.TryValidationFromControl(
						control: obj as Control,
						onlyOneControl: true,
						baseDVO: out _))
				{
					Control control = obj as Control;

					this.HoaDonNhapDVO_TenNhaCungCap.Text = NhaCungCapDAO.Instance.GetNameWithPhoneNumber(this.HoaDonNhapDVO_DienThoaiNhaCungCap.Text);
				}
			};

			//			ChiTietHDNhapDVO_MaSanPham
			this.ChiTietHDNhapDVO_MaSanPham.KeyPress += this.TextBoxBase_KeyPress_NumericOnly;
			//				Auto Completion
			this.ChiTietHDNhapDVO_MaSanPham.LostFocus += (obj, e) =>
			{
				if (this.TryValidationFromControl(
						control: obj as Control,
						onlyOneControl: true,
						baseDVO: out _))
				{
					this.ChiTietHDNhapDVO_TenSanPham.Text = DMSanPhamDAO.Instance.GetTenSanPhamWithMaSanPham(this.ChiTietHDNhapDVO_MaSanPham.Text);

					this.ActiveControl = this.ChiTietHDNhapDVO_SoLuong;

					if (this.CheckIfControlEmptyOrPlaceholder(this.ChiTietHDNhapDVO_SoLuong))
					{
						this.ChiTietHDNhapDVO_SoLuong.Text = 1.ToString();
					}
					this.ChiTietHDNhapDVO_SoLuong.SelectionStart = this.ChiTietHDNhapDVO_SoLuong.Text.Length;
				}
			};
			this.ChiTietHDNhapDVO_MaSanPham.SelectedIndexChanged += (obj, e) =>
			{
				if (this.TryValidationFromControl(
						control: obj as Control,
						onlyOneControl: true,
						baseDVO: out _))
				{
					this.ChiTietHDNhapDVO_TenSanPham.Text = DMSanPhamDAO.Instance.GetTenSanPhamWithMaSanPham(this.ChiTietHDNhapDVO_MaSanPham.Text);

					this.ActiveControl = this.ChiTietHDNhapDVO_SoLuong;

					if (this.CheckIfControlEmptyOrPlaceholder(this.ChiTietHDNhapDVO_SoLuong))
					{
						this.ChiTietHDNhapDVO_SoLuong.Text = 1.ToString();
					}
					this.ChiTietHDNhapDVO_SoLuong.SelectionStart = this.ChiTietHDNhapDVO_SoLuong.Text.Length;
				}
			};

			//			NhanVienThuNganHDNhapDVO_NhanVien
			//				Auto Completion
			this.NhanVienThuNganHDNhapDVO_NhanVien.LostFocus += (obj, e) =>
			{
				if (this.TryValidationFromControl(
							control: obj as Control,
							onlyOneControl: true,
							baseDVO: out _))
				{
					this.ActiveControl = this.ChiTietHDNhapDVO_MaSanPham;
				}
			};
			this.NhanVienThuNganHDNhapDVO_NhanVien.SelectedIndexChanged += (obj, e) =>
			{
				if (this.TryValidationFromControl(
							control: obj as Control,
							onlyOneControl: true,
							baseDVO: out _))
				{
					this.ActiveControl = this.ChiTietHDNhapDVO_MaSanPham;
				}
			};

			//			ChiTietHDNhapDVO_SoLuong
			this.ChiTietHDNhapDVO_SoLuong.KeyDown += (obj, e) =>
			{
				//		If Enter
				if (e.KeyCode == Keys.Enter)
				{
					this.NewChiTietHDNhap();
				}
			};

			//		Event For Buttons
			//			TabPageHoaDonNhap_ButtonTaoSanPham
			//				TODO:	Finish
			this.TabPageHoaDonNhap_ButtonTaoSanPham.Click += (obj, e) =>
			{

			};

			//			TabPageHoaDonNhap_ButtonNhapSanPham
			this.TabPageHoaDonNhap_ButtonNhapSanPham.Click += (obj, e) =>
			{
				this.NewChiTietHDNhap();
			};

			//			TabPageHoaDonNhap_ButtonXoaSanPham
			this.TabPageHoaDonNhap_ButtonXoaSanPham.Click += (obj, e) =>
			{
				//		Nothing is picked isn't it
				if (this.TabPageHoaDonNhap_MaterialListView.SelectedIndices.Count <= 0)
				{
					this.ShowMessageBox(message: "Xin vui lòng chọn sản phẩm cần xóa");

					return;
				}
				//		Else, delete the ones highlighted
				else
				{
					ListView.SelectedListViewItemCollection selectedItems = this.TabPageHoaDonNhap_MaterialListView.SelectedItems;

					//		Remove
					foreach (ListViewItem item in selectedItems)
					{
						this.UpdateTongTienHDNhap(
								tien: long.Parse(item.SubItems[5].Text),
								biTru: true);

						this.TabPageHoaDonNhap_MaterialListView.Items.Remove(item);
					}

					//		Re-Indexing
					for (int i = 0; i < this.TabPageHoaDonNhap_MaterialListView.Items.Count; i++)
					{
						this.TabPageHoaDonNhap_MaterialListView.Items[i].SubItems[0].Text = (i + 1).ToString();
					}

					//		Focus
					this.ActiveControl = this.ChiTietHDNhapDVO_MaSanPham;

					//		Reset Input
					this.ResetInputForControl(this.ChiTietHDNhapDVO_MaSanPham, false);
				}
			};

			//			TabPageHoaDonNhap_ButtonNhapMoiSanPham
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.Click += (obj, e) =>
			{
				if (this.ShowMessageBoxYesNo(message: "Bạn có muốn nhập mới sản phẩm không?"))
				{
					this.ResetInputForControl(this.ChiTietHDNhapDVO_MaSanPham, false);

					return;
				}
			};

			//			TabPageHoaDonNhap_ButtonTaoNhaCungCap
			//				TODO: finish
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.Click += (obj, e) =>
			{

			};

			//			TabPageHoaDonNhap_ButtonNhapHoaDon
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.Click += (obj, e) =>
			{
				Debug.WriteLine("TabPageHoaDonNhap_ButtonNhapHoaDon Triggered!");

				if (this.TryValidationFromControl(this.HoaDonNhapDVO_DienThoaiNhaCungCap, onlyOneControl: false, out dynamic baseHoaDonNhap) &&
					this.TryValidationFromControl(this.NhanVienThuNganHDNhapDVO_NhanVien, onlyOneControl: false, out dynamic baseNhanVienThuNgan))
				{
					//		Validated!

					Debug.WriteLine("TabPageHoaDonNhap_ButtonNhapHoaDon Validated!");

					//		...Nothing?
					if (this.TabPageHoaDonNhap_MaterialListView.Items.Count <= 0)
					{
						this.ShowMessageBox(message: "Chưa có sản phẩm trong đơn hàng");

						return;
					}

					//		Casting
					NhanVienThuNganHDNhapDVO nhanVienThuNganDVO = baseNhanVienThuNgan as NhanVienThuNganHDNhapDVO;
					HoaDonNhapDVO hoaDonNhapDVO = baseHoaDonNhap as HoaDonNhapDVO;

					//		Show another Confirmation Form
					FormConfirmHoaDonNhap formConfirmHoaDonNhap = new FormConfirmHoaDonNhap(hoaDonNhapDVO, nhanVienThuNganDVO);
					formConfirmHoaDonNhap.FormClosing += (_obj, _e) =>
					{
						this.ResetColorForLabel(this.GetTabPageControlSelectedIndex());
					};

					formConfirmHoaDonNhap.Show();
					formConfirmHoaDonNhap.Activate();
				}
			};

			//			TabPageHoaDonNhap_ButtonNhapMoiHoaDon
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.Click += (obj, e) =>
			{
				if (this.ShowMessageBoxYesNo(message: "Bạn có chắc muốn nhập mới hóa đơn không?"))
				{
					this.ResetHoaDonNhapAndChiTietHDNhap();

					return;
				}
			};
		}

		#endregion

		#region HoaDonBan

		private void Initialize_HoaDonBan()
		{
			this.UpdateDataSource(NhanVienThuNganHDBanDVO_NhanVien, NhanVienDAO.Instance.GetTenNhanVienAndNgaySinhList);
			this.UpdateDataSource(ChiTietHDBanDVO_MaSanPham, DMSanPhamDAO.Instance.GetMaSanPhamList);
			this.UpdateDataSource(HoaDonBanDVO_DienThoaiKhachHang, KhachHangDAO.Instance.GetPhoneNumberList);

			//		Event For Validate Controls
			//			TabPageHoaDonBan_materialListView
			this.TabPageHoaDonBan_MaterialListView.SelectedIndexChanged += (obj, e) =>
			{
				//		Nothing
				if (this.TabPageHoaDonBan_MaterialListView.SelectedIndices.Count <= 0)
				{
					return;
				}

				//		Update Controls
				int index = this.TabPageHoaDonBan_MaterialListView.SelectedIndices[0];

				if (index >= 0)
				{
					ListViewItem listViewItem = this.TabPageHoaDonBan_MaterialListView.Items[index];

					this.ChiTietHDBanDVO_MaSanPham.Text = listViewItem.SubItems[1].Text;
					this.ChiTietHDBanDVO_TenSanPham.Text = listViewItem.SubItems[2].Text;
					this.ChiTietHDBanDVO_SoLuong.Text = listViewItem.SubItems[3].Text;
				}

				//		Update Focus
				this.ActiveControl = this.ChiTietHDBanDVO_MaSanPham;
			};

			//			HoaDonBanDVO_DienThoaiKhachHang
			this.HoaDonBanDVO_DienThoaiKhachHang.KeyPress += this.TextBoxBase_KeyPress_NumericOnly;
			//				Auto Completion
			this.HoaDonBanDVO_DienThoaiKhachHang.LostFocus += (obj, e) =>
			{
				if (this.TryValidationFromControl(
						control: obj as Control,
						onlyOneControl: true,
						baseDVO: out _))
				{
					Control control = obj as Control;

					if (this.CheckIfControlEmptyOrPlaceholder(control))
					{
						return;
					}

					this.HoaDonBanDVO_TenKhachHang.Text = KhachHangDAO.Instance.GetTenKhachHangWithPhoneNumber(this.HoaDonBanDVO_DienThoaiKhachHang.Text);

					this.ActiveControl = this.HoaDonBanDVO_TenGiamGia;
				}
			};
			this.HoaDonBanDVO_DienThoaiKhachHang.SelectedIndexChanged += (obj, e) =>
			{
				if (this.TryValidationFromControl(
						control: obj as Control,
						onlyOneControl: true,
						baseDVO: out _))
				{
					Control control = obj as Control;

					if (this.CheckIfControlEmptyOrPlaceholder(control))
					{
						return;
					}

					this.HoaDonBanDVO_TenKhachHang.Text = KhachHangDAO.Instance.GetTenKhachHangWithPhoneNumber(this.HoaDonBanDVO_DienThoaiKhachHang.Text);

					this.ActiveControl = this.HoaDonBanDVO_TenGiamGia;
				}
			};

			//			ChiTietHDBanDVO_MaSanPham
			this.ChiTietHDBanDVO_MaSanPham.KeyPress += this.TextBoxBase_KeyPress_NumericOnly;
			//				Auto Completion
			this.ChiTietHDBanDVO_MaSanPham.LostFocus += (obj, e) =>
			{
				if (this.TryValidationFromControl(
						control: obj as Control,
						onlyOneControl: true,
						baseDVO: out _))
				{
					this.ChiTietHDBanDVO_TenSanPham.Text = DMSanPhamDAO.Instance.GetTenSanPhamWithMaSanPham(this.ChiTietHDBanDVO_MaSanPham.Text);

					this.ActiveControl = this.ChiTietHDBanDVO_SoLuong;

					if (this.CheckIfControlEmptyOrPlaceholder(this.ChiTietHDBanDVO_SoLuong))
					{
						this.ChiTietHDBanDVO_SoLuong.Text = 1.ToString();
					}
					this.ChiTietHDBanDVO_SoLuong.SelectionStart = this.ChiTietHDBanDVO_SoLuong.Text.Length;
				}
			};
			this.ChiTietHDBanDVO_MaSanPham.SelectedIndexChanged += (obj, e) =>
			{
				if (this.TryValidationFromControl(
						control: obj as Control,
						onlyOneControl: true,
						baseDVO: out _))
				{
					this.ChiTietHDBanDVO_TenSanPham.Text = DMSanPhamDAO.Instance.GetTenSanPhamWithMaSanPham(this.ChiTietHDBanDVO_MaSanPham.Text);

					this.ActiveControl = this.ChiTietHDBanDVO_SoLuong;

					if (this.CheckIfControlEmptyOrPlaceholder(this.ChiTietHDBanDVO_SoLuong))
					{
						this.ChiTietHDBanDVO_SoLuong.Text = 1.ToString();
					}
					this.ChiTietHDBanDVO_SoLuong.SelectionStart = this.ChiTietHDBanDVO_SoLuong.Text.Length;
				}
			};

			//			HoaDonBanDVO_NhanVien
			//				Auto Completion
			this.NhanVienThuNganHDBanDVO_NhanVien.LostFocus += (obj, e) =>
			{
				if (this.TryValidationFromControl(
							control: obj as Control,
							onlyOneControl: true,
							baseDVO: out _))
				{
					this.ActiveControl = this.ChiTietHDBanDVO_MaSanPham;
				}
			};
			this.NhanVienThuNganHDBanDVO_NhanVien.SelectedIndexChanged += (obj, e) =>
			{
				if (this.TryValidationFromControl(
							control: obj as Control,
							onlyOneControl: true,
							baseDVO: out _))
				{
					this.ActiveControl = this.ChiTietHDBanDVO_MaSanPham;
				}
			};

			//			HoaDonBanDVO_TenGiamGia
			this.HoaDonBanDVO_TenGiamGia.LostFocus += (obj, e) =>
			{
				if (this.TryValidationFromControl(this.HoaDonBanDVO_TenGiamGia, onlyOneControl: true, out dynamic baseDVO) &&
					!this.CheckIfControlEmptyOrPlaceholder(this.HoaDonBanDVO_TenGiamGia))
				{
					HoaDonBanDVO hoaDonBanDVO = baseDVO as HoaDonBanDVO;

					System.Data.DataTable dataTable = GiamGiaDAO.Instance.GetDetailGiamGia(hoaDonBanDVO.HoaDonBanDVO_TenGiamGia);

					this.TabPageHoaDonBan_maxGiamGia = long.Parse(dataTable.Rows[0][0].ToString());
					this.TabPageHoaDonBan_phanTramGiamGia = double.Parse(dataTable.Rows[0][1].ToString());
				}
				else
				{
					this.TabPageHoaDonBan_maxGiamGia = 0;
					this.TabPageHoaDonBan_phanTramGiamGia = 0f;
				}

				this.UpdateTongTienHDBan(tien: 0, biTru: true);
			};

			//			ChiTietHDBanDVO_SoLuong
			this.ChiTietHDBanDVO_SoLuong.KeyDown += (obj, e) =>
			{
				//		If Enter
				if (e.KeyCode == Keys.Enter)
				{
					this.NewChiTietHDBan();
				}
			};

			//		Event For Buttons
			//			TabPageHoaDonBan_ButtonTaoSanPham
			//				TODO:	Finish
			this.TabPageHoaDonBan_ButtonTaoSanPham.Click += (obj, e) =>
			{

			};

			//			TabPageHoaDonBan_ButtonNhapChiTiet
			this.TabPageHoaDonBan_ButtonNhapSanPham.Click += (obj, e) =>
			{
				this.NewChiTietHDBan();
			};

			//			TabPageHoaDonBan_ButtonXoaSanPham
			this.TabPageHoaDonBan_ButtonXoaSanPham.Click += (obj, e) =>
			{
				//		Nothing is picked isn't it
				if (this.TabPageHoaDonBan_MaterialListView.SelectedIndices.Count <= 0)
				{
					this.ShowMessageBox(message: "Xin vui lòng chọn sản phẩm cần xóa");

					return;
				}
				//		Else, delete the ones highlighted
				else
				{
					ListView.SelectedListViewItemCollection selectedItems = this.TabPageHoaDonBan_MaterialListView.SelectedItems;

					//		Remove
					foreach (ListViewItem item in selectedItems)
					{
						this.UpdateTongTienHDBan(
								tien: long.Parse(item.SubItems[5].Text),
								biTru: true);

						this.TabPageHoaDonBan_MaterialListView.Items.Remove(item);
					}

					//		Re-Indexing
					for (int i = 0; i < this.TabPageHoaDonBan_MaterialListView.Items.Count; i++)
					{
						this.TabPageHoaDonBan_MaterialListView.Items[i].SubItems[0].Text = (i + 1).ToString();
					}

					//		Focus
					this.ActiveControl = this.ChiTietHDBanDVO_MaSanPham;

					//		Reset Input
					this.ResetInputForControl(this.ChiTietHDBanDVO_MaSanPham, false);
				}
			};

			//			TabPageHoaDonBan_ButtonTaoMoiSanPham
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.Click += (obj, e) =>
			{
				if (this.ShowMessageBoxYesNo(message: "Bạn có muốn nhập mới sản phẩm không?"))
				{
					this.ResetInputForControl(this.ChiTietHDBanDVO_MaSanPham, false);

					return;
				}
			};

			//			TabPageHoaDonBan_ButtonTaoKhachHang
			this.TabPageHoaDonBan_ButtonTaoKhachHang.Click += (obj, e) =>
			{
				FormCreateKhachHang formCreateKhachHang = new FormCreateKhachHang
				(
					onlyOnce: true
				);

				formCreateKhachHang.Show();
			};

			//			TabPageHoaDonBan_ButtonNhapHoaDon
			this.TabPageHoaDonBan_ButtonNhapHoaDon.Click += (obj, e) =>
			{
				if (this.TryValidationFromControl(this.HoaDonBanDVO_TongTien, onlyOneControl: false, out dynamic baseHoaDonBan) &&
					this.TryValidationFromControl(this.NhanVienThuNganHDBanDVO_NhanVien, onlyOneControl: false, out dynamic baseNhanVienThuNgan))
				{
					//		Validated!

					//		...Nothing?
					if (this.TabPageHoaDonBan_MaterialListView.Items.Count <= 0)
					{
						this.ShowMessageBox(message: "Chưa có sản phẩm trong đơn hàng");

						return;
					}

					//		Casting
					NhanVienThuNganHDBanDVO nhanVienThuNganDVO = baseNhanVienThuNgan as NhanVienThuNganHDBanDVO;
					HoaDonBanDVO hoaDonBanDVO = baseHoaDonBan as HoaDonBanDVO;

					//		Show another Confirmation Form
					FormConfirmHoaDonBan formConfirmHoaDonBan = new FormConfirmHoaDonBan(hoaDonBanDVO, nhanVienThuNganDVO);
					formConfirmHoaDonBan.FormClosing += (_obj, _e) =>
					{
						this.ResetColorForLabel();
					};

					formConfirmHoaDonBan.Show();
					formConfirmHoaDonBan.Activate();
				}
			};

			//			TabPageHoaDonBan_ButtonTaoMoiHoaDon
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.Click += (obj, e) =>
			{
				if (this.ShowMessageBoxYesNo(message: "Bạn có chắc muốn nhập mới hóa đơn không?"))
				{
					this.ResetHoaDonBanAndChiTietHDBan();

					return;
				}
			};
		}

		#endregion

		#region Specialised Functions

		//		Function

		private void UpdateTongTienHDNhap(long tien, bool biTru)
		{
			long tongTienCurr = this.CheckIfControlEmptyOrPlaceholder(this.HoaDonNhapDVO_TongTien) ? 0 : long.Parse(this.HoaDonNhapDVO_TongTien.Text);
			long tongTienNew = biTru ? tongTienCurr - tien : tongTienCurr + tien;

			if (tongTienNew == 0)
			{
				this.ResetInputForControl(this.HoaDonNhapDVO_TongTien, true);

				return;
			}

			this.HoaDonNhapDVO_TongTien.Text = tongTienNew.ToString();
		}

		private void UpdateTongTienHDBan(long tien, bool biTru)
		{
			long tongTienCurr = this.CheckIfControlEmptyOrPlaceholder(this.HoaDonBanDVO_TongTien) ? 0 : long.Parse(this.HoaDonBanDVO_TongTien.Text);
			long tongTienNew = biTru ? tongTienCurr - tien : tongTienCurr + tien;

			if (tongTienNew == 0)
			{
				this.ResetInputForControl(this.HoaDonBanDVO_TongTien, true);
				this.ResetInputForControl(this.HoaDonBanDVO_ThanhToan, true);

				return;
			}

			this.HoaDonBanDVO_TongTien.Text = tongTienNew.ToString();

			long thanhToanTemp = (long)(tongTienNew * this.TabPageHoaDonBan_phanTramGiamGia);
			long thanhToanFinal = tongTienNew - (thanhToanTemp > TabPageHoaDonBan_maxGiamGia ? TabPageHoaDonBan_maxGiamGia : thanhToanTemp - thanhToanTemp % 100);

			this.HoaDonBanDVO_ThanhToan.Text = thanhToanFinal.ToString();
		}

		public void NhapHoaDonBan(HoaDonBanDVO hoaDonBanDVO, NhanVienThuNganHDBanDVO nhanVienThuNganDVO, TongTienKhachTraDVO tongTienKhachTraDVO, bool inHoaDonBan)
		{
			Guid maHoaDonBan = Guid.NewGuid();

			HoaDonBanDTO hoaDonBanDTO = new HoaDonBanDTO(
				hoaDonBanDTO_MaHDBan: maHoaDonBan,
				hoaDonBanDTO_MaKhachHang: KhachHangDAO.Instance.GetMaKhachHangWithPhoneNumbers(hoaDonBanDVO.HoaDonBanDVO_DienThoaiKhachHang),
				hoaDonBanDTO_MaNhanVien: NhanVienDAO.Instance.GetMaNhanVienByTenNhanVienAndNgaySinh(nhanVienThuNganDVO.NhanVienThuNganHDBanDVO_NhanVien),
				hoaDonBanDTO_NgayBan: DateTime.Now,
				hoaDonBanDTO_SoSanPham: this.TabPageHoaDonBan_MaterialListView.Items.Count,
				hoaDonBanDTO_MaGiamGia: GiamGiaDAO.Instance.GetMaGiamGia(hoaDonBanDVO.HoaDonBanDVO_TenGiamGia),
				hoaDonBanDTO_TongTien: hoaDonBanDVO.HoaDonBanDVO_ThanhToan,
				hoaDonBanDTO_TongTienKhachTra: tongTienKhachTraDVO.TongTienKhachTraDVO_TongTienKhachTra
				);

			if (!HoaDonBanDAO.Instance.InsertHoaDonBan(hoaDonBanDTO))
			{
				this.ShowMessageBox("Có lỗi gì đó vừa xảy ra", "!HoaDonBanDAO");

				return;
			}

			foreach (ListViewItem listViewItem in this.TabPageHoaDonBan_MaterialListView.Items)
			{
				//		Get MaDMSanPham
				Guid maDMSanPhamTemp = DMSanPhamDAO.Instance.GetMaDMSanPhamFromMaSanPham(listViewItem.SubItems[1].Text);

				if (maDMSanPhamTemp == Guid.Empty)
				{
					this.ShowMessageBox("Có lỗi gì đó vừa xảy ra", "maDMSanPhamTemp == Guid.Empty");

					return;
				}

				ChiTietHDBanDTO chiTietHDBanDTO = new ChiTietHDBanDTO(
					chiTietHDBanDTO_MaHDBan: maHoaDonBan,
					chiTietHDBanDTO_MaDMSanPham: maDMSanPhamTemp,
					chiTietHDBanDTO_SoLuong: int.Parse(listViewItem.SubItems[3].Text),
					chiTietHDBanDTO_ThanhTien: long.Parse(listViewItem.SubItems[5].Text)
					);

				if (!ChiTietHDBanDAO.Instance.InsertChiTietHDBan(chiTietHDBanDTO))
				{
					this.ShowMessageBox("Có lỗi gì đó vừa xảy ra", "!ChiTietHDBanDAO");

					return;
				}

				if (!DMSanPhamDAO.Instance.UpdateTruSoLuongTon(listViewItem.SubItems[1].Text, int.Parse(listViewItem.SubItems[3].Text)))
				{
					this.ShowMessageBox("Trừ số lượng tồn bị lỗi");
				}
			}

			if (inHoaDonBan)
			{
				System.Data.DataTable Bill = ChiTietHDBanDAO.Instance.HoaDonInformationFromMaHoaDon(maHoaDonBan.ToString());

				this.exportTableData.ExportToExcel(
					dataTable: Bill,
					workSheetName: $"ChiTietHDBan_{maHoaDonBan.ToString().Split('-')[0]}",
					filePath: "",
					typeOfFile: ExportTableData.TypeOfExcel.ChiTietHDBan
				);
			}

			//		Reset Input
			this.ResetHoaDonBanAndChiTietHDBan();
		}

		public void NhapHoaDonNhap(HoaDonNhapDVO hoaDonNhapDVO, NhanVienThuNganHDNhapDVO nhanVienThuNganDVO, bool inHoaDonNhap)
		{
			Guid maHoaDonNhap = Guid.NewGuid();

			HoaDonNhapDTO hoaDonNhapDTO = new HoaDonNhapDTO(
				hoaDonNhapDTO_MaHDNhap: maHoaDonNhap,
				hoaDonNhapDTO_MaNhaCungCap: NhaCungCapDAO.Instance.GetMaNhaCungCapWithPhoneNumbers(hoaDonNhapDVO.HoaDonNhapDVO_DienThoaiNhaCungCap),
				hoaDonNhapDTO_MaNhanVien: NhanVienDAO.Instance.GetMaNhanVienByTenNhanVienAndNgaySinh(nhanVienThuNganDVO.NhanVienThuNganHDNhapDVO_NhanVien),
				hoaDonNhapDTO_NgayNhap: DateTime.Now,
				hoaDonNhapDTO_SoSanPham: this.TabPageHoaDonBan_MaterialListView.Items.Count,
				hoaDonNhapDTO_TongTien: hoaDonNhapDVO.HoaDonNhapDVO_TongTien
				);

			if (!HoaDonNhapDAO.Instance.InsertHoaDonNhap(hoaDonNhapDTO))
			{
				this.ShowMessageBox("Có lỗi gì đó vừa xảy ra", "!HoaDonNhapDAO");

				return;
			}

			foreach (ListViewItem listViewItem in this.TabPageHoaDonNhap_MaterialListView.Items)
			{
				//		Get MaDMSanPham
				Guid maDMSanPhamTemp = DMSanPhamDAO.Instance.GetMaDMSanPhamFromMaSanPham(listViewItem.SubItems[1].Text);

				if (maDMSanPhamTemp == Guid.Empty)
				{
					this.ShowMessageBox("Có lỗi gì đó vừa xảy ra", "maDMSanPhamTemp == Guid.Empty");

					return;
				}

				ChiTietHDNhapDTO chiTietHDNhapDTO = new ChiTietHDNhapDTO(
					chiTietHDNhapDTO_MaHDNhap: maHoaDonNhap,
					chiTietHDNhapDTO_MaDMSanPham: maDMSanPhamTemp,
					chiTietHDNhapDTO_SoLuong: int.Parse(listViewItem.SubItems[3].Text),
					chiTietHDNhapDTO_ThanhTien: long.Parse(listViewItem.SubItems[5].Text)
					);

				if (!ChiTietHDNhapDAO.Instance.InsertChiTietHDNhap(chiTietHDNhapDTO))
				{
					this.ShowMessageBox("Có lỗi gì đó vừa xảy ra", "!ChiTietHDNhapDAO");

					return;
				}

				if (!DMSanPhamDAO.Instance.UpdateCongSoLuongTon(listViewItem.SubItems[1].Text, int.Parse(listViewItem.SubItems[3].Text)))
				{
					this.ShowMessageBox("Cộng số lượng tồn bị lỗi");
				}
			}

			if (inHoaDonNhap)
			{
				System.Data.DataTable Bill = ChiTietHDNhapDAO.Instance.HoaDonInformationFromMaHoaDon(maHoaDonNhap.ToString());

				this.exportTableData.ExportToExcel(
					dataTable: Bill,
					workSheetName: $"ChiTietHDNhap_{maHoaDonNhap.ToString().Split('-')[0]}",
					filePath: "",
					typeOfFile: ExportTableData.TypeOfExcel.ChiTietHDNhap
				);
			}

			//		Reset Input
			this.ResetHoaDonNhapAndChiTietHDNhap();
		}

		private void ResetHoaDonNhapAndChiTietHDNhap()
		{
			//		Clear ListView
			this.TabPageHoaDonNhap_MaterialListView.Items.Clear();

			//		Set Focus
			this.ActiveControl = this.ChiTietHDNhapDVO_MaSanPham;

			//		Reset Controls
			this.ResetInputForControl(this.ChiTietHDNhapDVO_MaSanPham, false);
			this.ResetInputForControl(this.HoaDonNhapDVO_DienThoaiNhaCungCap, false);

			//		Set Interracted
			this.SetInterractedForControl(this.ChiTietHDNhapDVO_MaSanPham, onlyOneControl: false, value: false);
			this.SetInterractedForControl(this.HoaDonNhapDVO_DienThoaiNhaCungCap, onlyOneControl: false, value: false);
		}

		private void ResetHoaDonBanAndChiTietHDBan()
		{
			//		Clear ListView
			this.TabPageHoaDonBan_MaterialListView.Items.Clear();

			//		Set Focus
			this.ActiveControl = this.ChiTietHDBanDVO_MaSanPham;

			//		Reset Controls
			this.ResetInputForControl(this.ChiTietHDBanDVO_MaSanPham, false);
			this.ResetInputForControl(this.HoaDonBanDVO_DienThoaiKhachHang, false);

			//		Set Interracted
			this.SetInterractedForControl(this.ChiTietHDBanDVO_MaSanPham, onlyOneControl: false, value: false);
			this.SetInterractedForControl(this.HoaDonBanDVO_DienThoaiKhachHang, onlyOneControl: false, value: false);
		}

		private void NewChiTietHDNhap()
		{
			if (this.TryValidationFromControl(this.ChiTietHDNhapDVO_MaSanPham, onlyOneControl: false, out dynamic baseDVO))
			{
				//		Casting
				ChiTietHDNhapDVO chiTietHDNhapDVO = baseDVO as ChiTietHDNhapDVO;

				//		Get DonGiaBan
				long tempDonGiaNhap = DMSanPhamDAO.Instance.GetDonGiaNhapWithMaSanPham(chiTietHDNhapDVO.ChiTietHDNhapDVO_MaSanPham);

				if (this.TabPageHoaDonNhap_MaterialListView.SelectedIndices.Count <= 0)
				{
					//		If already Existed AND not Selected => Update
					foreach (ListViewItem listViewItem1 in this.TabPageHoaDonNhap_MaterialListView.Items)
					{
						if (listViewItem1.SubItems[1].Text.Equals(this.ChiTietHDNhapDVO_MaSanPham.Text))
						{
							//		Reset TongTien
							this.UpdateTongTienHDNhap(
								tien: long.Parse(listViewItem1.SubItems[5].Text),
								biTru: true);

							//		Update
							int soLuongTemp = int.Parse(listViewItem1.SubItems[3].Text) + chiTietHDNhapDVO.ChiTietHDNhapDVO_SoLuong;

							listViewItem1.SubItems[3].Text = soLuongTemp.ToString();
							listViewItem1.SubItems[5].Text = (soLuongTemp * tempDonGiaNhap).ToString();

							//		Update TongTien
							this.UpdateTongTienHDNhap(
								tien: long.Parse(listViewItem1.SubItems[5].Text),
								biTru: false);

							//		Grant Control
							this.ActiveControl = this.ChiTietHDNhapDVO_MaSanPham;

							this.ResetInputForControl(this.ChiTietHDNhapDVO_MaSanPham, false);

							return;
						}
					}
				}
				else
				{
					//		Remove Selected Indexes
					ListView.SelectedListViewItemCollection selectedItems = this.TabPageHoaDonNhap_MaterialListView.SelectedItems;

					foreach (ListViewItem item in selectedItems)
					{
						this.UpdateTongTienHDNhap(
							tien: long.Parse(item.SubItems[5].Text),
							biTru: true);

						this.TabPageHoaDonNhap_MaterialListView.Items.Remove(item);
					}

					//		Re-Indexing
					for (int i = 0; i < this.TabPageHoaDonNhap_MaterialListView.Items.Count; i++)
					{
						this.TabPageHoaDonNhap_MaterialListView.Items[i].SubItems[0].Text = (i + 1).ToString();
					}
				}

				//		If not Existed => Add new
				ListViewItem listViewItem = new ListViewItem();

				listViewItem.SubItems[0].Text = ((this.TabPageHoaDonNhap_MaterialListView.Items.Count + 1).ToString());
				listViewItem.SubItems.Add(chiTietHDNhapDVO.ChiTietHDNhapDVO_MaSanPham);
				listViewItem.SubItems.Add(chiTietHDNhapDVO.ChiTietHDNhapDVO_TenSanPham);
				listViewItem.SubItems.Add(chiTietHDNhapDVO.ChiTietHDNhapDVO_SoLuong.ToString());
				listViewItem.SubItems.Add(tempDonGiaNhap.ToString());
				listViewItem.SubItems.Add((tempDonGiaNhap * chiTietHDNhapDVO.ChiTietHDNhapDVO_SoLuong).ToString());

				//		Add new
				this.TabPageHoaDonNhap_MaterialListView.Items.Add(listViewItem);

				//		Update TongTien
				this.UpdateTongTienHDNhap(
					tien: long.Parse(listViewItem.SubItems[5].Text),
					biTru: false);

				//		Reset Focus
				this.ActiveControl = this.ChiTietHDNhapDVO_MaSanPham;

				//		Reset Input
				this.ResetInputForControl(this.ChiTietHDNhapDVO_MaSanPham, false);

				return;
			}
		}

		private void NewChiTietHDBan()
		{
			if (this.TryValidationFromControl(this.ChiTietHDBanDVO_MaSanPham, onlyOneControl: false, out dynamic baseDVO))
			{
				//		Casting
				ChiTietHDBanDVO chiTietHDBanDVO = baseDVO as ChiTietHDBanDVO;

				//		Get DonGiaBan
				long tempDonGiaBan = DMSanPhamDAO.Instance.GetDonGiaBanWithMaSanPham(chiTietHDBanDVO.ChiTietHDBanDVO_MaSanPham);

				//		If already Existed AND not Selected => Update
				if (this.TabPageHoaDonBan_MaterialListView.SelectedIndices.Count <= 0)
				{
					foreach (ListViewItem listViewItem1 in this.TabPageHoaDonBan_MaterialListView.Items)
					{
						if (listViewItem1.SubItems[1].Text.Equals(this.ChiTietHDBanDVO_MaSanPham.Text))
						{
							//		Reset TongTien
							this.UpdateTongTienHDBan(
								tien: long.Parse(listViewItem1.SubItems[5].Text),
								biTru: true);

							//		Update
							int soLuongTemp = int.Parse(listViewItem1.SubItems[3].Text) + chiTietHDBanDVO.ChiTietHDBanDVO_SoLuong;

							listViewItem1.SubItems[3].Text = soLuongTemp.ToString();
							listViewItem1.SubItems[5].Text = (soLuongTemp * tempDonGiaBan).ToString();

							//		Update TongTien
							this.UpdateTongTienHDBan(
								tien: long.Parse(listViewItem1.SubItems[5].Text),
								biTru: false);

							//		Grant Control
							this.ActiveControl = this.ChiTietHDBanDVO_MaSanPham;

							this.ResetInputForControl(this.ChiTietHDBanDVO_MaSanPham, false);

							return;
						}
					}
				}
				//		Remove selected Indexes
				else
				{
					ListView.SelectedListViewItemCollection selectedItems = this.TabPageHoaDonBan_MaterialListView.SelectedItems;

					foreach (ListViewItem item in selectedItems)
					{
						this.UpdateTongTienHDBan(
							tien: long.Parse(item.SubItems[5].Text),
							biTru: true);

						this.TabPageHoaDonBan_MaterialListView.Items.Remove(item);
					}

					//		Re-Indexing
					for (int i = 0; i < this.TabPageHoaDonBan_MaterialListView.Items.Count; i++)
					{
						this.TabPageHoaDonBan_MaterialListView.Items[i].SubItems[0].Text = (i + 1).ToString();
					}
				}

				//		If not Existed => Add new
				ListViewItem listViewItem = new ListViewItem();

				listViewItem.SubItems[0].Text = ((this.TabPageHoaDonBan_MaterialListView.Items.Count + 1).ToString());
				listViewItem.SubItems.Add(chiTietHDBanDVO.ChiTietHDBanDVO_MaSanPham);
				listViewItem.SubItems.Add(chiTietHDBanDVO.ChiTietHDBanDVO_TenSanPham);
				listViewItem.SubItems.Add(chiTietHDBanDVO.ChiTietHDBanDVO_SoLuong.ToString());
				listViewItem.SubItems.Add(tempDonGiaBan.ToString());
				listViewItem.SubItems.Add((tempDonGiaBan * chiTietHDBanDVO.ChiTietHDBanDVO_SoLuong).ToString());

				//		Add new
				this.TabPageHoaDonBan_MaterialListView.Items.Add(listViewItem);

				//		Update TongTien
				this.UpdateTongTienHDBan(
					tien: long.Parse(listViewItem.SubItems[5].Text),
					biTru: false);

				//		Reset Focus
				this.ActiveControl = this.ChiTietHDBanDVO_MaSanPham;

				//		Reset Input
				this.ResetInputForControl(this.ChiTietHDBanDVO_MaSanPham, false);

				return;
			}
		}

		//		Functions Use from another form

		public void TabPageHoaDonBan_SetDienThoaiKhachHang(string dienThoai)
		{
			this.HoaDonBanDVO_DienThoaiKhachHang.Text = dienThoai;

			this.ActiveControl = this.HoaDonBanDVO_DienThoaiKhachHang;

			this.ResetColorForLabel();
		}

		public long TabPageHoaDonBan_GetThanhToan()
		{
			if (!long.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonBanDVO_ThanhToan), out long tempThanhToan))
			{
				tempThanhToan = 0;
			}

			return tempThanhToan;
		}

		#endregion

		#endregion

		#region Trần Hồng Thái

		private void Initialize_TranHongThai()
		{
			this.InitializeBillOfSell();
			this.InitializeImportBill();
			this.InitializeCustomerAnalytics();

			this.InitializeChart1();
			this.InitializeChart2();
			this.InitializeChart3();
			this.InitializeChart4();
		}

		private void InitializeBillOfSell()
		{
			// Data queried from DB
			int countBillOfCellCurrentMonth = PhanTichDAO.Instance.CountBillOfSellCurrentMonth();
			long revenueCurrentMonth = PhanTichDAO.Instance.GetRevenueCurrentMonth();
			double discountTotalCurrentMonth = PhanTichDAO.Instance.GetDiscountTotalCurrentMonth();
			double priceTotalCurrentMonth = PhanTichDAO.Instance.GetPriceTotalCurrentMonth();
			int percentDiscount = priceTotalCurrentMonth == 0 ? 0 : (int)Math.Ceiling((double)discountTotalCurrentMonth / priceTotalCurrentMonth * 100);

			// Render data
			TabPagePhanTich_HoaDonBan_SoLuong_LB.Text = countBillOfCellCurrentMonth.ToString();
			TabPagePhanTich_HoaDonBan_DoanhThu_LB.Text = this.formatValues.FormatPriceToView(revenueCurrentMonth.ToString(), 3) + " đ";
			TabPagePhanTich_HoaDonBan_GiamGiaPB.Value = percentDiscount;
			TabPagePhanTich_HoaDonBan_GiamGiaLB.Text = $"Tiền giảm giá tháng này: {this.formatValues.FormatPriceToView(discountTotalCurrentMonth.ToString(), 3)} đ ({percentDiscount}%)";


			// Event
			TabPagePhanTich_HoaDonBan_ShowBTN.Click += (obj, e) =>
			{
				FormChiTietHoaDonBan formChiTietHoaDonBan = new FormChiTietHoaDonBan();
				formChiTietHoaDonBan.Show();
			};
		}

		private void InitializeImportBill()
		{
			// Data queried from DB
			int countBillOfImportCurrentMonth = PhanTichDAO.Instance.CountBillOfImportCurrentMonth();
			long importCostCurrentMonth = PhanTichDAO.Instance.GetImportCostCurrentMonth();
			long revenueCurrentMonth = PhanTichDAO.Instance.GetRevenueCurrentMonth();
			int percentImportPerRevenue = importCostCurrentMonth == 0 ? 0 : (int)Math.Ceiling((double)importCostCurrentMonth / revenueCurrentMonth * 100);

			// Render data
			TabPagePhanTich_HoaDonNhap_SoLuong_LB.Text = countBillOfImportCurrentMonth.ToString();
			TabPagePhanTich_HoaDonNhap_ChiPhi_LB.Text = this.formatValues.FormatPriceToView(importCostCurrentMonth.ToString(), 3) + " đ";
			TabPagePhanTich_HoaDonNhap_TiLePB.Value = percentImportPerRevenue > 100 ? 100 : percentImportPerRevenue;
			TabPagePhanTich_HoaDonNhap_TiLeLB.Text = $"Tỉ lệ chi phí nhập khẩu so với doanh thu: {percentImportPerRevenue}%";

			// Event
			TabPagePhanTich_HoaDonNhap_ShowBTN.Click += (obj, e) =>
			{
				FormChiTietHoaDonNhap formChiTietHoaDonNhap = new FormChiTietHoaDonNhap();
				formChiTietHoaDonNhap.Show();
			};
		}

		private void InitializeCustomerAnalytics()
		{
			// Data queried from DB
			List<string> customerPhoneNumersNotInCurrentMonth = PhanTichDAO.Instance.GetCustomerPhoneNumberListNotInCurrentMonth();
			List<string> customerPhoneNumersCurrentMonth = PhanTichDAO.Instance.GetCustomerPhoneNumberListCurrentMonth();

			// Handle logic
			int countNewCustomerCurrentMonth = this.CountUniquePhoneNumbers(customerPhoneNumersNotInCurrentMonth, customerPhoneNumersCurrentMonth);
			int percentCustomerReturn = countNewCustomerCurrentMonth == 0 ? 0 :
				(int)Math.Ceiling((double)(customerPhoneNumersCurrentMonth.Count - countNewCustomerCurrentMonth) / customerPhoneNumersNotInCurrentMonth.Count * 100);

			// Render data
			TabPagePhanTich_KhachHang_Tong_LB.Text = (customerPhoneNumersNotInCurrentMonth.Count + customerPhoneNumersCurrentMonth.Count).ToString();
			TabPagePhanTich_KhachHang_KHmoi_LB.Text = countNewCustomerCurrentMonth.ToString();
			TabPagePhanTich_KhachHang_TiLePB.Value = percentCustomerReturn;
			TabPagePhanTich_KhachHang_TiLeLB.Text = $"Tỉ lệ khách quay lại tháng này: {percentCustomerReturn}%";
		}

		private void InitializeChart1()
		{
			// Data queried from DB
			List<ProductsBestSellerResponseDTO> productsTop1BestSeller = PhanTichDAO.Instance.GetRankProductsByMonth(1);
			List<ProductsBestSellerResponseDTO> productsTop2BestSeller = PhanTichDAO.Instance.GetRankProductsByMonth(2);
			List<ProductsBestSellerResponseDTO> productsTop3BestSeller = PhanTichDAO.Instance.GetRankProductsByMonth(3);

			// Fill all default value each month
			List<ProductsBestSellerResponseDTO> productsValueFirstColumn = new List<ProductsBestSellerResponseDTO>();
			List<ProductsBestSellerResponseDTO> productsValueSecondColumn = new List<ProductsBestSellerResponseDTO>();
			List<ProductsBestSellerResponseDTO> productsValueThirdColumn = new List<ProductsBestSellerResponseDTO>();
			for (int i = 0; i < 12; i++)
			{
				productsValueFirstColumn.Add(new ProductsBestSellerResponseDTO() { ProductsBestSellerResponseDTO_Thang = i + 1 });
				productsValueSecondColumn.Add(new ProductsBestSellerResponseDTO() { ProductsBestSellerResponseDTO_Thang = i + 1 });
				productsValueThirdColumn.Add(new ProductsBestSellerResponseDTO() { ProductsBestSellerResponseDTO_Thang = i + 1 });
			}

			// Fill data from DB
			foreach (ProductsBestSellerResponseDTO product in productsTop1BestSeller)
			{
				productsValueFirstColumn[product.ProductsBestSellerResponseDTO_Thang - 1].ProductsBestSellerResponseDTO_SoLuongBan
					= product.ProductsBestSellerResponseDTO_SoLuongBan;
				productsValueFirstColumn[product.ProductsBestSellerResponseDTO_Thang - 1].ProductsBestSellerResponseDTO_TenSanPham
					= product.ProductsBestSellerResponseDTO_TenSanPham;
			}
			foreach (ProductsBestSellerResponseDTO product in productsTop2BestSeller)
			{
				productsValueSecondColumn[product.ProductsBestSellerResponseDTO_Thang - 1].ProductsBestSellerResponseDTO_SoLuongBan
					= product.ProductsBestSellerResponseDTO_SoLuongBan;
				productsValueSecondColumn[product.ProductsBestSellerResponseDTO_Thang - 1].ProductsBestSellerResponseDTO_TenSanPham
					= product.ProductsBestSellerResponseDTO_TenSanPham;
			}
			foreach (ProductsBestSellerResponseDTO product in productsTop3BestSeller)
			{
				productsValueThirdColumn[product.ProductsBestSellerResponseDTO_Thang - 1].ProductsBestSellerResponseDTO_SoLuongBan
					= product.ProductsBestSellerResponseDTO_SoLuongBan;
				productsValueThirdColumn[product.ProductsBestSellerResponseDTO_Thang - 1].ProductsBestSellerResponseDTO_TenSanPham
					= product.ProductsBestSellerResponseDTO_TenSanPham;
			}

			cartesianChart1.Series = new ISeries[]
			{
				new ColumnSeries<ProductsBestSellerResponseDTO>
				{
					Values = productsValueFirstColumn,
					GroupPadding = 8,
					YToolTipLabelFormatter = point => $"{point.Model.ProductsBestSellerResponseDTO_TenSanPham} {point.Model.ProductsBestSellerResponseDTO_SoLuongBan}",
					DataLabelsFormatter = point => $"{point.Model.ProductsBestSellerResponseDTO_TenSanPham} {point.Model.ProductsBestSellerResponseDTO_SoLuongBan}",
					DataLabelsPosition = DataLabelsPosition.End,
					Mapping = (product, point) =>
					{
						point.PrimaryValue = product.ProductsBestSellerResponseDTO_SoLuongBan;
						point.SecondaryValue = point.Context.Index;

					},
				},
				new ColumnSeries<ProductsBestSellerResponseDTO>
				{
					Values = productsValueSecondColumn,
					GroupPadding = 8,
					YToolTipLabelFormatter = point => $"{point.Model.ProductsBestSellerResponseDTO_TenSanPham} {point.Model.ProductsBestSellerResponseDTO_SoLuongBan}",
					DataLabelsFormatter = point => $"{point.Model.ProductsBestSellerResponseDTO_TenSanPham}   {point.Model.ProductsBestSellerResponseDTO_SoLuongBan}",
					DataLabelsPosition = DataLabelsPosition.End,
					Mapping = (product, point) =>
					{
						point.PrimaryValue = product.ProductsBestSellerResponseDTO_SoLuongBan;
						point.SecondaryValue = point.Context.Index;

					},
				},
				new ColumnSeries<ProductsBestSellerResponseDTO>
				{
					Values = productsValueThirdColumn,
					GroupPadding = 8,
					YToolTipLabelFormatter = point => $"{point.Model.ProductsBestSellerResponseDTO_TenSanPham}   {point.Model.ProductsBestSellerResponseDTO_SoLuongBan}",
					DataLabelsFormatter = point => $"{point.Model.ProductsBestSellerResponseDTO_TenSanPham}   {point.Model.ProductsBestSellerResponseDTO_SoLuongBan}",
					DataLabelsPosition = DataLabelsPosition.End,
					Mapping = (product, point) =>
					{
						point.PrimaryValue = product.ProductsBestSellerResponseDTO_SoLuongBan;
						point.SecondaryValue = point.Context.Index;

					},
				}
			};

			// Axis
			List<string> year = new List<string>();
			for (int i = 1; i <= 12; i++)
			{
				year.Add("Tháng " + i.ToString());
			}

			cartesianChart1.XAxes = new List<Axis>
			{
				new Axis
				{
					// Use the labels property to define named labels.
					Labels = year
				}
			};

			// Legend custom
			//cartesianChart1.LegendPosition = LiveChartsCore.Measure.LegendPosition.Bottom;

			//cartesianChart1.
			cartesianChart1.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.Both;
		}

		private void InitializeChart2()
		{
			// Days in a Month
			List<string> daysInMonth = new List<string>();
			int currentMonth = DateTime.Now.Month;
			int lastMonth = DateTime.Now.Month - 1 != 0 ? DateTime.Now.Month - 1 : 12;
			int year = DateTime.Now.Month - 1 != 0 ? DateTime.Now.Year : DateTime.Now.Year - 1;

			int countDaysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, currentMonth);
			int countDaysInLastMonth = DateTime.DaysInMonth(year, lastMonth);

			// Data queried from DB
			List<RevenueResponseDTO> revanueResponseCurrentMonth = PhanTichDAO.Instance.GetDailyRevenueByThisMonth();
			List<RevenueResponseDTO> revanueResponseLastMonth = PhanTichDAO.Instance.GetDailyRevenueByLastMonth();

			List<long> revenuesCurrentMonth = new List<long>(countDaysInMonth);
			List<long> revenuesLastMonth = new List<long>(countDaysInMonth);

			// Fill all value 0
			for (int i = 0; i < countDaysInMonth; i++)
			{
				revenuesCurrentMonth.Add(0);
			}

			for (int i = 0; i < countDaysInLastMonth; i++)
			{
				revenuesLastMonth.Add(0);
			}

			// Fill value get from DB
			foreach (RevenueResponseDTO revanue in revanueResponseCurrentMonth)
			{
				revenuesCurrentMonth[revanue.RevenueResponseDTO_Ngay - 1] = revanue.RevenueResponseDTO_DoanhThu;
			}

			foreach (RevenueResponseDTO revanue in revanueResponseLastMonth)
			{
				revenuesLastMonth[revanue.RevenueResponseDTO_Ngay - 1] = revanue.RevenueResponseDTO_DoanhThu;
			}

			cartesianChart2.Series = new ISeries[]
			{
				new LineSeries<long>
				{
					Values = revenuesCurrentMonth,
					GeometrySize = 20,
					Name = "Doanh thu tháng " + currentMonth,
				},
				new LineSeries<long>
				{
					Values = revenuesLastMonth,
					GeometrySize = 10,
					Name = "Doanh thu tháng " + lastMonth,

				},

			};

			// Legend custom
			cartesianChart2.LegendPosition = LiveChartsCore.Measure.LegendPosition.Bottom;

			// Axis
			for (int i = 1; i <= countDaysInMonth; i++)
			{
				daysInMonth.Add("Ngày " + i.ToString());
			}

			cartesianChart2.XAxes = new List<Axis>
			{
				new Axis
				{
					// Use the labels property to define named labels.
					Labels = daysInMonth
				}
			};

			cartesianChart2.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.Both;
		}

		private void InitializeChart3()
		{
			List<SalaryArrangementResponseDTO> salaryArrangementResponseDTOs = PhanTichDAO.Instance.GetSalaryArrangementResponseDTOs();
			SalaryArrangementResponseDTO salaryArrangementFirst = salaryArrangementResponseDTOs[0] != null ? salaryArrangementResponseDTOs[0] : new SalaryArrangementResponseDTO();
			SalaryArrangementResponseDTO salaryArrangementSecond = salaryArrangementResponseDTOs[1] != null ? salaryArrangementResponseDTOs[1] : new SalaryArrangementResponseDTO();
			SalaryArrangementResponseDTO salaryArrangementThird = salaryArrangementResponseDTOs[2] != null ? salaryArrangementResponseDTOs[2] : new SalaryArrangementResponseDTO();

			pieChart1.Series = new ISeries[]
			{
				new PieSeries<double>
				{
					Values = new List<double> { salaryArrangementFirst.SalaryArrangementResponseDTO_Luong },
					DataLabelsPaint = new SolidColorPaint(SKColors.Black),
					DataLabelsSize = 14,
					DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
					DataLabelsFormatter = point => salaryArrangementFirst.SalaryArrangementResponseDTO_Luong.ToString(),
					Name = salaryArrangementFirst.SalaryArrangementResponseDTO_TenCongViec
				},
				new PieSeries<double>
				{
					Values = new List<double> { salaryArrangementSecond.SalaryArrangementResponseDTO_Luong },
					DataLabelsPaint = new SolidColorPaint(SKColors.Black),
					DataLabelsSize = 14,
					DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
					DataLabelsFormatter = point => salaryArrangementSecond.SalaryArrangementResponseDTO_Luong.ToString(),
					Name = salaryArrangementSecond.SalaryArrangementResponseDTO_TenCongViec
				},
				new PieSeries<double>
				{
					Values = new List<double> { salaryArrangementThird.SalaryArrangementResponseDTO_Luong },
					DataLabelsPaint = new SolidColorPaint(SKColors.Black),
					DataLabelsSize = 14,
					DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
					DataLabelsFormatter = point => salaryArrangementThird.SalaryArrangementResponseDTO_Luong.ToString(),
					Name = salaryArrangementThird.SalaryArrangementResponseDTO_TenCongViec
				}
			};
		}

		private void InitializeChart4()
		{
			List<InventoryArrangementResponseDTO> inventoryArrangementResponseDTOs = PhanTichDAO.Instance.GetInventoryArrangementResponseDTOs();
			InventoryArrangementResponseDTO inventoryArrangementFirst = inventoryArrangementResponseDTOs[0] != null ? inventoryArrangementResponseDTOs[0] : new InventoryArrangementResponseDTO();
			InventoryArrangementResponseDTO inventoryArrangementSecond = inventoryArrangementResponseDTOs[1] != null ? inventoryArrangementResponseDTOs[1] : new InventoryArrangementResponseDTO();
			InventoryArrangementResponseDTO inventoryArrangementThird = inventoryArrangementResponseDTOs[2] != null ? inventoryArrangementResponseDTOs[2] : new InventoryArrangementResponseDTO();

			pieChart2.Series = new ISeries[]
			{
				new PieSeries<double>
				{
					Values = new List<double> { inventoryArrangementFirst.InventoryArrangementResponseDTO_SoLuongTonKho },
					DataLabelsPaint = new SolidColorPaint(SKColors.Black),
					DataLabelsSize = 20,
					DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
					DataLabelsFormatter = point => inventoryArrangementFirst.InventoryArrangementResponseDTO_SoLuongTonKho.ToString(),
					Name = inventoryArrangementFirst.InventoryArrangementResponseDTO_TenSanPham
				},
				new PieSeries<double>
				{
					Values = new List<double> { inventoryArrangementSecond.InventoryArrangementResponseDTO_SoLuongTonKho },
					DataLabelsPaint = new SolidColorPaint(SKColors.Black),
					DataLabelsSize = 20,
					DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
					DataLabelsFormatter = point => inventoryArrangementSecond.InventoryArrangementResponseDTO_SoLuongTonKho.ToString(),
					Name = inventoryArrangementSecond.InventoryArrangementResponseDTO_TenSanPham
				},
				new PieSeries<double>
				{
					Values = new List<double> { inventoryArrangementThird.InventoryArrangementResponseDTO_SoLuongTonKho },
					DataLabelsPaint = new SolidColorPaint(SKColors.Black),
					DataLabelsSize = 20,
					DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
					DataLabelsFormatter = point => inventoryArrangementThird.InventoryArrangementResponseDTO_SoLuongTonKho.ToString(),
					Name = inventoryArrangementThird.InventoryArrangementResponseDTO_TenSanPham
				}
			};
		}

		private int CountUniquePhoneNumbers(List<string> A, List<string> B)
		{
			Dictionary<string, int> phoneCount = new Dictionary<string, int>();

			// Đếm số lượng xuất hiện của từng số điện thoại trong danh sách A
			foreach (string number in A)
			{
				if (phoneCount.ContainsKey(number))
					phoneCount[number]++;
				else
					phoneCount[number] = 1;
			}

			// Kiểm tra số lượng số điện thoại của B không trùng trong A
			int uniqueCount = 0;
			foreach (string number in B)
			{
				if (phoneCount.ContainsKey(number) && phoneCount[number] > 0)
				{
					uniqueCount++;
					phoneCount[number]--;
				}
			}

			return uniqueCount;
		}

		#endregion

		#region Nguyễn Hồng Sơn

		private void Initialize_NguyenHongSon()
		{
			this.Initialize_KhachHang();

			this.Initialize_NhaCungCap();
		}

		#region Khách hàng
		private void Initialize_KhachHang()
		{
			this.Load += (obj, e) =>
			{
				System.Data.DataTable khachHang = KhachHangDAO.Instance.QueryFullKhachHang();

				ListViewItem items;

				int count = 0;
				foreach (DataRow row in khachHang.Rows)
				{
					items = new ListViewItem();
					count += 1;
					//Debug.Write(count);
					items.SubItems[0].Text = count.ToString();
					for (int i = 0; i < khachHang.Columns.Count; i++)
					{
						items.SubItems.Add(row[i].ToString().Trim());
					}
					//items.Remove();
					this.TabPageKhachHang_MaterialListView.Items.Add(items);
				}
			};

			this.TabPageKhachHang_MaterialListView.SelectedIndexChanged += (obj, e) =>
			{
				// Nothing
				if (this.TabPageKhachHang_MaterialListView.SelectedIndices.Count <= 0)
				{
					return;
				}

				this.ResetValidationForControl(this.KhachHangDVO_TenKhachHang, onlyOneControl: false);

				// Update Controls
				int index = this.TabPageKhachHang_MaterialListView.SelectedIndices[0];

				if (index >= 0)
				{
					ListViewItem listViewItem = this.TabPageKhachHang_MaterialListView.Items[index];

					this.KhachHangDVO_TenKhachHang.Text = listViewItem.SubItems[2].Text;
					this.KhachHangDVO_DiaChi.Text = listViewItem.SubItems[3].Text;
					this.KhachHangDVO_DienThoai.Text = listViewItem.SubItems[4].Text;
				}
			};

			this.TabPageKhachHang_MaterialListView.DoubleClick += (obj, e) =>
			{
				if (this.TabPageKhachHang_MaterialListView.SelectedIndices.Count <= 0)
				{
					this.ShowMessageBox("Hãy chọn khách hàng mà bạn muốn xem!");

					return;
				}

				int index = this.TabPageKhachHang_MaterialListView.SelectedIndices[0];

				if (index >= 0)
				{
					ListViewItem listViewItem = this.TabPageKhachHang_MaterialListView.Items[index];

					string KhachHang_SoDienThoai = listViewItem.SubItems[4].Text;

					if (!HoaDonBanDAO.Instance.IfHoaDonBanInformationFromSoDienThoai(KhachHang_SoDienThoai))
					{
						this.ShowMessageBox("Khách hàng chưa có đơn hàng nào cả!");

						return;
					}

					FormListSellBill formListSellBill = new FormListSellBill(KhachHang_SoDienThoai);
					formListSellBill.ShowDialog();
				}
			};

			this.KhachHangDVO_DienThoai.KeyPress += this.TextBoxBase_KeyPress_NumericOnly;

			this.KhachHangDVO_DienThoai.KeyDown += (obj, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				{
					this.SearchKhachHang();
				}
			};

			this.KhachHangDVO_TenKhachHang.KeyDown += (obj, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				{
					this.SearchKhachHang();
				}
			};

			this.KhachHangDVO_DiaChi.KeyDown += (obj, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				{
					this.SearchKhachHang();
				}
			};

			this.TabPageKhachHang_XoaKhachHang.Click += (obj, e) =>
			{
				if (this.TabPageKhachHang_MaterialListView.SelectedIndices.Count <= 0)
				{
					this.ShowMessageBox("Bạn hãy chọn khách hàng cần xóa!");

					return;
				}

				Guid maKhachHang = Guid.Parse(this.TabPageKhachHang_MaterialListView.SelectedItems[0].SubItems[1].Text);

				if (KhachHangDAO.Instance.CheckIfKhachHangHasHDBan(maKhachHang))
				{
					this.ShowMessageBox("Khách hàng đã có dữ liệu trong cơ sở, không được phép xóa!");

					return;
				}
				else
				{
					if (!this.ShowMessageBoxYesNo("Bạn có muốn xóa dữ liệu khách hàng này?"))
					{
						return;
					}

					if (KhachHangDAO.Instance.DeleteKhachHang(maKhachHang))
					{
						this.ShowMessageBox("Khách hàng đã được xóa!");

						this.LoadKhachHang();
					}
					else
					{
						this.ShowMessageBox("Có lỗi gì đó đã xảy ra");
					}
				}
			};

			this.TabPageKhachHang_TaoKhachHang.Click += (obj, e) =>
			{
				FormCreateKhachHang formCreateKhachHang = new FormCreateKhachHang(false);

				formCreateKhachHang.Show();
			};

			this.TabPageKhachHang_SuaKhachHang.Click += (obj, e) =>
			{
				if (this.TabPageKhachHang_MaterialListView.SelectedIndices.Count <= 0)
				{
					this.ShowMessageBox("Bạn hãy chọn khách hàng bạn muốn cập nhật");

					return;
				}

				if (this.TryValidationFromControl(this.KhachHangDVO_DiaChi, onlyOneControl: true, out dynamic baseDVO) &&
					this.TryValidationFromControl(this.KhachHangDVO_TenKhachHang, onlyOneControl: true, out dynamic baseDVO1) &&
					this.GetControlTextIfPlaceholderThenEmpty(this.KhachHangDVO_DienThoai).Length == 10)
				{
					KhachHangDVO khachHangDVO = this.GetInputFromControl(this.KhachHangDVO_TenKhachHang) as KhachHangDVO;

					int index = this.TabPageKhachHang_MaterialListView.SelectedIndices[0];

					if (index >= 0)
					{
						ListViewItem listViewItem = this.TabPageKhachHang_MaterialListView.Items[index];

						string KhachHang_TenKhachHangTMP = listViewItem.SubItems[2].Text;
						string KhachHang_DienThoaiTMP = listViewItem.SubItems[4].Text;

						if (ShowMessageBoxYesNo($"Bạn có chắc chắn muốn thay đổi khách hàng {KhachHang_TenKhachHangTMP} có số điện thoại {KhachHang_DienThoaiTMP}?"))
						{
							if (KhachHangDAO.Instance.UpdateKhachHangFull(khachHangDVO, KhachHang_DienThoaiTMP))
							{
								ShowMessageBox("Đã cập nhật thành công!");

								listViewItem.SubItems[2].Text = khachHangDVO.KhachHangDVO_TenKhachHang;
								listViewItem.SubItems[3].Text = khachHangDVO.KhachHangDVO_DiaChi;
								listViewItem.SubItems[4].Text = khachHangDVO.KhachHangDVO_DienThoai;

								this.LoadKhachHang();
							}
							else
							{
								ShowMessageBox("Thay đổi thất bại!");
							}
						}
					}
				}
			};

			this.TabPageKhachHang_SearchKH.Click += (obj, e) =>
			{
				this.SearchKhachHang();
			};

			this.TabPageKhachHang_RefreshKhachHang.Click += (obj, e) =>
			{
				this.ResetKhachHangDVO();

				this.LoadKhachHang();
			};

			this.TabPageKhachHang_XuatExcelKH.Click += (obj, e) =>
			{
				System.Data.DataTable dataTable = KhachHangDAO.Instance.QueryFullKhachHang();

				this.exportTableData.ExportToExcel(
					dataTable: dataTable,
					workSheetName: "KhachHang" + this.getDateTime.GetDateTimeNow_Date(),
					filePath: "",
					typeOfFile: ExportTableData.TypeOfExcel.KhachHang
				);

				this.ResetColorForLabel();
			};

			this.TabPageKhachHang_LichSuMuaHang.Click += (obj, e) =>
			{
				if (this.TabPageKhachHang_MaterialListView.SelectedIndices.Count <= 0)
				{
					this.ShowMessageBox("Hãy chọn khách hàng mà bạn muốn xem!");

					return;
				}

				int index = this.TabPageKhachHang_MaterialListView.SelectedIndices[0];

				if (index >= 0)
				{
					ListViewItem listViewItem = this.TabPageKhachHang_MaterialListView.Items[index];

					string KhachHang_SoDienThoai = listViewItem.SubItems[4].Text;

					if (!HoaDonBanDAO.Instance.IfHoaDonBanInformationFromSoDienThoai(KhachHang_SoDienThoai))
					{
						this.ShowMessageBox("Khách hàng chưa có đơn hàng nào cả!");

						return;
					}

					FormListSellBill formListSellBill = new FormListSellBill(KhachHang_SoDienThoai);
					formListSellBill.ShowDialog();
				}
			};
		}

		private void LoadKhachHang()
		{
			System.Data.DataTable khachHangDT = KhachHangDAO.Instance.QueryFullKhachHang();

			this.TabPageKhachHang_MaterialListView.Items.Clear();

			ListViewItem item;

			int cnt = 0;

			foreach (DataRow row in khachHangDT.Rows)
			{
				item = new ListViewItem();

				cnt += 1;

				item.SubItems[0].Text = cnt.ToString();

				for (int i = 0; i < khachHangDT.Columns.Count; i++)
				{
					item.SubItems.Add(row[i].ToString().Trim());
				}

				this.TabPageKhachHang_MaterialListView.Items.Add(item);
			}
		}

		private void ResetKhachHangDVO()
		{
			this.ResetInputForControl(this.KhachHangDVO_TenKhachHang, onlyOneControl: false);

			this.ResetValidationForControl(this.KhachHangDVO_TenKhachHang, onlyOneControl: false);
		}

		private void SearchKhachHang()
		{
			KhachHangDVO khachHangDVO = this.GetInputFromControl(this.KhachHangDVO_DiaChi);

			System.Data.DataTable khachHang = KhachHangDAO.Instance.KhachHangInformationFromSearch(khachHangDVO);

			if (khachHang.Rows.Count <= 0)
			{
				this.ShowMessageBox("Khách hàng bạn tìm kiếm không tồn tại, hãy kiểm tra kỹ đầu vào!");

				return;
			}

			this.TabPageKhachHang_MaterialListView.Items.Clear();

			foreach (DataRow row in khachHang.Rows)
			{
				ListViewItem items = new ListViewItem();

				items.SubItems[0].Text = (this.TabPageKhachHang_MaterialListView.Items.Count + 1).ToString();

				for (int i = 0; i < khachHang.Columns.Count; i++)
				{
					items.SubItems.Add(row[i].ToString().Trim());
				}

				this.TabPageKhachHang_MaterialListView.Items.Add(items);
			}

			this.ResetValidationForControl(this.KhachHangDVO_TenKhachHang, onlyOneControl: false);
		}

		#endregion

		#region Nhà cung cấp
		private void Initialize_NhaCungCap()
		{
			this.Load += FormMain_NhaCungCap_Load;

			this.TabPageNhaCungCap_MaterialListView.SelectedIndexChanged += TabPageNhaCungCap_MaterialListView_SelectedIndexChanged;

			this.NhaCungCapDVO_DienThoai.KeyDown += (obj, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				{
					NewNhaCungCap();
				}
			};

			this.TabPageNhaCungCap_TaoNhaCungCap.Click += (obj, e) =>
			{
				FormCreateNhaCungCap formCreateNhaCungCap = new FormCreateNhaCungCap(false);

				formCreateNhaCungCap.Show();
				//NewNhaCungCap();
			};

			this.TabPageNhaCungCap_XoaNhaCungCap.Click += (obj, e) =>
			{
				if (this.TabPageNhaCungCap_MaterialListView.SelectedIndices.Count <= 0)
				{
					this.ShowMessageBox("Hãy chọn nhà cung cấp mà bạn cần xóa!");

					return;
				}

				Guid maNhaCungCap = Guid.Parse(this.TabPageNhaCungCap_MaterialListView.SelectedItems[0].SubItems[1].Text);

				if (NhaCungCapDAO.Instance.CheckIfNhaCungCapHasHDNhap(maNhaCungCap))
				{
					this.ShowMessageBox("Nhà cung cấp đã có trong cơ sở dữ liệu, không được phép xóa!");

					return;
				}
				else
				{
					if (!this.ShowMessageBoxYesNo("Bạn có muốn xóa nhà cung cấp này không?"))
					{
						return;
					}

					if (NhaCungCapDAO.Instance.DeleteNhaCungCap(maNhaCungCap))
					{
						this.ShowMessageBox("Nhà cung cấp đã đã đợc xóa!");

						this.LoadNhaCungCap();
					}
					else
					{
						this.ShowMessageBox("Có lỗi gì đó đã xẩy ra, hãy đợi chúng tôi bảo trì code!");
					}
				}
			};

			this.TabPageNhaCungCap_MaterialListView.DoubleClick += (obj, e) =>
			{
				if (this.TabPageNhaCungCap_MaterialListView.SelectedIndices.Count <= 0)
				{
					this.ShowMessageBox("Hãy chọn nhà cung cấp mà bạn muốn xem!");

					return;
				}

				int index = this.TabPageNhaCungCap_MaterialListView.SelectedIndices[0];

				if (index >= 0)
				{
					ListViewItem listViewItem = this.TabPageNhaCungCap_MaterialListView.Items[index];

					string NhaCungCap_SoDienThoai = listViewItem.SubItems[3].Text;

					if (!HoaDonNhapDAO.Instance.IfHoaDonNhapInformationFromSoDienThoai(NhaCungCap_SoDienThoai))
					{
						this.ShowMessageBox("Nhà cung cấp chưa có đơn hàng nào cả!");

						return;
					}

					FormListImportBill formListImportlBill = new FormListImportBill(NhaCungCap_SoDienThoai);
					formListImportlBill.ShowDialog();
				}
			};


			this.NhaCungCapDVO_DienThoai.KeyPress += this.TextBoxBase_KeyPress_NumericOnly;

			this.NhaCungCapDVO_DienThoai.KeyDown += (obj, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				{
					this.SearchNhaCungCap();
				}
			};

			this.NhaCungCapDVO_TenNhaCungCap.KeyDown += (obj, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				{
					this.SearchNhaCungCap();
				}
			};

			this.NhaCungCapDVO_DiaChi.KeyDown += (obj, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				{
					this.SearchNhaCungCap();
				}
			};

			this.TabPageNhaCungCap_SuaNCC.Click += MaterialButton_SuaNCC_Click;

			this.TabPageNhaCungCap_SearchNhaCungCap.Click += (obj, e) =>
			{
				this.SearchNhaCungCap();
			};

			this.TabPageNhaCungCap_RefreshNhaCungCap.Click += (obj, e) =>
			{
				ResetNhaCungCapDVO();

				LoadNhaCungCap();
			};

			this.TabPageNhaCungCap_XuatExcelNCC.Click += (obj, e) =>
			{
				System.Data.DataTable dataTable = NhaCungCapDAO.Instance.QueryAllNhaCungCap();
				this.exportTableData.ExportToExcel(
					dataTable: dataTable,
					workSheetName: "NhaCungCap" + this.getDateTime.GetDateTimeNow_Date(),
					filePath: "",
					typeOfFile: ExportTableData.TypeOfExcel.NhaCungCap
				);

				this.ResetColorForLabel();
			};

			this.TabPageNhaCungCap_LichSuNhapHang.Click += MaterialButton_LichSuNhapHang_Click;
		}

		private void MaterialButton_LichSuNhapHang_Click(object sender, EventArgs e)
		{
			if (this.TabPageNhaCungCap_MaterialListView.SelectedIndices.Count <= 0)
			{
				this.ShowMessageBox("Hãy chọn nhà cung cấp mà bạn muốn xem!");

				return;
			}

			int index = this.TabPageNhaCungCap_MaterialListView.SelectedIndices[0];

			if (index >= 0)
			{
				ListViewItem listViewItem = this.TabPageNhaCungCap_MaterialListView.Items[index];

				string nhaCungCap_SoDienThoai = listViewItem.SubItems[3].Text;

				if (!HoaDonNhapDAO.Instance.IfHoaDonNhapInformationFromSoDienThoai(nhaCungCap_SoDienThoai))
				{
					this.ShowMessageBox("Nhà cung cấp chưa có đơn hàng nào cả!");

					return;
				}

				FormListImportBill formListImportBill = new FormListImportBill(nhaCungCap_SoDienThoai);
				formListImportBill.ShowDialog();
			}
		}

		private bool CheckNullNCC()
		{
			return this.CheckIfControlEmptyOrPlaceholder(this.NhaCungCapDVO_DienThoai) &&
					this.CheckIfControlEmptyOrPlaceholder(this.NhaCungCapDVO_TenNhaCungCap);
		}

		private void LoadNhaCungCap()
		{
			System.Data.DataTable nhaCungCapDT = NhaCungCapDAO.Instance.QueryAllNhaCungCap();

			ListViewItem item;

			int cnt = 0;
			foreach (DataRow row in nhaCungCapDT.Rows)
			{
				item = new ListViewItem();
				cnt += 1;
				item.SubItems[0].Text = cnt.ToString();
				for (int i = 0; i < nhaCungCapDT.Columns.Count; i++)
				{
					item.SubItems.Add(row[i].ToString().Trim());
				}
				this.TabPageNhaCungCap_MaterialListView.Items.Add(item);
			}
		}

		private void SearchNhaCungCap()
		{
			NhaCungCapDVO nhaCungCapDVO = this.GetInputFromControl(this.NhaCungCapDVO_DiaChi);

			System.Data.DataTable nhaCungCap = NhaCungCapDAO.Instance.NhaCungCapInformationFromSearch(nhaCungCapDVO);

			if (nhaCungCap.Rows.Count <= 0)
			{
				this.ShowMessageBox("Nhà cung cấp bạn tìm kiếm không tồn tại, hãy kiểm tra kỹ đầu vào!");

				return;
			}

			this.TabPageNhaCungCap_MaterialListView.Items.Clear();

			foreach (DataRow row in nhaCungCap.Rows)
			{
				ListViewItem items = new ListViewItem();

				items.SubItems[0].Text = (this.TabPageNhaCungCap_MaterialListView.Items.Count + 1).ToString();

				for (int i = 0; i < nhaCungCap.Columns.Count; i++)
				{
					items.SubItems.Add(row[i].ToString().Trim());
				}

				this.TabPageNhaCungCap_MaterialListView.Items.Add(items);
			}

			this.ResetValidationForControl(this.NhaCungCapDVO_TenNhaCungCap, onlyOneControl: false);
		}

		private void MaterialButton_SuaNCC_Click(object sender, EventArgs e)
		{
			if (this.TabPageNhaCungCap_MaterialListView.SelectedIndices.Count <= 0)
			{
				this.ShowMessageBox("Bạn hãy chọn nhà cung cấp bạn muốn cập nhật");

				return;
			}

			if (this.TryValidationFromControl(this.NhaCungCapDVO_DiaChi, onlyOneControl: true, out dynamic baseDVO) &&
					this.TryValidationFromControl(this.NhaCungCapDVO_TenNhaCungCap, onlyOneControl: true, out dynamic baseDVO1) &&
					this.GetControlTextIfPlaceholderThenEmpty(this.NhaCungCapDVO_DienThoai).Length == 10)
			{
				NhaCungCapDVO nhaCungCapDVO = baseDVO as NhaCungCapDVO;
				// Update Controls
				int index = this.TabPageNhaCungCap_MaterialListView.SelectedIndices[0];

				if (index >= 0)
				{
					ListViewItem listViewItem = this.TabPageNhaCungCap_MaterialListView.Items[index];

					string NhaCungCap_TenNhaCungCapTMP = listViewItem.SubItems[2].Text;
					string NhaCungCap_DienThoaiTMP = listViewItem.SubItems[3].Text;

					if (ShowMessageBoxYesNo($"Bạn có chắc chắn muốn thay đổi nhà cung cấp {NhaCungCap_TenNhaCungCapTMP} có số điện thoại {NhaCungCap_DienThoaiTMP}?"))
					{
						if (NhaCungCapDAO.Instance.UpdateNhaCungCapFull(nhaCungCapDVO, NhaCungCap_DienThoaiTMP))
						{
							ShowMessageBox("Đã cập nhật thành công!");
							listViewItem.SubItems[2].Text = nhaCungCapDVO.NhaCungCapDVO_TenNhaCungCap;
							listViewItem.SubItems[3].Text = nhaCungCapDVO.NhaCungCapDVO_DienThoai;
							listViewItem.SubItems[4].Text = nhaCungCapDVO.NhaCungCapDVO_DiaChi;
						}
						else
						{
							ShowMessageBox("Thay đổi thất bại!");
						}
					}
				}

			}
		}

		private void ResetNhaCungCapDVO()
		{
			this.TabPageNhaCungCap_MaterialListView.Items.Clear();

			this.ResetInputForControl(this.NhaCungCapDVO_TenNhaCungCap, onlyOneControl: false);

			this.ResetValidationForControl(this.NhaCungCapDVO_TenNhaCungCap, onlyOneControl: false);
		}

		private void NewNhaCungCap()
		{
			if (this.TryValidationFromControl(this.NhaCungCapDVO_DienThoai, onlyOneControl: false, out dynamic baseDVO))
			{
				NhaCungCapDVO nhaCungCapDVO = baseDVO as NhaCungCapDVO;
				if (this.TabPageNhaCungCap_MaterialListView.SelectedIndices.Count <= 0)
				{
					foreach (ListViewItem items in this.TabPageNhaCungCap_MaterialListView.Items)
					{
						// If the phone number already exists, update the customer information
						string phoneNumber = items.SubItems[3].Text;
						if (phoneNumber.Equals(this.NhaCungCapDVO_DienThoai.Text))
						{
							if (ShowMessageBoxYesNo($"Nhà cung cấp có số điện thoại {phoneNumber} đã tồn tại, bạn có muốn cập nhật lại thông tin khách hàng không?"))
							{
								bool status = NhaCungCapDAO.Instance.UpdateNhaCungCap(
									items.SubItems[2].Text,
									items.SubItems[4].Text,
									items.SubItems[3].Text);
								if (status)
								{
									ShowMessageBox("Đã cập nhật thành công!");
								}
								else
								{
									ShowMessageBox("Cập nhật thất bại, hãy kiểm tra lại các thông tin!!");
								}

								ResetNhaCungCapDVO();

								return;
							}
							else
							{
								return;
							}
						}
					}
				}
				else
				{
					for (int i = 0; i < this.TabPageNhaCungCap_MaterialListView.Items.Count; i++)
					{
						this.TabPageNhaCungCap_MaterialListView.Items[i].SubItems[0].Text = (i + 1).ToString();
					}
				}

				if (NhaCungCapDAO.Instance.InsertNhaCungCap(nhaCungCapDVO))
				{
					ShowMessageBox("Đã cập nhật thành công!");
					System.Data.DataTable dataTable = NhaCungCapDAO.Instance.NhaCungCapInformationFromPhoneNumber(NhaCungCapDVO_DienThoai.Text);

					ListViewItem item = new ListViewItem();

					item.SubItems[0].Text = (this.TabPageNhaCungCap_MaterialListView.Items.Count + 1).ToString();

					foreach (DataRow row in dataTable.Rows)
					{
						for (int i = 0; i < dataTable.Columns.Count; i++)
						{
							item.SubItems.Add(row[i].ToString().Trim());
						}
					}

					this.TabPageNhaCungCap_MaterialListView.Items.Add(item);
				}

				ResetNhaCungCapDVO();

				return;
			}

		}

		private void TabPageNhaCungCap_MaterialListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Nothing
			if (this.TabPageNhaCungCap_MaterialListView.SelectedIndices.Count <= 0)
			{
				return;
			}

			// Update Controls
			int index = this.TabPageNhaCungCap_MaterialListView.SelectedIndices[0];

			if (index >= 0)
			{
				ListViewItem listViewItem = this.TabPageNhaCungCap_MaterialListView.Items[index];

				this.NhaCungCapDVO_TenNhaCungCap.Text = listViewItem.SubItems[2].Text;
				this.NhaCungCapDVO_DienThoai.Text = listViewItem.SubItems[3].Text;
				this.NhaCungCapDVO_DiaChi.Text = listViewItem.SubItems[4].Text;
			}
		}

		private void FormMain_NhaCungCap_Load(object sender, EventArgs e)
		{
			System.Data.DataTable nhaCungCap = NhaCungCapDAO.Instance.QueryAllNhaCungCap();
			ListViewItem items;

			int count = 0;
			foreach (DataRow row in nhaCungCap.Rows)
			{
				items = new ListViewItem();
				//Console.WriteLine(count);
				count += 1;
				//Debug.Write(count);

				items.SubItems[0].Text = count.ToString();
				for (int i = 0; i < nhaCungCap.Columns.Count; i++)
				{
					items.SubItems.Add(row[i].ToString().Trim());
				}
				this.TabPageNhaCungCap_MaterialListView.Items.Add(items);
			}
		}


		#endregion

		#endregion

		#region Bùi Thị Thanh Trúc

		private Guid maNhanVien;

		private void Initialize_BuiThiThanhTruc()
		{
			this.NhanVienDVO_MatKhau.GotFocus += (obj, e) =>
			{
				this.NhanVienDVO_MatKhau.Password = true;
			};
			this.NhanVienDVO_NhapLaiMatKhau.GotFocus += (obj, e) =>
			{
				this.NhanVienDVO_NhapLaiMatKhau.Password = true;
			};

			this.NhanVienDVO_MatKhau.LostFocus += (obj, e) =>
			{
				if (this.CheckIfControlEmptyOrPlaceholder(this.NhanVienDVO_MatKhau))
				{
					this.NhanVienDVO_MatKhau.Password = false;
				}
			};
			this.NhanVienDVO_NhapLaiMatKhau.LostFocus += (obj, e) =>
			{
				if (this.CheckIfControlEmptyOrPlaceholder(this.NhanVienDVO_NhapLaiMatKhau))
				{
					this.NhanVienDVO_NhapLaiMatKhau.Password = false;
				}
			};

			this.TabPageNhanVien_btnExcel.Click += (obj, e) =>
			{
				System.Data.DataTable dataTable = NhanVienDAO.Instance.GetNhanVienWithInput(this.TabPageNhanVien_TextboxSelectNhanVien.Text);

				if (dataTable.Rows.Count <= 0)
				{
					this.ShowMessageBox("Không tìm được nhân viên");

					return;
				}

				this.exportTableData.ExportToExcel(
					dataTable: dataTable,
					workSheetName: "NhanVien" + this.getDateTime.GetDateTimeNow_Date(),
					filePath: "",
					typeOfFile: ExportTableData.TypeOfExcel.NhanVien
				);

				this.ResetColorForLabel();
			};

			this.AddItemToComboBox();
			this.CallDataNhanVien();
			this.LoadThongTinNhanVien();
			this.CreateNewNhanVien();
			this.DeleteNhanVien();
			this.EditNhanVien();
			this.SearchNhanVien();
			this.CreateNewCongViec();
		}

		public void AddItemToComboBox()
		{
			// Xóa danh sách combobox hiện tại trên UI
			NhanVienDVO_TenCongViec.Items.Clear();

			// Thêm danh sách vào ComboBox
			NhanVienDVO_TenCongViec.Items.AddRange(CongViecDAO.Instance.GetTenCongViecList().ToArray());
		}

		// Hiện thông tin lên ListView
		private void LoadThongTinNhanVien()
		{
			materialTabControl.SelectedIndexChanged += (object sender, EventArgs e) =>
			{
				if (this.materialTabControl.SelectedIndex == 0)
				{
					this.CallDataNhanVien();
				}
			};
		}

		//Tạo mới một Nhân Viên 
		private void CreateNewNhanVien()
		{
			TabPageNhanVien_btnThem.Click += (object sender, EventArgs e) =>
			{
				if (this.ShowMessageBoxYesNo("Bạn có muốn thêm không?", this.GetTabPageControlSelectedIndex()))
				{
					if (!this.TryValidationFromControl(this.NhanVienDVO_GioiTinh, onlyOneControl: false, out dynamic baseDVO))
					{
						return;
					}

					NhanVienDVO nhanVienDVO = baseDVO as NhanVienDVO;

					NhanVienDTO nhanVienDTO = new NhanVienDTO();

					nhanVienDTO.NhanVienDTO_MaNhanVien = Guid.NewGuid();
					nhanVienDTO.NhanVienDTO_MaCongViec = CongViecDAO.Instance.GetMaCongViecFromTenCongViec(this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_TenCongViec));
					nhanVienDTO.NhanVienDTO_TenNhanVien = nhanVienDVO.NhanVienDVO_TenNhanVien;
					nhanVienDTO.NhanVienDTO_DiaChi = nhanVienDVO.NhanVienDVO_DiaChi;
					nhanVienDTO.NhanVienDTO_DienThoai = nhanVienDVO.NhanVienDVO_SoDienThoai;
					nhanVienDTO.NhanVienDTO_NgaySinh = nhanVienDVO.NhanVienDVO_NgaySinh;
					nhanVienDTO.NhanVienDTO_Email = nhanVienDVO.NhanVienDVO_Email;
					nhanVienDTO.NhanVienDTO_GioiTinh = nhanVienDVO.NhanVienDVO_GioiTinh;
					nhanVienDTO.NhanVienDTO_MatKhau = nhanVienDVO.NhanVienDVO_MatKhau;

					// Dữ liệu hợp lệ, tiếp tục xử lý
					if (NhanVienDAO.Instance.InsertNhanVien(nhanVienDTO))
					{
						// Thêm thành công, cập nhật ListView và làm sạch dữ liệu
						this.TabPageNhanVien_MaterialListView.Items.Clear();

						this.CallDataNhanVien();

						this.ClearFormData();

						// Thực hiện sự kiện sau khi thêm nhân viên thành công
						// Ví dụ: Hiển thị thông báo hoặc thực hiện một hành động nào đó
						this.ShowMessageBox("Thêm nhân viên thành công!", "Thông báo");
					}
					else
					{
						// Thêm không thành công, hiển thị thông báo lỗi
						this.ShowMessageBox("Thêm nhân viên không thành công!", "Lỗi");
					}

				}
			};
		}

		// Xóa Nhân Viên Hiện Có
		private void DeleteNhanVien()
		{
			TabPageNhanVien_btnXoa.Click += (object sender, EventArgs e) =>
			{
				if (this.TabPageNhanVien_MaterialListView.SelectedItems.Count > 0)
				{
					if (this.ShowMessageBoxYesNo("Bạn có chắc chắn muốn xóa dữ liệu đã chọn?"))
					{
						foreach (ListViewItem item in TabPageNhanVien_MaterialListView.SelectedItems)
						{
							// Lấy giá trị của mã nhân viên từ SubItems[1], cột mã nhân viên là cột thứ 1
							string maNhanVien = item.SubItems[1].Text;

							// Gọi hàm xóa dữ liệu dựa trên mã nhân viên
							NhanVienDAO.Instance.XoaNhanVienTheoMa(maNhanVien);
						}

						this.TabPageNhanVien_MaterialListView.Items.Clear();

						this.CallDataNhanVien();
						
						this.ShowMessageBox("Dữ liệu đã được xóa thành công.", "Thông báo");
					}
				}
				else
				{
					this.ShowMessageBox("Vui lòng chọn ít nhất một mục để xóa.", "Thông báo");
				}
			};
		}

		// Tìm Kiếm Nhân Viên
		private void SearchNhanVien()
		{
			TabPageNhanVien_btnSearch.Click += (object sender, EventArgs e) =>
			{
				if (this.TabPageNhanVien_TextboxSelectNhanVien.Text == "")
				{
					this.ShowMessageBox("Vui lòng nhập thông tin tìm kiếm.", "Thông báo");

					return;
				}

				string timNhanVien = this.TabPageNhanVien_TextboxSelectNhanVien.Text;

				// Gọi phương thức để tìm kiếm nhân viên theo tên
				List<NhanVienDTO> ketQua = NhanVienDAO.Instance.TimNhanVienTheoMaNhanVienHoacTenNhanVien(timNhanVien);

				this.TabPageNhanVien_MaterialListView.Items.Clear();

				// Hiện Kết Quả lên ListView
				int stt = 0;

				foreach (NhanVienDTO nhanVienDTO in ketQua)
				{
					ListViewItem item = new ListViewItem();

					item.SubItems[0].Text = (++stt).ToString();
					item.SubItems.Add(nhanVienDTO.NhanVienDTO_MaNhanVien.ToString());
					item.SubItems.Add(nhanVienDTO.NhanVienDTO_TenNhanVien);
					item.SubItems.Add(nhanVienDTO.NhanVienDTO_NgaySinh.ToString());
					item.SubItems.Add(nhanVienDTO.NhanVienDTO_GioiTinh);
					item.SubItems.Add(nhanVienDTO.NhanVienDTO_DienThoai);
					item.SubItems.Add(nhanVienDTO.NhanVienDTO_DiaChi);
					item.SubItems.Add(nhanVienDTO.NhanVienDTO_Email);

					TabPageNhanVien_MaterialListView.Items.Add(item);
				}
			};

			TabPageNhanVien_btnMacDinh.Click += (object sender, EventArgs e) =>
			{
				TabPageNhanVien_MaterialListView.Items.Clear();

				this.CallDataNhanVien();
			};
		}

		// Sửa thông tin Nhân Viên
		private void EditNhanVien()
		{
			TabPageNhanVien_btnSua.Click += (object sender, EventArgs e) =>
			{
				// Kiểm tra xem đã chọn nhân viên nào chưa
				if (this.TabPageNhanVien_MaterialListView.SelectedItems.Count > 0)
				{
					// Lấy thông tin nhân viên được chọn
					ListViewItem item = this.TabPageNhanVien_MaterialListView.SelectedItems[0];

					this.maNhanVien = Guid.Parse(item.SubItems[1].Text);

					CustomNhanVienDTO customNhanVienDTO = NhanVienDAO.Instance.GetNhanVienByID(this.maNhanVien);
					
					//Debug.WriteLine(this.maNhanVien);
					//Debug.WriteLine(customNhanVienDTO.NhanVienDTO_TenNhanVien);

					//Hiện thông tin lên form
					NhanVienDVO_TenNhanVien.Text = customNhanVienDTO.NhanVienDTO_TenNhanVien;
					NhanVienDVO_NgaySinh.Value = customNhanVienDTO.NhanVienDTO_NgaySinh;
					NhanVienDVO_SoDienThoai.Text = customNhanVienDTO.NhanVienDTO_DienThoai.Trim();
					NhanVienDVO_GioiTinh.Text = customNhanVienDTO.NhanVienDTO_GioiTinh;
					NhanVienDVO_DiaChi.Text = customNhanVienDTO.NhanVienDTO_DiaChi;
					NhanVienDVO_TenCongViec.Text = customNhanVienDTO.NhanVienDTO_TenCongViec;
					NhanVienDVO_Email.Text = customNhanVienDTO.NhanVienDTO_Email;

					this.ResetValidationForTabPage();
				}
				else
				{
					this.ShowMessageBox("Vui lòng chọn một nhân viên để sửa.");
				}
			};

			TabPageNhanVien_btnLuu.Click += (object sender, EventArgs e) =>
			{
				if (this.ShowMessageBoxYesNo("Bạn có muốn sửa không?", this.GetTabPageControlSelectedIndex()))
				{
					// Kiểm tra tính hợp lệ của dữ liệu
					if (!this.TryValidationFromControl(this.NhanVienDVO_GioiTinh, onlyOneControl: false, out dynamic baseDVO))
					{
						// Cập nhật thất bại
						this.ShowMessageBox("Sửa thất bại! Vui Lòng thử lại!");

						return;
					}

					NhanVienDVO nhanVienDVO = baseDVO as NhanVienDVO;

					if (!NhanVienDAO.Instance.CheckMatKhauNhanVien(this.maNhanVien, nhanVienDVO.NhanVienDVO_MatKhau))
					{
						this.ShowMessageBox("Mật khẩu vừa nhập không khớp với mật khẩu nhân viên đã lưu");

						return;
					}

					NhanVienDTO data = new NhanVienDTO
					{
						NhanVienDTO_MaNhanVien = this.maNhanVien,
						NhanVienDTO_TenNhanVien = nhanVienDVO.NhanVienDVO_TenNhanVien,
						NhanVienDTO_Email = nhanVienDVO.NhanVienDVO_Email,
						NhanVienDTO_MatKhau = nhanVienDVO.NhanVienDVO_MatKhau,
						NhanVienDTO_NgaySinh = nhanVienDVO.NhanVienDVO_NgaySinh,
						NhanVienDTO_GioiTinh = nhanVienDVO.NhanVienDVO_GioiTinh,
						NhanVienDTO_DienThoai = nhanVienDVO.NhanVienDVO_SoDienThoai,
						NhanVienDTO_DiaChi = nhanVienDVO.NhanVienDVO_DiaChi,
						NhanVienDTO_MaCongViec = CongViecDAO.Instance.GetMaCongViecFromTenCongViec(nhanVienDVO.NhanVienDVO_TenCongViec)
					};

					// Cập nhật nhân viên trong database
					bool updateResult = NhanVienDAO.Instance.UpdateNhanVien(data);


					if (updateResult)
					{
						this.ClearFormData();

						this.TabPageNhanVien_MaterialListView.Items.Clear();

						this.CallDataNhanVien();

						// Cập nhật thành công
						this.ShowMessageBox("Cập nhật thông tin nhân viên thành công!");
					}
				}
			};
		}

		private void CallDataNhanVien()
		{
			// Lay du lieu 
			List<NhanVienDTO> nhanvienDTOs = NhanVienDAO.Instance.GetListNV();

			// load du lieu len 
			int stt = 0;

			foreach (NhanVienDTO nhanVienDTO in nhanvienDTOs)
			{
				ListViewItem item = new ListViewItem();

				item.SubItems[0].Text = (++stt).ToString();
				item.SubItems.Add(nhanVienDTO.NhanVienDTO_MaNhanVien.ToString());
				item.SubItems.Add(nhanVienDTO.NhanVienDTO_TenNhanVien);
				item.SubItems.Add(nhanVienDTO.NhanVienDTO_NgaySinh.ToString());
				item.SubItems.Add(nhanVienDTO.NhanVienDTO_GioiTinh);
				item.SubItems.Add(nhanVienDTO.NhanVienDTO_DienThoai);
				item.SubItems.Add(nhanVienDTO.NhanVienDTO_DiaChi);
				item.SubItems.Add(nhanVienDTO.NhanVienDTO_Email);

				TabPageNhanVien_MaterialListView.Items.Add(item);
			}
		}

		// Xóa dữ liệu trong form
		private void ClearFormData()
		{
			this.ResetInputForTabPage();

			//NhanVienDVO_TenNhanVien.Text = string.Empty;
			//NhanVienDVO_Email.Text = string.Empty;
			//NhanVienDVO_NgaySinh.Value = this.dateTimeDefault;
			//NhanVienDVO_GioiTinh.SelectedIndex = -1;
			//NhanVienDVO_SoDienThoai.Text = string.Empty;
			//NhanVienDVO_DiaChi.Text = string.Empty;
			//NhanVienDVO_TenCongViec.Text = string.Empty;
		}

		// Tạo mới một công việc 
		private void CreateNewCongViec()
		{
			TabPageNhanVien_btnTaoMoiCongViec.Click += (object sender, EventArgs e) =>
			{
				FormCreateCongViec formCreateCongViec = new FormCreateCongViec();

				formCreateCongViec.Show();
			};
		}

		#endregion

		#region Vũ Hồng Hạnh

		//		HieuNote: Winform bên t chạy bình thường, bên m chậm có thể là do m bật quá nhiều tác vụ cùng một lúc
		private void Initialize_VuHongHanh()
		{
			//Debug.WriteLine(DMSanPhamDAO.Instance.UpdateCongSoLuongTon("469075421580", 2));

			this.Load += TabPageSanPham_materialListView_Load;

			this.TabPageSanPham_MaterialListView.SelectedIndexChanged += TabPageSanPham_materialListView_SelectedIndexChanged;
			this.TabPageSanPham_ButtonThemSanPham.Click += TabPageSanPham_ButtonThemSanPham_Click;
			this.TabPageSanPham_ButtonSuaSanPham.Click += TabPageSanPham_ButtonSuaSanPham_Click;
			this.TabPageSanPham_NhapMoiTimKiem.Click += TabPageSanPham_NhapMoiTimKiem_Click;
			this.TabPageSanPham_ButtonXoaSanPham.Click += TabPageSanPham_ButtonXoaSanPham_Click;
			this.TabPageSanPham_ButtonXuatRaFileExcel.Click += TabPageSanPham_ButtonXuatRaFileExcel_Click;
			this.TabPageSanPham_ButtonTimKiem.Click += TabPageSanPham_ButtonTimKiem_Click;
			this.TabPageSanPham_ButtonLoadSP.Click += TabPageSanPham_ButtonLoadSP_Click;
			this.TabPageSanPham_ButtonDSKM.Click += TabPageSanPham_ButtonDSKM_Click;
		}

		private void TabPageSanPham_ButtonDSKM_Click(object sender, EventArgs e)
		{
			if (this.ShowMessageBoxYesNo("Bạn có muốn xem danh sách khuyến mại không ?"))
			{
				FormDanhSachGiamGia formDanhSachGiamGia = new FormDanhSachGiamGia();
				
				formDanhSachGiamGia.Show();
			}
		}

		private void TabPageSanPham_ButtonLoadSP_Click(object sender, EventArgs e)
		{
			if (this.ShowMessageBoxYesNo("Bạn có muốn load lại dữ liệu tất cả các sản phẩm không?"))
			{
				System.Data.DataTable sanPham = DMSanPhamDAO.Instance.GetAllSanPham();
				LoadSanPham(sanPham);
			}
		}

		private void TabPageSanPham_ButtonTimKiem_Click(object sender, EventArgs e)
		{
			System.Data.DataTable sanPham;

			//		HieuNote: cái lúc trước của m là check null là không đúng, check bằng "" sẽ chuẩn hơn, t ở đây cứ dùng phương thức có sẵn
			if (!this.CheckIfControlEmptyOrPlaceholder(this.DMSanPhamDVO_MaSanPham))
			{
				sanPham = DMSanPhamDAO.Instance.GetSanPhamFromMSP(this.GetControlTextIfPlaceholderThenEmpty(DMSanPhamDVO_MaSanPham));
			}
			else
			{
				long DonGiaBanMin, DonGiaBanMax, DonGiaNhapMin, DonGiaNhapMax;
				int SoLuongTonKhoMin, SoLuongTonKhoMax;
				DateTime ThoiGianBaoHanhMin, ThoiGianBaoHanhMax, ThoiGianBaoHanhDefault;

				//		HieuNote: t sửa để dùng các phương thức có sẵn, m ko hiểu cũng ko sao
				if (this.CheckIfControlEmptyOrPlaceholder(this.DMSanPhamDVO_DonGiaBanMin)) DonGiaBanMin = 0;
				else DonGiaBanMin = long.Parse(DMSanPhamDVO_DonGiaBanMin.Text.Trim());

				if (this.CheckIfControlEmptyOrPlaceholder(this.DMSanPhamDVO_DonGiaBanMax)) DonGiaBanMax = 0;
				else DonGiaBanMax = long.Parse(DMSanPhamDVO_DonGiaBanMax.Text.Trim());

				if (this.CheckIfControlEmptyOrPlaceholder(this.DMSanPhamDVO_DonGiaNhapMin)) DonGiaNhapMin = 0;
				else DonGiaNhapMin = long.Parse(DMSanPhamDVO_DonGiaNhapMin.Text.Trim());

				if (this.CheckIfControlEmptyOrPlaceholder(this.DMSanPhamDVO_DonGiaNhapMax)) DonGiaNhapMax = 0;
				else DonGiaNhapMax = long.Parse(DMSanPhamDVO_DonGiaNhapMax.Text.Trim());

				if (this.CheckIfControlEmptyOrPlaceholder(this.DMSanPhamDVO_SoLuongTonKhoMin)) SoLuongTonKhoMin = 0;
				else SoLuongTonKhoMin = int.Parse(DMSanPhamDVO_SoLuongTonKhoMin.Text.Trim());

				if (this.CheckIfControlEmptyOrPlaceholder(this.DMSanPhamDVO_SoLuongTonKhoMax)) SoLuongTonKhoMax = 0;
				else SoLuongTonKhoMax = int.Parse(DMSanPhamDVO_SoLuongTonKhoMax.Text.Trim());

				ThoiGianBaoHanhMin = DMSanPhamDVO_ThoiGianBaoHanhMin.Value;

				ThoiGianBaoHanhMax = DMSanPhamDVO_ThoiGianBaoHanhMax.Value;

				sanPham = DMSanPhamDAO.Instance.GetSanPham(
												this.GetControlTextIfPlaceholderThenEmpty(this.DMSanPhamDVO_TenSanPham),
												DonGiaBanMin,
												DonGiaBanMax,
												DonGiaNhapMin,
												DonGiaNhapMax,
												SoLuongTonKhoMin,
												SoLuongTonKhoMax,
												ThoiGianBaoHanhMin,
												ThoiGianBaoHanhMax
												);

			}

			//		HieuNote: lúc trước m cho check null, nhưng mà phương thức ExecuteQuery luôn trả về một biến DataTable
			//					dù có dữ liệu hay không, nên giờ check xem .Rows.Count > 0
			if (sanPham.Rows.Count > 0)
			{
				this.LoadSanPham(sanPham);
			}
			else
			{
				this.ShowMessageBox("Không tìm thấy sản phẩm cần tìm kiếm");
			}
		}

		private void TabPageSanPham_ButtonXuatRaFileExcel_Click(object sender, EventArgs e)
		{
			System.Data.DataTable dataTable = new System.Data.DataTable();

			dataTable.Columns.Add("STT");
			dataTable.Columns.Add("Mã sản phẩm");
			dataTable.Columns.Add("Tên sản phẩm");
			dataTable.Columns.Add("Đơn giá bán");
			dataTable.Columns.Add("Đơn giá nhập");
			dataTable.Columns.Add("Số lượng tồn kho");
			dataTable.Columns.Add("Thời gian bảo hành");

			foreach (ListViewItem item in TabPageSanPham_MaterialListView.Items)
			{
				DataRow row = dataTable.NewRow();
				row["STT"] = item.SubItems[0].Text;
				row["Mã sản phẩm"] = item.SubItems[1].Text;
				row["Tên sản phẩm"] = item.SubItems[2].Text;
				row["Đơn giá bán"] = item.SubItems[3].Text;
				row["Đơn giá nhập"] = item.SubItems[4].Text;
				row["Số lượng tồn kho"] = item.SubItems[5].Text;
				row["Thời gian bảo hành"] = item.SubItems[6].Text;
				dataTable.Rows.Add(row);//Thêm dataRow vào dataTable
			}

			this.exportTableData.ExportToExcel(
				dataTable: dataTable,
				workSheetName: "DMSanPham" + this.getDateTime.GetDateTimeNow_Date(),
				filePath: ""
			);

			this.ResetColorForLabel();
		}

		private void TabPageSanPham_ButtonXoaSanPham_Click(object sender, EventArgs e)
		{
			if (this.ShowMessageBoxYesNo("Bạn có chắc chắn muốn xóa sản phẩm này không?"))
			{
				if (TabPageSanPham_MaterialListView.SelectedIndices.Count <= 0)
				{
					this.ShowMessageBox("Hãy chọn sản phẩm muốn xóa");

					return;
				}
				int selectedIndex = TabPageSanPham_MaterialListView.SelectedIndices[0];

				ListViewItem listViewItem = this.TabPageSanPham_MaterialListView.Items[selectedIndex];

				string MSP;

				MSP = listViewItem.SubItems[1].Text;
				Debug.WriteLine(MSP);
				if (DMSanPhamDAO.Instance.DeleteSanPham(MSP))
				{
					this.ShowMessageBox("Đã xóa sản phẩm thành công");
					System.Data.DataTable sanPham = DMSanPhamDAO.Instance.GetAllSanPham();
					LoadSanPham(sanPham);
				}
			}
		}

		private void TabPageSanPham_NhapMoiTimKiem_Click(object sender, EventArgs e)
		{
			this.ResetInputForTabPage();
		}

		private void TabPageSanPham_materialListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListView.SelectedIndexCollection selectedIndices = TabPageSanPham_MaterialListView.SelectedIndices;
			if (selectedIndices.Count > 0)
			{
				int selectedIndex = TabPageSanPham_MaterialListView.SelectedIndices[0];
				ListViewItem listViewItem = this.TabPageSanPham_MaterialListView.Items[selectedIndex];
				DMSanPhamDVO_MaSanPham.Text = listViewItem.SubItems[1].Text;
				DMSanPhamDVO_TenSanPham.Text = listViewItem.SubItems[2].Text;
				DMSanPhamDVO_DonGiaBanMin.Text = listViewItem.SubItems[3].Text;
				DMSanPhamDVO_DonGiaBanMax.Text = "";
				DMSanPhamDVO_DonGiaNhapMin.Text = listViewItem.SubItems[4].Text;
				DMSanPhamDVO_DonGiaNhapMax.Text = "";
				DMSanPhamDVO_SoLuongTonKhoMin.Text = listViewItem.SubItems[5].Text;
				DMSanPhamDVO_SoLuongTonKhoMax.Text = "";
				DMSanPhamDVO_ThoiGianBaoHanhMin.Text = listViewItem.SubItems[6].Text;
				DMSanPhamDVO_ThoiGianBaoHanhMax.Text = "";
			}
		}

		private void TabPageSanPham_materialListView_Load(object sender, EventArgs e)
		{
			System.Data.DataTable sanPham = DMSanPhamDAO.Instance.GetAllSanPham();
			LoadSanPham(sanPham);
		}

		private void TabPageSanPham_ButtonSuaSanPham_Click(object sender, EventArgs e)
		{
			if (this.ShowMessageBoxYesNo("Bạn có chắc chắn muốn thay đổi không?"))
			{
				if (TabPageSanPham_MaterialListView.SelectedIndices.Count <= 0)
				{
					this.ShowMessageBox("Hãy chọn sản phẩm muốn thay đổi");

					return;
				}
				int selectedIndex = TabPageSanPham_MaterialListView.SelectedIndices[0];
				ListViewItem listViewItem = this.TabPageSanPham_MaterialListView.Items[selectedIndex];
				string MSP;
				Guid MDMSP;
				MSP = listViewItem.SubItems[1].Text;
				MDMSP = DMSanPhamDAO.Instance.GetMaDMSanPhamFromMaSanPham(MSP);
				FormCreateSanPhamDVO formCreateSanPhamDVO = new FormCreateSanPhamDVO();
				formCreateSanPhamDVO.FormCreateSanPhamDVO_MaSanPham = MSP;
				foreach (object obj in listViewItem.SubItems)
				{
					Debug.WriteLine(obj.ToString());
				}
				formCreateSanPhamDVO.FormCreateSanPhamDVO_TenSanPham = listViewItem.SubItems[2].Text;
				formCreateSanPhamDVO.FormCreateSanPhamDVO_DonGiaBan = long.Parse(listViewItem.SubItems[3].Text);
				formCreateSanPhamDVO.FormCreateSanPhamDVO_DonGiaNhap = long.Parse(listViewItem.SubItems[4].Text);
				formCreateSanPhamDVO.FormCreateSanPhamDVO_SoLuongTonKho = int.Parse(listViewItem.SubItems[5].Text);
				formCreateSanPhamDVO.FormCreateSanPhamDVO_ThoiGianBaoHanh = DateTime.Parse(listViewItem.SubItems[6].Text);
				FormCreateSanPham formCreateSanPham = new FormCreateSanPham(formCreateSanPhamDVO, MDMSP, true);
				formCreateSanPham.Show();
				System.Data.DataTable sanPham = DMSanPhamDAO.Instance.GetAllSanPham();
				LoadSanPham(sanPham);
			}
		}

		private void TabPageSanPham_ButtonThemSanPham_Click(object sender, EventArgs e)
		{
			if (this.ShowMessageBoxYesNo("Bạn có muốn thêm sản phẩm mới không?"))
			{
				FormCreateSanPham formCreateSanPham = new FormCreateSanPham();
				formCreateSanPham.Show();
			}
		}
		private void LoadSanPham(System.Data.DataTable sanPham)
		{
			TabPageSanPham_MaterialListView.Items.Clear();
			ListViewItem items;

			int Count = 0;

			foreach (DataRow row in sanPham.Rows)
			{
				items = new ListViewItem();

				Count++;

				items.SubItems[0].Text = Count.ToString();

				for (int i = 0; i < sanPham.Columns.Count; i++)
				{
					items.SubItems.Add(row[i].ToString().Trim());
				}
				this.TabPageSanPham_MaterialListView.Items.Add(items);
			}
		}

		private void DateTimePickerLimit()
		{
			this.DMSanPhamDVO_ThoiGianBaoHanhMin.ValueChanged += (object obj, EventArgs e) =>
			{
				if (this.DMSanPhamDVO_ThoiGianBaoHanhMin.Value > this.DMSanPhamDVO_ThoiGianBaoHanhMax.Value)
				{
					this.ShowMessageBox("Thời gian bảo hành mà bạn vừa chọn chưa thỏa mãn");
					this.DMSanPhamDVO_ThoiGianBaoHanhMax.Value = DMSanPhamDAO.Instance.GetThoiGianBaoHanhMax();
					this.DMSanPhamDVO_ThoiGianBaoHanhMin.Value = DMSanPhamDAO.Instance.GetThoiGianBaoHanhMin();
				}
			};

			this.DMSanPhamDVO_ThoiGianBaoHanhMax.ValueChanged += (object obj, EventArgs e) =>
			{
				if (this.DMSanPhamDVO_ThoiGianBaoHanhMax.Value < this.DMSanPhamDVO_ThoiGianBaoHanhMax.Value)
				{
					this.ShowMessageBox("Thời gian bảo hành mà bạn vừa chọn chưa thỏa mãn");
					this.DMSanPhamDVO_ThoiGianBaoHanhMax.Value = DMSanPhamDAO.Instance.GetThoiGianBaoHanhMax();
					this.DMSanPhamDVO_ThoiGianBaoHanhMin.Value = DMSanPhamDAO.Instance.GetThoiGianBaoHanhMin();
				}
			};

		}

		#endregion

		#region Generalist Function

		delegate List<string> DAOUpdateDelegate();

		//		Cài đặt Update tự động
		private void UpdateDataSource(ComboBox comboBox, DAOUpdateDelegate dAOUpdateDelegate)
		{
			comboBox.DataSource = dAOUpdateDelegate();

			comboBox.SelectedIndex = -1;
		}

		//		Hiện MessageBox với các lựa chọn Yes No cho TabPage
		private bool ShowMessageBoxYesNo(string message, int tabPageIndex = -1)
		{
			if (tabPageIndex == -1)
			{
				tabPageIndex = this.GetTabPageControlSelectedIndex();
			}

			bool ifYes = MaterialMessageBox.Show(
							text: message,
							caption: this.Text,
							buttons: MessageBoxButtons.YesNo,
							icon: MessageBoxIcon.Question,
							UseRichTextBox: false,
							buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
							)
						== DialogResult.Yes;

			this.ResetColorForLabel(tabPageIndex);

			return ifYes;
		}

		//		Hiện MessageBox cho TabPage
		private void ShowMessageBox(string message, string title = "", int tabPageIndex = -1)
		{
			if (tabPageIndex == -1)
			{
				tabPageIndex = this.GetTabPageControlSelectedIndex();
			}

			if (title == "")
			{
				title = this.materialTabControl.SelectedTab.Text;
			}

			MaterialMessageBox.Show(
					text: message,
					caption: title,
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);

			//		Workaround a bug
			this.ResetColorForLabel(tabPageIndex);
		}

		//		Sửa lại màu cho Label của TabPage
		private void ResetColorForLabel(int tabPageIndex = -1, bool ifAllTabPage = false)
		{
			if (ifAllTabPage)
			{
				foreach (List<Label> list in this.listOfLabelsDVO) {
					foreach (Label label in list)
					{
						label.ForeColor = Color.Red;
					}
				}
			}
			if (tabPageIndex == -1)
			{
				tabPageIndex = this.GetTabPageControlSelectedIndex();
			}

			//		Workaround a bug
			for (int i = 0; i < this.listOfLabelsDVO[tabPageIndex].Count; i++)
			{
				this.listOfLabelsDVO[tabPageIndex][i].ForeColor = Color.Red;
			}
		}

		//		Thử Validate nội dung từ Control, onlyOneControl để check xem có Validate MỖI nội dung đấy
		//		hay không, và đầu ra là baseDVO (= null nếu validate lỗi)
		private bool TryValidationFromControl(Control control, bool onlyOneControl, out dynamic baseDVO)
		{
			//		Reset Validation
			this.ResetValidationForControl(control, onlyOneControl: onlyOneControl);
			this.SetInterractedForControl(control, onlyOneControl: onlyOneControl, true);

			//		New Object
			baseDVO = this.GetInputFromControl(control);

			List<ValidationResult> results = new List<ValidationResult>();

			//		Try Validating
			if (!Validator.TryValidateObject(baseDVO, new ValidationContext(baseDVO), results, true)) {
				if (onlyOneControl)
				{
					int selectedIndex = this.GetTabPageControlSelectedIndex();

					foreach (ValidationResult result in results)
					{
						if (result.MemberNames.Contains(control.Name))
						{
							this.SetStringLabelForControl(control, selectedIndex, result.ErrorMessage);

							return false;
						}
					}

					return true;
				}
				else
				{
					int selectedIndex = this.GetTabPageControlSelectedIndex();

					foreach (ValidationResult result in results)
					{
						foreach (Control controlToValidate in this.listOfControlsDVO[selectedIndex])
						{
							if (result.MemberNames.Contains(controlToValidate.Name) &&
								this.CheckIfControlInterracted(controlToValidate))
							{
								this.SetStringLabelForControl(controlToValidate, selectedIndex, result.ErrorMessage);
							}
						}
					}
				}

				return false;
			}

			return true;
		}

		//		Thử xem TextBox đã được chạm vào chưa
		private bool CheckIfControlInterracted(Control control)
		{
			int selectedIndex = this.GetTabPageControlSelectedIndex();

			return this.isInterracted
					[selectedIndex]
					[this.listOfControlsDVO[selectedIndex].IndexOf(control)];
		}

		//		Thử xem TextBox đã có nội dung nhập chưa hay chỉ có Placeholder hoặc trống rỗng
		private bool CheckIfControlEmptyOrPlaceholder(Control control)
		{
			return this.CheckControlTextEqualToString(control: control, text: "") ||
					this.CheckControlTextEqualToString(control: control, text: this.GetPlaceholderForControl(control));
		}

		//		Thử xem nội dung của Control có bằng String không
		private bool CheckControlTextEqualToString(Control control, string text)
		{
			return control.Text.Trim().Equals(text);
		}

		//		Lấy nội dung của Control (nếu = PlaceHolder thì trả lại rỗng)
		private string GetControlTextIfPlaceholderThenEmpty(Control control)
		{
			return control.Text == this.GetPlaceholderForControl(control) ? "" : control.Text;
		}

		//		Lấy nội dung của Control (nếu = rỗng thì trả lại PlaceHolder)
		private string GetControlTextIfEmptyThenPlaceholder(Control control)
		{
			return control.Text == "" ? this.GetPlaceholderForControl(control) : control.Text;
		}

		//		Lấy PlaceHolder cho Control
		private string GetPlaceholderForControl(Control control)
		{
			//		Get Type + Attribute Name
			//			NOTE: The name of the Textbox == Attribute Name
			Type propertyType = this.GetBaseDVOFromControl(control);
			string propertyName = control.Name;

			//Debug.WriteLine(control.Name);

			//		Get DisplayName
			PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(propertyType)[propertyName];
			DisplayNameAttribute displayNameAttribute = (DisplayNameAttribute)propertyDescriptor.Attributes[typeof(DisplayNameAttribute)];

			return displayNameAttribute.DisplayName;
		}

		//		Đặt String cho Label tương ứng với Control được gửi
		private void SetStringLabelForControl(Control control, int selectedIndex, string text)
		{
			string controlName = control.Name;

			foreach (Label label in this.listOfLabelsDVO[selectedIndex])
			{
				if (label.Name.Contains(controlName))
				{
					label.Text = text;

					return;
				}
			}

			Debug.WriteLine("\n\nFailed to set String Label for Control");
		}

		//		Reset lại tất cả Input cho TabPage
		private void ResetInputForTabPage(int tabPageIndex = -1)
		{
			if (tabPageIndex == -1)
			{
				tabPageIndex = this.GetTabPageControlSelectedIndex();
			}

			foreach (Control controlTemp in this.listOfControlsDVO[tabPageIndex])
			{
				if (controlTemp is DateTimePicker dateTimePicker)
				{
					dateTimePicker.Value = this.defaultDateTime;

					return;
				}
				else if (controlTemp is ComboBox comboBox)
				{
					comboBox.SelectedIndex = -1;
				}

				controlTemp.Text = this.GetPlaceholderForControl(controlTemp);
			}

			if (tabPageIndex == 1)
			{
				this.TabPageHoaDonBan_MaterialListView.Items.Clear();
			}
			else if (tabPageIndex == 2)
			{
				this.TabPageHoaDonNhap_MaterialListView.Items.Clear();
			}
		}

		//		Reset lại tất cả Input tương ứng với DVO của 1 Control
		private void ResetInputForControl(Control control, bool onlyOneControl)
		{
			int tabPageIndex = this.GetTabPageControlSelectedIndex();

			if (onlyOneControl)
			{
				foreach (Control controlTemp in this.listOfControlsDVO[tabPageIndex])
				{
					if (controlTemp != this.ActiveControl && controlTemp == control)
					{
						controlTemp.Text = this.GetPlaceholderForControl(controlTemp);

						return;
					}
					else if (controlTemp == this.ActiveControl)
					{
						controlTemp.Text = "";

						return;
					}
				}

				return;
			}

			string getClassName = control.Name.Split('_')[0];

			foreach (Control controlTemp in this.listOfControlsDVO[tabPageIndex])
			{
				if (controlTemp != this.ActiveControl && controlTemp.Name.Contains(getClassName))
				{
					controlTemp.Text = this.GetPlaceholderForControl(controlTemp);
				}
				else if (controlTemp == this.ActiveControl)
				{
					controlTemp.Text = "";
				}
			}
		}

		//		Reset lại Validation cho cả 1 TabPage
		private void ResetValidationForTabPage(int tabPageIndex = -1)
		{
			if (tabPageIndex == -1)
			{
				tabPageIndex = this.GetTabPageControlSelectedIndex();
			}

			for (int i = 0; i < this.listOfLabelsDVO[tabPageIndex].Count; i++)
			{
				this.listOfLabelsDVO[tabPageIndex][i].Text = "";
			}

			this.SetInterractedForTabPage(tabPageIndex, false);
		}

		//		Reset lại Validation cho 1 hoặc tất cả Input tương ứng với DVO của 1 Control
		private void ResetValidationForControl(Control control, bool onlyOneControl)
		{
			int tabPageIndex = this.GetTabPageControlSelectedIndex();
			string getClassName;

			if (onlyOneControl)
			{
				getClassName = control.Name;

				for (int i = 0; i < this.listOfLabelsDVO[tabPageIndex].Count; i++)
				{
					if (this.listOfLabelsDVO[tabPageIndex][i].Name.Contains(getClassName))
					{
						this.listOfLabelsDVO[tabPageIndex][i].Text = "";

						return;
					}
				}
			}
			else
			{
				getClassName = control.Name.Split('_')[0];

				for (int i = 0; i < this.listOfLabelsDVO[tabPageIndex].Count; i++)
				{
					if (this.listOfLabelsDVO[tabPageIndex][i].Name.Contains(getClassName))
					{
						this.listOfLabelsDVO[tabPageIndex][i].Text = "";
					}
				}
			}

			this.SetInterractedForControl(control, onlyOneControl: onlyOneControl, false);
		}

		//		Cài đặt TabPage xem các phần tử đã được chạm chưa
		private void SetInterractedForTabPage(int tabPageIndex, bool value)
		{
			for (int i = 0; i < this.isInterracted[tabPageIndex].Count; i++)
			{
				this.isInterracted[tabPageIndex][i] = value;
			}
		}

		//		Cài đặt Control và DVO tương đương nó xem các phần tử đã được chạm chưa
		private void SetInterractedForControl(Control control, bool onlyOneControl, bool value)
		{
			string getClassName;
			int tabPageIndex = this.GetTabPageControlSelectedIndex();

			if (onlyOneControl)
			{
				getClassName = control.Name;

				for (int i = 0; i < this.listOfLabelsDVO[tabPageIndex].Count; i++)
				{
					if (this.listOfLabelsDVO[tabPageIndex][i].Name.Contains(getClassName))
					{
						this.isInterracted[tabPageIndex][i] = value;

						return;
					}
				}
			}
			else
			{
				getClassName = control.Name.Split('_')[0];

				for (int i = 0; i < this.listOfLabelsDVO[tabPageIndex].Count; i++)
				{
					if (this.listOfLabelsDVO[tabPageIndex][i].Name.Contains(getClassName))
					{
						this.isInterracted[tabPageIndex][i] = value;
					}
				}
			}
		}

		//		Lấy DVO đã nhập từ Control và các Control liên quan tới nó
		private dynamic GetInputFromControl(Control control)
		{
			Type type = this.GetBaseDVOFromControl(control);

			if (type != null)
			{
				object obj = Activator.CreateInstance(type);

				switch (obj)
				{
					case NhanVienThuNganHDBanDVO nhanVienThuNganHDBanDVO:
						nhanVienThuNganHDBanDVO.NhanVienThuNganHDBanDVO_NhanVien = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienThuNganHDBanDVO_NhanVien);

						return nhanVienThuNganHDBanDVO;

					case NhanVienThuNganHDNhapDVO nhanVienThuNganHDNhapDVO:
						nhanVienThuNganHDNhapDVO.NhanVienThuNganHDNhapDVO_NhanVien = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienThuNganHDNhapDVO_NhanVien);

						return nhanVienThuNganHDNhapDVO;

					case HoaDonBanDVO hoaDonBanDVO:
						if (!long.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonBanDVO_TongTien), out long tempTongTien_hoaDonBanDVO))
						{
							tempTongTien_hoaDonBanDVO = 0;
						}

						if (!long.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonBanDVO_ThanhToan), out long tempThanhToan_hoaDonBanDVO))
						{
							tempThanhToan_hoaDonBanDVO = 0;
						}

						hoaDonBanDVO.HoaDonBanDVO_DienThoaiKhachHang = this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonBanDVO_DienThoaiKhachHang);
						hoaDonBanDVO.HoaDonBanDVO_TenGiamGia = this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonBanDVO_TenGiamGia);
						hoaDonBanDVO.HoaDonBanDVO_TenKhachHang = this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonBanDVO_TenKhachHang);
						hoaDonBanDVO.HoaDonBanDVO_TongTien = tempTongTien_hoaDonBanDVO;
						hoaDonBanDVO.HoaDonBanDVO_ThanhToan = tempThanhToan_hoaDonBanDVO;

						return hoaDonBanDVO;

					case HoaDonNhapDVO hoaDonNhapDVO:
						if (!long.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonNhapDVO_TongTien), out long tempTongTien_hoaDonNhapDVO))
						{
							tempTongTien_hoaDonNhapDVO = 0;
						}

						hoaDonNhapDVO.HoaDonNhapDVO_DienThoaiNhaCungCap = this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonNhapDVO_DienThoaiNhaCungCap);
						hoaDonNhapDVO.HoaDonNhapDVO_TenNhaCungCap = this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonNhapDVO_TenNhaCungCap);
						hoaDonNhapDVO.HoaDonNhapDVO_TongTien = tempTongTien_hoaDonNhapDVO;

						return hoaDonNhapDVO;

					case ChiTietHDBanDVO chiTietHDBanDVO:
						if (!int.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.ChiTietHDBanDVO_SoLuong), out int tempSoLuong_chiTietHDBanDVO))
						{
							tempSoLuong_chiTietHDBanDVO = 0;
						}

						chiTietHDBanDVO.ChiTietHDBanDVO_MaSanPham = this.GetControlTextIfPlaceholderThenEmpty(this.ChiTietHDBanDVO_MaSanPham);
						chiTietHDBanDVO.ChiTietHDBanDVO_TenSanPham = this.GetControlTextIfPlaceholderThenEmpty(this.ChiTietHDBanDVO_TenSanPham);
						chiTietHDBanDVO.ChiTietHDBanDVO_SoLuong = tempSoLuong_chiTietHDBanDVO;

						return chiTietHDBanDVO;

					case ChiTietHDNhapDVO chiTietHDNhapDVO:
						if (!int.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.ChiTietHDNhapDVO_SoLuong), out int tempSoLuong_chiTietHDNhapDVO))
						{
							tempSoLuong_chiTietHDNhapDVO = 0;
						}

						chiTietHDNhapDVO.ChiTietHDNhapDVO_MaSanPham = this.GetControlTextIfPlaceholderThenEmpty(this.ChiTietHDNhapDVO_MaSanPham);
						chiTietHDNhapDVO.ChiTietHDNhapDVO_TenSanPham = this.GetControlTextIfPlaceholderThenEmpty(this.ChiTietHDNhapDVO_TenSanPham);
						chiTietHDNhapDVO.ChiTietHDNhapDVO_SoLuong = tempSoLuong_chiTietHDNhapDVO;

						return chiTietHDNhapDVO;

					case NhanVienDVO nhanVienDVO:
						nhanVienDVO.NhanVienDVO_TenNhanVien = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_TenNhanVien);
						nhanVienDVO.NhanVienDVO_NgaySinh = this.NhanVienDVO_NgaySinh.Value;
						nhanVienDVO.NhanVienDVO_GioiTinh = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_GioiTinh);
						nhanVienDVO.NhanVienDVO_SoDienThoai = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_SoDienThoai);
						nhanVienDVO.NhanVienDVO_DiaChi = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_DiaChi);
						nhanVienDVO.NhanVienDVO_TenCongViec = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_TenCongViec);
						nhanVienDVO.NhanVienDVO_Email = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_Email);
						nhanVienDVO.NhanVienDVO_MatKhau = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_MatKhau);
						nhanVienDVO.NhanVienDVO_NhapLaiMatKhau = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_NhapLaiMatKhau);

						return nhanVienDVO;

					case KhachHangDVO khachHangDVO:
						khachHangDVO.KhachHangDVO_TenKhachHang= this.GetControlTextIfPlaceholderThenEmpty(this.KhachHangDVO_TenKhachHang);
						khachHangDVO.KhachHangDVO_DiaChi = this.GetControlTextIfPlaceholderThenEmpty(this.KhachHangDVO_DiaChi);
						khachHangDVO.KhachHangDVO_DienThoai= this.GetControlTextIfPlaceholderThenEmpty(this.KhachHangDVO_DienThoai);

						return khachHangDVO;
						
					case NhaCungCapDVO nhaCungCapDVO:
						nhaCungCapDVO.NhaCungCapDVO_TenNhaCungCap = this.GetControlTextIfPlaceholderThenEmpty(this.NhaCungCapDVO_TenNhaCungCap);
						nhaCungCapDVO.NhaCungCapDVO_DiaChi = this.GetControlTextIfPlaceholderThenEmpty(this.NhaCungCapDVO_DiaChi);
						nhaCungCapDVO.NhaCungCapDVO_DienThoai = this.GetControlTextIfPlaceholderThenEmpty(this.NhaCungCapDVO_DienThoai);

						return nhaCungCapDVO;

					case DMSanPhamDVO dMSanPhamDVO:
						if (!int.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.DMSanPhamDVO_DonGiaBanMin), out int tempDonGianBanMin))
						{
							tempDonGianBanMin = 0;
						}
						if (!int.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.DMSanPhamDVO_DonGiaBanMax), out int tempDonGianBanMax))
						{
							tempDonGianBanMax = 0;
						}
						if (!int.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.DMSanPhamDVO_DonGiaNhapMin), out int tempDonGianNhapMin))
						{
							tempDonGianNhapMin = 0;
						}
						if (!int.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.DMSanPhamDVO_DonGiaNhapMax), out int tempDonGianNhapMax))
						{
							tempDonGianNhapMax = 0;
						}
						if (!int.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.DMSanPhamDVO_SoLuongTonKhoMin), out int tempSoLuongTonKhoMin))
						{
							tempSoLuongTonKhoMin = 0;
						}
						if (!int.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.DMSanPhamDVO_SoLuongTonKhoMax), out int tempSoLuongTonKhoMax))
						{
							tempSoLuongTonKhoMax = 0;
						}

						dMSanPhamDVO.DMSanPhamDVO_MaSanPham = this.GetControlTextIfPlaceholderThenEmpty(this.DMSanPhamDVO_MaSanPham);
						dMSanPhamDVO.DMSanPhamDVO_TenSanPham = this.GetControlTextIfPlaceholderThenEmpty(this.DMSanPhamDVO_TenSanPham);
						dMSanPhamDVO.DMSanPhamDVO_DonGiaBanMin = tempDonGianBanMin;
						dMSanPhamDVO.DMSanPhamDVO_DonGiaBanMax = tempDonGianBanMax;
						dMSanPhamDVO.DMSanPhamDVO_DonGiaNhapMin = tempDonGianNhapMin;
						dMSanPhamDVO.DMSanPhamDVO_DonGiaNhapMax = tempDonGianNhapMax;
						dMSanPhamDVO.DMSanPhamDVO_SoLuongTonKhoMin = tempSoLuongTonKhoMin;
						dMSanPhamDVO.DMSanPhamDVO_SoLuongTonKhoMax = tempSoLuongTonKhoMax;
						dMSanPhamDVO.DMSanPhamDVO_ThoiGianBaoHanhMin = this.DMSanPhamDVO_ThoiGianBaoHanhMin.Value;
						dMSanPhamDVO.DMSanPhamDVO_ThoiGianBaoHanhMax = this.DMSanPhamDVO_ThoiGianBaoHanhMax.Value;

						return dMSanPhamDVO;
				}

				return obj;
			}
			else
			{
				Debug.WriteLine("GetInputFromControl failed");

				return null;
			}
		}

		//		Lấy kiểu DVO từ Control
		private Type GetBaseDVOFromControl(Control control)
		{
			string getClassName = "WinformWithExternalLibrary.DataValidateObjects." + control.Name.Split('_')[0];

			Type type = Type.GetType(getClassName);

			if (type != null)
			{
				//Debug.WriteLine(type);

				return type;
			}
			else
			{
				Debug.WriteLine("GetBaseDVOFromControl failed: " + getClassName);

				return null;
			}
		}

		//		Lấy Index của TabPage đang được chọn
		private int GetTabPageControlSelectedIndex()
		{
			//Debug.WriteLine(materialTabControl.SelectedIndex);

			return this.materialTabControl.SelectedIndex;
		}

		//		Thử xem TabPage còn thông tin nhập dở không
		private bool CheckIfDirtyData(int tabPageIndex)
		{
			foreach (Control control in this.listOfControlsDVO[tabPageIndex])
			{
				//		Check DirtyData for DateTimePicker is different
				if (control is DateTimePicker dateTimePicker)
				{
					if (dateTimePicker.Value != this.defaultDateTime)
					{
						//Debug.WriteLine(control.Name);

						return true;
					}
				}
				//		Check DirtyData for DateTimePicker is different
				else if (control is RJDatePicker rjDatePicker)
				{
					if (rjDatePicker.Value != this.defaultDateTime)
					{
						//Debug.WriteLine(control.Name);

						return true;
					}
				}
				//		If not DateTimePicker:
				else if (!this.CheckIfControlEmptyOrPlaceholder(control))
				{
					//Debug.WriteLine(control.Name);

					return true;
				}
			}

			return false;
		}



		public bool IsAutoValidate()
		{
			return this.IfAutoValidate;
		}

		#endregion
	}
}