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
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.Measure;
using WinformWithExternalLibrary.DataTransferObjects;
using System.Diagnostics;
using WinformWithExternalLibrary.DataValidateObject;
using System.Windows.Controls.Primitives;
using static WinformWithExternalLibrary.DataTransferObjects.CustomDTO.PhanTichDTO;
using WinformWithExternalLibrary.Utils;
using WinformWithExternalLibrary.ExtraForm;
using System.Runtime.Remoting.Channels;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace WinformWithExternalLibrary
{
    public partial class FormMain : MaterialForm
	{
		public static FormMain Instance { get; set; }

		private readonly List<List<Control>> listOfControlsDVO = new List<List<Control>>();
		private readonly List<List<Label>> listOfLabelsDVO = new List<List<Label>>();
		private readonly List<List<bool>> isInterracted = new List<List<bool>>();

		private readonly PhanTichDAO phanTichDAO = new PhanTichDAO();

		private readonly FormatValues formatValues = new FormatValues();

        public FormMain()
		{
			//		GenerateData
			// this.InitializeFakeData();

			//		NOTE: THIS ALWAYS GO FIRST
			this.InitializeComponent();

			//		Attributes
			this.InitializeHardCodedAttributes();

			//		Events
			this.InitializeAutomaticEventAndList();
			this.InitializeSpecializedEvent();

			//		Specific
			this.Initialize_NgoSachMinhHieu();
			//this.Initialize_TranHongThai();
			this.Initialize_NguyenHongSon();
			this.Initialize_NguyenThanhTruc();
			this.Initialize_VuHongHanh();
		}

		#region Initialize

		//		Initializing

		private void InitializeFakeData()
		{
			BogusAmogus bogusAmogus = new BogusAmogus();
			bogusAmogus.GenerateFakeData();
		}

		private void InitializeHardCodedAttributes()
		{
			//		Material Skin Manager
			MaterialSkinManager.Instance.AddFormToManage(this);

			//		Label(s) for Focus
			this.labelForFocus.Text = "";

			//		Font
			this.Font = FormLogin.Instance.GetFont();

			//		Generalist Attributes
			foreach (TabPage tabPage in this.materialTabControl.TabPages) 
			{ 
				if (tabPage != this.HoaDonBanDVO)
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
						tempDateTimePicker.Value = DateTime.Now;

						//		Max Range = Now
						tempDateTimePicker.MaxDate = DateTime.Now;
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
				if (this.materialTabControl.TabPages[i] != this.HoaDonBanDVO)
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
						//		Get Placeholder
						control.Text = this.GetPlaceholderForControl(control);

						//		Adding in the list
						this.isInterracted[i].Add(false);
						this.listOfControlsDVO[i].Add(control);

						//		Assigning generalist Events
						control.GotFocus += this.ControlForInput_GotFocus;
						control.LostFocus += this.ControlForInput_LostFocus;
					}
					//		DateTimePicker
					else if (control is DateTimePicker tempDateTimePicker)
					{
						//		Event
						//tempDateTimePicker.ValueChanged += (obj, e) =>
						//{
						//	this.TryValidationFromControl(tempDateTimePicker);
						//};
					}
				}
			}
		}

		#endregion

		#region Event

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

			//		Set to FullScreen
			//		Set MaximumSize and MinimumSize to FullScreen
			//		Set ActiveControl to nothing
			this.Load += (obj, e) =>
			{
				this.FormBorderStyle = FormBorderStyle.None;
				this.WindowState = FormWindowState.Maximized;

				this.MinimumSize = this.Size;
				this.MaximumSize = this.Size;

				this.ActiveControl = this.labelForFocus;
			};

			//		Set ActiveControl to nothing
			this.Click += (obj, e) =>
			{
				this.ActiveControl = null;
			};

			//		TODO: Add DirtyData check when leaving tabPage
			//		TODO: Add Reset (PlaceHolder) when entering tabPage
			this.materialTabControl.Selecting += (obj, e) =>
			{

			};
		}

		private void ControlForInput_GotFocus(object sender, EventArgs e)
		{
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

			if (this.TryValidationFromControl(
						control: control, 
						onlyOneControl: false, 
						out dynamic baseDVO))
			{
				//		TODO: Succeeded btw, do whatever
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

		private void Initialize_NgoSachMinhHieu()
		{
			//		TODO: set up Event system for DAOs to update DataSource
			this.TabPageHoaDonBan_materialListView.Scrollable = true;

			this.NhanVienThuNganDVO_NhanVien.DataSource = NhanVienDAO.Instance.GetTenNhanVienAndNgaySinhList();
			this.HoaDonBanDVO_DienThoaiKhachHang.DataSource = KhachHangDAO.Instance.GetPhoneNumberList();
			this.ChiTietHDBanDVO_MaSanPham.DataSource = DMSanPhamDAO.Instance.GetMaSanPhamList();

			this.NhanVienThuNganDVO_NhanVien.SelectedIndex = -1;
			this.HoaDonBanDVO_DienThoaiKhachHang.SelectedIndex = -1;
			this.ChiTietHDBanDVO_MaSanPham.SelectedIndex = -1;

			//		Event For Validate Controls
			//			TabPageHoaDonBan_materialListView
			this.TabPageHoaDonBan_materialListView.SelectedIndexChanged += (obj, e) =>
			{
				//		Nothing
				if (this.TabPageHoaDonBan_materialListView.SelectedIndices.Count <= 0)
				{
					return;
				}

				//		Update Controls
				int index = this.TabPageHoaDonBan_materialListView.SelectedIndices[0];

				if (index >= 0)
				{
					ListViewItem listViewItem = this.TabPageHoaDonBan_materialListView.Items[index];

					this.ChiTietHDBanDVO_MaSanPham.Text = listViewItem.SubItems[1].Text;
					this.ChiTietHDBanDVO_TenSanPham.Text = listViewItem.SubItems[2].Text;
					this.ChiTietHDBanDVO_SoLuong.Text = listViewItem.SubItems[3].Text;
				}

				//		Update Focus
				this.ActiveControl = this.ChiTietHDBanDVO_MaSanPham;
			};

			//			HoaDonBanDVO_DienThoaiKhachHang
			this.HoaDonBanDVO_DienThoaiKhachHang.KeyPress += this.TextBoxBase_KeyPress_NumericOnly;
			this.HoaDonBanDVO_DienThoaiKhachHang.LostFocus += this.DienThoaiKhachHang_AutoComplete;
			this.HoaDonBanDVO_DienThoaiKhachHang.SelectedIndexChanged += this.DienThoaiKhachHang_AutoComplete;

			//			ChiTietHDBanDVO_MaSanPham
			this.ChiTietHDBanDVO_MaSanPham.KeyPress += this.TextBoxBase_KeyPress_NumericOnly;
			this.ChiTietHDBanDVO_MaSanPham.LostFocus += this.TenSanPham_AutoComplete;
			this.ChiTietHDBanDVO_MaSanPham.SelectedIndexChanged += this.TenSanPham_AutoComplete;

			//			HoaDonBanDVO_NhanVien
			this.NhanVienThuNganDVO_NhanVien.LostFocus += this.NhanVien_AutoComplete;
			this.NhanVienThuNganDVO_NhanVien.SelectedIndexChanged += this.NhanVien_AutoComplete;

			//			ChiTietHDBanDVO_SoLuong
			this.ChiTietHDBanDVO_SoLuong.KeyDown += (obj, e) =>
			{
				//		If Enter
				if (e.KeyCode == Keys.Enter)
				{
					this.NewChiTietHDBan(obj as Control);
				}
			};

			//		Event For Buttons
			//			TabPageHoaDonBan_ButtonTaoMoiSanPham
			//				TODO:	Finish
			this.TabPageHoaDonBan_ButtonTaoMoiSanPham.Click += (obj, e) =>
			{
				
			};

			//			TabPageHoaDonBan_ButtonNhapChiTiet
			this.TabPageHoaDonBan_ButtonNhapChiTiet.Click += (obj, e) =>
			{
				this.NewChiTietHDBan(this.ChiTietHDBanDVO_MaSanPham);
			};

			//			TabPageHoaDonBan_ButtonXoaSanPham
			this.TabPageHoaDonBan_ButtonXoaSanPham.Click += (obj, e) =>
			{
				//		Nothing is picked isn't it
				if (this.TabPageHoaDonBan_materialListView.SelectedIndices.Count <= 0)
				{
					return;
				}
				//		Else, delete the ones highlighted
				else
				{
					ListView.SelectedListViewItemCollection selectedItems = this.TabPageHoaDonBan_materialListView.SelectedItems;

					foreach (ListViewItem item in selectedItems)
					{
						this.UpdateTongTienHDBan(
								tien: long.Parse(item.SubItems[5].Text),
								biTru: true);

						this.TabPageHoaDonBan_materialListView.Items.Remove(item);
					}

					this.ResetInputForControl(this.ChiTietHDBanDVO_MaSanPham);

					this.ActiveControl = this.ChiTietHDBanDVO_MaSanPham;
				}
			};

			//			TabPageHoaDonBan_ButtonTaoMoiSanPham
			this.TabPageHoaDonBan_ButtonTaoMoiSanPham.Click += (obj, e) =>
			{
				this.ResetInputForControl(this.ChiTietHDBanDVO_MaSanPham);
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
					this.TryValidationFromControl(this.NhanVienThuNganDVO_NhanVien, onlyOneControl: false, out dynamic baseNhanVienThuNgan))
				{
					//		Validated!
					
					//		...Nothing?
					if (this.TabPageHoaDonBan_materialListView.Items.Count <= 0)
					{
						MaterialMessageBox.Show(
							text: "Hóa đơn chưa có đủ dữ liệu",
							caption: this.Text,
							UseRichTextBox: false,
							buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
							);

						return;
					}

					//		Casting
					NhanVienThuNganDVO nhanVienThuNganDVO = baseNhanVienThuNgan as NhanVienThuNganDVO;
					HoaDonBanDVO hoaDonBanDVO = baseHoaDonBan as HoaDonBanDVO;

					//		Show another Confirmation Form
					FormConfirmHoaDonBan formConfirmHoaDonBan = new FormConfirmHoaDonBan(hoaDonBanDVO, nhanVienThuNganDVO);
					formConfirmHoaDonBan.Show();
				}
			};

			//			TabPageHoaDonBan_ButtonTaoMoiHoaDon
			this.TabPageHoaDonBan_ButtonTaoMoiHoaDon.Click += (obj, e) =>
			{
				if (MaterialMessageBox.Show(
							text: "Bạn có chắc muốn nhập mới Hóa Đơn không?",
							caption: this.Text,
							buttons: MessageBoxButtons.YesNo,
							icon: MessageBoxIcon.Question,
							UseRichTextBox: false,
							buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
							)
						== DialogResult.Yes)
				{
					this.ResetHoaDonBanAndChiTietHDBan();
				}
			};
		}

		//		Event
		private void UpdateTongTienHDBan(long tien, bool biTru)
		{
			long tongTien = this.CheckIfTextboxEmptyOrPlaceholder(this.HoaDonBanDVO_TongTien) ? 0 : long.Parse(this.HoaDonBanDVO_TongTien.Text);

			if (biTru)
			{
				this.HoaDonBanDVO_TongTien.Text = (tongTien - tien).ToString();
			}
			else
			{
				this.HoaDonBanDVO_TongTien.Text = (tongTien + tien).ToString();
			}
		}

		private void NhanVien_AutoComplete(object obj, EventArgs e)
		{
			if (this.TryValidationFromControl(
							control: obj as Control,
							onlyOneControl: true,
							baseDVO: out _))
			{
				this.ActiveControl = this.ChiTietHDBanDVO_MaSanPham;
			}
		}

		private void DienThoaiKhachHang_AutoComplete(object obj, EventArgs e)
		{ 
			if (this.TryValidationFromControl(
						control: obj as Control, 
						onlyOneControl: true, 
						baseDVO: out _))
			{
				this.HoaDonBanDVO_TenKhachHang.Text = KhachHangDAO.Instance.GetTenKhachHangWithPhoneNumber(this.HoaDonBanDVO_DienThoaiKhachHang.Text);

				this.ActiveControl = this.HoaDonBanDVO_TenGiamGia;
			}
		}

		private void TenSanPham_AutoComplete(object obj, EventArgs e)
		{
			if (this.TryValidationFromControl(
						control: obj as Control,
						onlyOneControl: true,
						baseDVO: out _))
			{
				this.ChiTietHDBanDVO_TenSanPham.Text = DMSanPhamDAO.Instance.GetTenSanPhamWithMaSanPham(this.ChiTietHDBanDVO_MaSanPham.Text);

				this.ActiveControl = this.ChiTietHDBanDVO_SoLuong;

				if (this.CheckIfTextboxEmptyOrPlaceholder(this.ChiTietHDBanDVO_SoLuong))
				{
					this.ChiTietHDBanDVO_SoLuong.Text = 1.ToString();
				}
				this.ChiTietHDBanDVO_SoLuong.SelectionStart = this.ChiTietHDBanDVO_SoLuong.Text.Length;
			}
		}

		//		Function
		public void NhapHoaDonBan(HoaDonBanDVO hoaDonBanDVO, NhanVienThuNganDVO nhanVienThuNganDVO, TongTienKhachTraDVO tongTienKhachTraDVO)
		{
			if (int.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonBanDVO_TenGiamGia), out int giamGiaTemp))
			{
				giamGiaTemp = 0;
			}

			HoaDonBanDTO hoaDonBanDTO = new HoaDonBanDTO(
				hoaDonBanDTO_MaHDBan: Guid.NewGuid(),
				hoaDonBanDTO_MaKhachHang: KhachHangDAO.Instance.GetMaKhachHangWithPhoneNumbers(hoaDonBanDVO.HoaDonBanDVO_DienThoaiKhachHang),
				hoaDonBanDTO_MaNhanVien: NhanVienDAO.Instance.GetMaNhanVienByTenNhanVienAndNgaySinh(nhanVienThuNganDVO.NhanVienThuNganDVO_NhanVien),
				hoaDonBanDTO_NgayBan: DateTime.Now,
				hoaDonBanDTO_SoSanPham: this.TabPageHoaDonBan_materialListView.Items.Count,
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

			foreach (ListViewItem listViewItem in this.TabPageHoaDonBan_materialListView.Items)
			{
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
			}

			//		Reset Input
			this.ResetHoaDonBanAndChiTietHDBan();
		}

		private void ResetHoaDonBanAndChiTietHDBan()
		{
			//		Clear ListView
			this.TabPageHoaDonBan_materialListView.Items.Clear();

			//		Reset Controls
			this.ResetInputForControl(this.ChiTietHDBanDVO_MaSanPham);
			this.ResetInputForControl(this.HoaDonBanDVO_DienThoaiKhachHang);

			//		Set Interracted
			this.SetInterractedForControl(this.ChiTietHDBanDVO_MaSanPham, false);
			this.SetInterractedForControl(this.HoaDonBanDVO_DienThoaiKhachHang, false);

			//		Set Focus
			this.ActiveControl = this.ChiTietHDBanDVO_MaSanPham;
		}

		private void NewChiTietHDBan(Control control)
		{
			if (this.TryValidationFromControl(control, onlyOneControl: false, out dynamic baseDVO))
			{
				//		Casting
				ChiTietHDBanDVO chiTietHDBanDVO = baseDVO as ChiTietHDBanDVO;

				//		Get DonGiaBan
				long tempDonGiaBan = DMSanPhamDAO.Instance.GetDonGiaBanWithMaSanPham(chiTietHDBanDVO.ChiTietHDBanDVO_MaSanPham);

				//		If already Existed AND not Selected => Update
				if (this.TabPageHoaDonBan_materialListView.SelectedIndices.Count <= 0)
				{
					foreach (ListViewItem listViewItem1 in this.TabPageHoaDonBan_materialListView.Items)
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
							this.ResetInputForControl(control);

							this.ActiveControl = this.ChiTietHDBanDVO_MaSanPham;

							return;
						}
					}
				}

				//		If not Existed => Add new
				ListViewItem listViewItem = new ListViewItem();

				listViewItem.SubItems[0].Text = ((this.TabPageHoaDonBan_materialListView.Items.Count + 1).ToString());
				listViewItem.SubItems.Add(chiTietHDBanDVO.ChiTietHDBanDVO_MaSanPham);
				listViewItem.SubItems.Add(chiTietHDBanDVO.ChiTietHDBanDVO_TenSanPham);
				listViewItem.SubItems.Add(chiTietHDBanDVO.ChiTietHDBanDVO_SoLuong.ToString());
				listViewItem.SubItems.Add(tempDonGiaBan.ToString());
				listViewItem.SubItems.Add((tempDonGiaBan * chiTietHDBanDVO.ChiTietHDBanDVO_SoLuong).ToString());

				//		Remove Selected Indexes
				if (this.TabPageHoaDonBan_materialListView.SelectedIndices.Count > 0)
				{
					ListView.SelectedListViewItemCollection selectedItems = this.TabPageHoaDonBan_materialListView.SelectedItems;

					foreach (ListViewItem item in selectedItems)
					{
						this.UpdateTongTienHDBan(
							tien: long.Parse(item.SubItems[5].Text),
							biTru: true);

						this.TabPageHoaDonBan_materialListView.Items.Remove(item);
					}
				}

				//		Add new
				this.TabPageHoaDonBan_materialListView.Items.Add(listViewItem);

				//		Update TongTien
				this.UpdateTongTienHDBan(
					tien: long.Parse(listViewItem.SubItems[5].Text),
					biTru: false);

				//		Reset Input
				this.ResetInputForControl(control);

				//		Reset Focus
				this.ActiveControl = this.ChiTietHDBanDVO_MaSanPham;
			}
		}

		//		Functions Use from another form

		public void SetDienThoaiKhachHang(string dienThoai)
		{
			this.HoaDonBanDVO_DienThoaiKhachHang.Text = dienThoai;

			this.ActiveControl = this.HoaDonBanDVO_DienThoaiKhachHang;
		}

		#endregion

		#region Trần Hồng Thái
		private void Initialize_TranHongThai()
		{
            this.InitializeBillOfSell();

            this.InitializeChart1();
            this.InitializeChart2();
        }

		private void InitializeBillOfSell()
		{
            // Data queried from DB
            int countBillOfCellCurrentMonth = phanTichDAO.CountBillOfSellCurrentMonth();
			long revenueCurrentMonth = phanTichDAO.GetRevenueCurrentMonth();
			long discountTotalCurrentMonth = phanTichDAO.GetDiscountTotalCurrentMonth();
			long priceTotalCurrentMonth = phanTichDAO.GetPriceTotalCurrentMonth();
            int percentDiscount = (int)Math.Ceiling((double)discountTotalCurrentMonth / priceTotalCurrentMonth * 100);

            // Render data
            SoHoaDonBanLB.Text = countBillOfCellCurrentMonth.ToString();
            DoanhThuHoaDonBanLB.Text = this.formatValues.FormatPriceToView(revenueCurrentMonth.ToString(), 3) + " đ";
			GiamGiaPB.Value = percentDiscount;
			SoTienGiamGiaLB.Text = $"Tiền giảm giá tháng này: {this.formatValues.FormatPriceToView(discountTotalCurrentMonth.ToString(), 3)} đ ({percentDiscount}%)";


			// Event
			ShowHoaDonBanBtn.Click += (obj, e) =>
			{
				FormChiTietHoaDonBan formChiTietHoaDonBan = new FormChiTietHoaDonBan();

				formChiTietHoaDonBan.Show();
            };
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
                productsValueFirstColumn.Add(new ProductsBestSellerResponseDTO() { ProductsBestSellerResponseDTO_Thang = i + 1});
                productsValueSecondColumn.Add(new ProductsBestSellerResponseDTO() { ProductsBestSellerResponseDTO_Thang = i + 1});
                productsValueThirdColumn.Add(new ProductsBestSellerResponseDTO() { ProductsBestSellerResponseDTO_Thang = i + 1});
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
			Debug.WriteLine(DMSanPhamDAO.Instance.UpdateCongSoLuongTon("469075421580", 2));
		}

		#endregion

		#region Generalist Function

		private bool TryValidationFromControl(Control control, bool onlyOneControl, out dynamic baseDVO)
		{
			//		Reset Validation
			this.ResetValidationForControl(control);
			this.SetInterractedForControl(control, true);

			//		New Object
			baseDVO = this.GetInputFromControl(control);

			List<ValidationResult> results = new List<ValidationResult>();

			//		Try Validating
			if (!Validator.TryValidateObject(baseDVO, new ValidationContext(baseDVO), results, true)) {
				if (onlyOneControl)
				{
					foreach (ValidationResult result in results)
					{
						if (result.MemberNames.Contains(control.Name))
						{
							this.SetStringLabelForControl(control, result.ErrorMessage);

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
						for (int i = 0; i < this.listOfControlsDVO.Count; i++)
						{
							if (result.MemberNames.Contains(this.listOfControlsDVO[selectedIndex][i].Name) &&
								this.CheckIfTextboxInterracted(this.listOfControlsDVO[selectedIndex][i]))
							{
								this.SetStringLabelForControl(this.listOfControlsDVO[selectedIndex][i], result.ErrorMessage);
							}
						}
					}
				}

				return false;
			}
				
			return true;
		}

		private bool CheckIfTextboxInterracted(Control control)
		{
			int selectedIndex = this.GetTabPageControlSelectedIndex();

			return this.isInterracted
					[selectedIndex]
					[this.listOfControlsDVO[selectedIndex].IndexOf(control)];
		}

		private bool CheckIfTextboxEmptyOrPlaceholder(Control control)
		{
			return this.CheckTextboxTextEqualToString(control: control, text: "") ||
					this.CheckTextboxTextEqualToString(control: control, text: this.GetPlaceholderForControl(control));
		}

		private bool CheckTextboxTextEqualToString(Control control, string text)
		{
			return control.Text.Trim().Equals(text);
		}

		private string GetControlTextIfPlaceholderThenEmpty(Control control)
		{
			return control.Text == this.GetPlaceholderForControl(control) ? "" : control.Text;
		}

		private string GetControlTextIfEmptyThenPlaceholder(Control control)
		{
			return control.Text == "" ? this.GetPlaceholderForControl(control) : control.Text;
		}

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

		private void SetStringLabelForControl(Control control, string text)
		{
			int selectedIndex = this.GetTabPageControlSelectedIndex();
			string controlName = control.Name;

			foreach (Label label in this.listOfLabelsDVO[selectedIndex])
			{
				if (label.Name.Contains(controlName))
				{
					label.Text = text;

					return;
				}
			}
		}

		private void SetInterractedForControl(Control control, bool value)
		{
			string getClassName = control.Name.Split('_')[0];
			int tabPageIndex = this.GetTabPageControlSelectedIndex();

			for (int i = 0; i < this.listOfLabelsDVO[tabPageIndex].Count; i++)
			{
				if (this.listOfLabelsDVO[tabPageIndex][i].Name.Contains(getClassName))
				{
					this.isInterracted[tabPageIndex][i] = value;
				}
			}
		}

		private void ResetValidationForControl(Control control)
		{
			string getClassName = control.Name.Split('_')[0];
			int tabPageIndex = this.GetTabPageControlSelectedIndex();

			for (int i = 0; i < this.listOfLabelsDVO[tabPageIndex].Count; i++)
			{
				if (this.listOfLabelsDVO[tabPageIndex][i].Name.Contains(getClassName))
				{
					this.listOfLabelsDVO[tabPageIndex][i].Text = "";

					this.isInterracted[tabPageIndex][i] = false;
				}
			}
		}

		private void ResetInputForControl(Control control)
		{
			string getClassName = control.Name.Split('_')[0];
			int tabPageIndex = this.GetTabPageControlSelectedIndex();

			foreach (Control controlTemp in this.listOfControlsDVO[tabPageIndex])
			{
				if (controlTemp.Name.Contains(getClassName))
				{
					controlTemp.Text = "";
				}
			}
		}

		private dynamic GetInputFromControl(Control control)
		{
			string getClassName = "WinformWithExternalLibrary.DataValidateObject." + control.Name.Split('_')[0];

			Type type = Type.GetType(getClassName);

			if (type != null)
			{
				object obj = Activator.CreateInstance(type);

				if (obj is NhanVienThuNganDVO nhanVienThuNganDVO)
				{
					nhanVienThuNganDVO.NhanVienThuNganDVO_NhanVien = this.GetControlTextIfPlaceholderThenEmpty(this.NhanVienThuNganDVO_NhanVien);

					return nhanVienThuNganDVO;
				}

				if (obj is HoaDonBanDVO hoaDonBanDVO)
				{
					if (!long.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonBanDVO_TongTien), out long tempTongTien))
					{
						tempTongTien = 0;
					}
					if (!long.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonBanDVO_TongTien), out long tempThanhToan))
					{
						tempThanhToan = 0;
					}

					hoaDonBanDVO.HoaDonBanDVO_DienThoaiKhachHang = this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonBanDVO_DienThoaiKhachHang);
					hoaDonBanDVO.HoaDonBanDVO_TenGiamGia = this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonBanDVO_TenGiamGia);
					hoaDonBanDVO.HoaDonBanDVO_TenKhachHang = this.GetControlTextIfPlaceholderThenEmpty(this.HoaDonBanDVO_TenKhachHang);
					hoaDonBanDVO.HoaDonBanDVO_TongTien = tempTongTien;
					hoaDonBanDVO.HoaDonBanDVO_ThanhToan = tempThanhToan;

					return hoaDonBanDVO;
				}
				else if (obj is ChiTietHDBanDVO chiTietHDBanDVO)
				{
					if (!int.TryParse(this.GetControlTextIfPlaceholderThenEmpty(this.ChiTietHDBanDVO_SoLuong), out int tempSoLuong))
					{
						tempSoLuong = 0;
					}

					chiTietHDBanDVO.ChiTietHDBanDVO_MaSanPham = this.GetControlTextIfPlaceholderThenEmpty(this.ChiTietHDBanDVO_MaSanPham);
					chiTietHDBanDVO.ChiTietHDBanDVO_TenSanPham = this.GetControlTextIfPlaceholderThenEmpty(this.ChiTietHDBanDVO_TenSanPham);
					chiTietHDBanDVO.ChiTietHDBanDVO_SoLuong = tempSoLuong;

					return chiTietHDBanDVO;
				}

				return obj;
			}
			else
			{
				Debug.WriteLine(getClassName);

				return null;
			}
		}

		//		Get DataValidateObject from Control
		private Type GetBaseDVOFromControl(Control control)
		{
			string getClassName = "WinformWithExternalLibrary.DataValidateObject." + control.Name.Split('_')[0];

			Type type = Type.GetType(getClassName);

			if (type != null)
			{
				Debug.WriteLine(type);

				return type;
			}
			else
			{
				Debug.WriteLine(getClassName);

				return null;
			}
		}

		private int GetTabPageControlSelectedIndex()
		{
			Debug.WriteLine(materialTabControl.SelectedIndex);

			return this.materialTabControl.SelectedIndex;
		}

		private TabPage GetTabPageControlSelectedTabPage()
		{
			return this.materialTabControl.SelectedTab;
		}

        #endregion
    }
}