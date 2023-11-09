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
using System.Diagnostics;
using WinformWithExternalLibrary.DataValidateObject;
using System.Windows.Controls.Primitives;
using static WinformWithExternalLibrary.DataTransferObjects.CustomDTO.PhanTichDTO;
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
		public static FormMain Instance { get; set; }

		private readonly List<List<Control>> listOfControlsDVO = new List<List<Control>>();
		private readonly List<List<Label>> listOfLabelsDVO = new List<List<Label>>();
		private readonly List<List<bool>> isInterracted = new List<List<bool>>();

		private readonly FormatValues formatValues = new FormatValues();

		private int lastTabPageIndex = 0;
		private readonly DateTime dateTimeDefault = new DateTime
			(
				day: DateTime.Now.Day,
				month: DateTime.Now.Month,
				year: DateTime.Now.Year
			);

		public FormMain()
		{
			//		TODO: Make Insert GiamGia
			//		TODO: set up Event system for DAOs to update DataSource

			//		NOTE: THIS ALWAYS GO FIRST
			this.InitializeComponent();

			//		Attributes
			this.InitializeHardCodedAttributes();

			//		Events
			this.InitializeAutomaticEventAndList();
			this.InitializeSpecializedEvent();
			this.InitializeAutoDataSourceUpdate();

			//		Specific
			this.Initialize_NgoSachMinhHieu();
			this.Initialize_TranHongThai();
			this.Initialize_NguyenHongSon();
			this.Initialize_BuiThiThanhTruc();
			this.Initialize_VuHongHanh();
		}

		#region Initialize

		//		Initializing
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
				if (tabPage != this.TabPageHoaDonBan &&
					tabPage != this.TabPageNhanVien &&
					tabPage != this.TabPageKhachHang &&
					tabPage != this.TabPageNhaCungCap &&
					tabPage != this.TabPageHoaDonNhap)
				{
					continue;
				}

				foreach (Control control in tabPage.Controls)
				{
					//Debug.WriteLine(control.Name);

					//		Label
					if (control is Label tempLabel && control.Name.Contains("Validation"))
					{
						//		Reset
						tempLabel.Text = "";

						//		For Validation
						tempLabel.ForeColor = Color.Red;
						tempLabel.Cursor = Cursors.Default;
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
					//		DateTimePicker
					else if (control is DateTimePicker tempDateTimePicker)
					{
						//		Current Day = Now
						tempDateTimePicker.Value = this.dateTimeDefault;

						//		Max Range = Now
						tempDateTimePicker.MaxDate = this.dateTimeDefault;
					}
					//		MaterialListView
					else if (control is MaterialListView tempMaterialListView)
					{
						//		Selectable
						tempMaterialListView.FullRowSelect = true;
						tempMaterialListView.MultiSelect = true;

						//		Design
						tempMaterialListView.GridLines = true;
						tempMaterialListView.BorderStyle = BorderStyle.FixedSingle;

						//		Extra
						tempMaterialListView.Scrollable = true;
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

				//		TEST: only for HoaDonBan
				if (this.materialTabControl.TabPages[i] != this.TabPageHoaDonBan &&
					this.materialTabControl.TabPages[i] != this.TabPageNhanVien &&
					this.materialTabControl.TabPages[i] != this.TabPageKhachHang &&
					this.materialTabControl.TabPages[i] != this.TabPageNhaCungCap &&
					this.materialTabControl.TabPages[i] != this.TabPageHoaDonNhap)
				{
					continue;
				}

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
			ChiTietHDBanDAO.Instance.OnDAONewInsert += (obj, e) =>
			{

			};
			ChiTietHDNhapDAO.Instance.OnDAONewInsert += (obj, e) =>
			{

			};
			CongViecDAO.Instance.OnDAONewInsert += (obj, e) =>
			{

			};
			DMSanPhamDAO.Instance.OnDAONewInsert += (obj, e) =>
			{
				this.UpdateDataSource(ChiTietHDBanDVO_MaSanPham, DMSanPhamDAO.Instance.GetMaSanPhamList);
				this.UpdateDataSource(ChiTietHDNhapDVO_MaSanPham, DMSanPhamDAO.Instance.GetMaSanPhamList);
			};
			GiamGiaDAO.Instance.OnDAONewInsert += (obj, e) =>
			{

			};
			HoaDonBanDAO.Instance.OnDAONewInsert += (obj, e) =>
			{

			};
			HoaDonNhapDAO.Instance.OnDAONewInsert += (obj, e) =>
			{

			};
			KhachHangDAO.Instance.OnDAONewInsert += (obj, e) =>
			{
				this.UpdateDataSource(HoaDonBanDVO_DienThoaiKhachHang, KhachHangDAO.Instance.GetPhoneNumberList);
			};
			NhaCungCapDAO.Instance.OnDAONewInsert += (obj, e) =>
			{
				this.UpdateDataSource(this.HoaDonNhapDVO_DienThoaiNhaCungCap, NhaCungCapDAO.Instance.GetPhoneNumbers);
			};
			NhanVienDAO.Instance.OnDAONewInsert += (obj, e) =>
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

			this.TryValidationFromControl(
						control: control,
						onlyOneControl: true,
						out _);
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
					this.ShowMessageBox(message: "Xin vui lòng chọn sản phẩm cần xóa", this.GetTabPageControlSelectedIndex());

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
				if (this.ShowMessageBoxYesNo(message: "Bạn có muốn nhập mới sản phẩm không?", this.GetTabPageControlSelectedIndex()))
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
			//				TODO: finish
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.Click += (obj, e) =>
			{
				if (this.TryValidationFromControl(this.HoaDonNhapDVO_TongTien, onlyOneControl: false, out dynamic baseHoaDonNhap) &&
					this.TryValidationFromControl(this.NhanVienThuNganHDNhapDVO_NhanVien, onlyOneControl: false, out dynamic baseNhanVienThuNgan))
				{
					//		Validated!

					//		...Nothing?
					if (this.TabPageHoaDonNhap_MaterialListView.Items.Count <= 0)
					{
						this.ShowMessageBox(message: "Chưa có sản phẩm trong đơn hàng", this.GetTabPageControlSelectedIndex());

						return;
					}

					//		Casting
					NhanVienThuNganHDNhapDVO nhanVienThuNganDVO = baseNhanVienThuNgan as NhanVienThuNganHDNhapDVO;
					HoaDonNhapDVO hoaDonNhapDVO = baseHoaDonNhap as HoaDonNhapDVO;

					//		Show another Confirmation Form
					//			TODO:
					//FormConfirmHoaDonBan formConfirmHoaDonBan = new FormConfirmHoaDonBan(hoaDonNhapDVO, nhanVienThuNganDVO);
					//formConfirmHoaDonBan.FormClosing += (_obj, _e) =>
					//{
					//	this.ResetColorForLabel(this.GetTabPageControlSelectedIndex());
					//};

					//formConfirmHoaDonBan.Show();
					//formConfirmHoaDonBan.Activate();
				}
			};

			//			TabPageHoaDonNhap_ButtonNhapMoiHoaDon
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.Click += (obj, e) =>
			{
				if (this.ShowMessageBoxYesNo(message: "Bạn có chắc muốn nhập mới hóa đơn không?", this.GetTabPageControlSelectedIndex()))
				{
					this.ResetHoaDonNhapAndChiTietHDNhap();

					return;
				}
			};
		}

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
					this.ShowMessageBox(message: "Xin vui lòng chọn sản phẩm cần xóa", this.GetTabPageControlSelectedIndex());

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
				if (this.ShowMessageBoxYesNo(message: "Bạn có muốn nhập mới sản phẩm không?", this.GetTabPageControlSelectedIndex()))
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
						this.ShowMessageBox(message: "Chưa có sản phẩm trong đơn hàng", this.GetTabPageControlSelectedIndex());

						return;
					}

					//		Casting
					NhanVienThuNganHDBanDVO nhanVienThuNganDVO = baseNhanVienThuNgan as NhanVienThuNganHDBanDVO;
					HoaDonBanDVO hoaDonBanDVO = baseHoaDonBan as HoaDonBanDVO;

					//		Show another Confirmation Form
					FormConfirmHoaDonBan formConfirmHoaDonBan = new FormConfirmHoaDonBan(hoaDonBanDVO, nhanVienThuNganDVO);
					formConfirmHoaDonBan.FormClosing += (_obj, _e) =>
					{
						this.ResetColorForLabel(this.GetTabPageControlSelectedIndex());
					};

					formConfirmHoaDonBan.Show();
					formConfirmHoaDonBan.Activate();
				}
			};

			//			TabPageHoaDonBan_ButtonTaoMoiHoaDon
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.Click += (obj, e) =>
			{
				if (this.ShowMessageBoxYesNo(message: "Bạn có chắc muốn nhập mới hóa đơn không?", this.GetTabPageControlSelectedIndex()))
				{
					this.ResetHoaDonBanAndChiTietHDBan();

					return;
				}
			};
		}

		//		Function

		private void UpdateTongTienHDNhap(long tien, bool biTru)
		{
			long tongTienCurr = this.CheckIfControlEmptyOrPlaceholder(this.HoaDonNhapDVO_TongTien) ? 0 : long.Parse(this.HoaDonNhapDVO_TongTien.Text);
			long tongTienNew = biTru ? tongTienCurr - tien : tongTienCurr + tien;

			if (tongTienNew == 0)
			{
				this.ResetInputForControl(this.HoaDonNhapDVO_TongTien, true);
				this.ResetInputForControl(this.HoaDonNhapDVO_ThanhToan, true);

				return;
			}

			this.HoaDonNhapDVO_TongTien.Text = tongTienNew.ToString();
			this.HoaDonNhapDVO_ThanhToan.Text = tongTienNew.ToString();
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

		public void NhapHoaDonBan(HoaDonBanDVO hoaDonBanDVO, NhanVienThuNganHDBanDVO nhanVienThuNganDVO, TongTienKhachTraDVO tongTienKhachTraDVO)
		{
			HoaDonBanDTO hoaDonBanDTO = new HoaDonBanDTO(
				hoaDonBanDTO_MaHDBan: Guid.NewGuid(),
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
				MaterialMessageBox.Show(
					text: "Có lỗi gì đó vừa xảy ra",
					caption: "!HoaDonBanDAO",
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
				);

				return;
			}

			foreach (ListViewItem listViewItem in this.TabPageHoaDonBan_MaterialListView.Items)
			{
				//		Get MaDMSanPham
				Guid maDMSanPhamTemp = DMSanPhamDAO.Instance.GetMaDMSanPhamFromMaSanPham(listViewItem.SubItems[1].Text);

				if (maDMSanPhamTemp == Guid.Empty)
				{
					MaterialMessageBox.Show(
					text: "Có lỗi gì đó vừa xảy ra",
					caption: "maDMSanPhamTemp == Guid.Empty",
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);

					return;
				}

				ChiTietHDBanDTO chiTietHDBanDTO = new ChiTietHDBanDTO(
					chiTietHDBanDTO_MaHDBan: hoaDonBanDTO.HoaDonBanDTO_MaHDBan,
					chiTietHDBanDTO_MaDMSanPham: maDMSanPhamTemp,
					chiTietHDBanDTO_SoLuong: int.Parse(listViewItem.SubItems[3].Text),
					chiTietHDBanDTO_ThanhTien: long.Parse(listViewItem.SubItems[5].Text)
					);

				if (!ChiTietHDBanDAO.Instance.InsertChiTietHDBan(chiTietHDBanDTO))
				{
					MaterialMessageBox.Show(
					text: "Có lỗi gì đó vừa xảy ra",
					caption: "!ChiTietHDBanDAO",
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);

					return;
				}

				if (!DMSanPhamDAO.Instance.UpdateTruSoLuongTon(listViewItem.SubItems[1].Text, int.Parse(listViewItem.SubItems[3].Text)))
				{
					this.ShowMessageBox(message: "Trừ số lượng tồn bị lỗi", this.GetTabPageControlSelectedIndex());
				}
			}

			//		Reset Input
			this.ResetHoaDonBanAndChiTietHDBan();
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

			this.ResetColorForLabel(this.GetTabPageControlSelectedIndex());
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

		}

		#endregion

		#region Bùi Thị Thanh Trúc

		private void Initialize_BuiThiThanhTruc()
		{
			this.NhanVienDVO_TenCongViec.DataSource = CongViecDAO.Instance.GetTenCongViec();

			this.NhanVienDVO_TenCongViec.SelectedIndex = -1;

			this.NhanVienDVO_TenCongViec.Text = this.GetPlaceholderForControl(this.NhanVienDVO_TenCongViec);
		}

		#endregion

		#region Vũ Hồng Hạnh

		private void Initialize_VuHongHanh()
		{
			//Debug.WriteLine(DMSanPhamDAO.Instance.UpdateCongSoLuongTon("469075421580", 2));
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
		private bool ShowMessageBoxYesNo(string message, int tabPageIndex)
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

			this.ResetColorForLabel(tabPageIndex);

			return ifYes;
		}

		//		Hiện MessageBox cho TabPage
		private void ShowMessageBox(string message, int tabPageIndex)
		{
			MaterialMessageBox.Show(
					text: message,
					caption: this.materialTabControl.SelectedTab.Text,
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);

			//		Workaround a bug
			this.ResetColorForLabel(tabPageIndex);
		}

		//		Sửa lại màu cho Label của TabPage
		private void ResetColorForLabel(int tabPageIndex)
		{
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
		private void ResetInputForTabPage(int tabPageIndex)
		{
			foreach (Control controlTemp in this.listOfControlsDVO[tabPageIndex])
			{
				if (controlTemp is DateTimePicker dateTimePicker)
				{
					dateTimePicker.Value = this.dateTimeDefault;

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
		private void ResetValidationForTabPage(int tabPageIndex)
		{
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
			string getClassName = "WinformWithExternalLibrary.DataValidateObject." + control.Name.Split('_')[0];

			Type type = Type.GetType(getClassName);

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

						if (!long.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonNhapDVO_ThanhToan), out long tempThanhToan_hoaDonNhapDVO))
						{
							tempThanhToan_hoaDonNhapDVO = 0;
						}

						hoaDonNhapDVO.HoaDonNhapDVO_DienThoaiNhaCungCap = this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonNhapDVO_DienThoaiNhaCungCap);
						hoaDonNhapDVO.HoaDonNhapDVO_TenNhaCungCap = this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonNhapDVO_TenNhaCungCap);
						hoaDonNhapDVO.HoaDonNhapDVO_TongTien = tempTongTien_hoaDonNhapDVO;
						hoaDonNhapDVO.HoaDonNhapDVO_ThanhToan = tempThanhToan_hoaDonNhapDVO;

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
						nhanVienDVO.NhanVienDVO_SelectNhanVien = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_SelectNhanVien);
						nhanVienDVO.NhanVienDVO_TenNhanVien = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_TenNhanVien);
						nhanVienDVO.NhanVienDVO_NgaySinh = this.NhanVienDVO_NgaySinh.Value;
						nhanVienDVO.NhanVienDVO_GioiTinh = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_GioiTinh);
						nhanVienDVO.NhanVienDVO_SoDienThoai = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_SoDienThoai);
						nhanVienDVO.NhanVienDVO_DiaChi = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_DiaChi);
						nhanVienDVO.NhanVienDVO_TenCongViec = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_TenCongViec);
						nhanVienDVO.NhanVienDVO_Email = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienDVO_Email);

						return nhanVienDVO;

					case KhachHangDVO khachHangDVO:
						khachHangDVO.KhachHangDVO_TenKhachHang = this.GetControlTextIfPlaceholderThenEmpty(this.KhachHangDVO_TenKhachHang);
						khachHangDVO.KhachHangDVO_DiaChi = this.GetControlTextIfPlaceholderThenEmpty(this.KhachHangDVO_DiaChi);
						khachHangDVO.KhachHangDVO_DienThoai = this.GetControlTextIfPlaceholderThenEmpty(this.KhachHangDVO_DienThoai);

						return khachHangDVO;
						
					case NhaCungCapDVO nhaCungCapDVO:
						nhaCungCapDVO.NhaCungCapDVO_TenNhaCungCap = this.GetControlTextIfPlaceholderThenEmpty(this.NhaCungCapDVO_TenNhaCungCap);
						nhaCungCapDVO.NhaCungCapDVO_DiaChi = this.GetControlTextIfPlaceholderThenEmpty(this.NhaCungCapDVO_DiaChi);
						nhaCungCapDVO.NhaCungCapDVO_DienThoai = this.GetControlTextIfPlaceholderThenEmpty(this.NhaCungCapDVO_DienThoai);

						return nhaCungCapDVO;
				}

				return obj;
			}
			else
			{
				Debug.WriteLine("GetInputFromControl failed: " + getClassName);

				return null;
			}
		}

		//		Lấy kiểu DVO từ Control
		private Type GetBaseDVOFromControl(Control control)
		{
			string getClassName = "WinformWithExternalLibrary.DataValidateObject." + control.Name.Split('_')[0];

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
					if (dateTimePicker.Value != this.dateTimeDefault)
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

		#endregion
	}
}