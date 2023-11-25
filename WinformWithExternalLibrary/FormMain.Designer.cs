

namespace WinformWithExternalLibrary
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
			this.TabPageNhanVien = new System.Windows.Forms.TabPage();
			this.NhanVienDVO_NhapLaiMatKhau = new MaterialSkin.Controls.MaterialTextBox();
			this.NhanVienDVO_NhapLaiMatKhau_Validation = new System.Windows.Forms.Label();
			this.NhanVienDVO_MatKhau = new MaterialSkin.Controls.MaterialTextBox();
			this.NhanVienDVO_MatKhau_Validation = new System.Windows.Forms.Label();
			this.NhanVienDVO_NgaySinh = new WinformWithExternalLibrary._Utilities.RJDatePicker();
			this.TabPageNhanVien_btnTaoMoiCongViec = new MaterialSkin.Controls.MaterialButton();
			this.TabPageNhanVien_btnMacDinh = new MaterialSkin.Controls.MaterialButton();
			this.NhanVienDVO_TenCongViec = new System.Windows.Forms.ComboBox();
			this.NhanVienDVO_Email = new MaterialSkin.Controls.MaterialTextBox();
			this.NhanVienDVO_GioiTinh = new System.Windows.Forms.ComboBox();
			this.NhanVienDVO_DiaChi = new MaterialSkin.Controls.MaterialTextBox();
			this.NhanVienDVO_SoDienThoai = new MaterialSkin.Controls.MaterialTextBox();
			this.NhanVienDVO_TenNhanVien = new MaterialSkin.Controls.MaterialTextBox();
			this.TabPageNhanVien_TextboxSelectNhanVien = new MaterialSkin.Controls.MaterialTextBox();
			this.NhanVienDVO_Email_Validation = new System.Windows.Forms.Label();
			this.NhanVienDVO_TenCongViec_Validation = new System.Windows.Forms.Label();
			this.NhanVienDVO_DiaChi_Validation = new System.Windows.Forms.Label();
			this.NhanVienDVO_SoDienThoai_Validation = new System.Windows.Forms.Label();
			this.NhanVienDVO_GioiTinh_Validation = new System.Windows.Forms.Label();
			this.NhanVienDVO_NgaySinh_Validation = new System.Windows.Forms.Label();
			this.NhanVienDVO_TenNhanVien_Validation = new System.Windows.Forms.Label();
			this.TabPageNhanVien_MaterialListView = new MaterialSkin.Controls.MaterialListView();
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TabPageNhanVien_btnSearch = new MaterialSkin.Controls.MaterialButton();
			this.TabPageNhanVien_btnLuu = new MaterialSkin.Controls.MaterialButton();
			this.TabPageNhanVien_btnThem = new MaterialSkin.Controls.MaterialButton();
			this.TabPageNhanVien_btnXoa = new MaterialSkin.Controls.MaterialButton();
			this.TabPageNhanVien_btnSua = new MaterialSkin.Controls.MaterialButton();
			this.TabPageNhanVien_btnExcel = new MaterialSkin.Controls.MaterialButton();
			this.TabPageHoaDonBan = new System.Windows.Forms.TabPage();
			this.HoaDonBanDVO_ThanhToan_Validation = new System.Windows.Forms.Label();
			this.HoaDonBanDVO_ThanhToan = new MaterialSkin.Controls.MaterialTextBox();
			this.TabPageHoaDonBan_ButtonXoaSanPham = new MaterialSkin.Controls.MaterialButton();
			this.HoaDonBanDVO_TongTien_Validation = new System.Windows.Forms.Label();
			this.ChiTietHDBanDVO_SoLuong_Validation = new System.Windows.Forms.Label();
			this.HoaDonBanDVO_TenGiamGia_Validation = new System.Windows.Forms.Label();
			this.NhanVienThuNganHDBanDVO_NhanVien = new System.Windows.Forms.ComboBox();
			this.HoaDonBanDVO_TenKhachHang_Validation = new System.Windows.Forms.Label();
			this.ChiTietHDBanDVO_TenSanPham_Validation = new System.Windows.Forms.Label();
			this.HoaDonBanDVO_DienThoaiKhachHang_Validation = new System.Windows.Forms.Label();
			this.NhanVienThuNganHDBanDVO_NhanVien_Validation = new System.Windows.Forms.Label();
			this.TabPageHoaDonBan_ButtonNhapHoaDon = new MaterialSkin.Controls.MaterialButton();
			this.ChiTietHDBanDVO_MaSanPham_Validation = new System.Windows.Forms.Label();
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon = new MaterialSkin.Controls.MaterialButton();
			this.HoaDonBanDVO_TongTien = new MaterialSkin.Controls.MaterialTextBox();
			this.TabPageHoaDonBan_ButtonNhapSanPham = new MaterialSkin.Controls.MaterialButton();
			this.HoaDonBanDVO_TenGiamGia = new MaterialSkin.Controls.MaterialTextBox();
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham = new MaterialSkin.Controls.MaterialButton();
			this.HoaDonBanDVO_DienThoaiKhachHang = new System.Windows.Forms.ComboBox();
			this.HoaDonBanDVO_TenKhachHang = new MaterialSkin.Controls.MaterialTextBox();
			this.LabelForFocus = new System.Windows.Forms.Label();
			this.TabPageHoaDonBan_ButtonTaoKhachHang = new MaterialSkin.Controls.MaterialButton();
			this.TabPageHoaDonBan_ButtonTaoSanPham = new MaterialSkin.Controls.MaterialButton();
			this.ChiTietHDBanDVO_SoLuong = new MaterialSkin.Controls.MaterialTextBox();
			this.TabPageHoaDonBan_MaterialListView = new MaterialSkin.Controls.MaterialListView();
			this.columnHeaderIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderIdentifier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderIndividualPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ChiTietHDBanDVO_MaSanPham = new System.Windows.Forms.ComboBox();
			this.ChiTietHDBanDVO_TenSanPham = new MaterialSkin.Controls.MaterialTextBox();
			this.TabPageHoaDonNhap = new System.Windows.Forms.TabPage();
			this.TabPageHoaDonNhap_ButtonXoaSanPham = new MaterialSkin.Controls.MaterialButton();
			this.HoaDonNhapDVO_TongTien_Validation = new System.Windows.Forms.Label();
			this.ChiTietHDNhapDVO_SoLuong_Validation = new System.Windows.Forms.Label();
			this.NhanVienThuNganHDNhapDVO_NhanVien = new System.Windows.Forms.ComboBox();
			this.HoaDonNhapDVO_TenNhaCungCap_Validation = new System.Windows.Forms.Label();
			this.ChiTietHDNhapDVO_TenSanPham_Validation = new System.Windows.Forms.Label();
			this.HoaDonNhapDVO_DienThoaiNhaCungCap_Validation = new System.Windows.Forms.Label();
			this.NhanVienThuNganHDNhapDVO_NhanVien_Validation = new System.Windows.Forms.Label();
			this.TabPageHoaDonNhap_ButtonNhapHoaDon = new MaterialSkin.Controls.MaterialButton();
			this.ChiTietHDNhapDVO_MaSanPham_Validation = new System.Windows.Forms.Label();
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon = new MaterialSkin.Controls.MaterialButton();
			this.HoaDonNhapDVO_TongTien = new MaterialSkin.Controls.MaterialTextBox();
			this.TabPageHoaDonNhap_ButtonNhapSanPham = new MaterialSkin.Controls.MaterialButton();
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham = new MaterialSkin.Controls.MaterialButton();
			this.HoaDonNhapDVO_DienThoaiNhaCungCap = new System.Windows.Forms.ComboBox();
			this.HoaDonNhapDVO_TenNhaCungCap = new MaterialSkin.Controls.MaterialTextBox();
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap = new MaterialSkin.Controls.MaterialButton();
			this.TabPageHoaDonNhap_ButtonTaoSanPham = new MaterialSkin.Controls.MaterialButton();
			this.ChiTietHDNhapDVO_SoLuong = new MaterialSkin.Controls.MaterialTextBox();
			this.TabPageHoaDonNhap_MaterialListView = new MaterialSkin.Controls.MaterialListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ChiTietHDNhapDVO_MaSanPham = new System.Windows.Forms.ComboBox();
			this.ChiTietHDNhapDVO_TenSanPham = new MaterialSkin.Controls.MaterialTextBox();
			this.TabPageKhachHang = new System.Windows.Forms.TabPage();
			this.TabPageKhachHang_XoaKhachHang = new MaterialSkin.Controls.MaterialButton();
			this.TabPageKhachHang_RefreshKhachHang = new MaterialSkin.Controls.MaterialButton();
			this.TabPageKhachHang_SuaKhachHang = new MaterialSkin.Controls.MaterialButton();
			this.TabPageKhachHang_LichSuMuaHang = new MaterialSkin.Controls.MaterialButton();
			this.TabPageKhachHang_SearchKH = new MaterialSkin.Controls.MaterialButton();
			this.TabPageKhachHang_XuatExcelKH = new MaterialSkin.Controls.MaterialButton();
			this.KhachHangDVO_DienThoai_Validation = new System.Windows.Forms.Label();
			this.KhachHangDVO_DienThoai = new MaterialSkin.Controls.MaterialTextBox();
			this.KhachHangDVO_DiaChi_Validation = new System.Windows.Forms.Label();
			this.KhachHangDVO_TenKhachHang_Validation = new System.Windows.Forms.Label();
			this.KhachHangDVO_DiaChi = new MaterialSkin.Controls.MaterialTextBox();
			this.KhachHangDVO_TenKhachHang = new MaterialSkin.Controls.MaterialTextBox();
			this.TabPageKhachHang_TaoKhachHang = new MaterialSkin.Controls.MaterialButton();
			this.TabPageKhachHang_MaterialListView = new MaterialSkin.Controls.MaterialListView();
			this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TabPageNhaCungCap = new System.Windows.Forms.TabPage();
			this.TabPageNhaCungCap_XoaNhaCungCap = new MaterialSkin.Controls.MaterialButton();
			this.TabPageNhaCungCap_RefreshNhaCungCap = new MaterialSkin.Controls.MaterialButton();
			this.TabPageNhaCungCap_SuaNCC = new MaterialSkin.Controls.MaterialButton();
			this.TabPageNhaCungCap_LichSuNhapHang = new MaterialSkin.Controls.MaterialButton();
			this.TabPageNhaCungCap_SearchNhaCungCap = new MaterialSkin.Controls.MaterialButton();
			this.TabPageNhaCungCap_XuatExcelNCC = new MaterialSkin.Controls.MaterialButton();
			this.TabPageNhaCungCap_TaoNhaCungCap = new MaterialSkin.Controls.MaterialButton();
			this.NhaCungCapDVO_DienThoai_Validation = new System.Windows.Forms.Label();
			this.NhaCungCapDVO_DienThoai = new MaterialSkin.Controls.MaterialTextBox();
			this.NhaCungCapDVO_DiaChi_Validation = new System.Windows.Forms.Label();
			this.NhaCungCapDVO_TenNhaCungCap_Validation = new System.Windows.Forms.Label();
			this.NhaCungCapDVO_DiaChi = new MaterialSkin.Controls.MaterialTextBox();
			this.NhaCungCapDVO_TenNhaCungCap = new MaterialSkin.Controls.MaterialTextBox();
			this.TabPageNhaCungCap_MaterialListView = new MaterialSkin.Controls.MaterialListView();
			this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TabPageSanPham = new System.Windows.Forms.TabPage();
			this.TabPageSanPham_ButtonDSKM = new MaterialSkin.Controls.MaterialButton();
			this.TabPageSanPham_ButtonLoadSP = new MaterialSkin.Controls.MaterialButton();
			this.TabPageSanPham_LabelThoiGianBaoHanh = new System.Windows.Forms.Label();
			this.TabPageSanPham_LabelSoLuongTonKho = new System.Windows.Forms.Label();
			this.TabPageSanPham_LabelDonGiaNhap = new System.Windows.Forms.Label();
			this.TabPageSanPham_LabelDonGiaBan = new System.Windows.Forms.Label();
			this.TabPageSanPham_NhapMoiTimKiem = new MaterialSkin.Controls.MaterialButton();
			this.TabPageSanPham_ButtonXuatRaFileExcel = new MaterialSkin.Controls.MaterialButton();
			this.DMSanPhamDVO_SoLuongTonKhoMax = new MaterialSkin.Controls.MaterialTextBox();
			this.DMSanPhamDVO_DonGiaNhapMax = new MaterialSkin.Controls.MaterialTextBox();
			this.DMSanPhamDVO_SoLuongTonKhoMin = new MaterialSkin.Controls.MaterialTextBox();
			this.DMSanPhamDVO_DonGiaNhapMin = new MaterialSkin.Controls.MaterialTextBox();
			this.DMSanPhamDVO_DonGiaBanMax = new MaterialSkin.Controls.MaterialTextBox();
			this.DMSanPhamDVO_TenSanPham = new MaterialSkin.Controls.MaterialTextBox();
			this.DMSanPhamDVO_DonGiaBanMin = new MaterialSkin.Controls.MaterialTextBox();
			this.TabPageSanPham_ButtonXoaSanPham = new MaterialSkin.Controls.MaterialButton();
			this.TabPageSanPham_ButtonThemSanPham = new MaterialSkin.Controls.MaterialButton();
			this.DMSanPhamDVO_MaSanPham = new MaterialSkin.Controls.MaterialTextBox();
			this.TabPageSanPham_ButtonSuaSanPham = new MaterialSkin.Controls.MaterialButton();
			this.TabPageSanPham_ButtonTimKiem = new MaterialSkin.Controls.MaterialButton();
			this.DMSanPhamDVO_ThoiGianBaoHanhMax = new WinformWithExternalLibrary._Utilities.RJDatePicker();
			this.DMSanPhamDVO_ThoiGianBaoHanhMin = new WinformWithExternalLibrary._Utilities.RJDatePicker();
			this.TabPageSanPham_MaterialListView = new MaterialSkin.Controls.MaterialListView();
			this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TabPagePhanTich = new System.Windows.Forms.TabPage();
			this.materialCard9 = new MaterialSkin.Controls.MaterialCard();
			this.label6 = new System.Windows.Forms.Label();
			this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
			this.label5 = new System.Windows.Forms.Label();
			this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
			this.label16 = new System.Windows.Forms.Label();
			this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
			this.label14 = new System.Windows.Forms.Label();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
			this.TabPagePhanTich_KhachHang_TiLeLB = new System.Windows.Forms.Label();
			this.TabPagePhanTich_KhachHang_TiLePB = new MaterialSkin.Controls.MaterialProgressBar();
			this.TabPagePhanTich_KhachHang_KHmoi_LB = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.TabPagePhanTich_KhachHang_Tong_LB = new System.Windows.Forms.Label();
			this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
			this.TabPagePhanTich_HoaDonNhap_TiLeLB = new System.Windows.Forms.Label();
			this.TabPagePhanTich_HoaDonNhap_TiLePB = new MaterialSkin.Controls.MaterialProgressBar();
			this.TabPagePhanTich_HoaDonNhap_ChiPhi_LB = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.TabPagePhanTich_HoaDonNhap_SoLuong_LB = new System.Windows.Forms.Label();
			this.TabPagePhanTich_HoaDonNhap_ShowBTN = new MaterialSkin.Controls.MaterialFloatingActionButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
			this.cartesianChart2 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
			this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
			this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
			this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
			this.TabPagePhanTich_HoaDonBan_GiamGiaLB = new System.Windows.Forms.Label();
			this.TabPagePhanTich_HoaDonBan_GiamGiaPB = new MaterialSkin.Controls.MaterialProgressBar();
			this.TabPagePhanTich_HoaDonBan_DoanhThu_LB = new System.Windows.Forms.Label();
			this.TabPagePhanTich_HoaDonBan_SoLuong_LB = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TabPagePhanTich_HoaDonBan_ShowBTN = new MaterialSkin.Controls.MaterialFloatingActionButton();
			this.pieChart2 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
			this.pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autoValidationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.materialTabControl.SuspendLayout();
			this.TabPageNhanVien.SuspendLayout();
			this.TabPageHoaDonBan.SuspendLayout();
			this.TabPageHoaDonNhap.SuspendLayout();
			this.TabPageKhachHang.SuspendLayout();
			this.TabPageNhaCungCap.SuspendLayout();
			this.TabPageSanPham.SuspendLayout();
			this.TabPagePhanTich.SuspendLayout();
			this.materialCard9.SuspendLayout();
			this.materialCard8.SuspendLayout();
			this.materialCard7.SuspendLayout();
			this.materialCard6.SuspendLayout();
			this.materialCard3.SuspendLayout();
			this.materialCard2.SuspendLayout();
			this.materialCard5.SuspendLayout();
			this.materialCard4.SuspendLayout();
			this.materialCard1.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// materialTabControl
			// 
			this.materialTabControl.Controls.Add(this.TabPageNhanVien);
			this.materialTabControl.Controls.Add(this.TabPageHoaDonBan);
			this.materialTabControl.Controls.Add(this.TabPageHoaDonNhap);
			this.materialTabControl.Controls.Add(this.TabPageKhachHang);
			this.materialTabControl.Controls.Add(this.TabPageNhaCungCap);
			this.materialTabControl.Controls.Add(this.TabPageSanPham);
			this.materialTabControl.Controls.Add(this.TabPagePhanTich);
			this.materialTabControl.Depth = 0;
			this.materialTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.materialTabControl.ImageList = this.imageList1;
			this.materialTabControl.Location = new System.Drawing.Point(3, 64);
			this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabControl.Multiline = true;
			this.materialTabControl.Name = "materialTabControl";
			this.materialTabControl.SelectedIndex = 0;
			this.materialTabControl.Size = new System.Drawing.Size(1481, 803);
			this.materialTabControl.TabIndex = 0;
			// 
			// TabPageNhanVien
			// 
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_NhapLaiMatKhau);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_NhapLaiMatKhau_Validation);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_MatKhau);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_MatKhau_Validation);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_NgaySinh);
			this.TabPageNhanVien.Controls.Add(this.TabPageNhanVien_btnTaoMoiCongViec);
			this.TabPageNhanVien.Controls.Add(this.TabPageNhanVien_btnMacDinh);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_TenCongViec);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_Email);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_GioiTinh);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_DiaChi);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_SoDienThoai);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_TenNhanVien);
			this.TabPageNhanVien.Controls.Add(this.TabPageNhanVien_TextboxSelectNhanVien);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_Email_Validation);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_TenCongViec_Validation);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_DiaChi_Validation);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_SoDienThoai_Validation);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_GioiTinh_Validation);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_NgaySinh_Validation);
			this.TabPageNhanVien.Controls.Add(this.NhanVienDVO_TenNhanVien_Validation);
			this.TabPageNhanVien.Controls.Add(this.TabPageNhanVien_MaterialListView);
			this.TabPageNhanVien.Controls.Add(this.TabPageNhanVien_btnSearch);
			this.TabPageNhanVien.Controls.Add(this.TabPageNhanVien_btnLuu);
			this.TabPageNhanVien.Controls.Add(this.TabPageNhanVien_btnThem);
			this.TabPageNhanVien.Controls.Add(this.TabPageNhanVien_btnXoa);
			this.TabPageNhanVien.Controls.Add(this.TabPageNhanVien_btnSua);
			this.TabPageNhanVien.Controls.Add(this.TabPageNhanVien_btnExcel);
			this.TabPageNhanVien.ImageKey = "icons8-male-user-32.png";
			this.TabPageNhanVien.Location = new System.Drawing.Point(4, 39);
			this.TabPageNhanVien.Name = "TabPageNhanVien";
			this.TabPageNhanVien.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageNhanVien.Size = new System.Drawing.Size(1473, 760);
			this.TabPageNhanVien.TabIndex = 2;
			this.TabPageNhanVien.Text = "Nhân Viên";
			this.TabPageNhanVien.UseVisualStyleBackColor = true;
			// 
			// NhanVienDVO_NhapLaiMatKhau
			// 
			this.NhanVienDVO_NhapLaiMatKhau.AnimateReadOnly = false;
			this.NhanVienDVO_NhapLaiMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NhanVienDVO_NhapLaiMatKhau.Depth = 0;
			this.NhanVienDVO_NhapLaiMatKhau.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.NhanVienDVO_NhapLaiMatKhau.LeadingIcon = null;
			this.NhanVienDVO_NhapLaiMatKhau.Location = new System.Drawing.Point(1078, 628);
			this.NhanVienDVO_NhapLaiMatKhau.MaxLength = 50;
			this.NhanVienDVO_NhapLaiMatKhau.MouseState = MaterialSkin.MouseState.OUT;
			this.NhanVienDVO_NhapLaiMatKhau.Multiline = false;
			this.NhanVienDVO_NhapLaiMatKhau.Name = "NhanVienDVO_NhapLaiMatKhau";
			this.NhanVienDVO_NhapLaiMatKhau.Size = new System.Drawing.Size(385, 50);
			this.NhanVienDVO_NhapLaiMatKhau.TabIndex = 73;
			this.NhanVienDVO_NhapLaiMatKhau.Text = "";
			this.NhanVienDVO_NhapLaiMatKhau.TrailingIcon = null;
			// 
			// NhanVienDVO_NhapLaiMatKhau_Validation
			// 
			this.NhanVienDVO_NhapLaiMatKhau_Validation.Location = new System.Drawing.Point(1079, 681);
			this.NhanVienDVO_NhapLaiMatKhau_Validation.Name = "NhanVienDVO_NhapLaiMatKhau_Validation";
			this.NhanVienDVO_NhapLaiMatKhau_Validation.Size = new System.Drawing.Size(386, 23);
			this.NhanVienDVO_NhapLaiMatKhau_Validation.TabIndex = 72;
			this.NhanVienDVO_NhapLaiMatKhau_Validation.Text = "NhanVienDVO_NhapLaiMatKhau_Validation";
			// 
			// NhanVienDVO_MatKhau
			// 
			this.NhanVienDVO_MatKhau.AnimateReadOnly = false;
			this.NhanVienDVO_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NhanVienDVO_MatKhau.Depth = 0;
			this.NhanVienDVO_MatKhau.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.NhanVienDVO_MatKhau.LeadingIcon = null;
			this.NhanVienDVO_MatKhau.Location = new System.Drawing.Point(1078, 549);
			this.NhanVienDVO_MatKhau.MaxLength = 50;
			this.NhanVienDVO_MatKhau.MouseState = MaterialSkin.MouseState.OUT;
			this.NhanVienDVO_MatKhau.Multiline = false;
			this.NhanVienDVO_MatKhau.Name = "NhanVienDVO_MatKhau";
			this.NhanVienDVO_MatKhau.Size = new System.Drawing.Size(385, 50);
			this.NhanVienDVO_MatKhau.TabIndex = 71;
			this.NhanVienDVO_MatKhau.Text = "";
			this.NhanVienDVO_MatKhau.TrailingIcon = null;
			// 
			// NhanVienDVO_MatKhau_Validation
			// 
			this.NhanVienDVO_MatKhau_Validation.Location = new System.Drawing.Point(1079, 602);
			this.NhanVienDVO_MatKhau_Validation.Name = "NhanVienDVO_MatKhau_Validation";
			this.NhanVienDVO_MatKhau_Validation.Size = new System.Drawing.Size(386, 23);
			this.NhanVienDVO_MatKhau_Validation.TabIndex = 70;
			this.NhanVienDVO_MatKhau_Validation.Text = "NhanVienDVO_MatKhau_Validation";
			// 
			// NhanVienDVO_NgaySinh
			// 
			this.NhanVienDVO_NgaySinh.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.NhanVienDVO_NgaySinh.BorderSize = 0;
			this.NhanVienDVO_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
			this.NhanVienDVO_NgaySinh.Location = new System.Drawing.Point(1078, 142);
			this.NhanVienDVO_NgaySinh.MinimumSize = new System.Drawing.Size(0, 35);
			this.NhanVienDVO_NgaySinh.Name = "NhanVienDVO_NgaySinh";
			this.NhanVienDVO_NgaySinh.Size = new System.Drawing.Size(385, 35);
			this.NhanVienDVO_NgaySinh.SkinColor = System.Drawing.Color.MediumSlateBlue;
			this.NhanVienDVO_NgaySinh.TabIndex = 69;
			this.NhanVienDVO_NgaySinh.TextColor = System.Drawing.Color.White;
			// 
			// TabPageNhanVien_btnTaoMoiCongViec
			// 
			this.TabPageNhanVien_btnTaoMoiCongViec.AutoSize = false;
			this.TabPageNhanVien_btnTaoMoiCongViec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhanVien_btnTaoMoiCongViec.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhanVien_btnTaoMoiCongViec.Depth = 0;
			this.TabPageNhanVien_btnTaoMoiCongViec.HighEmphasis = true;
			this.TabPageNhanVien_btnTaoMoiCongViec.Icon = null;
			this.TabPageNhanVien_btnTaoMoiCongViec.Location = new System.Drawing.Point(1312, 9);
			this.TabPageNhanVien_btnTaoMoiCongViec.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhanVien_btnTaoMoiCongViec.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhanVien_btnTaoMoiCongViec.Name = "TabPageNhanVien_btnTaoMoiCongViec";
			this.TabPageNhanVien_btnTaoMoiCongViec.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhanVien_btnTaoMoiCongViec.Size = new System.Drawing.Size(152, 45);
			this.TabPageNhanVien_btnTaoMoiCongViec.TabIndex = 68;
			this.TabPageNhanVien_btnTaoMoiCongViec.Text = "Tạo Mới Công Việc ";
			this.TabPageNhanVien_btnTaoMoiCongViec.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhanVien_btnTaoMoiCongViec.UseAccentColor = false;
			this.TabPageNhanVien_btnTaoMoiCongViec.UseVisualStyleBackColor = true;
			// 
			// TabPageNhanVien_btnMacDinh
			// 
			this.TabPageNhanVien_btnMacDinh.AutoSize = false;
			this.TabPageNhanVien_btnMacDinh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhanVien_btnMacDinh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhanVien_btnMacDinh.Depth = 0;
			this.TabPageNhanVien_btnMacDinh.HighEmphasis = true;
			this.TabPageNhanVien_btnMacDinh.Icon = null;
			this.TabPageNhanVien_btnMacDinh.Location = new System.Drawing.Point(623, 704);
			this.TabPageNhanVien_btnMacDinh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhanVien_btnMacDinh.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhanVien_btnMacDinh.Name = "TabPageNhanVien_btnMacDinh";
			this.TabPageNhanVien_btnMacDinh.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhanVien_btnMacDinh.Size = new System.Drawing.Size(153, 45);
			this.TabPageNhanVien_btnMacDinh.TabIndex = 67;
			this.TabPageNhanVien_btnMacDinh.Text = "Mặc Định ";
			this.TabPageNhanVien_btnMacDinh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhanVien_btnMacDinh.UseAccentColor = false;
			this.TabPageNhanVien_btnMacDinh.UseVisualStyleBackColor = true;
			// 
			// NhanVienDVO_TenCongViec
			// 
			this.NhanVienDVO_TenCongViec.FormattingEnabled = true;
			this.NhanVienDVO_TenCongViec.Location = new System.Drawing.Point(1078, 417);
			this.NhanVienDVO_TenCongViec.Name = "NhanVienDVO_TenCongViec";
			this.NhanVienDVO_TenCongViec.Size = new System.Drawing.Size(385, 24);
			this.NhanVienDVO_TenCongViec.TabIndex = 66;
			// 
			// NhanVienDVO_Email
			// 
			this.NhanVienDVO_Email.AnimateReadOnly = false;
			this.NhanVienDVO_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NhanVienDVO_Email.Depth = 0;
			this.NhanVienDVO_Email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.NhanVienDVO_Email.LeadingIcon = null;
			this.NhanVienDVO_Email.Location = new System.Drawing.Point(1078, 470);
			this.NhanVienDVO_Email.MaxLength = 50;
			this.NhanVienDVO_Email.MouseState = MaterialSkin.MouseState.OUT;
			this.NhanVienDVO_Email.Multiline = false;
			this.NhanVienDVO_Email.Name = "NhanVienDVO_Email";
			this.NhanVienDVO_Email.Size = new System.Drawing.Size(385, 50);
			this.NhanVienDVO_Email.TabIndex = 65;
			this.NhanVienDVO_Email.Text = "";
			this.NhanVienDVO_Email.TrailingIcon = null;
			// 
			// NhanVienDVO_GioiTinh
			// 
			this.NhanVienDVO_GioiTinh.FormattingEnabled = true;
			this.NhanVienDVO_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
			this.NhanVienDVO_GioiTinh.Location = new System.Drawing.Point(1078, 285);
			this.NhanVienDVO_GioiTinh.Name = "NhanVienDVO_GioiTinh";
			this.NhanVienDVO_GioiTinh.Size = new System.Drawing.Size(385, 24);
			this.NhanVienDVO_GioiTinh.TabIndex = 64;
			// 
			// NhanVienDVO_DiaChi
			// 
			this.NhanVienDVO_DiaChi.AnimateReadOnly = false;
			this.NhanVienDVO_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NhanVienDVO_DiaChi.Depth = 0;
			this.NhanVienDVO_DiaChi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.NhanVienDVO_DiaChi.LeadingIcon = null;
			this.NhanVienDVO_DiaChi.Location = new System.Drawing.Point(1078, 338);
			this.NhanVienDVO_DiaChi.MaxLength = 50;
			this.NhanVienDVO_DiaChi.MouseState = MaterialSkin.MouseState.OUT;
			this.NhanVienDVO_DiaChi.Multiline = false;
			this.NhanVienDVO_DiaChi.Name = "NhanVienDVO_DiaChi";
			this.NhanVienDVO_DiaChi.Size = new System.Drawing.Size(385, 50);
			this.NhanVienDVO_DiaChi.TabIndex = 63;
			this.NhanVienDVO_DiaChi.Text = "";
			this.NhanVienDVO_DiaChi.TrailingIcon = null;
			// 
			// NhanVienDVO_SoDienThoai
			// 
			this.NhanVienDVO_SoDienThoai.AnimateReadOnly = false;
			this.NhanVienDVO_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NhanVienDVO_SoDienThoai.Depth = 0;
			this.NhanVienDVO_SoDienThoai.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.NhanVienDVO_SoDienThoai.LeadingIcon = null;
			this.NhanVienDVO_SoDienThoai.Location = new System.Drawing.Point(1078, 206);
			this.NhanVienDVO_SoDienThoai.MaxLength = 50;
			this.NhanVienDVO_SoDienThoai.MouseState = MaterialSkin.MouseState.OUT;
			this.NhanVienDVO_SoDienThoai.Multiline = false;
			this.NhanVienDVO_SoDienThoai.Name = "NhanVienDVO_SoDienThoai";
			this.NhanVienDVO_SoDienThoai.Size = new System.Drawing.Size(385, 50);
			this.NhanVienDVO_SoDienThoai.TabIndex = 62;
			this.NhanVienDVO_SoDienThoai.Text = "";
			this.NhanVienDVO_SoDienThoai.TrailingIcon = null;
			// 
			// NhanVienDVO_TenNhanVien
			// 
			this.NhanVienDVO_TenNhanVien.AnimateReadOnly = false;
			this.NhanVienDVO_TenNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NhanVienDVO_TenNhanVien.Depth = 0;
			this.NhanVienDVO_TenNhanVien.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.NhanVienDVO_TenNhanVien.LeadingIcon = null;
			this.NhanVienDVO_TenNhanVien.Location = new System.Drawing.Point(1078, 63);
			this.NhanVienDVO_TenNhanVien.MaxLength = 50;
			this.NhanVienDVO_TenNhanVien.MouseState = MaterialSkin.MouseState.OUT;
			this.NhanVienDVO_TenNhanVien.Multiline = false;
			this.NhanVienDVO_TenNhanVien.Name = "NhanVienDVO_TenNhanVien";
			this.NhanVienDVO_TenNhanVien.Size = new System.Drawing.Size(385, 50);
			this.NhanVienDVO_TenNhanVien.TabIndex = 61;
			this.NhanVienDVO_TenNhanVien.Text = "";
			this.NhanVienDVO_TenNhanVien.TrailingIcon = null;
			// 
			// TabPageNhanVien_TextboxSelectNhanVien
			// 
			this.TabPageNhanVien_TextboxSelectNhanVien.AnimateReadOnly = false;
			this.TabPageNhanVien_TextboxSelectNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TabPageNhanVien_TextboxSelectNhanVien.Depth = 0;
			this.TabPageNhanVien_TextboxSelectNhanVien.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TabPageNhanVien_TextboxSelectNhanVien.LeadingIcon = null;
			this.TabPageNhanVien_TextboxSelectNhanVien.Location = new System.Drawing.Point(6, 6);
			this.TabPageNhanVien_TextboxSelectNhanVien.MaxLength = 50;
			this.TabPageNhanVien_TextboxSelectNhanVien.MouseState = MaterialSkin.MouseState.OUT;
			this.TabPageNhanVien_TextboxSelectNhanVien.Multiline = false;
			this.TabPageNhanVien_TextboxSelectNhanVien.Name = "TabPageNhanVien_TextboxSelectNhanVien";
			this.TabPageNhanVien_TextboxSelectNhanVien.Size = new System.Drawing.Size(896, 50);
			this.TabPageNhanVien_TextboxSelectNhanVien.TabIndex = 60;
			this.TabPageNhanVien_TextboxSelectNhanVien.Text = "";
			this.TabPageNhanVien_TextboxSelectNhanVien.TrailingIcon = null;
			// 
			// NhanVienDVO_Email_Validation
			// 
			this.NhanVienDVO_Email_Validation.Location = new System.Drawing.Point(1079, 523);
			this.NhanVienDVO_Email_Validation.Name = "NhanVienDVO_Email_Validation";
			this.NhanVienDVO_Email_Validation.Size = new System.Drawing.Size(386, 23);
			this.NhanVienDVO_Email_Validation.TabIndex = 58;
			this.NhanVienDVO_Email_Validation.Text = "NhanVienDVO_Email_Validation";
			// 
			// NhanVienDVO_TenCongViec_Validation
			// 
			this.NhanVienDVO_TenCongViec_Validation.Location = new System.Drawing.Point(1078, 444);
			this.NhanVienDVO_TenCongViec_Validation.Name = "NhanVienDVO_TenCongViec_Validation";
			this.NhanVienDVO_TenCongViec_Validation.Size = new System.Drawing.Size(386, 23);
			this.NhanVienDVO_TenCongViec_Validation.TabIndex = 57;
			this.NhanVienDVO_TenCongViec_Validation.Text = "NhanVienDVO_TenCongViec_Validation";
			// 
			// NhanVienDVO_DiaChi_Validation
			// 
			this.NhanVienDVO_DiaChi_Validation.Location = new System.Drawing.Point(1078, 391);
			this.NhanVienDVO_DiaChi_Validation.Name = "NhanVienDVO_DiaChi_Validation";
			this.NhanVienDVO_DiaChi_Validation.Size = new System.Drawing.Size(386, 23);
			this.NhanVienDVO_DiaChi_Validation.TabIndex = 56;
			this.NhanVienDVO_DiaChi_Validation.Text = "NhanVienDVO_DiaChi_Validation";
			// 
			// NhanVienDVO_SoDienThoai_Validation
			// 
			this.NhanVienDVO_SoDienThoai_Validation.Location = new System.Drawing.Point(1078, 259);
			this.NhanVienDVO_SoDienThoai_Validation.Name = "NhanVienDVO_SoDienThoai_Validation";
			this.NhanVienDVO_SoDienThoai_Validation.Size = new System.Drawing.Size(385, 23);
			this.NhanVienDVO_SoDienThoai_Validation.TabIndex = 55;
			this.NhanVienDVO_SoDienThoai_Validation.Text = "NhanVienDVO_SoDienThoai_Validation";
			// 
			// NhanVienDVO_GioiTinh_Validation
			// 
			this.NhanVienDVO_GioiTinh_Validation.Location = new System.Drawing.Point(1078, 312);
			this.NhanVienDVO_GioiTinh_Validation.Name = "NhanVienDVO_GioiTinh_Validation";
			this.NhanVienDVO_GioiTinh_Validation.Size = new System.Drawing.Size(388, 23);
			this.NhanVienDVO_GioiTinh_Validation.TabIndex = 54;
			this.NhanVienDVO_GioiTinh_Validation.Text = "NhanVienDVO_GioiTinh_Validation";
			// 
			// NhanVienDVO_NgaySinh_Validation
			// 
			this.NhanVienDVO_NgaySinh_Validation.Location = new System.Drawing.Point(1078, 180);
			this.NhanVienDVO_NgaySinh_Validation.Name = "NhanVienDVO_NgaySinh_Validation";
			this.NhanVienDVO_NgaySinh_Validation.Size = new System.Drawing.Size(387, 23);
			this.NhanVienDVO_NgaySinh_Validation.TabIndex = 53;
			this.NhanVienDVO_NgaySinh_Validation.Text = "NhanVienDVO_NgaySinh";
			// 
			// NhanVienDVO_TenNhanVien_Validation
			// 
			this.NhanVienDVO_TenNhanVien_Validation.Location = new System.Drawing.Point(1078, 116);
			this.NhanVienDVO_TenNhanVien_Validation.Name = "NhanVienDVO_TenNhanVien_Validation";
			this.NhanVienDVO_TenNhanVien_Validation.Size = new System.Drawing.Size(386, 23);
			this.NhanVienDVO_TenNhanVien_Validation.TabIndex = 52;
			this.NhanVienDVO_TenNhanVien_Validation.Text = "NhanVienDVO_TenNhanVien_Validation";
			// 
			// TabPageNhanVien_MaterialListView
			// 
			this.TabPageNhanVien_MaterialListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
			this.TabPageNhanVien_MaterialListView.AllowDrop = true;
			this.TabPageNhanVien_MaterialListView.AutoSizeTable = false;
			this.TabPageNhanVien_MaterialListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.TabPageNhanVien_MaterialListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TabPageNhanVien_MaterialListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader13,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader14});
			this.TabPageNhanVien_MaterialListView.Depth = 0;
			this.TabPageNhanVien_MaterialListView.ForeColor = System.Drawing.SystemColors.Desktop;
			this.TabPageNhanVien_MaterialListView.FullRowSelect = true;
			this.TabPageNhanVien_MaterialListView.HideSelection = false;
			this.TabPageNhanVien_MaterialListView.Location = new System.Drawing.Point(6, 92);
			this.TabPageNhanVien_MaterialListView.MinimumSize = new System.Drawing.Size(200, 100);
			this.TabPageNhanVien_MaterialListView.MouseLocation = new System.Drawing.Point(-1, -1);
			this.TabPageNhanVien_MaterialListView.MouseState = MaterialSkin.MouseState.OUT;
			this.TabPageNhanVien_MaterialListView.Name = "TabPageNhanVien_MaterialListView";
			this.TabPageNhanVien_MaterialListView.OwnerDraw = true;
			this.TabPageNhanVien_MaterialListView.Size = new System.Drawing.Size(1066, 603);
			this.TabPageNhanVien_MaterialListView.TabIndex = 44;
			this.TabPageNhanVien_MaterialListView.UseCompatibleStateImageBehavior = false;
			this.TabPageNhanVien_MaterialListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "STT";
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Mã Nhân Viên ";
			this.columnHeader13.Width = 150;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Tên Nhân Viên";
			this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader8.Width = 180;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Ngày Sinh";
			this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader9.Width = 150;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Giới Tính";
			this.columnHeader10.Width = 90;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "SĐT";
			this.columnHeader11.Width = 120;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Địa Chỉ ";
			this.columnHeader12.Width = 210;
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Email";
			this.columnHeader14.Width = 210;
			// 
			// TabPageNhanVien_btnSearch
			// 
			this.TabPageNhanVien_btnSearch.AutoSize = false;
			this.TabPageNhanVien_btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhanVien_btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhanVien_btnSearch.Depth = 0;
			this.TabPageNhanVien_btnSearch.HighEmphasis = true;
			this.TabPageNhanVien_btnSearch.Icon = null;
			this.TabPageNhanVien_btnSearch.Location = new System.Drawing.Point(920, 9);
			this.TabPageNhanVien_btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhanVien_btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhanVien_btnSearch.Name = "TabPageNhanVien_btnSearch";
			this.TabPageNhanVien_btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhanVien_btnSearch.Size = new System.Drawing.Size(140, 45);
			this.TabPageNhanVien_btnSearch.TabIndex = 48;
			this.TabPageNhanVien_btnSearch.Text = "Tìm Kiếm";
			this.TabPageNhanVien_btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhanVien_btnSearch.UseAccentColor = false;
			this.TabPageNhanVien_btnSearch.UseVisualStyleBackColor = true;
			// 
			// TabPageNhanVien_btnLuu
			// 
			this.TabPageNhanVien_btnLuu.AutoSize = false;
			this.TabPageNhanVien_btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhanVien_btnLuu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhanVien_btnLuu.Depth = 0;
			this.TabPageNhanVien_btnLuu.HighEmphasis = true;
			this.TabPageNhanVien_btnLuu.Icon = null;
			this.TabPageNhanVien_btnLuu.Location = new System.Drawing.Point(1208, 704);
			this.TabPageNhanVien_btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhanVien_btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhanVien_btnLuu.Name = "TabPageNhanVien_btnLuu";
			this.TabPageNhanVien_btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhanVien_btnLuu.Size = new System.Drawing.Size(133, 45);
			this.TabPageNhanVien_btnLuu.TabIndex = 50;
			this.TabPageNhanVien_btnLuu.Text = "Lưu Thay Đổi";
			this.TabPageNhanVien_btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhanVien_btnLuu.UseAccentColor = false;
			this.TabPageNhanVien_btnLuu.UseVisualStyleBackColor = true;
			// 
			// TabPageNhanVien_btnThem
			// 
			this.TabPageNhanVien_btnThem.AutoSize = false;
			this.TabPageNhanVien_btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhanVien_btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhanVien_btnThem.Depth = 0;
			this.TabPageNhanVien_btnThem.HighEmphasis = true;
			this.TabPageNhanVien_btnThem.Icon = null;
			this.TabPageNhanVien_btnThem.Location = new System.Drawing.Point(1078, 9);
			this.TabPageNhanVien_btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhanVien_btnThem.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhanVien_btnThem.Name = "TabPageNhanVien_btnThem";
			this.TabPageNhanVien_btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhanVien_btnThem.Size = new System.Drawing.Size(153, 45);
			this.TabPageNhanVien_btnThem.TabIndex = 45;
			this.TabPageNhanVien_btnThem.Text = "Tạo Mới Nhân Viên";
			this.TabPageNhanVien_btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhanVien_btnThem.UseAccentColor = false;
			this.TabPageNhanVien_btnThem.UseVisualStyleBackColor = true;
			// 
			// TabPageNhanVien_btnXoa
			// 
			this.TabPageNhanVien_btnXoa.AutoSize = false;
			this.TabPageNhanVien_btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhanVien_btnXoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhanVien_btnXoa.Depth = 0;
			this.TabPageNhanVien_btnXoa.HighEmphasis = true;
			this.TabPageNhanVien_btnXoa.Icon = null;
			this.TabPageNhanVien_btnXoa.Location = new System.Drawing.Point(20, 704);
			this.TabPageNhanVien_btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhanVien_btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhanVien_btnXoa.Name = "TabPageNhanVien_btnXoa";
			this.TabPageNhanVien_btnXoa.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhanVien_btnXoa.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
			this.TabPageNhanVien_btnXoa.Size = new System.Drawing.Size(151, 45);
			this.TabPageNhanVien_btnXoa.TabIndex = 46;
			this.TabPageNhanVien_btnXoa.Text = "Xóa ";
			this.TabPageNhanVien_btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhanVien_btnXoa.UseAccentColor = false;
			this.TabPageNhanVien_btnXoa.UseVisualStyleBackColor = true;
			// 
			// TabPageNhanVien_btnSua
			// 
			this.TabPageNhanVien_btnSua.AutoSize = false;
			this.TabPageNhanVien_btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhanVien_btnSua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhanVien_btnSua.Depth = 0;
			this.TabPageNhanVien_btnSua.HighEmphasis = true;
			this.TabPageNhanVien_btnSua.Icon = null;
			this.TabPageNhanVien_btnSua.Location = new System.Drawing.Point(303, 704);
			this.TabPageNhanVien_btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhanVien_btnSua.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhanVien_btnSua.Name = "TabPageNhanVien_btnSua";
			this.TabPageNhanVien_btnSua.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhanVien_btnSua.Size = new System.Drawing.Size(153, 45);
			this.TabPageNhanVien_btnSua.TabIndex = 47;
			this.TabPageNhanVien_btnSua.Text = "Sửa Thông Tin";
			this.TabPageNhanVien_btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhanVien_btnSua.UseAccentColor = false;
			this.TabPageNhanVien_btnSua.UseVisualStyleBackColor = true;
			// 
			// TabPageNhanVien_btnExcel
			// 
			this.TabPageNhanVien_btnExcel.AutoSize = false;
			this.TabPageNhanVien_btnExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhanVien_btnExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhanVien_btnExcel.Depth = 0;
			this.TabPageNhanVien_btnExcel.HighEmphasis = true;
			this.TabPageNhanVien_btnExcel.Icon = null;
			this.TabPageNhanVien_btnExcel.Location = new System.Drawing.Point(920, 704);
			this.TabPageNhanVien_btnExcel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhanVien_btnExcel.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhanVien_btnExcel.Name = "TabPageNhanVien_btnExcel";
			this.TabPageNhanVien_btnExcel.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhanVien_btnExcel.Size = new System.Drawing.Size(152, 45);
			this.TabPageNhanVien_btnExcel.TabIndex = 49;
			this.TabPageNhanVien_btnExcel.Text = "Xuất File Excel";
			this.TabPageNhanVien_btnExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhanVien_btnExcel.UseAccentColor = false;
			this.TabPageNhanVien_btnExcel.UseVisualStyleBackColor = true;
			// 
			// TabPageHoaDonBan
			// 
			this.TabPageHoaDonBan.Controls.Add(this.HoaDonBanDVO_ThanhToan_Validation);
			this.TabPageHoaDonBan.Controls.Add(this.HoaDonBanDVO_ThanhToan);
			this.TabPageHoaDonBan.Controls.Add(this.TabPageHoaDonBan_ButtonXoaSanPham);
			this.TabPageHoaDonBan.Controls.Add(this.HoaDonBanDVO_TongTien_Validation);
			this.TabPageHoaDonBan.Controls.Add(this.ChiTietHDBanDVO_SoLuong_Validation);
			this.TabPageHoaDonBan.Controls.Add(this.HoaDonBanDVO_TenGiamGia_Validation);
			this.TabPageHoaDonBan.Controls.Add(this.NhanVienThuNganHDBanDVO_NhanVien);
			this.TabPageHoaDonBan.Controls.Add(this.HoaDonBanDVO_TenKhachHang_Validation);
			this.TabPageHoaDonBan.Controls.Add(this.ChiTietHDBanDVO_TenSanPham_Validation);
			this.TabPageHoaDonBan.Controls.Add(this.HoaDonBanDVO_DienThoaiKhachHang_Validation);
			this.TabPageHoaDonBan.Controls.Add(this.NhanVienThuNganHDBanDVO_NhanVien_Validation);
			this.TabPageHoaDonBan.Controls.Add(this.TabPageHoaDonBan_ButtonNhapHoaDon);
			this.TabPageHoaDonBan.Controls.Add(this.ChiTietHDBanDVO_MaSanPham_Validation);
			this.TabPageHoaDonBan.Controls.Add(this.TabPageHoaDonBan_ButtonNhapMoiHoaDon);
			this.TabPageHoaDonBan.Controls.Add(this.HoaDonBanDVO_TongTien);
			this.TabPageHoaDonBan.Controls.Add(this.TabPageHoaDonBan_ButtonNhapSanPham);
			this.TabPageHoaDonBan.Controls.Add(this.HoaDonBanDVO_TenGiamGia);
			this.TabPageHoaDonBan.Controls.Add(this.TabPageHoaDonBan_ButtonNhapMoiSanPham);
			this.TabPageHoaDonBan.Controls.Add(this.HoaDonBanDVO_DienThoaiKhachHang);
			this.TabPageHoaDonBan.Controls.Add(this.HoaDonBanDVO_TenKhachHang);
			this.TabPageHoaDonBan.Controls.Add(this.LabelForFocus);
			this.TabPageHoaDonBan.Controls.Add(this.TabPageHoaDonBan_ButtonTaoKhachHang);
			this.TabPageHoaDonBan.Controls.Add(this.TabPageHoaDonBan_ButtonTaoSanPham);
			this.TabPageHoaDonBan.Controls.Add(this.ChiTietHDBanDVO_SoLuong);
			this.TabPageHoaDonBan.Controls.Add(this.TabPageHoaDonBan_MaterialListView);
			this.TabPageHoaDonBan.Controls.Add(this.ChiTietHDBanDVO_MaSanPham);
			this.TabPageHoaDonBan.Controls.Add(this.ChiTietHDBanDVO_TenSanPham);
			this.TabPageHoaDonBan.ImageKey = "icons8-create-order-32.png";
			this.TabPageHoaDonBan.Location = new System.Drawing.Point(4, 39);
			this.TabPageHoaDonBan.Name = "TabPageHoaDonBan";
			this.TabPageHoaDonBan.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageHoaDonBan.Size = new System.Drawing.Size(1473, 760);
			this.TabPageHoaDonBan.TabIndex = 1;
			this.TabPageHoaDonBan.Text = "Hóa Đơn Bán";
			this.TabPageHoaDonBan.UseVisualStyleBackColor = true;
			// 
			// HoaDonBanDVO_ThanhToan_Validation
			// 
			this.HoaDonBanDVO_ThanhToan_Validation.Location = new System.Drawing.Point(1112, 681);
			this.HoaDonBanDVO_ThanhToan_Validation.Name = "HoaDonBanDVO_ThanhToan_Validation";
			this.HoaDonBanDVO_ThanhToan_Validation.Size = new System.Drawing.Size(356, 23);
			this.HoaDonBanDVO_ThanhToan_Validation.TabIndex = 31;
			this.HoaDonBanDVO_ThanhToan_Validation.Text = "HoaDonBanDVO_ThanhToan_Validation";
			// 
			// HoaDonBanDVO_ThanhToan
			// 
			this.HoaDonBanDVO_ThanhToan.AnimateReadOnly = false;
			this.HoaDonBanDVO_ThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.HoaDonBanDVO_ThanhToan.Depth = 0;
			this.HoaDonBanDVO_ThanhToan.Enabled = false;
			this.HoaDonBanDVO_ThanhToan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.HoaDonBanDVO_ThanhToan.LeadingIcon = null;
			this.HoaDonBanDVO_ThanhToan.Location = new System.Drawing.Point(1112, 628);
			this.HoaDonBanDVO_ThanhToan.MaxLength = 50;
			this.HoaDonBanDVO_ThanhToan.MouseState = MaterialSkin.MouseState.OUT;
			this.HoaDonBanDVO_ThanhToan.Multiline = false;
			this.HoaDonBanDVO_ThanhToan.Name = "HoaDonBanDVO_ThanhToan";
			this.HoaDonBanDVO_ThanhToan.Size = new System.Drawing.Size(354, 50);
			this.HoaDonBanDVO_ThanhToan.TabIndex = 30;
			this.HoaDonBanDVO_ThanhToan.Text = "";
			this.HoaDonBanDVO_ThanhToan.TrailingIcon = null;
			// 
			// TabPageHoaDonBan_ButtonXoaSanPham
			// 
			this.TabPageHoaDonBan_ButtonXoaSanPham.AutoSize = false;
			this.TabPageHoaDonBan_ButtonXoaSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageHoaDonBan_ButtonXoaSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageHoaDonBan_ButtonXoaSanPham.Depth = 0;
			this.TabPageHoaDonBan_ButtonXoaSanPham.HighEmphasis = true;
			this.TabPageHoaDonBan_ButtonXoaSanPham.Icon = null;
			this.TabPageHoaDonBan_ButtonXoaSanPham.Location = new System.Drawing.Point(1232, 280);
			this.TabPageHoaDonBan_ButtonXoaSanPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageHoaDonBan_ButtonXoaSanPham.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageHoaDonBan_ButtonXoaSanPham.Name = "TabPageHoaDonBan_ButtonXoaSanPham";
			this.TabPageHoaDonBan_ButtonXoaSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageHoaDonBan_ButtonXoaSanPham.Size = new System.Drawing.Size(112, 36);
			this.TabPageHoaDonBan_ButtonXoaSanPham.TabIndex = 29;
			this.TabPageHoaDonBan_ButtonXoaSanPham.TabStop = false;
			this.TabPageHoaDonBan_ButtonXoaSanPham.Text = "Xóa Sản Phẩm";
			this.TabPageHoaDonBan_ButtonXoaSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageHoaDonBan_ButtonXoaSanPham.UseAccentColor = false;
			this.TabPageHoaDonBan_ButtonXoaSanPham.UseVisualStyleBackColor = true;
			// 
			// HoaDonBanDVO_TongTien_Validation
			// 
			this.HoaDonBanDVO_TongTien_Validation.Location = new System.Drawing.Point(1112, 602);
			this.HoaDonBanDVO_TongTien_Validation.Name = "HoaDonBanDVO_TongTien_Validation";
			this.HoaDonBanDVO_TongTien_Validation.Size = new System.Drawing.Size(356, 23);
			this.HoaDonBanDVO_TongTien_Validation.TabIndex = 28;
			this.HoaDonBanDVO_TongTien_Validation.Text = "HoaDonBanDVO_TongTien_Validation";
			// 
			// ChiTietHDBanDVO_SoLuong_Validation
			// 
			this.ChiTietHDBanDVO_SoLuong_Validation.Location = new System.Drawing.Point(1112, 258);
			this.ChiTietHDBanDVO_SoLuong_Validation.Name = "ChiTietHDBanDVO_SoLuong_Validation";
			this.ChiTietHDBanDVO_SoLuong_Validation.Size = new System.Drawing.Size(356, 23);
			this.ChiTietHDBanDVO_SoLuong_Validation.TabIndex = 25;
			this.ChiTietHDBanDVO_SoLuong_Validation.Text = "ChiTietHDBanDVO_SoLuong_Validation";
			// 
			// HoaDonBanDVO_TenGiamGia_Validation
			// 
			this.HoaDonBanDVO_TenGiamGia_Validation.Location = new System.Drawing.Point(1112, 523);
			this.HoaDonBanDVO_TenGiamGia_Validation.Name = "HoaDonBanDVO_TenGiamGia_Validation";
			this.HoaDonBanDVO_TenGiamGia_Validation.Size = new System.Drawing.Size(356, 23);
			this.HoaDonBanDVO_TenGiamGia_Validation.TabIndex = 27;
			this.HoaDonBanDVO_TenGiamGia_Validation.Text = "HoaDonBanDVO_TenGiamGia_Validation";
			// 
			// NhanVienThuNganHDBanDVO_NhanVien
			// 
			this.NhanVienThuNganHDBanDVO_NhanVien.Location = new System.Drawing.Point(1111, 6);
			this.NhanVienThuNganHDBanDVO_NhanVien.Name = "NhanVienThuNganHDBanDVO_NhanVien";
			this.NhanVienThuNganHDBanDVO_NhanVien.Size = new System.Drawing.Size(356, 24);
			this.NhanVienThuNganHDBanDVO_NhanVien.TabIndex = 1;
			// 
			// HoaDonBanDVO_TenKhachHang_Validation
			// 
			this.HoaDonBanDVO_TenKhachHang_Validation.Location = new System.Drawing.Point(1112, 444);
			this.HoaDonBanDVO_TenKhachHang_Validation.Name = "HoaDonBanDVO_TenKhachHang_Validation";
			this.HoaDonBanDVO_TenKhachHang_Validation.Size = new System.Drawing.Size(356, 23);
			this.HoaDonBanDVO_TenKhachHang_Validation.TabIndex = 26;
			this.HoaDonBanDVO_TenKhachHang_Validation.Text = "HoaDonBanDVO_TenKhachHang_Validation";
			// 
			// ChiTietHDBanDVO_TenSanPham_Validation
			// 
			this.ChiTietHDBanDVO_TenSanPham_Validation.Location = new System.Drawing.Point(1112, 178);
			this.ChiTietHDBanDVO_TenSanPham_Validation.Name = "ChiTietHDBanDVO_TenSanPham_Validation";
			this.ChiTietHDBanDVO_TenSanPham_Validation.Size = new System.Drawing.Size(356, 23);
			this.ChiTietHDBanDVO_TenSanPham_Validation.TabIndex = 24;
			this.ChiTietHDBanDVO_TenSanPham_Validation.Text = "ChiTietHDBanDVO_TenSanPham_Validation";
			// 
			// HoaDonBanDVO_DienThoaiKhachHang_Validation
			// 
			this.HoaDonBanDVO_DienThoaiKhachHang_Validation.Location = new System.Drawing.Point(1112, 366);
			this.HoaDonBanDVO_DienThoaiKhachHang_Validation.Name = "HoaDonBanDVO_DienThoaiKhachHang_Validation";
			this.HoaDonBanDVO_DienThoaiKhachHang_Validation.Size = new System.Drawing.Size(356, 23);
			this.HoaDonBanDVO_DienThoaiKhachHang_Validation.TabIndex = 25;
			this.HoaDonBanDVO_DienThoaiKhachHang_Validation.Text = "HoaDonBanDVO_DienThoaiKhachHang_Validation";
			// 
			// NhanVienThuNganHDBanDVO_NhanVien_Validation
			// 
			this.NhanVienThuNganHDBanDVO_NhanVien_Validation.Location = new System.Drawing.Point(1110, 33);
			this.NhanVienThuNganHDBanDVO_NhanVien_Validation.Name = "NhanVienThuNganHDBanDVO_NhanVien_Validation";
			this.NhanVienThuNganHDBanDVO_NhanVien_Validation.Size = new System.Drawing.Size(356, 23);
			this.NhanVienThuNganHDBanDVO_NhanVien_Validation.TabIndex = 6;
			this.NhanVienThuNganHDBanDVO_NhanVien_Validation.Text = "NhanVienThuNganHDBanDVO_NhanVien_Validation";
			// 
			// TabPageHoaDonBan_ButtonNhapHoaDon
			// 
			this.TabPageHoaDonBan_ButtonNhapHoaDon.AutoSize = false;
			this.TabPageHoaDonBan_ButtonNhapHoaDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageHoaDonBan_ButtonNhapHoaDon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageHoaDonBan_ButtonNhapHoaDon.Depth = 0;
			this.TabPageHoaDonBan_ButtonNhapHoaDon.HighEmphasis = true;
			this.TabPageHoaDonBan_ButtonNhapHoaDon.Icon = null;
			this.TabPageHoaDonBan_ButtonNhapHoaDon.Location = new System.Drawing.Point(1353, 715);
			this.TabPageHoaDonBan_ButtonNhapHoaDon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageHoaDonBan_ButtonNhapHoaDon.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageHoaDonBan_ButtonNhapHoaDon.Name = "TabPageHoaDonBan_ButtonNhapHoaDon";
			this.TabPageHoaDonBan_ButtonNhapHoaDon.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageHoaDonBan_ButtonNhapHoaDon.Size = new System.Drawing.Size(112, 36);
			this.TabPageHoaDonBan_ButtonNhapHoaDon.TabIndex = 13;
			this.TabPageHoaDonBan_ButtonNhapHoaDon.TabStop = false;
			this.TabPageHoaDonBan_ButtonNhapHoaDon.Text = "Nhập Hóa Đơn";
			this.TabPageHoaDonBan_ButtonNhapHoaDon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageHoaDonBan_ButtonNhapHoaDon.UseAccentColor = false;
			this.TabPageHoaDonBan_ButtonNhapHoaDon.UseVisualStyleBackColor = true;
			// 
			// ChiTietHDBanDVO_MaSanPham_Validation
			// 
			this.ChiTietHDBanDVO_MaSanPham_Validation.Location = new System.Drawing.Point(1112, 100);
			this.ChiTietHDBanDVO_MaSanPham_Validation.Name = "ChiTietHDBanDVO_MaSanPham_Validation";
			this.ChiTietHDBanDVO_MaSanPham_Validation.Size = new System.Drawing.Size(356, 23);
			this.ChiTietHDBanDVO_MaSanPham_Validation.TabIndex = 7;
			this.ChiTietHDBanDVO_MaSanPham_Validation.Text = "ChiTietHDBanDVO_MaSanPham_Validation";
			// 
			// TabPageHoaDonBan_ButtonNhapMoiHoaDon
			// 
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.AutoSize = false;
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.Depth = 0;
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.HighEmphasis = true;
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.Icon = null;
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.Location = new System.Drawing.Point(1110, 715);
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.Name = "TabPageHoaDonBan_ButtonNhapMoiHoaDon";
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.Size = new System.Drawing.Size(112, 36);
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.TabIndex = 22;
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.TabStop = false;
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.Text = "Nhập Mới Hóa Đơn";
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.UseAccentColor = false;
			this.TabPageHoaDonBan_ButtonNhapMoiHoaDon.UseVisualStyleBackColor = true;
			// 
			// HoaDonBanDVO_TongTien
			// 
			this.HoaDonBanDVO_TongTien.AnimateReadOnly = false;
			this.HoaDonBanDVO_TongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.HoaDonBanDVO_TongTien.Depth = 0;
			this.HoaDonBanDVO_TongTien.Enabled = false;
			this.HoaDonBanDVO_TongTien.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.HoaDonBanDVO_TongTien.LeadingIcon = null;
			this.HoaDonBanDVO_TongTien.Location = new System.Drawing.Point(1112, 549);
			this.HoaDonBanDVO_TongTien.MaxLength = 50;
			this.HoaDonBanDVO_TongTien.MouseState = MaterialSkin.MouseState.OUT;
			this.HoaDonBanDVO_TongTien.Multiline = false;
			this.HoaDonBanDVO_TongTien.Name = "HoaDonBanDVO_TongTien";
			this.HoaDonBanDVO_TongTien.Size = new System.Drawing.Size(354, 50);
			this.HoaDonBanDVO_TongTien.TabIndex = 7;
			this.HoaDonBanDVO_TongTien.Text = "";
			this.HoaDonBanDVO_TongTien.TrailingIcon = null;
			// 
			// TabPageHoaDonBan_ButtonNhapSanPham
			// 
			this.TabPageHoaDonBan_ButtonNhapSanPham.AutoSize = false;
			this.TabPageHoaDonBan_ButtonNhapSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageHoaDonBan_ButtonNhapSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageHoaDonBan_ButtonNhapSanPham.Depth = 0;
			this.TabPageHoaDonBan_ButtonNhapSanPham.HighEmphasis = true;
			this.TabPageHoaDonBan_ButtonNhapSanPham.Icon = null;
			this.TabPageHoaDonBan_ButtonNhapSanPham.Location = new System.Drawing.Point(1353, 280);
			this.TabPageHoaDonBan_ButtonNhapSanPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageHoaDonBan_ButtonNhapSanPham.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageHoaDonBan_ButtonNhapSanPham.Name = "TabPageHoaDonBan_ButtonNhapSanPham";
			this.TabPageHoaDonBan_ButtonNhapSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageHoaDonBan_ButtonNhapSanPham.Size = new System.Drawing.Size(112, 36);
			this.TabPageHoaDonBan_ButtonNhapSanPham.TabIndex = 23;
			this.TabPageHoaDonBan_ButtonNhapSanPham.TabStop = false;
			this.TabPageHoaDonBan_ButtonNhapSanPham.Text = "Nhập Sản Phẩm";
			this.TabPageHoaDonBan_ButtonNhapSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageHoaDonBan_ButtonNhapSanPham.UseAccentColor = false;
			this.TabPageHoaDonBan_ButtonNhapSanPham.UseVisualStyleBackColor = true;
			// 
			// HoaDonBanDVO_TenGiamGia
			// 
			this.HoaDonBanDVO_TenGiamGia.AnimateReadOnly = false;
			this.HoaDonBanDVO_TenGiamGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.HoaDonBanDVO_TenGiamGia.Depth = 0;
			this.HoaDonBanDVO_TenGiamGia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.HoaDonBanDVO_TenGiamGia.LeadingIcon = null;
			this.HoaDonBanDVO_TenGiamGia.Location = new System.Drawing.Point(1112, 470);
			this.HoaDonBanDVO_TenGiamGia.MaxLength = 50;
			this.HoaDonBanDVO_TenGiamGia.MouseState = MaterialSkin.MouseState.OUT;
			this.HoaDonBanDVO_TenGiamGia.Multiline = false;
			this.HoaDonBanDVO_TenGiamGia.Name = "HoaDonBanDVO_TenGiamGia";
			this.HoaDonBanDVO_TenGiamGia.Size = new System.Drawing.Size(354, 50);
			this.HoaDonBanDVO_TenGiamGia.TabIndex = 6;
			this.HoaDonBanDVO_TenGiamGia.Text = "";
			this.HoaDonBanDVO_TenGiamGia.TrailingIcon = null;
			// 
			// TabPageHoaDonBan_ButtonNhapMoiSanPham
			// 
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.AutoSize = false;
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.Depth = 0;
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.HighEmphasis = true;
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.Icon = null;
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.Location = new System.Drawing.Point(1111, 280);
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.Name = "TabPageHoaDonBan_ButtonNhapMoiSanPham";
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.Size = new System.Drawing.Size(112, 36);
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.TabIndex = 23;
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.TabStop = false;
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.Text = "Nhập Mới Sản Phẩm";
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.UseAccentColor = false;
			this.TabPageHoaDonBan_ButtonNhapMoiSanPham.UseVisualStyleBackColor = true;
			// 
			// HoaDonBanDVO_DienThoaiKhachHang
			// 
			this.HoaDonBanDVO_DienThoaiKhachHang.Location = new System.Drawing.Point(1112, 335);
			this.HoaDonBanDVO_DienThoaiKhachHang.Name = "HoaDonBanDVO_DienThoaiKhachHang";
			this.HoaDonBanDVO_DienThoaiKhachHang.Size = new System.Drawing.Size(235, 24);
			this.HoaDonBanDVO_DienThoaiKhachHang.TabIndex = 4;
			// 
			// HoaDonBanDVO_TenKhachHang
			// 
			this.HoaDonBanDVO_TenKhachHang.AnimateReadOnly = false;
			this.HoaDonBanDVO_TenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.HoaDonBanDVO_TenKhachHang.Depth = 0;
			this.HoaDonBanDVO_TenKhachHang.Enabled = false;
			this.HoaDonBanDVO_TenKhachHang.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.HoaDonBanDVO_TenKhachHang.LeadingIcon = null;
			this.HoaDonBanDVO_TenKhachHang.Location = new System.Drawing.Point(1112, 391);
			this.HoaDonBanDVO_TenKhachHang.MaxLength = 50;
			this.HoaDonBanDVO_TenKhachHang.MouseState = MaterialSkin.MouseState.OUT;
			this.HoaDonBanDVO_TenKhachHang.Multiline = false;
			this.HoaDonBanDVO_TenKhachHang.Name = "HoaDonBanDVO_TenKhachHang";
			this.HoaDonBanDVO_TenKhachHang.Size = new System.Drawing.Size(354, 50);
			this.HoaDonBanDVO_TenKhachHang.TabIndex = 5;
			this.HoaDonBanDVO_TenKhachHang.Text = "";
			this.HoaDonBanDVO_TenKhachHang.TrailingIcon = null;
			// 
			// LabelForFocus
			// 
			this.LabelForFocus.AutoSize = true;
			this.LabelForFocus.Location = new System.Drawing.Point(1211, 843);
			this.LabelForFocus.Name = "LabelForFocus";
			this.LabelForFocus.Size = new System.Drawing.Size(44, 16);
			this.LabelForFocus.TabIndex = 4;
			this.LabelForFocus.Text = "label2";
			// 
			// TabPageHoaDonBan_ButtonTaoKhachHang
			// 
			this.TabPageHoaDonBan_ButtonTaoKhachHang.AutoSize = false;
			this.TabPageHoaDonBan_ButtonTaoKhachHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageHoaDonBan_ButtonTaoKhachHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageHoaDonBan_ButtonTaoKhachHang.Depth = 0;
			this.TabPageHoaDonBan_ButtonTaoKhachHang.HighEmphasis = true;
			this.TabPageHoaDonBan_ButtonTaoKhachHang.Icon = null;
			this.TabPageHoaDonBan_ButtonTaoKhachHang.Location = new System.Drawing.Point(1354, 328);
			this.TabPageHoaDonBan_ButtonTaoKhachHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageHoaDonBan_ButtonTaoKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageHoaDonBan_ButtonTaoKhachHang.Name = "TabPageHoaDonBan_ButtonTaoKhachHang";
			this.TabPageHoaDonBan_ButtonTaoKhachHang.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageHoaDonBan_ButtonTaoKhachHang.Size = new System.Drawing.Size(112, 36);
			this.TabPageHoaDonBan_ButtonTaoKhachHang.TabIndex = 0;
			this.TabPageHoaDonBan_ButtonTaoKhachHang.TabStop = false;
			this.TabPageHoaDonBan_ButtonTaoKhachHang.Text = "Tạo Khách Hàng";
			this.TabPageHoaDonBan_ButtonTaoKhachHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageHoaDonBan_ButtonTaoKhachHang.UseAccentColor = false;
			this.TabPageHoaDonBan_ButtonTaoKhachHang.UseVisualStyleBackColor = true;
			// 
			// TabPageHoaDonBan_ButtonTaoSanPham
			// 
			this.TabPageHoaDonBan_ButtonTaoSanPham.AutoSize = false;
			this.TabPageHoaDonBan_ButtonTaoSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageHoaDonBan_ButtonTaoSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageHoaDonBan_ButtonTaoSanPham.Depth = 0;
			this.TabPageHoaDonBan_ButtonTaoSanPham.HighEmphasis = true;
			this.TabPageHoaDonBan_ButtonTaoSanPham.Icon = null;
			this.TabPageHoaDonBan_ButtonTaoSanPham.Location = new System.Drawing.Point(1354, 57);
			this.TabPageHoaDonBan_ButtonTaoSanPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageHoaDonBan_ButtonTaoSanPham.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageHoaDonBan_ButtonTaoSanPham.Name = "TabPageHoaDonBan_ButtonTaoSanPham";
			this.TabPageHoaDonBan_ButtonTaoSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageHoaDonBan_ButtonTaoSanPham.Size = new System.Drawing.Size(112, 36);
			this.TabPageHoaDonBan_ButtonTaoSanPham.TabIndex = 13;
			this.TabPageHoaDonBan_ButtonTaoSanPham.TabStop = false;
			this.TabPageHoaDonBan_ButtonTaoSanPham.Text = "Tạo Sản Phẩm";
			this.TabPageHoaDonBan_ButtonTaoSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageHoaDonBan_ButtonTaoSanPham.UseAccentColor = false;
			this.TabPageHoaDonBan_ButtonTaoSanPham.UseVisualStyleBackColor = true;
			// 
			// ChiTietHDBanDVO_SoLuong
			// 
			this.ChiTietHDBanDVO_SoLuong.AnimateReadOnly = false;
			this.ChiTietHDBanDVO_SoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ChiTietHDBanDVO_SoLuong.Depth = 0;
			this.ChiTietHDBanDVO_SoLuong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ChiTietHDBanDVO_SoLuong.LeadingIcon = null;
			this.ChiTietHDBanDVO_SoLuong.Location = new System.Drawing.Point(1112, 205);
			this.ChiTietHDBanDVO_SoLuong.MaxLength = 50;
			this.ChiTietHDBanDVO_SoLuong.MouseState = MaterialSkin.MouseState.OUT;
			this.ChiTietHDBanDVO_SoLuong.Multiline = false;
			this.ChiTietHDBanDVO_SoLuong.Name = "ChiTietHDBanDVO_SoLuong";
			this.ChiTietHDBanDVO_SoLuong.Size = new System.Drawing.Size(354, 50);
			this.ChiTietHDBanDVO_SoLuong.TabIndex = 3;
			this.ChiTietHDBanDVO_SoLuong.Text = "";
			this.ChiTietHDBanDVO_SoLuong.TrailingIcon = null;
			// 
			// TabPageHoaDonBan_MaterialListView
			// 
			this.TabPageHoaDonBan_MaterialListView.AutoSizeTable = false;
			this.TabPageHoaDonBan_MaterialListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.TabPageHoaDonBan_MaterialListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TabPageHoaDonBan_MaterialListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIndex,
            this.columnHeaderIdentifier,
            this.columnHeaderName,
            this.columnHeaderCount,
            this.columnHeaderIndividualPrice,
            this.columnHeaderPrice});
			this.TabPageHoaDonBan_MaterialListView.Depth = 0;
			this.TabPageHoaDonBan_MaterialListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPageHoaDonBan_MaterialListView.FullRowSelect = true;
			this.TabPageHoaDonBan_MaterialListView.HideSelection = false;
			this.TabPageHoaDonBan_MaterialListView.Location = new System.Drawing.Point(6, 6);
			this.TabPageHoaDonBan_MaterialListView.MinimumSize = new System.Drawing.Size(200, 100);
			this.TabPageHoaDonBan_MaterialListView.MouseLocation = new System.Drawing.Point(-1, -1);
			this.TabPageHoaDonBan_MaterialListView.MouseState = MaterialSkin.MouseState.OUT;
			this.TabPageHoaDonBan_MaterialListView.Name = "TabPageHoaDonBan_MaterialListView";
			this.TabPageHoaDonBan_MaterialListView.OwnerDraw = true;
			this.TabPageHoaDonBan_MaterialListView.Size = new System.Drawing.Size(1099, 748);
			this.TabPageHoaDonBan_MaterialListView.TabIndex = 1;
			this.TabPageHoaDonBan_MaterialListView.UseCompatibleStateImageBehavior = false;
			this.TabPageHoaDonBan_MaterialListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderIndex
			// 
			this.columnHeaderIndex.Text = "STT";
			this.columnHeaderIndex.Width = 59;
			// 
			// columnHeaderIdentifier
			// 
			this.columnHeaderIdentifier.Text = "Mã Sản Phẩm";
			this.columnHeaderIdentifier.Width = 145;
			// 
			// columnHeaderName
			// 
			this.columnHeaderName.Text = "Tên Sản Phẩm";
			this.columnHeaderName.Width = 550;
			// 
			// columnHeaderCount
			// 
			this.columnHeaderCount.Text = "Số Lượng";
			this.columnHeaderCount.Width = 99;
			// 
			// columnHeaderIndividualPrice
			// 
			this.columnHeaderIndividualPrice.Text = "Đơn Giá";
			this.columnHeaderIndividualPrice.Width = 96;
			// 
			// columnHeaderPrice
			// 
			this.columnHeaderPrice.Text = "Giá";
			this.columnHeaderPrice.Width = 150;
			// 
			// ChiTietHDBanDVO_MaSanPham
			// 
			this.ChiTietHDBanDVO_MaSanPham.Location = new System.Drawing.Point(1111, 64);
			this.ChiTietHDBanDVO_MaSanPham.Name = "ChiTietHDBanDVO_MaSanPham";
			this.ChiTietHDBanDVO_MaSanPham.Size = new System.Drawing.Size(235, 24);
			this.ChiTietHDBanDVO_MaSanPham.TabIndex = 2;
			// 
			// ChiTietHDBanDVO_TenSanPham
			// 
			this.ChiTietHDBanDVO_TenSanPham.AnimateReadOnly = false;
			this.ChiTietHDBanDVO_TenSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ChiTietHDBanDVO_TenSanPham.Depth = 0;
			this.ChiTietHDBanDVO_TenSanPham.Enabled = false;
			this.ChiTietHDBanDVO_TenSanPham.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ChiTietHDBanDVO_TenSanPham.LeadingIcon = null;
			this.ChiTietHDBanDVO_TenSanPham.Location = new System.Drawing.Point(1112, 126);
			this.ChiTietHDBanDVO_TenSanPham.MaxLength = 50;
			this.ChiTietHDBanDVO_TenSanPham.MouseState = MaterialSkin.MouseState.OUT;
			this.ChiTietHDBanDVO_TenSanPham.Multiline = false;
			this.ChiTietHDBanDVO_TenSanPham.Name = "ChiTietHDBanDVO_TenSanPham";
			this.ChiTietHDBanDVO_TenSanPham.Size = new System.Drawing.Size(354, 50);
			this.ChiTietHDBanDVO_TenSanPham.TabIndex = 5;
			this.ChiTietHDBanDVO_TenSanPham.Text = "";
			this.ChiTietHDBanDVO_TenSanPham.TrailingIcon = null;
			// 
			// TabPageHoaDonNhap
			// 
			this.TabPageHoaDonNhap.Controls.Add(this.TabPageHoaDonNhap_ButtonXoaSanPham);
			this.TabPageHoaDonNhap.Controls.Add(this.HoaDonNhapDVO_TongTien_Validation);
			this.TabPageHoaDonNhap.Controls.Add(this.ChiTietHDNhapDVO_SoLuong_Validation);
			this.TabPageHoaDonNhap.Controls.Add(this.NhanVienThuNganHDNhapDVO_NhanVien);
			this.TabPageHoaDonNhap.Controls.Add(this.HoaDonNhapDVO_TenNhaCungCap_Validation);
			this.TabPageHoaDonNhap.Controls.Add(this.ChiTietHDNhapDVO_TenSanPham_Validation);
			this.TabPageHoaDonNhap.Controls.Add(this.HoaDonNhapDVO_DienThoaiNhaCungCap_Validation);
			this.TabPageHoaDonNhap.Controls.Add(this.NhanVienThuNganHDNhapDVO_NhanVien_Validation);
			this.TabPageHoaDonNhap.Controls.Add(this.TabPageHoaDonNhap_ButtonNhapHoaDon);
			this.TabPageHoaDonNhap.Controls.Add(this.ChiTietHDNhapDVO_MaSanPham_Validation);
			this.TabPageHoaDonNhap.Controls.Add(this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon);
			this.TabPageHoaDonNhap.Controls.Add(this.HoaDonNhapDVO_TongTien);
			this.TabPageHoaDonNhap.Controls.Add(this.TabPageHoaDonNhap_ButtonNhapSanPham);
			this.TabPageHoaDonNhap.Controls.Add(this.TabPageHoaDonNhap_ButtonNhapMoiSanPham);
			this.TabPageHoaDonNhap.Controls.Add(this.HoaDonNhapDVO_DienThoaiNhaCungCap);
			this.TabPageHoaDonNhap.Controls.Add(this.HoaDonNhapDVO_TenNhaCungCap);
			this.TabPageHoaDonNhap.Controls.Add(this.TabPageHoaDonNhap_ButtonTaoNhaCungCap);
			this.TabPageHoaDonNhap.Controls.Add(this.TabPageHoaDonNhap_ButtonTaoSanPham);
			this.TabPageHoaDonNhap.Controls.Add(this.ChiTietHDNhapDVO_SoLuong);
			this.TabPageHoaDonNhap.Controls.Add(this.TabPageHoaDonNhap_MaterialListView);
			this.TabPageHoaDonNhap.Controls.Add(this.ChiTietHDNhapDVO_MaSanPham);
			this.TabPageHoaDonNhap.Controls.Add(this.ChiTietHDNhapDVO_TenSanPham);
			this.TabPageHoaDonNhap.ImageKey = "icons8-purchase-order-32.png";
			this.TabPageHoaDonNhap.Location = new System.Drawing.Point(4, 39);
			this.TabPageHoaDonNhap.Name = "TabPageHoaDonNhap";
			this.TabPageHoaDonNhap.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageHoaDonNhap.Size = new System.Drawing.Size(1473, 760);
			this.TabPageHoaDonNhap.TabIndex = 3;
			this.TabPageHoaDonNhap.Text = "Hóa Đơn Nhập";
			this.TabPageHoaDonNhap.UseVisualStyleBackColor = true;
			// 
			// TabPageHoaDonNhap_ButtonXoaSanPham
			// 
			this.TabPageHoaDonNhap_ButtonXoaSanPham.AutoSize = false;
			this.TabPageHoaDonNhap_ButtonXoaSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageHoaDonNhap_ButtonXoaSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageHoaDonNhap_ButtonXoaSanPham.Depth = 0;
			this.TabPageHoaDonNhap_ButtonXoaSanPham.HighEmphasis = true;
			this.TabPageHoaDonNhap_ButtonXoaSanPham.Icon = null;
			this.TabPageHoaDonNhap_ButtonXoaSanPham.Location = new System.Drawing.Point(1232, 280);
			this.TabPageHoaDonNhap_ButtonXoaSanPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageHoaDonNhap_ButtonXoaSanPham.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageHoaDonNhap_ButtonXoaSanPham.Name = "TabPageHoaDonNhap_ButtonXoaSanPham";
			this.TabPageHoaDonNhap_ButtonXoaSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageHoaDonNhap_ButtonXoaSanPham.Size = new System.Drawing.Size(112, 36);
			this.TabPageHoaDonNhap_ButtonXoaSanPham.TabIndex = 55;
			this.TabPageHoaDonNhap_ButtonXoaSanPham.TabStop = false;
			this.TabPageHoaDonNhap_ButtonXoaSanPham.Text = "Xóa Sản Phẩm";
			this.TabPageHoaDonNhap_ButtonXoaSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageHoaDonNhap_ButtonXoaSanPham.UseAccentColor = false;
			this.TabPageHoaDonNhap_ButtonXoaSanPham.UseVisualStyleBackColor = true;
			// 
			// HoaDonNhapDVO_TongTien_Validation
			// 
			this.HoaDonNhapDVO_TongTien_Validation.Location = new System.Drawing.Point(1111, 685);
			this.HoaDonNhapDVO_TongTien_Validation.Name = "HoaDonNhapDVO_TongTien_Validation";
			this.HoaDonNhapDVO_TongTien_Validation.Size = new System.Drawing.Size(356, 23);
			this.HoaDonNhapDVO_TongTien_Validation.TabIndex = 54;
			this.HoaDonNhapDVO_TongTien_Validation.Text = "HoaDonNhapDVO_TongTien_Validation";
			// 
			// ChiTietHDNhapDVO_SoLuong_Validation
			// 
			this.ChiTietHDNhapDVO_SoLuong_Validation.Location = new System.Drawing.Point(1112, 258);
			this.ChiTietHDNhapDVO_SoLuong_Validation.Name = "ChiTietHDNhapDVO_SoLuong_Validation";
			this.ChiTietHDNhapDVO_SoLuong_Validation.Size = new System.Drawing.Size(356, 23);
			this.ChiTietHDNhapDVO_SoLuong_Validation.TabIndex = 51;
			this.ChiTietHDNhapDVO_SoLuong_Validation.Text = "ChiTietHDNhapDVO_SoLuong_Validation";
			// 
			// NhanVienThuNganHDNhapDVO_NhanVien
			// 
			this.NhanVienThuNganHDNhapDVO_NhanVien.Location = new System.Drawing.Point(1111, 6);
			this.NhanVienThuNganHDNhapDVO_NhanVien.Name = "NhanVienThuNganHDNhapDVO_NhanVien";
			this.NhanVienThuNganHDNhapDVO_NhanVien.Size = new System.Drawing.Size(356, 24);
			this.NhanVienThuNganHDNhapDVO_NhanVien.TabIndex = 34;
			// 
			// HoaDonNhapDVO_TenNhaCungCap_Validation
			// 
			this.HoaDonNhapDVO_TenNhaCungCap_Validation.Location = new System.Drawing.Point(1112, 444);
			this.HoaDonNhapDVO_TenNhaCungCap_Validation.Name = "HoaDonNhapDVO_TenNhaCungCap_Validation";
			this.HoaDonNhapDVO_TenNhaCungCap_Validation.Size = new System.Drawing.Size(356, 23);
			this.HoaDonNhapDVO_TenNhaCungCap_Validation.TabIndex = 52;
			this.HoaDonNhapDVO_TenNhaCungCap_Validation.Text = "HoaDonNhapDVO_TenNhaCungCap_Validation";
			// 
			// ChiTietHDNhapDVO_TenSanPham_Validation
			// 
			this.ChiTietHDNhapDVO_TenSanPham_Validation.Location = new System.Drawing.Point(1112, 178);
			this.ChiTietHDNhapDVO_TenSanPham_Validation.Name = "ChiTietHDNhapDVO_TenSanPham_Validation";
			this.ChiTietHDNhapDVO_TenSanPham_Validation.Size = new System.Drawing.Size(356, 23);
			this.ChiTietHDNhapDVO_TenSanPham_Validation.TabIndex = 49;
			this.ChiTietHDNhapDVO_TenSanPham_Validation.Text = "ChiTietHDNhapDVO_TenSanPham_Validation";
			// 
			// HoaDonNhapDVO_DienThoaiNhaCungCap_Validation
			// 
			this.HoaDonNhapDVO_DienThoaiNhaCungCap_Validation.Location = new System.Drawing.Point(1112, 366);
			this.HoaDonNhapDVO_DienThoaiNhaCungCap_Validation.Name = "HoaDonNhapDVO_DienThoaiNhaCungCap_Validation";
			this.HoaDonNhapDVO_DienThoaiNhaCungCap_Validation.Size = new System.Drawing.Size(356, 23);
			this.HoaDonNhapDVO_DienThoaiNhaCungCap_Validation.TabIndex = 50;
			this.HoaDonNhapDVO_DienThoaiNhaCungCap_Validation.Text = "HoaDonNhapDVO_DienThoaiNhaCungCap_Validation";
			// 
			// NhanVienThuNganHDNhapDVO_NhanVien_Validation
			// 
			this.NhanVienThuNganHDNhapDVO_NhanVien_Validation.Location = new System.Drawing.Point(1110, 33);
			this.NhanVienThuNganHDNhapDVO_NhanVien_Validation.Name = "NhanVienThuNganHDNhapDVO_NhanVien_Validation";
			this.NhanVienThuNganHDNhapDVO_NhanVien_Validation.Size = new System.Drawing.Size(356, 23);
			this.NhanVienThuNganHDNhapDVO_NhanVien_Validation.TabIndex = 41;
			this.NhanVienThuNganHDNhapDVO_NhanVien_Validation.Text = "NhanVienThuNganHDNhapDVO_NhanVien_Validation";
			// 
			// TabPageHoaDonNhap_ButtonNhapHoaDon
			// 
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.AutoSize = false;
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.Depth = 0;
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.HighEmphasis = true;
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.Icon = null;
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.Location = new System.Drawing.Point(1353, 715);
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.Name = "TabPageHoaDonNhap_ButtonNhapHoaDon";
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.Size = new System.Drawing.Size(112, 36);
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.TabIndex = 45;
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.TabStop = false;
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.Text = "Nhập Hóa Đơn";
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.UseAccentColor = false;
			this.TabPageHoaDonNhap_ButtonNhapHoaDon.UseVisualStyleBackColor = true;
			// 
			// ChiTietHDNhapDVO_MaSanPham_Validation
			// 
			this.ChiTietHDNhapDVO_MaSanPham_Validation.Location = new System.Drawing.Point(1112, 100);
			this.ChiTietHDNhapDVO_MaSanPham_Validation.Name = "ChiTietHDNhapDVO_MaSanPham_Validation";
			this.ChiTietHDNhapDVO_MaSanPham_Validation.Size = new System.Drawing.Size(356, 23);
			this.ChiTietHDNhapDVO_MaSanPham_Validation.TabIndex = 43;
			this.ChiTietHDNhapDVO_MaSanPham_Validation.Text = "ChiTietHDNhapDVO_MaSanPham_Validation";
			// 
			// TabPageHoaDonNhap_ButtonNhapMoiHoaDon
			// 
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.AutoSize = false;
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.Depth = 0;
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.HighEmphasis = true;
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.Icon = null;
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.Location = new System.Drawing.Point(1110, 715);
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.Name = "TabPageHoaDonNhap_ButtonNhapMoiHoaDon";
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.Size = new System.Drawing.Size(112, 36);
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.TabIndex = 46;
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.TabStop = false;
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.Text = "Nhập Mới Hóa Đơn";
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.UseAccentColor = false;
			this.TabPageHoaDonNhap_ButtonNhapMoiHoaDon.UseVisualStyleBackColor = true;
			// 
			// HoaDonNhapDVO_TongTien
			// 
			this.HoaDonNhapDVO_TongTien.AnimateReadOnly = false;
			this.HoaDonNhapDVO_TongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.HoaDonNhapDVO_TongTien.Depth = 0;
			this.HoaDonNhapDVO_TongTien.Enabled = false;
			this.HoaDonNhapDVO_TongTien.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.HoaDonNhapDVO_TongTien.LeadingIcon = null;
			this.HoaDonNhapDVO_TongTien.Location = new System.Drawing.Point(1111, 632);
			this.HoaDonNhapDVO_TongTien.MaxLength = 50;
			this.HoaDonNhapDVO_TongTien.MouseState = MaterialSkin.MouseState.OUT;
			this.HoaDonNhapDVO_TongTien.Multiline = false;
			this.HoaDonNhapDVO_TongTien.Name = "HoaDonNhapDVO_TongTien";
			this.HoaDonNhapDVO_TongTien.Size = new System.Drawing.Size(354, 50);
			this.HoaDonNhapDVO_TongTien.TabIndex = 42;
			this.HoaDonNhapDVO_TongTien.Text = "";
			this.HoaDonNhapDVO_TongTien.TrailingIcon = null;
			// 
			// TabPageHoaDonNhap_ButtonNhapSanPham
			// 
			this.TabPageHoaDonNhap_ButtonNhapSanPham.AutoSize = false;
			this.TabPageHoaDonNhap_ButtonNhapSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageHoaDonNhap_ButtonNhapSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageHoaDonNhap_ButtonNhapSanPham.Depth = 0;
			this.TabPageHoaDonNhap_ButtonNhapSanPham.HighEmphasis = true;
			this.TabPageHoaDonNhap_ButtonNhapSanPham.Icon = null;
			this.TabPageHoaDonNhap_ButtonNhapSanPham.Location = new System.Drawing.Point(1353, 280);
			this.TabPageHoaDonNhap_ButtonNhapSanPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageHoaDonNhap_ButtonNhapSanPham.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageHoaDonNhap_ButtonNhapSanPham.Name = "TabPageHoaDonNhap_ButtonNhapSanPham";
			this.TabPageHoaDonNhap_ButtonNhapSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageHoaDonNhap_ButtonNhapSanPham.Size = new System.Drawing.Size(112, 36);
			this.TabPageHoaDonNhap_ButtonNhapSanPham.TabIndex = 47;
			this.TabPageHoaDonNhap_ButtonNhapSanPham.TabStop = false;
			this.TabPageHoaDonNhap_ButtonNhapSanPham.Text = "Nhập Sản Phẩm";
			this.TabPageHoaDonNhap_ButtonNhapSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageHoaDonNhap_ButtonNhapSanPham.UseAccentColor = false;
			this.TabPageHoaDonNhap_ButtonNhapSanPham.UseVisualStyleBackColor = true;
			// 
			// TabPageHoaDonNhap_ButtonNhapMoiSanPham
			// 
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.AutoSize = false;
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.Depth = 0;
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.HighEmphasis = true;
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.Icon = null;
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.Location = new System.Drawing.Point(1111, 280);
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.Name = "TabPageHoaDonNhap_ButtonNhapMoiSanPham";
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.Size = new System.Drawing.Size(112, 36);
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.TabIndex = 48;
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.TabStop = false;
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.Text = "Nhập Mới Sản Phẩm";
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.UseAccentColor = false;
			this.TabPageHoaDonNhap_ButtonNhapMoiSanPham.UseVisualStyleBackColor = true;
			// 
			// HoaDonNhapDVO_DienThoaiNhaCungCap
			// 
			this.HoaDonNhapDVO_DienThoaiNhaCungCap.Location = new System.Drawing.Point(1112, 335);
			this.HoaDonNhapDVO_DienThoaiNhaCungCap.Name = "HoaDonNhapDVO_DienThoaiNhaCungCap";
			this.HoaDonNhapDVO_DienThoaiNhaCungCap.Size = new System.Drawing.Size(235, 24);
			this.HoaDonNhapDVO_DienThoaiNhaCungCap.TabIndex = 37;
			// 
			// HoaDonNhapDVO_TenNhaCungCap
			// 
			this.HoaDonNhapDVO_TenNhaCungCap.AnimateReadOnly = false;
			this.HoaDonNhapDVO_TenNhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.HoaDonNhapDVO_TenNhaCungCap.Depth = 0;
			this.HoaDonNhapDVO_TenNhaCungCap.Enabled = false;
			this.HoaDonNhapDVO_TenNhaCungCap.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.HoaDonNhapDVO_TenNhaCungCap.LeadingIcon = null;
			this.HoaDonNhapDVO_TenNhaCungCap.Location = new System.Drawing.Point(1112, 391);
			this.HoaDonNhapDVO_TenNhaCungCap.MaxLength = 50;
			this.HoaDonNhapDVO_TenNhaCungCap.MouseState = MaterialSkin.MouseState.OUT;
			this.HoaDonNhapDVO_TenNhaCungCap.Multiline = false;
			this.HoaDonNhapDVO_TenNhaCungCap.Name = "HoaDonNhapDVO_TenNhaCungCap";
			this.HoaDonNhapDVO_TenNhaCungCap.Size = new System.Drawing.Size(354, 50);
			this.HoaDonNhapDVO_TenNhaCungCap.TabIndex = 39;
			this.HoaDonNhapDVO_TenNhaCungCap.Text = "";
			this.HoaDonNhapDVO_TenNhaCungCap.TrailingIcon = null;
			// 
			// TabPageHoaDonNhap_ButtonTaoNhaCungCap
			// 
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.AutoSize = false;
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.Depth = 0;
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.HighEmphasis = true;
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.Icon = null;
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.Location = new System.Drawing.Point(1354, 328);
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.Name = "TabPageHoaDonNhap_ButtonTaoNhaCungCap";
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.Size = new System.Drawing.Size(112, 36);
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.TabIndex = 32;
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.TabStop = false;
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.Text = "Tạo Nhà Cung Cấp";
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.UseAccentColor = false;
			this.TabPageHoaDonNhap_ButtonTaoNhaCungCap.UseVisualStyleBackColor = true;
			// 
			// TabPageHoaDonNhap_ButtonTaoSanPham
			// 
			this.TabPageHoaDonNhap_ButtonTaoSanPham.AutoSize = false;
			this.TabPageHoaDonNhap_ButtonTaoSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageHoaDonNhap_ButtonTaoSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageHoaDonNhap_ButtonTaoSanPham.Depth = 0;
			this.TabPageHoaDonNhap_ButtonTaoSanPham.HighEmphasis = true;
			this.TabPageHoaDonNhap_ButtonTaoSanPham.Icon = null;
			this.TabPageHoaDonNhap_ButtonTaoSanPham.Location = new System.Drawing.Point(1354, 57);
			this.TabPageHoaDonNhap_ButtonTaoSanPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageHoaDonNhap_ButtonTaoSanPham.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageHoaDonNhap_ButtonTaoSanPham.Name = "TabPageHoaDonNhap_ButtonTaoSanPham";
			this.TabPageHoaDonNhap_ButtonTaoSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageHoaDonNhap_ButtonTaoSanPham.Size = new System.Drawing.Size(112, 36);
			this.TabPageHoaDonNhap_ButtonTaoSanPham.TabIndex = 44;
			this.TabPageHoaDonNhap_ButtonTaoSanPham.TabStop = false;
			this.TabPageHoaDonNhap_ButtonTaoSanPham.Text = "Tạo Sản Phẩm";
			this.TabPageHoaDonNhap_ButtonTaoSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageHoaDonNhap_ButtonTaoSanPham.UseAccentColor = false;
			this.TabPageHoaDonNhap_ButtonTaoSanPham.UseVisualStyleBackColor = true;
			// 
			// ChiTietHDNhapDVO_SoLuong
			// 
			this.ChiTietHDNhapDVO_SoLuong.AnimateReadOnly = false;
			this.ChiTietHDNhapDVO_SoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ChiTietHDNhapDVO_SoLuong.Depth = 0;
			this.ChiTietHDNhapDVO_SoLuong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ChiTietHDNhapDVO_SoLuong.LeadingIcon = null;
			this.ChiTietHDNhapDVO_SoLuong.Location = new System.Drawing.Point(1112, 205);
			this.ChiTietHDNhapDVO_SoLuong.MaxLength = 50;
			this.ChiTietHDNhapDVO_SoLuong.MouseState = MaterialSkin.MouseState.OUT;
			this.ChiTietHDNhapDVO_SoLuong.Multiline = false;
			this.ChiTietHDNhapDVO_SoLuong.Name = "ChiTietHDNhapDVO_SoLuong";
			this.ChiTietHDNhapDVO_SoLuong.Size = new System.Drawing.Size(354, 50);
			this.ChiTietHDNhapDVO_SoLuong.TabIndex = 36;
			this.ChiTietHDNhapDVO_SoLuong.Text = "";
			this.ChiTietHDNhapDVO_SoLuong.TrailingIcon = null;
			// 
			// TabPageHoaDonNhap_MaterialListView
			// 
			this.TabPageHoaDonNhap_MaterialListView.AutoSizeTable = false;
			this.TabPageHoaDonNhap_MaterialListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.TabPageHoaDonNhap_MaterialListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TabPageHoaDonNhap_MaterialListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.TabPageHoaDonNhap_MaterialListView.Depth = 0;
			this.TabPageHoaDonNhap_MaterialListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPageHoaDonNhap_MaterialListView.FullRowSelect = true;
			this.TabPageHoaDonNhap_MaterialListView.HideSelection = false;
			this.TabPageHoaDonNhap_MaterialListView.Location = new System.Drawing.Point(6, 6);
			this.TabPageHoaDonNhap_MaterialListView.MinimumSize = new System.Drawing.Size(200, 100);
			this.TabPageHoaDonNhap_MaterialListView.MouseLocation = new System.Drawing.Point(-1, -1);
			this.TabPageHoaDonNhap_MaterialListView.MouseState = MaterialSkin.MouseState.OUT;
			this.TabPageHoaDonNhap_MaterialListView.Name = "TabPageHoaDonNhap_MaterialListView";
			this.TabPageHoaDonNhap_MaterialListView.OwnerDraw = true;
			this.TabPageHoaDonNhap_MaterialListView.Size = new System.Drawing.Size(1099, 748);
			this.TabPageHoaDonNhap_MaterialListView.TabIndex = 33;
			this.TabPageHoaDonNhap_MaterialListView.UseCompatibleStateImageBehavior = false;
			this.TabPageHoaDonNhap_MaterialListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			this.columnHeader1.Width = 59;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã Sản Phẩm";
			this.columnHeader2.Width = 145;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên Sản Phẩm";
			this.columnHeader3.Width = 550;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Số Lượng";
			this.columnHeader4.Width = 99;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Đơn Giá";
			this.columnHeader5.Width = 96;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Giá";
			this.columnHeader6.Width = 150;
			// 
			// ChiTietHDNhapDVO_MaSanPham
			// 
			this.ChiTietHDNhapDVO_MaSanPham.Location = new System.Drawing.Point(1111, 64);
			this.ChiTietHDNhapDVO_MaSanPham.Name = "ChiTietHDNhapDVO_MaSanPham";
			this.ChiTietHDNhapDVO_MaSanPham.Size = new System.Drawing.Size(235, 24);
			this.ChiTietHDNhapDVO_MaSanPham.TabIndex = 35;
			// 
			// ChiTietHDNhapDVO_TenSanPham
			// 
			this.ChiTietHDNhapDVO_TenSanPham.AnimateReadOnly = false;
			this.ChiTietHDNhapDVO_TenSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ChiTietHDNhapDVO_TenSanPham.Depth = 0;
			this.ChiTietHDNhapDVO_TenSanPham.Enabled = false;
			this.ChiTietHDNhapDVO_TenSanPham.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ChiTietHDNhapDVO_TenSanPham.LeadingIcon = null;
			this.ChiTietHDNhapDVO_TenSanPham.Location = new System.Drawing.Point(1112, 126);
			this.ChiTietHDNhapDVO_TenSanPham.MaxLength = 50;
			this.ChiTietHDNhapDVO_TenSanPham.MouseState = MaterialSkin.MouseState.OUT;
			this.ChiTietHDNhapDVO_TenSanPham.Multiline = false;
			this.ChiTietHDNhapDVO_TenSanPham.Name = "ChiTietHDNhapDVO_TenSanPham";
			this.ChiTietHDNhapDVO_TenSanPham.Size = new System.Drawing.Size(354, 50);
			this.ChiTietHDNhapDVO_TenSanPham.TabIndex = 38;
			this.ChiTietHDNhapDVO_TenSanPham.Text = "";
			this.ChiTietHDNhapDVO_TenSanPham.TrailingIcon = null;
			// 
			// TabPageKhachHang
			// 
			this.TabPageKhachHang.Controls.Add(this.TabPageKhachHang_XoaKhachHang);
			this.TabPageKhachHang.Controls.Add(this.TabPageKhachHang_RefreshKhachHang);
			this.TabPageKhachHang.Controls.Add(this.TabPageKhachHang_SuaKhachHang);
			this.TabPageKhachHang.Controls.Add(this.TabPageKhachHang_LichSuMuaHang);
			this.TabPageKhachHang.Controls.Add(this.TabPageKhachHang_SearchKH);
			this.TabPageKhachHang.Controls.Add(this.TabPageKhachHang_XuatExcelKH);
			this.TabPageKhachHang.Controls.Add(this.KhachHangDVO_DienThoai_Validation);
			this.TabPageKhachHang.Controls.Add(this.KhachHangDVO_DienThoai);
			this.TabPageKhachHang.Controls.Add(this.KhachHangDVO_DiaChi_Validation);
			this.TabPageKhachHang.Controls.Add(this.KhachHangDVO_TenKhachHang_Validation);
			this.TabPageKhachHang.Controls.Add(this.KhachHangDVO_DiaChi);
			this.TabPageKhachHang.Controls.Add(this.KhachHangDVO_TenKhachHang);
			this.TabPageKhachHang.Controls.Add(this.TabPageKhachHang_TaoKhachHang);
			this.TabPageKhachHang.Controls.Add(this.TabPageKhachHang_MaterialListView);
			this.TabPageKhachHang.ImageKey = "icons8-people-32.png";
			this.TabPageKhachHang.Location = new System.Drawing.Point(4, 39);
			this.TabPageKhachHang.Name = "TabPageKhachHang";
			this.TabPageKhachHang.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageKhachHang.Size = new System.Drawing.Size(1473, 760);
			this.TabPageKhachHang.TabIndex = 4;
			this.TabPageKhachHang.Text = "Khách Hàng";
			this.TabPageKhachHang.UseVisualStyleBackColor = true;
			// 
			// TabPageKhachHang_XoaKhachHang
			// 
			this.TabPageKhachHang_XoaKhachHang.AutoSize = false;
			this.TabPageKhachHang_XoaKhachHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageKhachHang_XoaKhachHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageKhachHang_XoaKhachHang.Depth = 0;
			this.TabPageKhachHang_XoaKhachHang.HighEmphasis = true;
			this.TabPageKhachHang_XoaKhachHang.Icon = null;
			this.TabPageKhachHang_XoaKhachHang.Location = new System.Drawing.Point(1113, 575);
			this.TabPageKhachHang_XoaKhachHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageKhachHang_XoaKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageKhachHang_XoaKhachHang.Name = "TabPageKhachHang_XoaKhachHang";
			this.TabPageKhachHang_XoaKhachHang.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageKhachHang_XoaKhachHang.Size = new System.Drawing.Size(151, 36);
			this.TabPageKhachHang_XoaKhachHang.TabIndex = 62;
			this.TabPageKhachHang_XoaKhachHang.TabStop = false;
			this.TabPageKhachHang_XoaKhachHang.Text = "Xóa Khách Hàng";
			this.TabPageKhachHang_XoaKhachHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageKhachHang_XoaKhachHang.UseAccentColor = false;
			this.TabPageKhachHang_XoaKhachHang.UseVisualStyleBackColor = true;
			// 
			// TabPageKhachHang_RefreshKhachHang
			// 
			this.TabPageKhachHang_RefreshKhachHang.AutoSize = false;
			this.TabPageKhachHang_RefreshKhachHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageKhachHang_RefreshKhachHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageKhachHang_RefreshKhachHang.Depth = 0;
			this.TabPageKhachHang_RefreshKhachHang.HighEmphasis = true;
			this.TabPageKhachHang_RefreshKhachHang.Icon = null;
			this.TabPageKhachHang_RefreshKhachHang.Location = new System.Drawing.Point(1312, 719);
			this.TabPageKhachHang_RefreshKhachHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageKhachHang_RefreshKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageKhachHang_RefreshKhachHang.Name = "TabPageKhachHang_RefreshKhachHang";
			this.TabPageKhachHang_RefreshKhachHang.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageKhachHang_RefreshKhachHang.Size = new System.Drawing.Size(151, 36);
			this.TabPageKhachHang_RefreshKhachHang.TabIndex = 61;
			this.TabPageKhachHang_RefreshKhachHang.TabStop = false;
			this.TabPageKhachHang_RefreshKhachHang.Text = "Làm Mới";
			this.TabPageKhachHang_RefreshKhachHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageKhachHang_RefreshKhachHang.UseAccentColor = false;
			this.TabPageKhachHang_RefreshKhachHang.UseVisualStyleBackColor = true;
			// 
			// TabPageKhachHang_SuaKhachHang
			// 
			this.TabPageKhachHang_SuaKhachHang.AutoSize = false;
			this.TabPageKhachHang_SuaKhachHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageKhachHang_SuaKhachHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageKhachHang_SuaKhachHang.Depth = 0;
			this.TabPageKhachHang_SuaKhachHang.HighEmphasis = true;
			this.TabPageKhachHang_SuaKhachHang.Icon = null;
			this.TabPageKhachHang_SuaKhachHang.Location = new System.Drawing.Point(1113, 719);
			this.TabPageKhachHang_SuaKhachHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageKhachHang_SuaKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageKhachHang_SuaKhachHang.Name = "TabPageKhachHang_SuaKhachHang";
			this.TabPageKhachHang_SuaKhachHang.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageKhachHang_SuaKhachHang.Size = new System.Drawing.Size(151, 36);
			this.TabPageKhachHang_SuaKhachHang.TabIndex = 60;
			this.TabPageKhachHang_SuaKhachHang.TabStop = false;
			this.TabPageKhachHang_SuaKhachHang.Text = "Sửa thông tin";
			this.TabPageKhachHang_SuaKhachHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageKhachHang_SuaKhachHang.UseAccentColor = false;
			this.TabPageKhachHang_SuaKhachHang.UseVisualStyleBackColor = true;
			// 
			// TabPageKhachHang_LichSuMuaHang
			// 
			this.TabPageKhachHang_LichSuMuaHang.AutoSize = false;
			this.TabPageKhachHang_LichSuMuaHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageKhachHang_LichSuMuaHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageKhachHang_LichSuMuaHang.Depth = 0;
			this.TabPageKhachHang_LichSuMuaHang.HighEmphasis = true;
			this.TabPageKhachHang_LichSuMuaHang.Icon = null;
			this.TabPageKhachHang_LichSuMuaHang.Location = new System.Drawing.Point(1314, 623);
			this.TabPageKhachHang_LichSuMuaHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageKhachHang_LichSuMuaHang.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageKhachHang_LichSuMuaHang.Name = "TabPageKhachHang_LichSuMuaHang";
			this.TabPageKhachHang_LichSuMuaHang.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageKhachHang_LichSuMuaHang.Size = new System.Drawing.Size(151, 36);
			this.TabPageKhachHang_LichSuMuaHang.TabIndex = 59;
			this.TabPageKhachHang_LichSuMuaHang.TabStop = false;
			this.TabPageKhachHang_LichSuMuaHang.Text = "Lịch sử mua hàng";
			this.TabPageKhachHang_LichSuMuaHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageKhachHang_LichSuMuaHang.UseAccentColor = false;
			this.TabPageKhachHang_LichSuMuaHang.UseVisualStyleBackColor = true;
			// 
			// TabPageKhachHang_SearchKH
			// 
			this.TabPageKhachHang_SearchKH.AutoSize = false;
			this.TabPageKhachHang_SearchKH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageKhachHang_SearchKH.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageKhachHang_SearchKH.Depth = 0;
			this.TabPageKhachHang_SearchKH.HighEmphasis = true;
			this.TabPageKhachHang_SearchKH.Icon = null;
			this.TabPageKhachHang_SearchKH.Location = new System.Drawing.Point(1113, 671);
			this.TabPageKhachHang_SearchKH.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageKhachHang_SearchKH.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageKhachHang_SearchKH.Name = "TabPageKhachHang_SearchKH";
			this.TabPageKhachHang_SearchKH.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageKhachHang_SearchKH.Size = new System.Drawing.Size(151, 36);
			this.TabPageKhachHang_SearchKH.TabIndex = 58;
			this.TabPageKhachHang_SearchKH.TabStop = false;
			this.TabPageKhachHang_SearchKH.Text = "Tìm kiếm";
			this.TabPageKhachHang_SearchKH.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageKhachHang_SearchKH.UseAccentColor = false;
			this.TabPageKhachHang_SearchKH.UseVisualStyleBackColor = true;
			// 
			// TabPageKhachHang_XuatExcelKH
			// 
			this.TabPageKhachHang_XuatExcelKH.AutoSize = false;
			this.TabPageKhachHang_XuatExcelKH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageKhachHang_XuatExcelKH.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageKhachHang_XuatExcelKH.Depth = 0;
			this.TabPageKhachHang_XuatExcelKH.HighEmphasis = true;
			this.TabPageKhachHang_XuatExcelKH.Icon = null;
			this.TabPageKhachHang_XuatExcelKH.Location = new System.Drawing.Point(1314, 671);
			this.TabPageKhachHang_XuatExcelKH.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageKhachHang_XuatExcelKH.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageKhachHang_XuatExcelKH.Name = "TabPageKhachHang_XuatExcelKH";
			this.TabPageKhachHang_XuatExcelKH.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageKhachHang_XuatExcelKH.Size = new System.Drawing.Size(149, 36);
			this.TabPageKhachHang_XuatExcelKH.TabIndex = 57;
			this.TabPageKhachHang_XuatExcelKH.TabStop = false;
			this.TabPageKhachHang_XuatExcelKH.Text = "Xuất Excel";
			this.TabPageKhachHang_XuatExcelKH.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageKhachHang_XuatExcelKH.UseAccentColor = false;
			this.TabPageKhachHang_XuatExcelKH.UseVisualStyleBackColor = true;
			// 
			// KhachHangDVO_DienThoai_Validation
			// 
			this.KhachHangDVO_DienThoai_Validation.Location = new System.Drawing.Point(1112, 220);
			this.KhachHangDVO_DienThoai_Validation.Name = "KhachHangDVO_DienThoai_Validation";
			this.KhachHangDVO_DienThoai_Validation.Size = new System.Drawing.Size(353, 23);
			this.KhachHangDVO_DienThoai_Validation.TabIndex = 56;
			this.KhachHangDVO_DienThoai_Validation.Text = "KhachHangDVO_DienThoai_Validation";
			// 
			// KhachHangDVO_DienThoai
			// 
			this.KhachHangDVO_DienThoai.AnimateReadOnly = false;
			this.KhachHangDVO_DienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.KhachHangDVO_DienThoai.Depth = 0;
			this.KhachHangDVO_DienThoai.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.KhachHangDVO_DienThoai.LeadingIcon = null;
			this.KhachHangDVO_DienThoai.Location = new System.Drawing.Point(1113, 167);
			this.KhachHangDVO_DienThoai.MaxLength = 50;
			this.KhachHangDVO_DienThoai.MouseState = MaterialSkin.MouseState.OUT;
			this.KhachHangDVO_DienThoai.Multiline = false;
			this.KhachHangDVO_DienThoai.Name = "KhachHangDVO_DienThoai";
			this.KhachHangDVO_DienThoai.Size = new System.Drawing.Size(350, 50);
			this.KhachHangDVO_DienThoai.TabIndex = 55;
			this.KhachHangDVO_DienThoai.Text = "";
			this.KhachHangDVO_DienThoai.TrailingIcon = null;
			// 
			// KhachHangDVO_DiaChi_Validation
			// 
			this.KhachHangDVO_DiaChi_Validation.Location = new System.Drawing.Point(1112, 141);
			this.KhachHangDVO_DiaChi_Validation.Name = "KhachHangDVO_DiaChi_Validation";
			this.KhachHangDVO_DiaChi_Validation.Size = new System.Drawing.Size(353, 23);
			this.KhachHangDVO_DiaChi_Validation.TabIndex = 54;
			this.KhachHangDVO_DiaChi_Validation.Text = "KhachHangDVO_DiaChi_Validation";
			// 
			// KhachHangDVO_TenKhachHang_Validation
			// 
			this.KhachHangDVO_TenKhachHang_Validation.Location = new System.Drawing.Point(1112, 61);
			this.KhachHangDVO_TenKhachHang_Validation.Name = "KhachHangDVO_TenKhachHang_Validation";
			this.KhachHangDVO_TenKhachHang_Validation.Size = new System.Drawing.Size(353, 23);
			this.KhachHangDVO_TenKhachHang_Validation.TabIndex = 53;
			this.KhachHangDVO_TenKhachHang_Validation.Text = "KhachHangDVO_TenKhachHang_Validation";
			// 
			// KhachHangDVO_DiaChi
			// 
			this.KhachHangDVO_DiaChi.AnimateReadOnly = false;
			this.KhachHangDVO_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.KhachHangDVO_DiaChi.Depth = 0;
			this.KhachHangDVO_DiaChi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.KhachHangDVO_DiaChi.LeadingIcon = null;
			this.KhachHangDVO_DiaChi.Location = new System.Drawing.Point(1113, 88);
			this.KhachHangDVO_DiaChi.MaxLength = 50;
			this.KhachHangDVO_DiaChi.MouseState = MaterialSkin.MouseState.OUT;
			this.KhachHangDVO_DiaChi.Multiline = false;
			this.KhachHangDVO_DiaChi.Name = "KhachHangDVO_DiaChi";
			this.KhachHangDVO_DiaChi.Size = new System.Drawing.Size(350, 50);
			this.KhachHangDVO_DiaChi.TabIndex = 51;
			this.KhachHangDVO_DiaChi.Text = "";
			this.KhachHangDVO_DiaChi.TrailingIcon = null;
			// 
			// KhachHangDVO_TenKhachHang
			// 
			this.KhachHangDVO_TenKhachHang.AnimateReadOnly = false;
			this.KhachHangDVO_TenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.KhachHangDVO_TenKhachHang.Depth = 0;
			this.KhachHangDVO_TenKhachHang.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.KhachHangDVO_TenKhachHang.LeadingIcon = null;
			this.KhachHangDVO_TenKhachHang.Location = new System.Drawing.Point(1113, 9);
			this.KhachHangDVO_TenKhachHang.MaxLength = 50;
			this.KhachHangDVO_TenKhachHang.MouseState = MaterialSkin.MouseState.OUT;
			this.KhachHangDVO_TenKhachHang.Multiline = false;
			this.KhachHangDVO_TenKhachHang.Name = "KhachHangDVO_TenKhachHang";
			this.KhachHangDVO_TenKhachHang.Size = new System.Drawing.Size(350, 50);
			this.KhachHangDVO_TenKhachHang.TabIndex = 52;
			this.KhachHangDVO_TenKhachHang.Text = "";
			this.KhachHangDVO_TenKhachHang.TrailingIcon = null;
			// 
			// TabPageKhachHang_TaoKhachHang
			// 
			this.TabPageKhachHang_TaoKhachHang.AutoSize = false;
			this.TabPageKhachHang_TaoKhachHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageKhachHang_TaoKhachHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageKhachHang_TaoKhachHang.Depth = 0;
			this.TabPageKhachHang_TaoKhachHang.HighEmphasis = true;
			this.TabPageKhachHang_TaoKhachHang.Icon = null;
			this.TabPageKhachHang_TaoKhachHang.Location = new System.Drawing.Point(1113, 623);
			this.TabPageKhachHang_TaoKhachHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageKhachHang_TaoKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageKhachHang_TaoKhachHang.Name = "TabPageKhachHang_TaoKhachHang";
			this.TabPageKhachHang_TaoKhachHang.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageKhachHang_TaoKhachHang.Size = new System.Drawing.Size(151, 36);
			this.TabPageKhachHang_TaoKhachHang.TabIndex = 50;
			this.TabPageKhachHang_TaoKhachHang.TabStop = false;
			this.TabPageKhachHang_TaoKhachHang.Text = "Tạo khách hàng";
			this.TabPageKhachHang_TaoKhachHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageKhachHang_TaoKhachHang.UseAccentColor = false;
			this.TabPageKhachHang_TaoKhachHang.UseVisualStyleBackColor = true;
			// 
			// TabPageKhachHang_MaterialListView
			// 
			this.TabPageKhachHang_MaterialListView.AutoSizeTable = false;
			this.TabPageKhachHang_MaterialListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.TabPageKhachHang_MaterialListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TabPageKhachHang_MaterialListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
			this.TabPageKhachHang_MaterialListView.Depth = 0;
			this.TabPageKhachHang_MaterialListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPageKhachHang_MaterialListView.FullRowSelect = true;
			this.TabPageKhachHang_MaterialListView.HideSelection = false;
			this.TabPageKhachHang_MaterialListView.Location = new System.Drawing.Point(7, 6);
			this.TabPageKhachHang_MaterialListView.MinimumSize = new System.Drawing.Size(200, 100);
			this.TabPageKhachHang_MaterialListView.MouseLocation = new System.Drawing.Point(-1, -1);
			this.TabPageKhachHang_MaterialListView.MouseState = MaterialSkin.MouseState.OUT;
			this.TabPageKhachHang_MaterialListView.Name = "TabPageKhachHang_MaterialListView";
			this.TabPageKhachHang_MaterialListView.OwnerDraw = true;
			this.TabPageKhachHang_MaterialListView.Size = new System.Drawing.Size(1099, 748);
			this.TabPageKhachHang_MaterialListView.TabIndex = 49;
			this.TabPageKhachHang_MaterialListView.UseCompatibleStateImageBehavior = false;
			this.TabPageKhachHang_MaterialListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "STT";
			this.columnHeader15.Width = 59;
			// 
			// columnHeader16
			// 
			this.columnHeader16.Text = "Mã Khách Hàng";
			this.columnHeader16.Width = 145;
			// 
			// columnHeader17
			// 
			this.columnHeader17.Text = "Tên Khách Hàng";
			this.columnHeader17.Width = 300;
			// 
			// columnHeader18
			// 
			this.columnHeader18.Text = "Địa Chỉ";
			this.columnHeader18.Width = 429;
			// 
			// columnHeader19
			// 
			this.columnHeader19.Text = "Số Điện Thoại";
			this.columnHeader19.Width = 120;
			// 
			// TabPageNhaCungCap
			// 
			this.TabPageNhaCungCap.Controls.Add(this.TabPageNhaCungCap_XoaNhaCungCap);
			this.TabPageNhaCungCap.Controls.Add(this.TabPageNhaCungCap_RefreshNhaCungCap);
			this.TabPageNhaCungCap.Controls.Add(this.TabPageNhaCungCap_SuaNCC);
			this.TabPageNhaCungCap.Controls.Add(this.TabPageNhaCungCap_LichSuNhapHang);
			this.TabPageNhaCungCap.Controls.Add(this.TabPageNhaCungCap_SearchNhaCungCap);
			this.TabPageNhaCungCap.Controls.Add(this.TabPageNhaCungCap_XuatExcelNCC);
			this.TabPageNhaCungCap.Controls.Add(this.TabPageNhaCungCap_TaoNhaCungCap);
			this.TabPageNhaCungCap.Controls.Add(this.NhaCungCapDVO_DienThoai_Validation);
			this.TabPageNhaCungCap.Controls.Add(this.NhaCungCapDVO_DienThoai);
			this.TabPageNhaCungCap.Controls.Add(this.NhaCungCapDVO_DiaChi_Validation);
			this.TabPageNhaCungCap.Controls.Add(this.NhaCungCapDVO_TenNhaCungCap_Validation);
			this.TabPageNhaCungCap.Controls.Add(this.NhaCungCapDVO_DiaChi);
			this.TabPageNhaCungCap.Controls.Add(this.NhaCungCapDVO_TenNhaCungCap);
			this.TabPageNhaCungCap.Controls.Add(this.TabPageNhaCungCap_MaterialListView);
			this.TabPageNhaCungCap.ImageKey = "icons8-administrator-male-32.png";
			this.TabPageNhaCungCap.Location = new System.Drawing.Point(4, 39);
			this.TabPageNhaCungCap.Name = "TabPageNhaCungCap";
			this.TabPageNhaCungCap.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageNhaCungCap.Size = new System.Drawing.Size(1473, 760);
			this.TabPageNhaCungCap.TabIndex = 5;
			this.TabPageNhaCungCap.Text = "Nhà Cung Cấp";
			this.TabPageNhaCungCap.UseVisualStyleBackColor = true;
			// 
			// TabPageNhaCungCap_XoaNhaCungCap
			// 
			this.TabPageNhaCungCap_XoaNhaCungCap.AutoSize = false;
			this.TabPageNhaCungCap_XoaNhaCungCap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhaCungCap_XoaNhaCungCap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhaCungCap_XoaNhaCungCap.Depth = 0;
			this.TabPageNhaCungCap_XoaNhaCungCap.HighEmphasis = true;
			this.TabPageNhaCungCap_XoaNhaCungCap.Icon = null;
			this.TabPageNhaCungCap_XoaNhaCungCap.Location = new System.Drawing.Point(1109, 572);
			this.TabPageNhaCungCap_XoaNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhaCungCap_XoaNhaCungCap.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhaCungCap_XoaNhaCungCap.Name = "TabPageNhaCungCap_XoaNhaCungCap";
			this.TabPageNhaCungCap_XoaNhaCungCap.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhaCungCap_XoaNhaCungCap.Size = new System.Drawing.Size(151, 36);
			this.TabPageNhaCungCap_XoaNhaCungCap.TabIndex = 80;
			this.TabPageNhaCungCap_XoaNhaCungCap.TabStop = false;
			this.TabPageNhaCungCap_XoaNhaCungCap.Text = "Xóa Nhà Cung Cấp";
			this.TabPageNhaCungCap_XoaNhaCungCap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhaCungCap_XoaNhaCungCap.UseAccentColor = false;
			this.TabPageNhaCungCap_XoaNhaCungCap.UseVisualStyleBackColor = true;
			// 
			// TabPageNhaCungCap_RefreshNhaCungCap
			// 
			this.TabPageNhaCungCap_RefreshNhaCungCap.AutoSize = false;
			this.TabPageNhaCungCap_RefreshNhaCungCap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhaCungCap_RefreshNhaCungCap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhaCungCap_RefreshNhaCungCap.Depth = 0;
			this.TabPageNhaCungCap_RefreshNhaCungCap.HighEmphasis = true;
			this.TabPageNhaCungCap_RefreshNhaCungCap.Icon = null;
			this.TabPageNhaCungCap_RefreshNhaCungCap.Location = new System.Drawing.Point(1310, 716);
			this.TabPageNhaCungCap_RefreshNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhaCungCap_RefreshNhaCungCap.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhaCungCap_RefreshNhaCungCap.Name = "TabPageNhaCungCap_RefreshNhaCungCap";
			this.TabPageNhaCungCap_RefreshNhaCungCap.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhaCungCap_RefreshNhaCungCap.Size = new System.Drawing.Size(153, 36);
			this.TabPageNhaCungCap_RefreshNhaCungCap.TabIndex = 78;
			this.TabPageNhaCungCap_RefreshNhaCungCap.TabStop = false;
			this.TabPageNhaCungCap_RefreshNhaCungCap.Text = "Làm Mới";
			this.TabPageNhaCungCap_RefreshNhaCungCap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhaCungCap_RefreshNhaCungCap.UseAccentColor = false;
			this.TabPageNhaCungCap_RefreshNhaCungCap.UseVisualStyleBackColor = true;
			// 
			// TabPageNhaCungCap_SuaNCC
			// 
			this.TabPageNhaCungCap_SuaNCC.AutoSize = false;
			this.TabPageNhaCungCap_SuaNCC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhaCungCap_SuaNCC.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhaCungCap_SuaNCC.Depth = 0;
			this.TabPageNhaCungCap_SuaNCC.HighEmphasis = true;
			this.TabPageNhaCungCap_SuaNCC.Icon = null;
			this.TabPageNhaCungCap_SuaNCC.Location = new System.Drawing.Point(1109, 716);
			this.TabPageNhaCungCap_SuaNCC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhaCungCap_SuaNCC.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhaCungCap_SuaNCC.Name = "TabPageNhaCungCap_SuaNCC";
			this.TabPageNhaCungCap_SuaNCC.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhaCungCap_SuaNCC.Size = new System.Drawing.Size(151, 36);
			this.TabPageNhaCungCap_SuaNCC.TabIndex = 75;
			this.TabPageNhaCungCap_SuaNCC.TabStop = false;
			this.TabPageNhaCungCap_SuaNCC.Text = "Sửa thông tin";
			this.TabPageNhaCungCap_SuaNCC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhaCungCap_SuaNCC.UseAccentColor = false;
			this.TabPageNhaCungCap_SuaNCC.UseVisualStyleBackColor = true;
			// 
			// TabPageNhaCungCap_LichSuNhapHang
			// 
			this.TabPageNhaCungCap_LichSuNhapHang.AutoSize = false;
			this.TabPageNhaCungCap_LichSuNhapHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhaCungCap_LichSuNhapHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhaCungCap_LichSuNhapHang.Depth = 0;
			this.TabPageNhaCungCap_LichSuNhapHang.HighEmphasis = true;
			this.TabPageNhaCungCap_LichSuNhapHang.Icon = null;
			this.TabPageNhaCungCap_LichSuNhapHang.Location = new System.Drawing.Point(1310, 620);
			this.TabPageNhaCungCap_LichSuNhapHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhaCungCap_LichSuNhapHang.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhaCungCap_LichSuNhapHang.Name = "TabPageNhaCungCap_LichSuNhapHang";
			this.TabPageNhaCungCap_LichSuNhapHang.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhaCungCap_LichSuNhapHang.Size = new System.Drawing.Size(153, 36);
			this.TabPageNhaCungCap_LichSuNhapHang.TabIndex = 77;
			this.TabPageNhaCungCap_LichSuNhapHang.TabStop = false;
			this.TabPageNhaCungCap_LichSuNhapHang.Text = "Lịch sử nhập hàng";
			this.TabPageNhaCungCap_LichSuNhapHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhaCungCap_LichSuNhapHang.UseAccentColor = false;
			this.TabPageNhaCungCap_LichSuNhapHang.UseVisualStyleBackColor = true;
			// 
			// TabPageNhaCungCap_SearchNhaCungCap
			// 
			this.TabPageNhaCungCap_SearchNhaCungCap.AutoSize = false;
			this.TabPageNhaCungCap_SearchNhaCungCap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhaCungCap_SearchNhaCungCap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhaCungCap_SearchNhaCungCap.Depth = 0;
			this.TabPageNhaCungCap_SearchNhaCungCap.HighEmphasis = true;
			this.TabPageNhaCungCap_SearchNhaCungCap.Icon = null;
			this.TabPageNhaCungCap_SearchNhaCungCap.Location = new System.Drawing.Point(1109, 668);
			this.TabPageNhaCungCap_SearchNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhaCungCap_SearchNhaCungCap.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhaCungCap_SearchNhaCungCap.Name = "TabPageNhaCungCap_SearchNhaCungCap";
			this.TabPageNhaCungCap_SearchNhaCungCap.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhaCungCap_SearchNhaCungCap.Size = new System.Drawing.Size(151, 36);
			this.TabPageNhaCungCap_SearchNhaCungCap.TabIndex = 74;
			this.TabPageNhaCungCap_SearchNhaCungCap.TabStop = false;
			this.TabPageNhaCungCap_SearchNhaCungCap.Text = "Tìm kiếm";
			this.TabPageNhaCungCap_SearchNhaCungCap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhaCungCap_SearchNhaCungCap.UseAccentColor = false;
			this.TabPageNhaCungCap_SearchNhaCungCap.UseVisualStyleBackColor = true;
			// 
			// TabPageNhaCungCap_XuatExcelNCC
			// 
			this.TabPageNhaCungCap_XuatExcelNCC.AutoSize = false;
			this.TabPageNhaCungCap_XuatExcelNCC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhaCungCap_XuatExcelNCC.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhaCungCap_XuatExcelNCC.Depth = 0;
			this.TabPageNhaCungCap_XuatExcelNCC.HighEmphasis = true;
			this.TabPageNhaCungCap_XuatExcelNCC.Icon = null;
			this.TabPageNhaCungCap_XuatExcelNCC.Location = new System.Drawing.Point(1310, 668);
			this.TabPageNhaCungCap_XuatExcelNCC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhaCungCap_XuatExcelNCC.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhaCungCap_XuatExcelNCC.Name = "TabPageNhaCungCap_XuatExcelNCC";
			this.TabPageNhaCungCap_XuatExcelNCC.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhaCungCap_XuatExcelNCC.Size = new System.Drawing.Size(153, 36);
			this.TabPageNhaCungCap_XuatExcelNCC.TabIndex = 76;
			this.TabPageNhaCungCap_XuatExcelNCC.TabStop = false;
			this.TabPageNhaCungCap_XuatExcelNCC.Text = "Xuất Excel";
			this.TabPageNhaCungCap_XuatExcelNCC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhaCungCap_XuatExcelNCC.UseAccentColor = false;
			this.TabPageNhaCungCap_XuatExcelNCC.UseVisualStyleBackColor = true;
			// 
			// TabPageNhaCungCap_TaoNhaCungCap
			// 
			this.TabPageNhaCungCap_TaoNhaCungCap.AutoSize = false;
			this.TabPageNhaCungCap_TaoNhaCungCap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNhaCungCap_TaoNhaCungCap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNhaCungCap_TaoNhaCungCap.Depth = 0;
			this.TabPageNhaCungCap_TaoNhaCungCap.HighEmphasis = true;
			this.TabPageNhaCungCap_TaoNhaCungCap.Icon = null;
			this.TabPageNhaCungCap_TaoNhaCungCap.Location = new System.Drawing.Point(1109, 620);
			this.TabPageNhaCungCap_TaoNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNhaCungCap_TaoNhaCungCap.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNhaCungCap_TaoNhaCungCap.Name = "TabPageNhaCungCap_TaoNhaCungCap";
			this.TabPageNhaCungCap_TaoNhaCungCap.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNhaCungCap_TaoNhaCungCap.Size = new System.Drawing.Size(151, 36);
			this.TabPageNhaCungCap_TaoNhaCungCap.TabIndex = 73;
			this.TabPageNhaCungCap_TaoNhaCungCap.TabStop = false;
			this.TabPageNhaCungCap_TaoNhaCungCap.Text = "Tạo nhà cung cấp";
			this.TabPageNhaCungCap_TaoNhaCungCap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNhaCungCap_TaoNhaCungCap.UseAccentColor = false;
			this.TabPageNhaCungCap_TaoNhaCungCap.UseVisualStyleBackColor = true;
			// 
			// NhaCungCapDVO_DienThoai_Validation
			// 
			this.NhaCungCapDVO_DienThoai_Validation.Location = new System.Drawing.Point(1109, 220);
			this.NhaCungCapDVO_DienThoai_Validation.Name = "NhaCungCapDVO_DienThoai_Validation";
			this.NhaCungCapDVO_DienThoai_Validation.Size = new System.Drawing.Size(356, 23);
			this.NhaCungCapDVO_DienThoai_Validation.TabIndex = 68;
			this.NhaCungCapDVO_DienThoai_Validation.Text = "NhaCungCapDVO_DienThoai_Validation";
			// 
			// NhaCungCapDVO_DienThoai
			// 
			this.NhaCungCapDVO_DienThoai.AnimateReadOnly = false;
			this.NhaCungCapDVO_DienThoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NhaCungCapDVO_DienThoai.Depth = 0;
			this.NhaCungCapDVO_DienThoai.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.NhaCungCapDVO_DienThoai.LeadingIcon = null;
			this.NhaCungCapDVO_DienThoai.Location = new System.Drawing.Point(1109, 167);
			this.NhaCungCapDVO_DienThoai.MaxLength = 50;
			this.NhaCungCapDVO_DienThoai.MouseState = MaterialSkin.MouseState.OUT;
			this.NhaCungCapDVO_DienThoai.Multiline = false;
			this.NhaCungCapDVO_DienThoai.Name = "NhaCungCapDVO_DienThoai";
			this.NhaCungCapDVO_DienThoai.Size = new System.Drawing.Size(354, 50);
			this.NhaCungCapDVO_DienThoai.TabIndex = 64;
			this.NhaCungCapDVO_DienThoai.Text = "";
			this.NhaCungCapDVO_DienThoai.TrailingIcon = null;
			// 
			// NhaCungCapDVO_DiaChi_Validation
			// 
			this.NhaCungCapDVO_DiaChi_Validation.Location = new System.Drawing.Point(1109, 141);
			this.NhaCungCapDVO_DiaChi_Validation.Name = "NhaCungCapDVO_DiaChi_Validation";
			this.NhaCungCapDVO_DiaChi_Validation.Size = new System.Drawing.Size(356, 23);
			this.NhaCungCapDVO_DiaChi_Validation.TabIndex = 65;
			this.NhaCungCapDVO_DiaChi_Validation.Text = "NhaCungCapDVO_DiaChi_Validation";
			// 
			// NhaCungCapDVO_TenNhaCungCap_Validation
			// 
			this.NhaCungCapDVO_TenNhaCungCap_Validation.Location = new System.Drawing.Point(1109, 61);
			this.NhaCungCapDVO_TenNhaCungCap_Validation.Name = "NhaCungCapDVO_TenNhaCungCap_Validation";
			this.NhaCungCapDVO_TenNhaCungCap_Validation.Size = new System.Drawing.Size(356, 23);
			this.NhaCungCapDVO_TenNhaCungCap_Validation.TabIndex = 62;
			this.NhaCungCapDVO_TenNhaCungCap_Validation.Text = "NhaCungCapDVO_TenNhaCungCap_Validation";
			// 
			// NhaCungCapDVO_DiaChi
			// 
			this.NhaCungCapDVO_DiaChi.AnimateReadOnly = false;
			this.NhaCungCapDVO_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NhaCungCapDVO_DiaChi.Depth = 0;
			this.NhaCungCapDVO_DiaChi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.NhaCungCapDVO_DiaChi.LeadingIcon = null;
			this.NhaCungCapDVO_DiaChi.Location = new System.Drawing.Point(1109, 88);
			this.NhaCungCapDVO_DiaChi.MaxLength = 50;
			this.NhaCungCapDVO_DiaChi.MouseState = MaterialSkin.MouseState.OUT;
			this.NhaCungCapDVO_DiaChi.Multiline = false;
			this.NhaCungCapDVO_DiaChi.Name = "NhaCungCapDVO_DiaChi";
			this.NhaCungCapDVO_DiaChi.Size = new System.Drawing.Size(354, 50);
			this.NhaCungCapDVO_DiaChi.TabIndex = 63;
			this.NhaCungCapDVO_DiaChi.Text = "";
			this.NhaCungCapDVO_DiaChi.TrailingIcon = null;
			// 
			// NhaCungCapDVO_TenNhaCungCap
			// 
			this.NhaCungCapDVO_TenNhaCungCap.AnimateReadOnly = false;
			this.NhaCungCapDVO_TenNhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NhaCungCapDVO_TenNhaCungCap.Depth = 0;
			this.NhaCungCapDVO_TenNhaCungCap.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.NhaCungCapDVO_TenNhaCungCap.LeadingIcon = null;
			this.NhaCungCapDVO_TenNhaCungCap.Location = new System.Drawing.Point(1109, 9);
			this.NhaCungCapDVO_TenNhaCungCap.MaxLength = 50;
			this.NhaCungCapDVO_TenNhaCungCap.MouseState = MaterialSkin.MouseState.OUT;
			this.NhaCungCapDVO_TenNhaCungCap.Multiline = false;
			this.NhaCungCapDVO_TenNhaCungCap.Name = "NhaCungCapDVO_TenNhaCungCap";
			this.NhaCungCapDVO_TenNhaCungCap.Size = new System.Drawing.Size(354, 50);
			this.NhaCungCapDVO_TenNhaCungCap.TabIndex = 61;
			this.NhaCungCapDVO_TenNhaCungCap.Text = "";
			this.NhaCungCapDVO_TenNhaCungCap.TrailingIcon = null;
			// 
			// TabPageNhaCungCap_MaterialListView
			// 
			this.TabPageNhaCungCap_MaterialListView.AutoSizeTable = false;
			this.TabPageNhaCungCap_MaterialListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.TabPageNhaCungCap_MaterialListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TabPageNhaCungCap_MaterialListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader24,
            this.columnHeader23});
			this.TabPageNhaCungCap_MaterialListView.Depth = 0;
			this.TabPageNhaCungCap_MaterialListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPageNhaCungCap_MaterialListView.FullRowSelect = true;
			this.TabPageNhaCungCap_MaterialListView.HideSelection = false;
			this.TabPageNhaCungCap_MaterialListView.Location = new System.Drawing.Point(7, 6);
			this.TabPageNhaCungCap_MaterialListView.MinimumSize = new System.Drawing.Size(200, 100);
			this.TabPageNhaCungCap_MaterialListView.MouseLocation = new System.Drawing.Point(-1, -1);
			this.TabPageNhaCungCap_MaterialListView.MouseState = MaterialSkin.MouseState.OUT;
			this.TabPageNhaCungCap_MaterialListView.Name = "TabPageNhaCungCap_MaterialListView";
			this.TabPageNhaCungCap_MaterialListView.OwnerDraw = true;
			this.TabPageNhaCungCap_MaterialListView.Size = new System.Drawing.Size(1099, 748);
			this.TabPageNhaCungCap_MaterialListView.TabIndex = 60;
			this.TabPageNhaCungCap_MaterialListView.UseCompatibleStateImageBehavior = false;
			this.TabPageNhaCungCap_MaterialListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader20
			// 
			this.columnHeader20.Text = "STT";
			this.columnHeader20.Width = 59;
			// 
			// columnHeader21
			// 
			this.columnHeader21.Text = "Mã Nhà Cung Cấp";
			this.columnHeader21.Width = 145;
			// 
			// columnHeader22
			// 
			this.columnHeader22.Text = "Tên Nhà Cung Cấp";
			this.columnHeader22.Width = 300;
			// 
			// columnHeader24
			// 
			this.columnHeader24.Text = "Số Điện Thoại";
			this.columnHeader24.Width = 120;
			// 
			// columnHeader23
			// 
			this.columnHeader23.Text = "Địa Chỉ";
			this.columnHeader23.Width = 429;
			// 
			// TabPageSanPham
			// 
			this.TabPageSanPham.Controls.Add(this.TabPageSanPham_ButtonDSKM);
			this.TabPageSanPham.Controls.Add(this.TabPageSanPham_ButtonLoadSP);
			this.TabPageSanPham.Controls.Add(this.TabPageSanPham_LabelThoiGianBaoHanh);
			this.TabPageSanPham.Controls.Add(this.TabPageSanPham_LabelSoLuongTonKho);
			this.TabPageSanPham.Controls.Add(this.TabPageSanPham_LabelDonGiaNhap);
			this.TabPageSanPham.Controls.Add(this.TabPageSanPham_LabelDonGiaBan);
			this.TabPageSanPham.Controls.Add(this.TabPageSanPham_NhapMoiTimKiem);
			this.TabPageSanPham.Controls.Add(this.TabPageSanPham_ButtonXuatRaFileExcel);
			this.TabPageSanPham.Controls.Add(this.DMSanPhamDVO_SoLuongTonKhoMax);
			this.TabPageSanPham.Controls.Add(this.DMSanPhamDVO_DonGiaNhapMax);
			this.TabPageSanPham.Controls.Add(this.DMSanPhamDVO_SoLuongTonKhoMin);
			this.TabPageSanPham.Controls.Add(this.DMSanPhamDVO_DonGiaNhapMin);
			this.TabPageSanPham.Controls.Add(this.DMSanPhamDVO_DonGiaBanMax);
			this.TabPageSanPham.Controls.Add(this.DMSanPhamDVO_TenSanPham);
			this.TabPageSanPham.Controls.Add(this.DMSanPhamDVO_DonGiaBanMin);
			this.TabPageSanPham.Controls.Add(this.TabPageSanPham_ButtonXoaSanPham);
			this.TabPageSanPham.Controls.Add(this.TabPageSanPham_ButtonThemSanPham);
			this.TabPageSanPham.Controls.Add(this.DMSanPhamDVO_MaSanPham);
			this.TabPageSanPham.Controls.Add(this.TabPageSanPham_ButtonSuaSanPham);
			this.TabPageSanPham.Controls.Add(this.TabPageSanPham_ButtonTimKiem);
			this.TabPageSanPham.Controls.Add(this.DMSanPhamDVO_ThoiGianBaoHanhMax);
			this.TabPageSanPham.Controls.Add(this.DMSanPhamDVO_ThoiGianBaoHanhMin);
			this.TabPageSanPham.Controls.Add(this.TabPageSanPham_MaterialListView);
			this.TabPageSanPham.ImageKey = "icons8-new-product-32.png";
			this.TabPageSanPham.Location = new System.Drawing.Point(4, 39);
			this.TabPageSanPham.Name = "TabPageSanPham";
			this.TabPageSanPham.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageSanPham.Size = new System.Drawing.Size(1473, 760);
			this.TabPageSanPham.TabIndex = 6;
			this.TabPageSanPham.Text = "Sản Phẩm";
			this.TabPageSanPham.UseVisualStyleBackColor = true;
			// 
			// TabPageSanPham_ButtonDSKM
			// 
			this.TabPageSanPham_ButtonDSKM.AutoSize = false;
			this.TabPageSanPham_ButtonDSKM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageSanPham_ButtonDSKM.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageSanPham_ButtonDSKM.Depth = 0;
			this.TabPageSanPham_ButtonDSKM.HighEmphasis = true;
			this.TabPageSanPham_ButtonDSKM.Icon = null;
			this.TabPageSanPham_ButtonDSKM.Location = new System.Drawing.Point(1005, 715);
			this.TabPageSanPham_ButtonDSKM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageSanPham_ButtonDSKM.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageSanPham_ButtonDSKM.Name = "TabPageSanPham_ButtonDSKM";
			this.TabPageSanPham_ButtonDSKM.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageSanPham_ButtonDSKM.Size = new System.Drawing.Size(160, 36);
			this.TabPageSanPham_ButtonDSKM.TabIndex = 71;
			this.TabPageSanPham_ButtonDSKM.Text = "Danh sách giảm giá";
			this.TabPageSanPham_ButtonDSKM.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageSanPham_ButtonDSKM.UseAccentColor = false;
			this.TabPageSanPham_ButtonDSKM.UseVisualStyleBackColor = true;
			// 
			// TabPageSanPham_ButtonLoadSP
			// 
			this.TabPageSanPham_ButtonLoadSP.AutoSize = false;
			this.TabPageSanPham_ButtonLoadSP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageSanPham_ButtonLoadSP.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageSanPham_ButtonLoadSP.Depth = 0;
			this.TabPageSanPham_ButtonLoadSP.HighEmphasis = true;
			this.TabPageSanPham_ButtonLoadSP.Icon = null;
			this.TabPageSanPham_ButtonLoadSP.Location = new System.Drawing.Point(1304, 715);
			this.TabPageSanPham_ButtonLoadSP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageSanPham_ButtonLoadSP.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageSanPham_ButtonLoadSP.Name = "TabPageSanPham_ButtonLoadSP";
			this.TabPageSanPham_ButtonLoadSP.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageSanPham_ButtonLoadSP.Size = new System.Drawing.Size(160, 36);
			this.TabPageSanPham_ButtonLoadSP.TabIndex = 70;
			this.TabPageSanPham_ButtonLoadSP.Text = "Danh sách tất cả sản phẩm";
			this.TabPageSanPham_ButtonLoadSP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageSanPham_ButtonLoadSP.UseAccentColor = false;
			this.TabPageSanPham_ButtonLoadSP.UseVisualStyleBackColor = true;
			// 
			// TabPageSanPham_LabelThoiGianBaoHanh
			// 
			this.TabPageSanPham_LabelThoiGianBaoHanh.Location = new System.Drawing.Point(1005, 455);
			this.TabPageSanPham_LabelThoiGianBaoHanh.Name = "TabPageSanPham_LabelThoiGianBaoHanh";
			this.TabPageSanPham_LabelThoiGianBaoHanh.Size = new System.Drawing.Size(459, 23);
			this.TabPageSanPham_LabelThoiGianBaoHanh.TabIndex = 69;
			this.TabPageSanPham_LabelThoiGianBaoHanh.Text = "Thời gian bảo hành";
			// 
			// TabPageSanPham_LabelSoLuongTonKho
			// 
			this.TabPageSanPham_LabelSoLuongTonKho.Location = new System.Drawing.Point(1005, 373);
			this.TabPageSanPham_LabelSoLuongTonKho.Name = "TabPageSanPham_LabelSoLuongTonKho";
			this.TabPageSanPham_LabelSoLuongTonKho.Size = new System.Drawing.Size(459, 23);
			this.TabPageSanPham_LabelSoLuongTonKho.TabIndex = 68;
			this.TabPageSanPham_LabelSoLuongTonKho.Text = "Số lượng tồn kho";
			// 
			// TabPageSanPham_LabelDonGiaNhap
			// 
			this.TabPageSanPham_LabelDonGiaNhap.Location = new System.Drawing.Point(1005, 263);
			this.TabPageSanPham_LabelDonGiaNhap.Name = "TabPageSanPham_LabelDonGiaNhap";
			this.TabPageSanPham_LabelDonGiaNhap.Size = new System.Drawing.Size(459, 23);
			this.TabPageSanPham_LabelDonGiaNhap.TabIndex = 67;
			this.TabPageSanPham_LabelDonGiaNhap.Text = "Đơn giá nhập";
			// 
			// TabPageSanPham_LabelDonGiaBan
			// 
			this.TabPageSanPham_LabelDonGiaBan.Location = new System.Drawing.Point(1005, 158);
			this.TabPageSanPham_LabelDonGiaBan.Name = "TabPageSanPham_LabelDonGiaBan";
			this.TabPageSanPham_LabelDonGiaBan.Size = new System.Drawing.Size(459, 23);
			this.TabPageSanPham_LabelDonGiaBan.TabIndex = 66;
			this.TabPageSanPham_LabelDonGiaBan.Text = "Đơn giá bán";
			// 
			// TabPageSanPham_NhapMoiTimKiem
			// 
			this.TabPageSanPham_NhapMoiTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageSanPham_NhapMoiTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageSanPham_NhapMoiTimKiem.Depth = 0;
			this.TabPageSanPham_NhapMoiTimKiem.HighEmphasis = true;
			this.TabPageSanPham_NhapMoiTimKiem.Icon = null;
			this.TabPageSanPham_NhapMoiTimKiem.Location = new System.Drawing.Point(1005, 619);
			this.TabPageSanPham_NhapMoiTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageSanPham_NhapMoiTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageSanPham_NhapMoiTimKiem.Name = "TabPageSanPham_NhapMoiTimKiem";
			this.TabPageSanPham_NhapMoiTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageSanPham_NhapMoiTimKiem.Size = new System.Drawing.Size(160, 36);
			this.TabPageSanPham_NhapMoiTimKiem.TabIndex = 51;
			this.TabPageSanPham_NhapMoiTimKiem.Text = "Nhập mới tìm kiếm";
			this.TabPageSanPham_NhapMoiTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageSanPham_NhapMoiTimKiem.UseAccentColor = false;
			this.TabPageSanPham_NhapMoiTimKiem.UseVisualStyleBackColor = true;
			// 
			// TabPageSanPham_ButtonXuatRaFileExcel
			// 
			this.TabPageSanPham_ButtonXuatRaFileExcel.AutoSize = false;
			this.TabPageSanPham_ButtonXuatRaFileExcel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageSanPham_ButtonXuatRaFileExcel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageSanPham_ButtonXuatRaFileExcel.Depth = 0;
			this.TabPageSanPham_ButtonXuatRaFileExcel.HighEmphasis = true;
			this.TabPageSanPham_ButtonXuatRaFileExcel.Icon = null;
			this.TabPageSanPham_ButtonXuatRaFileExcel.Location = new System.Drawing.Point(1005, 667);
			this.TabPageSanPham_ButtonXuatRaFileExcel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageSanPham_ButtonXuatRaFileExcel.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageSanPham_ButtonXuatRaFileExcel.Name = "TabPageSanPham_ButtonXuatRaFileExcel";
			this.TabPageSanPham_ButtonXuatRaFileExcel.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageSanPham_ButtonXuatRaFileExcel.Size = new System.Drawing.Size(160, 36);
			this.TabPageSanPham_ButtonXuatRaFileExcel.TabIndex = 48;
			this.TabPageSanPham_ButtonXuatRaFileExcel.Text = "Xuất ra file excel";
			this.TabPageSanPham_ButtonXuatRaFileExcel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageSanPham_ButtonXuatRaFileExcel.UseAccentColor = false;
			this.TabPageSanPham_ButtonXuatRaFileExcel.UseVisualStyleBackColor = true;
			// 
			// DMSanPhamDVO_SoLuongTonKhoMax
			// 
			this.DMSanPhamDVO_SoLuongTonKhoMax.AnimateReadOnly = false;
			this.DMSanPhamDVO_SoLuongTonKhoMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DMSanPhamDVO_SoLuongTonKhoMax.Depth = 0;
			this.DMSanPhamDVO_SoLuongTonKhoMax.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.DMSanPhamDVO_SoLuongTonKhoMax.LeadingIcon = null;
			this.DMSanPhamDVO_SoLuongTonKhoMax.Location = new System.Drawing.Point(1251, 399);
			this.DMSanPhamDVO_SoLuongTonKhoMax.MaxLength = 50;
			this.DMSanPhamDVO_SoLuongTonKhoMax.MouseState = MaterialSkin.MouseState.OUT;
			this.DMSanPhamDVO_SoLuongTonKhoMax.Multiline = false;
			this.DMSanPhamDVO_SoLuongTonKhoMax.Name = "DMSanPhamDVO_SoLuongTonKhoMax";
			this.DMSanPhamDVO_SoLuongTonKhoMax.Size = new System.Drawing.Size(216, 50);
			this.DMSanPhamDVO_SoLuongTonKhoMax.TabIndex = 47;
			this.DMSanPhamDVO_SoLuongTonKhoMax.Text = "";
			this.DMSanPhamDVO_SoLuongTonKhoMax.TrailingIcon = null;
			// 
			// DMSanPhamDVO_DonGiaNhapMax
			// 
			this.DMSanPhamDVO_DonGiaNhapMax.AnimateReadOnly = false;
			this.DMSanPhamDVO_DonGiaNhapMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DMSanPhamDVO_DonGiaNhapMax.Depth = 0;
			this.DMSanPhamDVO_DonGiaNhapMax.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.DMSanPhamDVO_DonGiaNhapMax.LeadingIcon = null;
			this.DMSanPhamDVO_DonGiaNhapMax.Location = new System.Drawing.Point(1251, 289);
			this.DMSanPhamDVO_DonGiaNhapMax.MaxLength = 50;
			this.DMSanPhamDVO_DonGiaNhapMax.MouseState = MaterialSkin.MouseState.OUT;
			this.DMSanPhamDVO_DonGiaNhapMax.Multiline = false;
			this.DMSanPhamDVO_DonGiaNhapMax.Name = "DMSanPhamDVO_DonGiaNhapMax";
			this.DMSanPhamDVO_DonGiaNhapMax.Size = new System.Drawing.Size(216, 50);
			this.DMSanPhamDVO_DonGiaNhapMax.TabIndex = 46;
			this.DMSanPhamDVO_DonGiaNhapMax.Text = "";
			this.DMSanPhamDVO_DonGiaNhapMax.TrailingIcon = null;
			// 
			// DMSanPhamDVO_SoLuongTonKhoMin
			// 
			this.DMSanPhamDVO_SoLuongTonKhoMin.AnimateReadOnly = false;
			this.DMSanPhamDVO_SoLuongTonKhoMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DMSanPhamDVO_SoLuongTonKhoMin.Depth = 0;
			this.DMSanPhamDVO_SoLuongTonKhoMin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.DMSanPhamDVO_SoLuongTonKhoMin.LeadingIcon = null;
			this.DMSanPhamDVO_SoLuongTonKhoMin.Location = new System.Drawing.Point(1005, 399);
			this.DMSanPhamDVO_SoLuongTonKhoMin.MaxLength = 50;
			this.DMSanPhamDVO_SoLuongTonKhoMin.MouseState = MaterialSkin.MouseState.OUT;
			this.DMSanPhamDVO_SoLuongTonKhoMin.Multiline = false;
			this.DMSanPhamDVO_SoLuongTonKhoMin.Name = "DMSanPhamDVO_SoLuongTonKhoMin";
			this.DMSanPhamDVO_SoLuongTonKhoMin.Size = new System.Drawing.Size(216, 50);
			this.DMSanPhamDVO_SoLuongTonKhoMin.TabIndex = 43;
			this.DMSanPhamDVO_SoLuongTonKhoMin.Text = "";
			this.DMSanPhamDVO_SoLuongTonKhoMin.TrailingIcon = null;
			// 
			// DMSanPhamDVO_DonGiaNhapMin
			// 
			this.DMSanPhamDVO_DonGiaNhapMin.AnimateReadOnly = false;
			this.DMSanPhamDVO_DonGiaNhapMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DMSanPhamDVO_DonGiaNhapMin.Depth = 0;
			this.DMSanPhamDVO_DonGiaNhapMin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.DMSanPhamDVO_DonGiaNhapMin.LeadingIcon = null;
			this.DMSanPhamDVO_DonGiaNhapMin.Location = new System.Drawing.Point(1005, 289);
			this.DMSanPhamDVO_DonGiaNhapMin.MaxLength = 50;
			this.DMSanPhamDVO_DonGiaNhapMin.MouseState = MaterialSkin.MouseState.OUT;
			this.DMSanPhamDVO_DonGiaNhapMin.Multiline = false;
			this.DMSanPhamDVO_DonGiaNhapMin.Name = "DMSanPhamDVO_DonGiaNhapMin";
			this.DMSanPhamDVO_DonGiaNhapMin.Size = new System.Drawing.Size(216, 50);
			this.DMSanPhamDVO_DonGiaNhapMin.TabIndex = 42;
			this.DMSanPhamDVO_DonGiaNhapMin.Text = "";
			this.DMSanPhamDVO_DonGiaNhapMin.TrailingIcon = null;
			// 
			// DMSanPhamDVO_DonGiaBanMax
			// 
			this.DMSanPhamDVO_DonGiaBanMax.AnimateReadOnly = false;
			this.DMSanPhamDVO_DonGiaBanMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DMSanPhamDVO_DonGiaBanMax.Depth = 0;
			this.DMSanPhamDVO_DonGiaBanMax.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.DMSanPhamDVO_DonGiaBanMax.LeadingIcon = null;
			this.DMSanPhamDVO_DonGiaBanMax.Location = new System.Drawing.Point(1251, 184);
			this.DMSanPhamDVO_DonGiaBanMax.MaxLength = 50;
			this.DMSanPhamDVO_DonGiaBanMax.MouseState = MaterialSkin.MouseState.OUT;
			this.DMSanPhamDVO_DonGiaBanMax.Multiline = false;
			this.DMSanPhamDVO_DonGiaBanMax.Name = "DMSanPhamDVO_DonGiaBanMax";
			this.DMSanPhamDVO_DonGiaBanMax.Size = new System.Drawing.Size(216, 50);
			this.DMSanPhamDVO_DonGiaBanMax.TabIndex = 41;
			this.DMSanPhamDVO_DonGiaBanMax.Text = "";
			this.DMSanPhamDVO_DonGiaBanMax.TrailingIcon = null;
			// 
			// DMSanPhamDVO_TenSanPham
			// 
			this.DMSanPhamDVO_TenSanPham.AnimateReadOnly = false;
			this.DMSanPhamDVO_TenSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DMSanPhamDVO_TenSanPham.Depth = 0;
			this.DMSanPhamDVO_TenSanPham.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.DMSanPhamDVO_TenSanPham.LeadingIcon = null;
			this.DMSanPhamDVO_TenSanPham.Location = new System.Drawing.Point(1005, 83);
			this.DMSanPhamDVO_TenSanPham.MaxLength = 50;
			this.DMSanPhamDVO_TenSanPham.MouseState = MaterialSkin.MouseState.OUT;
			this.DMSanPhamDVO_TenSanPham.Multiline = false;
			this.DMSanPhamDVO_TenSanPham.Name = "DMSanPhamDVO_TenSanPham";
			this.DMSanPhamDVO_TenSanPham.Size = new System.Drawing.Size(462, 50);
			this.DMSanPhamDVO_TenSanPham.TabIndex = 40;
			this.DMSanPhamDVO_TenSanPham.Text = "";
			this.DMSanPhamDVO_TenSanPham.TrailingIcon = null;
			// 
			// DMSanPhamDVO_DonGiaBanMin
			// 
			this.DMSanPhamDVO_DonGiaBanMin.AnimateReadOnly = false;
			this.DMSanPhamDVO_DonGiaBanMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DMSanPhamDVO_DonGiaBanMin.Depth = 0;
			this.DMSanPhamDVO_DonGiaBanMin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.DMSanPhamDVO_DonGiaBanMin.LeadingIcon = null;
			this.DMSanPhamDVO_DonGiaBanMin.Location = new System.Drawing.Point(1005, 184);
			this.DMSanPhamDVO_DonGiaBanMin.MaxLength = 50;
			this.DMSanPhamDVO_DonGiaBanMin.MouseState = MaterialSkin.MouseState.OUT;
			this.DMSanPhamDVO_DonGiaBanMin.Multiline = false;
			this.DMSanPhamDVO_DonGiaBanMin.Name = "DMSanPhamDVO_DonGiaBanMin";
			this.DMSanPhamDVO_DonGiaBanMin.Size = new System.Drawing.Size(216, 50);
			this.DMSanPhamDVO_DonGiaBanMin.TabIndex = 37;
			this.DMSanPhamDVO_DonGiaBanMin.Text = "";
			this.DMSanPhamDVO_DonGiaBanMin.TrailingIcon = null;
			// 
			// TabPageSanPham_ButtonXoaSanPham
			// 
			this.TabPageSanPham_ButtonXoaSanPham.AutoSize = false;
			this.TabPageSanPham_ButtonXoaSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageSanPham_ButtonXoaSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageSanPham_ButtonXoaSanPham.Depth = 0;
			this.TabPageSanPham_ButtonXoaSanPham.HighEmphasis = true;
			this.TabPageSanPham_ButtonXoaSanPham.Icon = null;
			this.TabPageSanPham_ButtonXoaSanPham.Location = new System.Drawing.Point(1304, 667);
			this.TabPageSanPham_ButtonXoaSanPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageSanPham_ButtonXoaSanPham.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageSanPham_ButtonXoaSanPham.Name = "TabPageSanPham_ButtonXoaSanPham";
			this.TabPageSanPham_ButtonXoaSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageSanPham_ButtonXoaSanPham.Size = new System.Drawing.Size(160, 36);
			this.TabPageSanPham_ButtonXoaSanPham.TabIndex = 34;
			this.TabPageSanPham_ButtonXoaSanPham.Text = "Xóa sản phẩm";
			this.TabPageSanPham_ButtonXoaSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageSanPham_ButtonXoaSanPham.UseAccentColor = false;
			this.TabPageSanPham_ButtonXoaSanPham.UseVisualStyleBackColor = true;
			// 
			// TabPageSanPham_ButtonThemSanPham
			// 
			this.TabPageSanPham_ButtonThemSanPham.AutoSize = false;
			this.TabPageSanPham_ButtonThemSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageSanPham_ButtonThemSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageSanPham_ButtonThemSanPham.Depth = 0;
			this.TabPageSanPham_ButtonThemSanPham.HighEmphasis = true;
			this.TabPageSanPham_ButtonThemSanPham.Icon = null;
			this.TabPageSanPham_ButtonThemSanPham.Location = new System.Drawing.Point(1304, 571);
			this.TabPageSanPham_ButtonThemSanPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageSanPham_ButtonThemSanPham.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageSanPham_ButtonThemSanPham.Name = "TabPageSanPham_ButtonThemSanPham";
			this.TabPageSanPham_ButtonThemSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageSanPham_ButtonThemSanPham.Size = new System.Drawing.Size(160, 36);
			this.TabPageSanPham_ButtonThemSanPham.TabIndex = 32;
			this.TabPageSanPham_ButtonThemSanPham.Text = "Thêm sản phẩm";
			this.TabPageSanPham_ButtonThemSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageSanPham_ButtonThemSanPham.UseAccentColor = false;
			this.TabPageSanPham_ButtonThemSanPham.UseVisualStyleBackColor = true;
			// 
			// DMSanPhamDVO_MaSanPham
			// 
			this.DMSanPhamDVO_MaSanPham.AnimateReadOnly = false;
			this.DMSanPhamDVO_MaSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DMSanPhamDVO_MaSanPham.Depth = 0;
			this.DMSanPhamDVO_MaSanPham.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.DMSanPhamDVO_MaSanPham.LeadingIcon = null;
			this.DMSanPhamDVO_MaSanPham.Location = new System.Drawing.Point(1005, 6);
			this.DMSanPhamDVO_MaSanPham.MaxLength = 50;
			this.DMSanPhamDVO_MaSanPham.MouseState = MaterialSkin.MouseState.OUT;
			this.DMSanPhamDVO_MaSanPham.Multiline = false;
			this.DMSanPhamDVO_MaSanPham.Name = "DMSanPhamDVO_MaSanPham";
			this.DMSanPhamDVO_MaSanPham.Size = new System.Drawing.Size(462, 50);
			this.DMSanPhamDVO_MaSanPham.TabIndex = 33;
			this.DMSanPhamDVO_MaSanPham.Text = "";
			this.DMSanPhamDVO_MaSanPham.TrailingIcon = null;
			// 
			// TabPageSanPham_ButtonSuaSanPham
			// 
			this.TabPageSanPham_ButtonSuaSanPham.AutoSize = false;
			this.TabPageSanPham_ButtonSuaSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageSanPham_ButtonSuaSanPham.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageSanPham_ButtonSuaSanPham.Depth = 0;
			this.TabPageSanPham_ButtonSuaSanPham.HighEmphasis = true;
			this.TabPageSanPham_ButtonSuaSanPham.Icon = null;
			this.TabPageSanPham_ButtonSuaSanPham.Location = new System.Drawing.Point(1304, 619);
			this.TabPageSanPham_ButtonSuaSanPham.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageSanPham_ButtonSuaSanPham.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageSanPham_ButtonSuaSanPham.Name = "TabPageSanPham_ButtonSuaSanPham";
			this.TabPageSanPham_ButtonSuaSanPham.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageSanPham_ButtonSuaSanPham.Size = new System.Drawing.Size(160, 36);
			this.TabPageSanPham_ButtonSuaSanPham.TabIndex = 36;
			this.TabPageSanPham_ButtonSuaSanPham.Text = "Sửa sản phẩm";
			this.TabPageSanPham_ButtonSuaSanPham.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageSanPham_ButtonSuaSanPham.UseAccentColor = false;
			this.TabPageSanPham_ButtonSuaSanPham.UseVisualStyleBackColor = true;
			// 
			// TabPageSanPham_ButtonTimKiem
			// 
			this.TabPageSanPham_ButtonTimKiem.AutoSize = false;
			this.TabPageSanPham_ButtonTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageSanPham_ButtonTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageSanPham_ButtonTimKiem.Depth = 0;
			this.TabPageSanPham_ButtonTimKiem.HighEmphasis = true;
			this.TabPageSanPham_ButtonTimKiem.Icon = null;
			this.TabPageSanPham_ButtonTimKiem.Location = new System.Drawing.Point(1005, 571);
			this.TabPageSanPham_ButtonTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageSanPham_ButtonTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageSanPham_ButtonTimKiem.Name = "TabPageSanPham_ButtonTimKiem";
			this.TabPageSanPham_ButtonTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageSanPham_ButtonTimKiem.Size = new System.Drawing.Size(160, 36);
			this.TabPageSanPham_ButtonTimKiem.TabIndex = 35;
			this.TabPageSanPham_ButtonTimKiem.Text = "Tìm kiếm";
			this.TabPageSanPham_ButtonTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageSanPham_ButtonTimKiem.UseAccentColor = false;
			this.TabPageSanPham_ButtonTimKiem.UseVisualStyleBackColor = true;
			// 
			// DMSanPhamDVO_ThoiGianBaoHanhMax
			// 
			this.DMSanPhamDVO_ThoiGianBaoHanhMax.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.DMSanPhamDVO_ThoiGianBaoHanhMax.BorderSize = 0;
			this.DMSanPhamDVO_ThoiGianBaoHanhMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
			this.DMSanPhamDVO_ThoiGianBaoHanhMax.Location = new System.Drawing.Point(1251, 481);
			this.DMSanPhamDVO_ThoiGianBaoHanhMax.MinimumSize = new System.Drawing.Size(0, 35);
			this.DMSanPhamDVO_ThoiGianBaoHanhMax.Name = "DMSanPhamDVO_ThoiGianBaoHanhMax";
			this.DMSanPhamDVO_ThoiGianBaoHanhMax.Size = new System.Drawing.Size(216, 35);
			this.DMSanPhamDVO_ThoiGianBaoHanhMax.SkinColor = System.Drawing.Color.MediumSlateBlue;
			this.DMSanPhamDVO_ThoiGianBaoHanhMax.TabIndex = 50;
			this.DMSanPhamDVO_ThoiGianBaoHanhMax.TextColor = System.Drawing.Color.White;
			// 
			// DMSanPhamDVO_ThoiGianBaoHanhMin
			// 
			this.DMSanPhamDVO_ThoiGianBaoHanhMin.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.DMSanPhamDVO_ThoiGianBaoHanhMin.BorderSize = 0;
			this.DMSanPhamDVO_ThoiGianBaoHanhMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
			this.DMSanPhamDVO_ThoiGianBaoHanhMin.Location = new System.Drawing.Point(1005, 481);
			this.DMSanPhamDVO_ThoiGianBaoHanhMin.MinimumSize = new System.Drawing.Size(0, 35);
			this.DMSanPhamDVO_ThoiGianBaoHanhMin.Name = "DMSanPhamDVO_ThoiGianBaoHanhMin";
			this.DMSanPhamDVO_ThoiGianBaoHanhMin.Size = new System.Drawing.Size(219, 35);
			this.DMSanPhamDVO_ThoiGianBaoHanhMin.SkinColor = System.Drawing.Color.MediumSlateBlue;
			this.DMSanPhamDVO_ThoiGianBaoHanhMin.TabIndex = 49;
			this.DMSanPhamDVO_ThoiGianBaoHanhMin.TextColor = System.Drawing.Color.White;
			// 
			// TabPageSanPham_MaterialListView
			// 
			this.TabPageSanPham_MaterialListView.AutoSizeTable = false;
			this.TabPageSanPham_MaterialListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.TabPageSanPham_MaterialListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TabPageSanPham_MaterialListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader31});
			this.TabPageSanPham_MaterialListView.Depth = 0;
			this.TabPageSanPham_MaterialListView.FullRowSelect = true;
			this.TabPageSanPham_MaterialListView.HideSelection = false;
			this.TabPageSanPham_MaterialListView.Location = new System.Drawing.Point(3, 3);
			this.TabPageSanPham_MaterialListView.MinimumSize = new System.Drawing.Size(200, 100);
			this.TabPageSanPham_MaterialListView.MouseLocation = new System.Drawing.Point(-1, -1);
			this.TabPageSanPham_MaterialListView.MouseState = MaterialSkin.MouseState.OUT;
			this.TabPageSanPham_MaterialListView.Name = "TabPageSanPham_MaterialListView";
			this.TabPageSanPham_MaterialListView.OwnerDraw = true;
			this.TabPageSanPham_MaterialListView.Size = new System.Drawing.Size(966, 757);
			this.TabPageSanPham_MaterialListView.TabIndex = 15;
			this.TabPageSanPham_MaterialListView.UseCompatibleStateImageBehavior = false;
			this.TabPageSanPham_MaterialListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader25
			// 
			this.columnHeader25.Text = "STT";
			this.columnHeader25.Width = 76;
			// 
			// columnHeader26
			// 
			this.columnHeader26.Text = "Mã sản phẩm";
			this.columnHeader26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader26.Width = 145;
			// 
			// columnHeader27
			// 
			this.columnHeader27.Text = "Tên sản phẩm";
			this.columnHeader27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader27.Width = 142;
			// 
			// columnHeader28
			// 
			this.columnHeader28.Text = "Đơn giá bán";
			this.columnHeader28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader28.Width = 128;
			// 
			// columnHeader29
			// 
			this.columnHeader29.Text = "Đơn giá nhập";
			this.columnHeader29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader29.Width = 159;
			// 
			// columnHeader30
			// 
			this.columnHeader30.Text = "Số lượng tồn kho";
			this.columnHeader30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader30.Width = 159;
			// 
			// columnHeader31
			// 
			this.columnHeader31.Text = "Thời gian bảo hành ";
			this.columnHeader31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader31.Width = 161;
			// 
			// TabPagePhanTich
			// 
			this.TabPagePhanTich.Controls.Add(this.materialCard9);
			this.TabPagePhanTich.Controls.Add(this.materialCard8);
			this.TabPagePhanTich.Controls.Add(this.materialCard7);
			this.TabPagePhanTich.Controls.Add(this.materialCard6);
			this.TabPagePhanTich.Controls.Add(this.materialLabel1);
			this.TabPagePhanTich.Controls.Add(this.materialCard3);
			this.TabPagePhanTich.Controls.Add(this.materialCard2);
			this.TabPagePhanTich.Controls.Add(this.materialCard5);
			this.TabPagePhanTich.Controls.Add(this.materialCard4);
			this.TabPagePhanTich.Controls.Add(this.materialCard1);
			this.TabPagePhanTich.Controls.Add(this.pieChart2);
			this.TabPagePhanTich.Controls.Add(this.pieChart1);
			this.TabPagePhanTich.ImageKey = "icons8-intelligence-32.png";
			this.TabPagePhanTich.Location = new System.Drawing.Point(4, 39);
			this.TabPagePhanTich.Name = "TabPagePhanTich";
			this.TabPagePhanTich.Padding = new System.Windows.Forms.Padding(3);
			this.TabPagePhanTich.Size = new System.Drawing.Size(1473, 760);
			this.TabPagePhanTich.TabIndex = 7;
			this.TabPagePhanTich.Text = "Phân Tích";
			this.TabPagePhanTich.UseVisualStyleBackColor = true;
			// 
			// materialCard9
			// 
			this.materialCard9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard9.Controls.Add(this.label6);
			this.materialCard9.Depth = 0;
			this.materialCard9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard9.Location = new System.Drawing.Point(1098, 243);
			this.materialCard9.Margin = new System.Windows.Forms.Padding(18);
			this.materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard9.Name = "materialCard9";
			this.materialCard9.Padding = new System.Windows.Forms.Padding(14);
			this.materialCard9.Size = new System.Drawing.Size(150, 48);
			this.materialCard9.TabIndex = 21;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(4, 10);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(157, 40);
			this.label6.TabIndex = 0;
			this.label6.Text = "Biểu đồ lương \n công việc nhiều nhất";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.UseMnemonic = false;
			// 
			// materialCard8
			// 
			this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard8.Controls.Add(this.label5);
			this.materialCard8.Depth = 0;
			this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard8.Location = new System.Drawing.Point(246, 243);
			this.materialCard8.Margin = new System.Windows.Forms.Padding(18);
			this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard8.Name = "materialCard8";
			this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
			this.materialCard8.Size = new System.Drawing.Size(150, 48);
			this.materialCard8.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(11, 10);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(158, 40);
			this.label5.TabIndex = 0;
			this.label5.Text = "Biểu đồ số sản phẩm \ntồn kho nhiều nhất";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.UseMnemonic = false;
			// 
			// materialCard7
			// 
			this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard7.Controls.Add(this.label16);
			this.materialCard7.Depth = 0;
			this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard7.Location = new System.Drawing.Point(1040, 696);
			this.materialCard7.Margin = new System.Windows.Forms.Padding(18);
			this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard7.Name = "materialCard7";
			this.materialCard7.Padding = new System.Windows.Forms.Padding(18);
			this.materialCard7.Size = new System.Drawing.Size(165, 59);
			this.materialCard7.TabIndex = 17;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(2, 14);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(165, 40);
			this.label16.TabIndex = 0;
			this.label16.Text = "Biểu đồ doanh thu \n  các ngày trong tháng";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label16.UseMnemonic = false;
			// 
			// materialCard6
			// 
			this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard6.Controls.Add(this.label14);
			this.materialCard6.Depth = 0;
			this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard6.Location = new System.Drawing.Point(326, 696);
			this.materialCard6.Margin = new System.Windows.Forms.Padding(18);
			this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard6.Name = "materialCard6";
			this.materialCard6.Padding = new System.Windows.Forms.Padding(18);
			this.materialCard6.Size = new System.Drawing.Size(178, 59);
			this.materialCard6.TabIndex = 16;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(6, 14);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(169, 40);
			this.label14.TabIndex = 0;
			this.label14.Text = "Các sản phẩm đẫn đầu \n các tháng";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.Location = new System.Drawing.Point(588, 721);
			this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(1, 0);
			this.materialLabel1.TabIndex = 15;
			// 
			// materialCard3
			// 
			this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard3.Controls.Add(this.TabPagePhanTich_KhachHang_TiLeLB);
			this.materialCard3.Controls.Add(this.TabPagePhanTich_KhachHang_TiLePB);
			this.materialCard3.Controls.Add(this.TabPagePhanTich_KhachHang_KHmoi_LB);
			this.materialCard3.Controls.Add(this.label1);
			this.materialCard3.Controls.Add(this.label15);
			this.materialCard3.Controls.Add(this.label17);
			this.materialCard3.Controls.Add(this.TabPagePhanTich_KhachHang_Tong_LB);
			this.materialCard3.Depth = 0;
			this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard3.Location = new System.Drawing.Point(1040, 11);
			this.materialCard3.Margin = new System.Windows.Forms.Padding(18);
			this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard3.Name = "materialCard3";
			this.materialCard3.Padding = new System.Windows.Forms.Padding(18);
			this.materialCard3.Size = new System.Drawing.Size(370, 165);
			this.materialCard3.TabIndex = 10;
			// 
			// TabPagePhanTich_KhachHang_TiLeLB
			// 
			this.TabPagePhanTich_KhachHang_TiLeLB.AutoSize = true;
			this.TabPagePhanTich_KhachHang_TiLeLB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPagePhanTich_KhachHang_TiLeLB.Location = new System.Drawing.Point(21, 129);
			this.TabPagePhanTich_KhachHang_TiLeLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TabPagePhanTich_KhachHang_TiLeLB.Name = "TabPagePhanTich_KhachHang_TiLeLB";
			this.TabPagePhanTich_KhachHang_TiLeLB.Size = new System.Drawing.Size(124, 20);
			this.TabPagePhanTich_KhachHang_TiLeLB.TabIndex = 11;
			this.TabPagePhanTich_KhachHang_TiLeLB.Text = "Mục tiêu đạt 48%";
			// 
			// TabPagePhanTich_KhachHang_TiLePB
			// 
			this.TabPagePhanTich_KhachHang_TiLePB.Depth = 0;
			this.TabPagePhanTich_KhachHang_TiLePB.Location = new System.Drawing.Point(24, 119);
			this.TabPagePhanTich_KhachHang_TiLePB.Margin = new System.Windows.Forms.Padding(4);
			this.TabPagePhanTich_KhachHang_TiLePB.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPagePhanTich_KhachHang_TiLePB.Name = "TabPagePhanTich_KhachHang_TiLePB";
			this.TabPagePhanTich_KhachHang_TiLePB.Size = new System.Drawing.Size(269, 5);
			this.TabPagePhanTich_KhachHang_TiLePB.TabIndex = 10;
			this.TabPagePhanTich_KhachHang_TiLePB.Value = 48;
			// 
			// TabPagePhanTich_KhachHang_KHmoi_LB
			// 
			this.TabPagePhanTich_KhachHang_KHmoi_LB.AutoSize = true;
			this.TabPagePhanTich_KhachHang_KHmoi_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPagePhanTich_KhachHang_KHmoi_LB.Location = new System.Drawing.Point(245, 87);
			this.TabPagePhanTich_KhachHang_KHmoi_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TabPagePhanTich_KhachHang_KHmoi_LB.Name = "TabPagePhanTich_KhachHang_KHmoi_LB";
			this.TabPagePhanTich_KhachHang_KHmoi_LB.Size = new System.Drawing.Size(55, 29);
			this.TabPagePhanTich_KhachHang_KHmoi_LB.TabIndex = 9;
			this.TabPagePhanTich_KhachHang_KHmoi_LB.Text = "344";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 87);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(225, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Khách hàng mới tháng này";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(19, 15);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(147, 32);
			this.label15.TabIndex = 4;
			this.label15.Text = "Khách hàng";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(23, 52);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(223, 23);
			this.label17.TabIndex = 2;
			this.label17.Text = "Tổng số lượng khách hàng";
			// 
			// TabPagePhanTich_KhachHang_Tong_LB
			// 
			this.TabPagePhanTich_KhachHang_Tong_LB.AutoSize = true;
			this.TabPagePhanTich_KhachHang_Tong_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPagePhanTich_KhachHang_Tong_LB.Location = new System.Drawing.Point(245, 50);
			this.TabPagePhanTich_KhachHang_Tong_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TabPagePhanTich_KhachHang_Tong_LB.Name = "TabPagePhanTich_KhachHang_Tong_LB";
			this.TabPagePhanTich_KhachHang_Tong_LB.Size = new System.Drawing.Size(55, 29);
			this.TabPagePhanTich_KhachHang_Tong_LB.TabIndex = 1;
			this.TabPagePhanTich_KhachHang_Tong_LB.Text = "344";
			// 
			// materialCard2
			// 
			this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard2.Controls.Add(this.TabPagePhanTich_HoaDonNhap_TiLeLB);
			this.materialCard2.Controls.Add(this.TabPagePhanTich_HoaDonNhap_TiLePB);
			this.materialCard2.Controls.Add(this.TabPagePhanTich_HoaDonNhap_ChiPhi_LB);
			this.materialCard2.Controls.Add(this.label9);
			this.materialCard2.Controls.Add(this.label10);
			this.materialCard2.Controls.Add(this.label11);
			this.materialCard2.Controls.Add(this.TabPagePhanTich_HoaDonNhap_SoLuong_LB);
			this.materialCard2.Controls.Add(this.TabPagePhanTich_HoaDonNhap_ShowBTN);
			this.materialCard2.Depth = 0;
			this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard2.Location = new System.Drawing.Point(557, 11);
			this.materialCard2.Margin = new System.Windows.Forms.Padding(18);
			this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard2.Name = "materialCard2";
			this.materialCard2.Padding = new System.Windows.Forms.Padding(18);
			this.materialCard2.Size = new System.Drawing.Size(370, 165);
			this.materialCard2.TabIndex = 8;
			// 
			// TabPagePhanTich_HoaDonNhap_TiLeLB
			// 
			this.TabPagePhanTich_HoaDonNhap_TiLeLB.AutoSize = true;
			this.TabPagePhanTich_HoaDonNhap_TiLeLB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPagePhanTich_HoaDonNhap_TiLeLB.Location = new System.Drawing.Point(22, 129);
			this.TabPagePhanTich_HoaDonNhap_TiLeLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TabPagePhanTich_HoaDonNhap_TiLeLB.Name = "TabPagePhanTich_HoaDonNhap_TiLeLB";
			this.TabPagePhanTich_HoaDonNhap_TiLeLB.Size = new System.Drawing.Size(124, 20);
			this.TabPagePhanTich_HoaDonNhap_TiLeLB.TabIndex = 7;
			this.TabPagePhanTich_HoaDonNhap_TiLeLB.Text = "Mục tiêu đạt 48%";
			// 
			// TabPagePhanTich_HoaDonNhap_TiLePB
			// 
			this.TabPagePhanTich_HoaDonNhap_TiLePB.Depth = 0;
			this.TabPagePhanTich_HoaDonNhap_TiLePB.Location = new System.Drawing.Point(26, 119);
			this.TabPagePhanTich_HoaDonNhap_TiLePB.Margin = new System.Windows.Forms.Padding(4);
			this.TabPagePhanTich_HoaDonNhap_TiLePB.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPagePhanTich_HoaDonNhap_TiLePB.Name = "TabPagePhanTich_HoaDonNhap_TiLePB";
			this.TabPagePhanTich_HoaDonNhap_TiLePB.Size = new System.Drawing.Size(269, 5);
			this.TabPagePhanTich_HoaDonNhap_TiLePB.TabIndex = 6;
			this.TabPagePhanTich_HoaDonNhap_TiLePB.Value = 48;
			// 
			// TabPagePhanTich_HoaDonNhap_ChiPhi_LB
			// 
			this.TabPagePhanTich_HoaDonNhap_ChiPhi_LB.AutoSize = true;
			this.TabPagePhanTich_HoaDonNhap_ChiPhi_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPagePhanTich_HoaDonNhap_ChiPhi_LB.Location = new System.Drawing.Point(131, 82);
			this.TabPagePhanTich_HoaDonNhap_ChiPhi_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TabPagePhanTich_HoaDonNhap_ChiPhi_LB.Name = "TabPagePhanTich_HoaDonNhap_ChiPhi_LB";
			this.TabPagePhanTich_HoaDonNhap_ChiPhi_LB.Size = new System.Drawing.Size(126, 29);
			this.TabPagePhanTich_HoaDonNhap_ChiPhi_LB.TabIndex = 5;
			this.TabPagePhanTich_HoaDonNhap_ChiPhi_LB.Text = "150.000 đ";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(19, 15);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(176, 32);
			this.label9.TabIndex = 4;
			this.label9.Text = "Hóa đơn nhập";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(21, 82);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(110, 23);
			this.label10.TabIndex = 3;
			this.label10.Text = "Tổng chi phí";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(21, 50);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(83, 23);
			this.label11.TabIndex = 2;
			this.label11.Text = "Số lượng";
			// 
			// TabPagePhanTich_HoaDonNhap_SoLuong_LB
			// 
			this.TabPagePhanTich_HoaDonNhap_SoLuong_LB.AutoSize = true;
			this.TabPagePhanTich_HoaDonNhap_SoLuong_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPagePhanTich_HoaDonNhap_SoLuong_LB.Location = new System.Drawing.Point(131, 50);
			this.TabPagePhanTich_HoaDonNhap_SoLuong_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TabPagePhanTich_HoaDonNhap_SoLuong_LB.Name = "TabPagePhanTich_HoaDonNhap_SoLuong_LB";
			this.TabPagePhanTich_HoaDonNhap_SoLuong_LB.Size = new System.Drawing.Size(55, 29);
			this.TabPagePhanTich_HoaDonNhap_SoLuong_LB.TabIndex = 1;
			this.TabPagePhanTich_HoaDonNhap_SoLuong_LB.Text = "344";
			// 
			// TabPagePhanTich_HoaDonNhap_ShowBTN
			// 
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.Depth = 0;
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.Icon = global::WinformWithExternalLibrary.Properties.Resources.icons8_download_641;
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.ImageKey = "icons8-download-48.png";
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.ImageList = this.imageList1;
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.Location = new System.Drawing.Point(300, 15);
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.Margin = new System.Windows.Forms.Padding(4);
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.Name = "TabPagePhanTich_HoaDonNhap_ShowBTN";
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.Size = new System.Drawing.Size(70, 70);
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.TabIndex = 9;
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.Text = "materialFloatingActionButton2";
			this.TabPagePhanTich_HoaDonNhap_ShowBTN.UseVisualStyleBackColor = false;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.White;
			this.imageList1.Images.SetKeyName(0, "icons8-boxes-32.png");
			this.imageList1.Images.SetKeyName(1, "icons8-create-order-32.png");
			this.imageList1.Images.SetKeyName(2, "icons8-favorite-package-32.png");
			this.imageList1.Images.SetKeyName(3, "icons8-intelligence-32.png");
			this.imageList1.Images.SetKeyName(4, "icons8-new-product-32.png");
			this.imageList1.Images.SetKeyName(5, "icons8-package-delivery-logistics-32.png");
			this.imageList1.Images.SetKeyName(6, "icons8-store-front-32.png");
			this.imageList1.Images.SetKeyName(7, "icons8-warehouse-32.png");
			this.imageList1.Images.SetKeyName(8, "icons8-invoice-32 (1).png");
			this.imageList1.Images.SetKeyName(9, "icons8-purchase-order-32.png");
			this.imageList1.Images.SetKeyName(10, "icons8-administrator-male-32.png");
			this.imageList1.Images.SetKeyName(11, "icons8-male-user-32.png");
			this.imageList1.Images.SetKeyName(12, "icons8-people-32.png");
			this.imageList1.Images.SetKeyName(13, "icons8-user-32.png");
			this.imageList1.Images.SetKeyName(14, "icons8-download-64.png");
			// 
			// materialCard5
			// 
			this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard5.Controls.Add(this.cartesianChart2);
			this.materialCard5.Depth = 0;
			this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard5.Location = new System.Drawing.Point(781, 358);
			this.materialCard5.Margin = new System.Windows.Forms.Padding(18);
			this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard5.Name = "materialCard5";
			this.materialCard5.Padding = new System.Windows.Forms.Padding(18);
			this.materialCard5.Size = new System.Drawing.Size(630, 316);
			this.materialCard5.TabIndex = 7;
			// 
			// cartesianChart2
			// 
			this.cartesianChart2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cartesianChart2.Location = new System.Drawing.Point(18, 18);
			this.cartesianChart2.Name = "cartesianChart2";
			this.cartesianChart2.Size = new System.Drawing.Size(594, 280);
			this.cartesianChart2.TabIndex = 1;
			// 
			// materialCard4
			// 
			this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard4.Controls.Add(this.cartesianChart1);
			this.materialCard4.Depth = 0;
			this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard4.Location = new System.Drawing.Point(52, 358);
			this.materialCard4.Margin = new System.Windows.Forms.Padding(18);
			this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard4.Name = "materialCard4";
			this.materialCard4.Padding = new System.Windows.Forms.Padding(18);
			this.materialCard4.Size = new System.Drawing.Size(684, 316);
			this.materialCard4.TabIndex = 6;
			// 
			// cartesianChart1
			// 
			this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cartesianChart1.Location = new System.Drawing.Point(18, 18);
			this.cartesianChart1.Name = "cartesianChart1";
			this.cartesianChart1.Size = new System.Drawing.Size(648, 280);
			this.cartesianChart1.TabIndex = 0;
			// 
			// materialCard1
			// 
			this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard1.Controls.Add(this.TabPagePhanTich_HoaDonBan_GiamGiaLB);
			this.materialCard1.Controls.Add(this.TabPagePhanTich_HoaDonBan_GiamGiaPB);
			this.materialCard1.Controls.Add(this.TabPagePhanTich_HoaDonBan_DoanhThu_LB);
			this.materialCard1.Controls.Add(this.TabPagePhanTich_HoaDonBan_SoLuong_LB);
			this.materialCard1.Controls.Add(this.label4);
			this.materialCard1.Controls.Add(this.label3);
			this.materialCard1.Controls.Add(this.label2);
			this.materialCard1.Controls.Add(this.TabPagePhanTich_HoaDonBan_ShowBTN);
			this.materialCard1.Depth = 0;
			this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard1.Location = new System.Drawing.Point(52, 11);
			this.materialCard1.Margin = new System.Windows.Forms.Padding(18);
			this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard1.Name = "materialCard1";
			this.materialCard1.Padding = new System.Windows.Forms.Padding(18);
			this.materialCard1.Size = new System.Drawing.Size(370, 165);
			this.materialCard1.TabIndex = 0;
			// 
			// TabPagePhanTich_HoaDonBan_GiamGiaLB
			// 
			this.TabPagePhanTich_HoaDonBan_GiamGiaLB.AutoSize = true;
			this.TabPagePhanTich_HoaDonBan_GiamGiaLB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPagePhanTich_HoaDonBan_GiamGiaLB.Location = new System.Drawing.Point(22, 132);
			this.TabPagePhanTich_HoaDonBan_GiamGiaLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TabPagePhanTich_HoaDonBan_GiamGiaLB.Name = "TabPagePhanTich_HoaDonBan_GiamGiaLB";
			this.TabPagePhanTich_HoaDonBan_GiamGiaLB.Size = new System.Drawing.Size(124, 20);
			this.TabPagePhanTich_HoaDonBan_GiamGiaLB.TabIndex = 8;
			this.TabPagePhanTich_HoaDonBan_GiamGiaLB.Text = "Mục tiêu đạt 48%";
			// 
			// TabPagePhanTich_HoaDonBan_GiamGiaPB
			// 
			this.TabPagePhanTich_HoaDonBan_GiamGiaPB.Depth = 0;
			this.TabPagePhanTich_HoaDonBan_GiamGiaPB.Location = new System.Drawing.Point(25, 119);
			this.TabPagePhanTich_HoaDonBan_GiamGiaPB.Margin = new System.Windows.Forms.Padding(4);
			this.TabPagePhanTich_HoaDonBan_GiamGiaPB.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPagePhanTich_HoaDonBan_GiamGiaPB.Name = "TabPagePhanTich_HoaDonBan_GiamGiaPB";
			this.TabPagePhanTich_HoaDonBan_GiamGiaPB.Size = new System.Drawing.Size(269, 5);
			this.TabPagePhanTich_HoaDonBan_GiamGiaPB.TabIndex = 7;
			this.TabPagePhanTich_HoaDonBan_GiamGiaPB.Value = 48;
			// 
			// TabPagePhanTich_HoaDonBan_DoanhThu_LB
			// 
			this.TabPagePhanTich_HoaDonBan_DoanhThu_LB.AutoSize = true;
			this.TabPagePhanTich_HoaDonBan_DoanhThu_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPagePhanTich_HoaDonBan_DoanhThu_LB.Location = new System.Drawing.Point(106, 82);
			this.TabPagePhanTich_HoaDonBan_DoanhThu_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TabPagePhanTich_HoaDonBan_DoanhThu_LB.Name = "TabPagePhanTich_HoaDonBan_DoanhThu_LB";
			this.TabPagePhanTich_HoaDonBan_DoanhThu_LB.Size = new System.Drawing.Size(126, 29);
			this.TabPagePhanTich_HoaDonBan_DoanhThu_LB.TabIndex = 6;
			this.TabPagePhanTich_HoaDonBan_DoanhThu_LB.Text = "150.000 đ";
			// 
			// TabPagePhanTich_HoaDonBan_SoLuong_LB
			// 
			this.TabPagePhanTich_HoaDonBan_SoLuong_LB.AutoSize = true;
			this.TabPagePhanTich_HoaDonBan_SoLuong_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TabPagePhanTich_HoaDonBan_SoLuong_LB.Location = new System.Drawing.Point(106, 50);
			this.TabPagePhanTich_HoaDonBan_SoLuong_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TabPagePhanTich_HoaDonBan_SoLuong_LB.Name = "TabPagePhanTich_HoaDonBan_SoLuong_LB";
			this.TabPagePhanTich_HoaDonBan_SoLuong_LB.Size = new System.Drawing.Size(55, 29);
			this.TabPagePhanTich_HoaDonBan_SoLuong_LB.TabIndex = 5;
			this.TabPagePhanTich_HoaDonBan_SoLuong_LB.Text = "344";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(20, 15);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(162, 32);
			this.label4.TabIndex = 4;
			this.label4.Text = "Hóa đơn bán";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(21, 82);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Doanh thu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(21, 50);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Số lượng";
			// 
			// TabPagePhanTich_HoaDonBan_ShowBTN
			// 
			this.TabPagePhanTich_HoaDonBan_ShowBTN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.TabPagePhanTich_HoaDonBan_ShowBTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.TabPagePhanTich_HoaDonBan_ShowBTN.Depth = 0;
			this.TabPagePhanTich_HoaDonBan_ShowBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.TabPagePhanTich_HoaDonBan_ShowBTN.Icon = global::WinformWithExternalLibrary.Properties.Resources.icons8_download_641;
			this.TabPagePhanTich_HoaDonBan_ShowBTN.ImageKey = "icons8-download-48.png";
			this.TabPagePhanTich_HoaDonBan_ShowBTN.ImageList = this.imageList1;
			this.TabPagePhanTich_HoaDonBan_ShowBTN.Location = new System.Drawing.Point(300, 15);
			this.TabPagePhanTich_HoaDonBan_ShowBTN.Margin = new System.Windows.Forms.Padding(4);
			this.TabPagePhanTich_HoaDonBan_ShowBTN.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPagePhanTich_HoaDonBan_ShowBTN.Name = "TabPagePhanTich_HoaDonBan_ShowBTN";
			this.TabPagePhanTich_HoaDonBan_ShowBTN.Size = new System.Drawing.Size(70, 70);
			this.TabPagePhanTich_HoaDonBan_ShowBTN.TabIndex = 10;
			this.TabPagePhanTich_HoaDonBan_ShowBTN.Text = "materialFloatingActionButton1";
			this.TabPagePhanTich_HoaDonBan_ShowBTN.UseVisualStyleBackColor = false;
			// 
			// pieChart2
			// 
			this.pieChart2.InitialRotation = 0D;
			this.pieChart2.IsClockwise = true;
			this.pieChart2.Location = new System.Drawing.Point(400, 180);
			this.pieChart2.MaxAngle = 360D;
			this.pieChart2.MaxValue = null;
			this.pieChart2.MinValue = 0D;
			this.pieChart2.Name = "pieChart2";
			this.pieChart2.Size = new System.Drawing.Size(231, 175);
			this.pieChart2.TabIndex = 19;
			this.pieChart2.Total = null;
			// 
			// pieChart1
			// 
			this.pieChart1.InitialRotation = 0D;
			this.pieChart1.IsClockwise = true;
			this.pieChart1.Location = new System.Drawing.Point(850, 180);
			this.pieChart1.MaxAngle = 360D;
			this.pieChart1.MaxValue = null;
			this.pieChart1.MinValue = 0D;
			this.pieChart1.Name = "pieChart1";
			this.pieChart1.Size = new System.Drawing.Size(238, 175);
			this.pieChart1.TabIndex = 18;
			this.pieChart1.Total = null;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem,
            this.autoValidationToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip1";
			this.contextMenuStrip.Size = new System.Drawing.Size(199, 52);
			// 
			// darkModeToolStripMenuItem
			// 
			this.darkModeToolStripMenuItem.CheckOnClick = true;
			this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
			this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
			this.darkModeToolStripMenuItem.Text = "Chế Độ Tối";
			// 
			// autoValidationToolStripMenuItem
			// 
			this.autoValidationToolStripMenuItem.CheckOnClick = true;
			this.autoValidationToolStripMenuItem.Name = "autoValidationToolStripMenuItem";
			this.autoValidationToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
			this.autoValidationToolStripMenuItem.Text = "Tự Động Kiểm Tra";
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1487, 870);
			this.Controls.Add(this.materialTabControl);
			this.DrawerShowIconsWhenHidden = true;
			this.DrawerTabControl = this.materialTabControl;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FormMain";
			this.Text = "Trang chủ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.materialTabControl.ResumeLayout(false);
			this.TabPageNhanVien.ResumeLayout(false);
			this.TabPageHoaDonBan.ResumeLayout(false);
			this.TabPageHoaDonBan.PerformLayout();
			this.TabPageHoaDonNhap.ResumeLayout(false);
			this.TabPageKhachHang.ResumeLayout(false);
			this.TabPageNhaCungCap.ResumeLayout(false);
			this.TabPageSanPham.ResumeLayout(false);
			this.TabPageSanPham.PerformLayout();
			this.TabPagePhanTich.ResumeLayout(false);
			this.TabPagePhanTich.PerformLayout();
			this.materialCard9.ResumeLayout(false);
			this.materialCard9.PerformLayout();
			this.materialCard8.ResumeLayout(false);
			this.materialCard8.PerformLayout();
			this.materialCard7.ResumeLayout(false);
			this.materialCard7.PerformLayout();
			this.materialCard6.ResumeLayout(false);
			this.materialCard6.PerformLayout();
			this.materialCard3.ResumeLayout(false);
			this.materialCard3.PerformLayout();
			this.materialCard2.ResumeLayout(false);
			this.materialCard2.PerformLayout();
			this.materialCard5.ResumeLayout(false);
			this.materialCard4.ResumeLayout(false);
			this.materialCard1.ResumeLayout(false);
			this.materialCard1.PerformLayout();
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private MaterialSkin.Controls.MaterialTabControl materialTabControl;
		private System.Windows.Forms.TabPage TabPageHoaDonBan;
		private System.Windows.Forms.ImageList imageList1;
		private MaterialSkin.Controls.MaterialButton TabPageHoaDonBan_ButtonTaoKhachHang;
		private MaterialSkin.Controls.MaterialListView TabPageHoaDonBan_MaterialListView;
		private System.Windows.Forms.ColumnHeader columnHeaderIndex;
		private System.Windows.Forms.ColumnHeader columnHeaderIdentifier;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
		private System.Windows.Forms.ColumnHeader columnHeaderCount;
		private System.Windows.Forms.ColumnHeader columnHeaderIndividualPrice;
		private System.Windows.Forms.ColumnHeader columnHeaderPrice;
		private System.Windows.Forms.Label LabelForFocus;
		private System.Windows.Forms.TabPage TabPageNhanVien;
		private System.Windows.Forms.TabPage TabPageHoaDonNhap;
		private System.Windows.Forms.TabPage TabPageKhachHang;
		private System.Windows.Forms.TabPage TabPageNhaCungCap;
		private System.Windows.Forms.TabPage TabPageSanPham;
        private System.Windows.Forms.TabPage TabPagePhanTich;
		private MaterialSkin.Controls.MaterialCard materialCard7;
		private System.Windows.Forms.Label label16;
		private MaterialSkin.Controls.MaterialCard materialCard6;
		private System.Windows.Forms.Label label14;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialCard materialCard3;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label TabPagePhanTich_KhachHang_Tong_LB;
		private MaterialSkin.Controls.MaterialFloatingActionButton TabPagePhanTich_HoaDonNhap_ShowBTN;
		private MaterialSkin.Controls.MaterialCard materialCard2;
		private System.Windows.Forms.Label TabPagePhanTich_HoaDonNhap_TiLeLB;
		private MaterialSkin.Controls.MaterialProgressBar TabPagePhanTich_HoaDonNhap_TiLePB;
		private System.Windows.Forms.Label TabPagePhanTich_HoaDonNhap_ChiPhi_LB;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label TabPagePhanTich_HoaDonNhap_SoLuong_LB;
		private MaterialSkin.Controls.MaterialCard materialCard5;
		private MaterialSkin.Controls.MaterialCard materialCard4;
		private MaterialSkin.Controls.MaterialFloatingActionButton ShowHoaDonBanBtn;
		private MaterialSkin.Controls.MaterialCard materialCard1;
		private System.Windows.Forms.Label SoTienGiamGiaLB;
		private MaterialSkin.Controls.MaterialProgressBar GiamGiaPB;
		private System.Windows.Forms.Label DoanhThuHoaDonBanLB;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label SoHoaDonBanLB;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart2;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
		private MaterialSkin.Controls.MaterialTextBox HoaDonBanDVO_TenGiamGia;
		private System.Windows.Forms.ComboBox HoaDonBanDVO_DienThoaiKhachHang;
		private MaterialSkin.Controls.MaterialTextBox HoaDonBanDVO_TenKhachHang;
		private MaterialSkin.Controls.MaterialTextBox ChiTietHDBanDVO_SoLuong;
		private System.Windows.Forms.ComboBox ChiTietHDBanDVO_MaSanPham;
		private MaterialSkin.Controls.MaterialTextBox ChiTietHDBanDVO_TenSanPham;
		private MaterialSkin.Controls.MaterialButton TabPageHoaDonBan_ButtonNhapMoiHoaDon;
		private MaterialSkin.Controls.MaterialButton TabPageHoaDonBan_ButtonNhapHoaDon;
		private MaterialSkin.Controls.MaterialButton TabPageHoaDonBan_ButtonTaoSanPham;
		private MaterialSkin.Controls.MaterialButton TabPageHoaDonBan_ButtonNhapSanPham;
		private MaterialSkin.Controls.MaterialButton TabPageHoaDonBan_ButtonNhapMoiSanPham;
		private MaterialSkin.Controls.MaterialTextBox HoaDonBanDVO_TongTien;
		private System.Windows.Forms.Label HoaDonBanDVO_TongTien_Validation;
		private System.Windows.Forms.Label HoaDonBanDVO_TenGiamGia_Validation;
		private System.Windows.Forms.Label HoaDonBanDVO_TenKhachHang_Validation;
		private System.Windows.Forms.Label HoaDonBanDVO_DienThoaiKhachHang_Validation;
		private System.Windows.Forms.Label ChiTietHDBanDVO_TenSanPham_Validation;
		private System.Windows.Forms.Label ChiTietHDBanDVO_MaSanPham_Validation;
		private System.Windows.Forms.Label ChiTietHDBanDVO_SoLuong_Validation;
		private System.Windows.Forms.ComboBox NhanVienThuNganHDBanDVO_NhanVien;
		private System.Windows.Forms.Label NhanVienThuNganHDBanDVO_NhanVien_Validation;
		private MaterialSkin.Controls.MaterialButton TabPageHoaDonBan_ButtonXoaSanPham;
        private System.Windows.Forms.Label TabPagePhanTich_HoaDonBan_SoLuong_LB;
        private System.Windows.Forms.Label TabPagePhanTich_HoaDonBan_DoanhThu_LB;
        private MaterialSkin.Controls.MaterialProgressBar TabPagePhanTich_HoaDonBan_GiamGiaPB;
        private System.Windows.Forms.Label TabPagePhanTich_HoaDonBan_GiamGiaLB;
        private MaterialSkin.Controls.MaterialFloatingActionButton TabPagePhanTich_HoaDonBan_ShowBTN;
		private System.Windows.Forms.Label HoaDonBanDVO_ThanhToan_Validation;
		private MaterialSkin.Controls.MaterialTextBox HoaDonBanDVO_ThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TabPagePhanTich_KhachHang_KHmoi_LB;
        private System.Windows.Forms.Label TabPagePhanTich_KhachHang_TiLeLB;
        private MaterialSkin.Controls.MaterialProgressBar TabPagePhanTich_KhachHang_TiLePB;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart2;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private System.Windows.Forms.Label label6;
		private MaterialSkin.Controls.MaterialButton TabPageHoaDonNhap_ButtonXoaSanPham;
		private System.Windows.Forms.Label HoaDonNhapDVO_TongTien_Validation;
		private System.Windows.Forms.Label ChiTietHDNhapDVO_SoLuong_Validation;
		private System.Windows.Forms.ComboBox NhanVienThuNganHDNhapDVO_NhanVien;
		private System.Windows.Forms.Label HoaDonNhapDVO_TenNhaCungCap_Validation;
		private System.Windows.Forms.Label ChiTietHDNhapDVO_TenSanPham_Validation;
		private System.Windows.Forms.Label HoaDonNhapDVO_DienThoaiNhaCungCap_Validation;
		private System.Windows.Forms.Label NhanVienThuNganHDNhapDVO_NhanVien_Validation;
		private MaterialSkin.Controls.MaterialButton TabPageHoaDonNhap_ButtonNhapHoaDon;
		private System.Windows.Forms.Label ChiTietHDNhapDVO_MaSanPham_Validation;
		private MaterialSkin.Controls.MaterialButton TabPageHoaDonNhap_ButtonNhapMoiHoaDon;
		private MaterialSkin.Controls.MaterialTextBox HoaDonNhapDVO_TongTien;
		private MaterialSkin.Controls.MaterialButton TabPageHoaDonNhap_ButtonNhapSanPham;
		private MaterialSkin.Controls.MaterialButton TabPageHoaDonNhap_ButtonNhapMoiSanPham;
		private System.Windows.Forms.ComboBox HoaDonNhapDVO_DienThoaiNhaCungCap;
		private MaterialSkin.Controls.MaterialTextBox HoaDonNhapDVO_TenNhaCungCap;
		private MaterialSkin.Controls.MaterialButton TabPageHoaDonNhap_ButtonTaoNhaCungCap;
		private MaterialSkin.Controls.MaterialButton TabPageHoaDonNhap_ButtonTaoSanPham;
		private MaterialSkin.Controls.MaterialTextBox ChiTietHDNhapDVO_SoLuong;
		private MaterialSkin.Controls.MaterialListView TabPageHoaDonNhap_MaterialListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ComboBox ChiTietHDNhapDVO_MaSanPham;
		private MaterialSkin.Controls.MaterialTextBox ChiTietHDNhapDVO_TenSanPham;
		private MaterialSkin.Controls.MaterialButton TabPageKhachHang_RefreshKhachHang;
		private MaterialSkin.Controls.MaterialButton TabPageKhachHang_SuaKhachHang;
		private MaterialSkin.Controls.MaterialButton TabPageKhachHang_LichSuMuaHang;
		private MaterialSkin.Controls.MaterialButton TabPageKhachHang_SearchKH;
		private MaterialSkin.Controls.MaterialButton TabPageKhachHang_XuatExcelKH;
		private System.Windows.Forms.Label KhachHangDVO_DienThoai_Validation;
		private MaterialSkin.Controls.MaterialTextBox KhachHangDVO_DienThoai;
		private System.Windows.Forms.Label KhachHangDVO_DiaChi_Validation;
		private System.Windows.Forms.Label KhachHangDVO_TenKhachHang_Validation;
		private MaterialSkin.Controls.MaterialTextBox KhachHangDVO_DiaChi;
		private MaterialSkin.Controls.MaterialTextBox KhachHangDVO_TenKhachHang;
		private MaterialSkin.Controls.MaterialButton TabPageKhachHang_TaoKhachHang;
		private MaterialSkin.Controls.MaterialListView TabPageKhachHang_MaterialListView;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.ColumnHeader columnHeader17;
		private System.Windows.Forms.ColumnHeader columnHeader18;
		private System.Windows.Forms.ColumnHeader columnHeader19;
		private System.Windows.Forms.Label NhaCungCapDVO_DienThoai_Validation;
		private MaterialSkin.Controls.MaterialTextBox NhaCungCapDVO_DienThoai;
		private System.Windows.Forms.Label NhaCungCapDVO_DiaChi_Validation;
		private System.Windows.Forms.Label NhaCungCapDVO_TenNhaCungCap_Validation;
		private MaterialSkin.Controls.MaterialTextBox NhaCungCapDVO_DiaChi;
		private MaterialSkin.Controls.MaterialTextBox NhaCungCapDVO_TenNhaCungCap;
		private MaterialSkin.Controls.MaterialListView TabPageNhaCungCap_MaterialListView;
		private System.Windows.Forms.ColumnHeader columnHeader20;
		private System.Windows.Forms.ColumnHeader columnHeader21;
		private System.Windows.Forms.ColumnHeader columnHeader22;
		private System.Windows.Forms.ColumnHeader columnHeader24;
		private System.Windows.Forms.ColumnHeader columnHeader23;
		private MaterialSkin.Controls.MaterialListView TabPageSanPham_MaterialListView;
		private System.Windows.Forms.ColumnHeader columnHeader25;
		private System.Windows.Forms.ColumnHeader columnHeader26;
		private System.Windows.Forms.ColumnHeader columnHeader27;
		private System.Windows.Forms.ColumnHeader columnHeader28;
		private System.Windows.Forms.ColumnHeader columnHeader29;
		private System.Windows.Forms.ColumnHeader columnHeader30;
		private System.Windows.Forms.ColumnHeader columnHeader31;
		private MaterialSkin.Controls.MaterialButton TabPageSanPham_NhapMoiTimKiem;
		private _Utilities.RJDatePicker DMSanPhamDVO_ThoiGianBaoHanhMax;
		private _Utilities.RJDatePicker DMSanPhamDVO_ThoiGianBaoHanhMin;
		private MaterialSkin.Controls.MaterialButton TabPageSanPham_ButtonXuatRaFileExcel;
		private MaterialSkin.Controls.MaterialTextBox DMSanPhamDVO_SoLuongTonKhoMax;
		private MaterialSkin.Controls.MaterialTextBox DMSanPhamDVO_DonGiaNhapMax;
		private MaterialSkin.Controls.MaterialTextBox DMSanPhamDVO_SoLuongTonKhoMin;
		private MaterialSkin.Controls.MaterialTextBox DMSanPhamDVO_DonGiaNhapMin;
		private MaterialSkin.Controls.MaterialTextBox DMSanPhamDVO_DonGiaBanMax;
		private MaterialSkin.Controls.MaterialTextBox DMSanPhamDVO_TenSanPham;
		private MaterialSkin.Controls.MaterialTextBox DMSanPhamDVO_DonGiaBanMin;
		private MaterialSkin.Controls.MaterialButton TabPageSanPham_ButtonXoaSanPham;
		private MaterialSkin.Controls.MaterialButton TabPageSanPham_ButtonThemSanPham;
		private MaterialSkin.Controls.MaterialTextBox DMSanPhamDVO_MaSanPham;
		private MaterialSkin.Controls.MaterialButton TabPageSanPham_ButtonSuaSanPham;
		private MaterialSkin.Controls.MaterialButton TabPageSanPham_ButtonTimKiem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem autoValidationToolStripMenuItem;
		private MaterialSkin.Controls.MaterialButton TabPageNhaCungCap_RefreshNhaCungCap;
		private MaterialSkin.Controls.MaterialButton TabPageNhaCungCap_SuaNCC;
		private MaterialSkin.Controls.MaterialButton TabPageNhaCungCap_LichSuNhapHang;
		private MaterialSkin.Controls.MaterialButton TabPageNhaCungCap_SearchNhaCungCap;
		private MaterialSkin.Controls.MaterialButton TabPageNhaCungCap_XuatExcelNCC;
		private MaterialSkin.Controls.MaterialButton TabPageNhaCungCap_TaoNhaCungCap;
		private MaterialSkin.Controls.MaterialButton TabPageNhanVien_btnTaoMoiCongViec;
		private MaterialSkin.Controls.MaterialButton TabPageNhanVien_btnMacDinh;
		private System.Windows.Forms.ComboBox NhanVienDVO_TenCongViec;
		private MaterialSkin.Controls.MaterialTextBox NhanVienDVO_Email;
		private System.Windows.Forms.ComboBox NhanVienDVO_GioiTinh;
		private MaterialSkin.Controls.MaterialTextBox NhanVienDVO_DiaChi;
		private MaterialSkin.Controls.MaterialTextBox NhanVienDVO_SoDienThoai;
		private MaterialSkin.Controls.MaterialTextBox NhanVienDVO_TenNhanVien;
		private MaterialSkin.Controls.MaterialTextBox TabPageNhanVien_TextboxSelectNhanVien;
		private System.Windows.Forms.Label NhanVienDVO_Email_Validation;
		private System.Windows.Forms.Label NhanVienDVO_TenCongViec_Validation;
		private System.Windows.Forms.Label NhanVienDVO_DiaChi_Validation;
		private System.Windows.Forms.Label NhanVienDVO_SoDienThoai_Validation;
		private System.Windows.Forms.Label NhanVienDVO_GioiTinh_Validation;
		private System.Windows.Forms.Label NhanVienDVO_NgaySinh_Validation;
		private System.Windows.Forms.Label NhanVienDVO_TenNhanVien_Validation;
		private MaterialSkin.Controls.MaterialListView TabPageNhanVien_MaterialListView;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private MaterialSkin.Controls.MaterialButton TabPageNhanVien_btnSearch;
		private MaterialSkin.Controls.MaterialButton TabPageNhanVien_btnLuu;
		private MaterialSkin.Controls.MaterialButton TabPageNhanVien_btnThem;
		private MaterialSkin.Controls.MaterialButton TabPageNhanVien_btnXoa;
		private MaterialSkin.Controls.MaterialButton TabPageNhanVien_btnSua;
		private MaterialSkin.Controls.MaterialButton TabPageNhanVien_btnExcel;
		private _Utilities.RJDatePicker NhanVienDVO_NgaySinh;
		private MaterialSkin.Controls.MaterialTextBox NhanVienDVO_MatKhau;
		private System.Windows.Forms.Label NhanVienDVO_MatKhau_Validation;
		private MaterialSkin.Controls.MaterialTextBox NhanVienDVO_NhapLaiMatKhau;
		private System.Windows.Forms.Label NhanVienDVO_NhapLaiMatKhau_Validation;
		private MaterialSkin.Controls.MaterialButton TabPageKhachHang_XoaKhachHang;
		private System.Windows.Forms.Label TabPageSanPham_LabelSoLuongTonKho;
		private System.Windows.Forms.Label TabPageSanPham_LabelDonGiaNhap;
		private System.Windows.Forms.Label TabPageSanPham_LabelDonGiaBan;
		private MaterialSkin.Controls.MaterialButton TabPageSanPham_ButtonDSKM;
		private MaterialSkin.Controls.MaterialButton TabPageSanPham_ButtonLoadSP;
		private System.Windows.Forms.Label TabPageSanPham_LabelThoiGianBaoHanh;
		private MaterialSkin.Controls.MaterialButton TabPageNhaCungCap_XoaNhaCungCap;
	}
}