using LiveCharts.Wpf;
using LiveCharts;

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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageThongTin = new System.Windows.Forms.TabPage();
            this.tabPageHoaDonBan = new System.Windows.Forms.TabPage();
            this.materialButtonTest = new MaterialSkin.Controls.MaterialButton();
            this.labelForFocus = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeaderIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIdentifier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIndividualPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialButtonTaoMoiKhachHang = new MaterialSkin.Controls.MaterialButton();
            this.tabPageHoaDonNhap = new System.Windows.Forms.TabPage();
            this.tabPageKhachHang = new System.Windows.Forms.TabPage();
            this.tabPageNhaCungCap = new System.Windows.Forms.TabPage();
            this.tabPageHangHoa = new System.Windows.Forms.TabPage();
            this.tabPagePhanTich = new System.Windows.Forms.TabPage();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.label16 = new System.Windows.Forms.Label();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.label14 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.label13 = new System.Windows.Forms.Label();
            this.materialProgressBar3 = new MaterialSkin.Controls.MaterialProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label7 = new System.Windows.Forms.Label();
            this.materialProgressBar2 = new MaterialSkin.Controls.MaterialProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label6 = new System.Windows.Forms.Label();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabPageHoaDonBan.SuspendLayout();
            this.tabPagePhanTich.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageThongTin);
            this.materialTabControl1.Controls.Add(this.tabPageHoaDonBan);
            this.materialTabControl1.Controls.Add(this.tabPageHoaDonNhap);
            this.materialTabControl1.Controls.Add(this.tabPageKhachHang);
            this.materialTabControl1.Controls.Add(this.tabPageNhaCungCap);
            this.materialTabControl1.Controls.Add(this.tabPageHangHoa);
            this.materialTabControl1.Controls.Add(this.tabPagePhanTich);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(2, 52);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1483, 816);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPageThongTin
            // 
            this.tabPageThongTin.ImageKey = "icons8-male-user-32.png";
            this.tabPageThongTin.Location = new System.Drawing.Point(4, 39);
            this.tabPageThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageThongTin.Name = "tabPageThongTin";
            this.tabPageThongTin.Size = new System.Drawing.Size(1475, 773);
            this.tabPageThongTin.TabIndex = 2;
            this.tabPageThongTin.Text = "Thông Tin";
            this.tabPageThongTin.UseVisualStyleBackColor = true;
            // 
            // tabPageHoaDonBan
            // 
            this.tabPageHoaDonBan.Controls.Add(this.materialButtonTest);
            this.tabPageHoaDonBan.Controls.Add(this.labelForFocus);
            this.tabPageHoaDonBan.Controls.Add(this.dateTimePicker1);
            this.tabPageHoaDonBan.Controls.Add(this.materialListView);
            this.tabPageHoaDonBan.Controls.Add(this.materialButtonTaoMoiKhachHang);
            this.tabPageHoaDonBan.ImageKey = "icons8-create-order-32.png";
            this.tabPageHoaDonBan.Location = new System.Drawing.Point(4, 39);
            this.tabPageHoaDonBan.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageHoaDonBan.Name = "tabPageHoaDonBan";
            this.tabPageHoaDonBan.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageHoaDonBan.Size = new System.Drawing.Size(1103, 610);
            this.tabPageHoaDonBan.TabIndex = 1;
            this.tabPageHoaDonBan.Text = "Hóa Đơn Bán";
            this.tabPageHoaDonBan.UseVisualStyleBackColor = true;
            // 
            // materialButtonTest
            // 
            this.materialButtonTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonTest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonTest.Depth = 0;
            this.materialButtonTest.HighEmphasis = true;
            this.materialButtonTest.Icon = null;
            this.materialButtonTest.Location = new System.Drawing.Point(1052, 544);
            this.materialButtonTest.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButtonTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonTest.Name = "materialButtonTest";
            this.materialButtonTest.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonTest.Size = new System.Drawing.Size(64, 36);
            this.materialButtonTest.TabIndex = 5;
            this.materialButtonTest.Text = "Test";
            this.materialButtonTest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonTest.UseAccentColor = false;
            this.materialButtonTest.UseVisualStyleBackColor = true;
            // 
            // labelForFocus
            // 
            this.labelForFocus.AutoSize = true;
            this.labelForFocus.Location = new System.Drawing.Point(909, 604);
            this.labelForFocus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForFocus.Name = "labelForFocus";
            this.labelForFocus.Size = new System.Drawing.Size(35, 13);
            this.labelForFocus.TabIndex = 4;
            this.labelForFocus.Text = "label2";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(830, 5);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // materialListView
            // 
            this.materialListView.AutoSizeTable = false;
            this.materialListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIndex,
            this.columnHeaderIdentifier,
            this.columnHeaderName,
            this.columnHeaderCount,
            this.columnHeaderIndividualPrice,
            this.columnHeaderPrice});
            this.materialListView.Depth = 0;
            this.materialListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListView.FullRowSelect = true;
            this.materialListView.HideSelection = false;
            this.materialListView.Location = new System.Drawing.Point(4, 5);
            this.materialListView.Margin = new System.Windows.Forms.Padding(2);
            this.materialListView.MinimumSize = new System.Drawing.Size(150, 81);
            this.materialListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView.Name = "materialListView";
            this.materialListView.OwnerDraw = true;
            this.materialListView.Size = new System.Drawing.Size(820, 608);
            this.materialListView.TabIndex = 1;
            this.materialListView.UseCompatibleStateImageBehavior = false;
            this.materialListView.View = System.Windows.Forms.View.Details;
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
            this.columnHeaderName.Width = 617;
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
            this.columnHeaderPrice.Width = 74;
            // 
            // materialButtonTaoMoiKhachHang
            // 
            this.materialButtonTaoMoiKhachHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonTaoMoiKhachHang.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonTaoMoiKhachHang.Depth = 0;
            this.materialButtonTaoMoiKhachHang.HighEmphasis = true;
            this.materialButtonTaoMoiKhachHang.Icon = null;
            this.materialButtonTaoMoiKhachHang.Location = new System.Drawing.Point(965, 583);
            this.materialButtonTaoMoiKhachHang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButtonTaoMoiKhachHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonTaoMoiKhachHang.Name = "materialButtonTaoMoiKhachHang";
            this.materialButtonTaoMoiKhachHang.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonTaoMoiKhachHang.Size = new System.Drawing.Size(179, 36);
            this.materialButtonTaoMoiKhachHang.TabIndex = 0;
            this.materialButtonTaoMoiKhachHang.Text = "Tạo Mới Khách Hàng";
            this.materialButtonTaoMoiKhachHang.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonTaoMoiKhachHang.UseAccentColor = false;
            this.materialButtonTaoMoiKhachHang.UseVisualStyleBackColor = true;
            // 
            // tabPageHoaDonNhap
            // 
            this.tabPageHoaDonNhap.ImageKey = "icons8-purchase-order-32.png";
            this.tabPageHoaDonNhap.Location = new System.Drawing.Point(4, 39);
            this.tabPageHoaDonNhap.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageHoaDonNhap.Name = "tabPageHoaDonNhap";
            this.tabPageHoaDonNhap.Size = new System.Drawing.Size(1103, 610);
            this.tabPageHoaDonNhap.TabIndex = 3;
            this.tabPageHoaDonNhap.Text = "Hóa Đơn Nhập";
            this.tabPageHoaDonNhap.UseVisualStyleBackColor = true;
            // 
            // tabPageKhachHang
            // 
            this.tabPageKhachHang.ImageKey = "icons8-people-32.png";
            this.tabPageKhachHang.Location = new System.Drawing.Point(4, 39);
            this.tabPageKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageKhachHang.Name = "tabPageKhachHang";
            this.tabPageKhachHang.Size = new System.Drawing.Size(1103, 610);
            this.tabPageKhachHang.TabIndex = 4;
            this.tabPageKhachHang.Text = "Khách Hàng";
            this.tabPageKhachHang.UseVisualStyleBackColor = true;
            // 
            // tabPageNhaCungCap
            // 
            this.tabPageNhaCungCap.ImageKey = "icons8-administrator-male-32.png";
            this.tabPageNhaCungCap.Location = new System.Drawing.Point(4, 39);
            this.tabPageNhaCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageNhaCungCap.Name = "tabPageNhaCungCap";
            this.tabPageNhaCungCap.Size = new System.Drawing.Size(1103, 610);
            this.tabPageNhaCungCap.TabIndex = 5;
            this.tabPageNhaCungCap.Text = "Nhà Cung Cấp";
            this.tabPageNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // tabPageHangHoa
            // 
            this.tabPageHangHoa.ImageKey = "icons8-new-product-32.png";
            this.tabPageHangHoa.Location = new System.Drawing.Point(4, 39);
            this.tabPageHangHoa.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageHangHoa.Name = "tabPageHangHoa";
            this.tabPageHangHoa.Size = new System.Drawing.Size(1103, 610);
            this.tabPageHangHoa.TabIndex = 6;
            this.tabPageHangHoa.Text = "Hàng Hóa";
            this.tabPageHangHoa.UseVisualStyleBackColor = true;
            // 
            // tabPagePhanTich
            // 
            this.tabPagePhanTich.Controls.Add(this.materialCard7);
            this.tabPagePhanTich.Controls.Add(this.materialCard6);
            this.tabPagePhanTich.Controls.Add(this.materialLabel1);
            this.tabPagePhanTich.Controls.Add(this.materialFloatingActionButton3);
            this.tabPagePhanTich.Controls.Add(this.materialCard3);
            this.tabPagePhanTich.Controls.Add(this.materialFloatingActionButton2);
            this.tabPagePhanTich.Controls.Add(this.materialCard2);
            this.tabPagePhanTich.Controls.Add(this.materialCard5);
            this.tabPagePhanTich.Controls.Add(this.materialCard4);
            this.tabPagePhanTich.Controls.Add(this.materialFloatingActionButton1);
            this.tabPagePhanTich.Controls.Add(this.materialCard1);
            this.tabPagePhanTich.ImageKey = "icons8-intelligence-32.png";
            this.tabPagePhanTich.Location = new System.Drawing.Point(4, 39);
            this.tabPagePhanTich.Margin = new System.Windows.Forms.Padding(2);
            this.tabPagePhanTich.Name = "tabPagePhanTich";
            this.tabPagePhanTich.Size = new System.Drawing.Size(1475, 773);
            this.tabPagePhanTich.TabIndex = 7;
            this.tabPagePhanTich.Text = "Phân Tích";
            this.tabPagePhanTich.UseVisualStyleBackColor = true;
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.label16);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(1011, 553);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(132, 35);
            this.materialCard7.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Biểu đồ doanh thu";
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.label14);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(315, 553);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(114, 35);
            this.materialCard6.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Biểu đồ ??";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(468, 574);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(1, 0);
            this.materialLabel1.TabIndex = 15;
            // 
            // materialFloatingActionButton3
            // 
            this.materialFloatingActionButton3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialFloatingActionButton3.Depth = 0;
            this.materialFloatingActionButton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialFloatingActionButton3.Icon = global::WinformWithExternalLibrary.Properties.Resources.icons8_download_641;
            this.materialFloatingActionButton3.ImageKey = "icons8-download-48.png";
            this.materialFloatingActionButton3.ImageList = this.imageList1;
            this.materialFloatingActionButton3.Location = new System.Drawing.Point(1310, 78);
            this.materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton3.TabIndex = 11;
            this.materialFloatingActionButton3.Text = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.UseVisualStyleBackColor = false;
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
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.label13);
            this.materialCard3.Controls.Add(this.materialProgressBar3);
            this.materialCard3.Controls.Add(this.label15);
            this.materialCard3.Controls.Add(this.label17);
            this.materialCard3.Controls.Add(this.label18);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(1036, 38);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(296, 132);
            this.materialCard3.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Mục tiêu đạt 48%";
            // 
            // materialProgressBar3
            // 
            this.materialProgressBar3.Depth = 0;
            this.materialProgressBar3.Location = new System.Drawing.Point(21, 95);
            this.materialProgressBar3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar3.Name = "materialProgressBar3";
            this.materialProgressBar3.Size = new System.Drawing.Size(215, 5);
            this.materialProgressBar3.TabIndex = 6;
            this.materialProgressBar3.Value = 48;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 25);
            this.label15.TabIndex = 4;
            this.label15.Text = "Khách hàng";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 17);
            this.label17.TabIndex = 2;
            this.label17.Text = "Số lượng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(105, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 24);
            this.label18.TabIndex = 1;
            this.label18.Text = "344";
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialFloatingActionButton2.Icon = global::WinformWithExternalLibrary.Properties.Resources.icons8_download_641;
            this.materialFloatingActionButton2.ImageKey = "icons8-download-48.png";
            this.materialFloatingActionButton2.ImageList = this.imageList1;
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(829, 78);
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton2.TabIndex = 9;
            this.materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.UseVisualStyleBackColor = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label7);
            this.materialCard2.Controls.Add(this.materialProgressBar2);
            this.materialCard2.Controls.Add(this.label8);
            this.materialCard2.Controls.Add(this.label9);
            this.materialCard2.Controls.Add(this.label10);
            this.materialCard2.Controls.Add(this.label11);
            this.materialCard2.Controls.Add(this.label12);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(555, 38);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(296, 132);
            this.materialCard2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mục tiêu đạt 48%";
            // 
            // materialProgressBar2
            // 
            this.materialProgressBar2.Depth = 0;
            this.materialProgressBar2.Location = new System.Drawing.Point(21, 95);
            this.materialProgressBar2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar2.Name = "materialProgressBar2";
            this.materialProgressBar2.Size = new System.Drawing.Size(215, 5);
            this.materialProgressBar2.TabIndex = 6;
            this.materialProgressBar2.Value = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "150.000 đ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Hóa đơn nhập";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tổng tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Số lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(105, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "344";
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.cartesianChart2);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(740, 234);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(592, 306);
            this.materialCard5.TabIndex = 7;
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart2.Location = new System.Drawing.Point(14, 14);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(564, 278);
            this.cartesianChart2.TabIndex = 0;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.cartesianChart1);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(56, 234);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(631, 306);
            this.materialCard4.TabIndex = 6;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(14, 14);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(603, 278);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialFloatingActionButton1.Icon = global::WinformWithExternalLibrary.Properties.Resources.icons8_download_641;
            this.materialFloatingActionButton1.ImageKey = "icons8-download-48.png";
            this.materialFloatingActionButton1.ImageList = this.imageList1;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(330, 78);
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton1.TabIndex = 1;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.label6);
            this.materialCard1.Controls.Add(this.materialProgressBar1);
            this.materialCard1.Controls.Add(this.label5);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(56, 38);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(296, 132);
            this.materialCard1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mục tiêu đạt 48%";
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(21, 95);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(215, 5);
            this.materialProgressBar1.TabIndex = 6;
            this.materialProgressBar1.Value = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "150.000 đ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hóa đơn bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "344";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 870);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageHoaDonBan.ResumeLayout(false);
            this.tabPageHoaDonBan.PerformLayout();
            this.tabPagePhanTich.ResumeLayout(false);
            this.tabPagePhanTich.PerformLayout();
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
            this.ResumeLayout(false);

        }

		#endregion

		private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
		private System.Windows.Forms.TabPage tabPageHoaDonBan;
		private System.Windows.Forms.ImageList imageList1;
		private MaterialSkin.Controls.MaterialButton materialButtonTaoMoiKhachHang;
		private MaterialSkin.Controls.MaterialListView materialListView;
		private System.Windows.Forms.ColumnHeader columnHeaderIndex;
		private System.Windows.Forms.ColumnHeader columnHeaderIdentifier;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
		private System.Windows.Forms.ColumnHeader columnHeaderCount;
		private System.Windows.Forms.ColumnHeader columnHeaderIndividualPrice;
		private System.Windows.Forms.ColumnHeader columnHeaderPrice;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label labelForFocus;
		private MaterialSkin.Controls.MaterialButton materialButtonTest;
		private System.Windows.Forms.TabPage tabPageThongTin;
		private System.Windows.Forms.TabPage tabPageHoaDonNhap;
		private System.Windows.Forms.TabPage tabPageKhachHang;
		private System.Windows.Forms.TabPage tabPageNhaCungCap;
		private System.Windows.Forms.TabPage tabPageHangHoa;
        private System.Windows.Forms.TabPage tabPagePhanTich;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.Label label13;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private System.Windows.Forms.Label label16;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private System.Windows.Forms.Label label14;
    }
}