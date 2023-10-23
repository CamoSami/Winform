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
			this.tabPageThongTin = new System.Windows.Forms.TabPage();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.tabPageHoaDonNhap = new System.Windows.Forms.TabPage();
			this.tabPageKhachHang = new System.Windows.Forms.TabPage();
			this.tabPageNhaCungCap = new System.Windows.Forms.TabPage();
			this.tabPageHangHoa = new System.Windows.Forms.TabPage();
			this.tabPagePhanTich = new System.Windows.Forms.TabPage();
			this.materialTabControl1.SuspendLayout();
			this.tabPageHoaDonBan.SuspendLayout();
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
			this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
			this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabControl1.Multiline = true;
			this.materialTabControl1.Name = "materialTabControl1";
			this.materialTabControl1.SelectedIndex = 0;
			this.materialTabControl1.Size = new System.Drawing.Size(1481, 803);
			this.materialTabControl1.TabIndex = 0;
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
			this.tabPageHoaDonBan.Name = "tabPageHoaDonBan";
			this.tabPageHoaDonBan.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageHoaDonBan.Size = new System.Drawing.Size(1473, 760);
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
			this.materialButtonTest.Location = new System.Drawing.Point(1402, 670);
			this.materialButtonTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
			this.labelForFocus.Location = new System.Drawing.Point(1212, 744);
			this.labelForFocus.Name = "labelForFocus";
			this.labelForFocus.Size = new System.Drawing.Size(44, 16);
			this.labelForFocus.TabIndex = 4;
			this.labelForFocus.Text = "label2";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(1106, 6);
			this.dateTimePicker1.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(360, 22);
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
			this.materialListView.Location = new System.Drawing.Point(6, 6);
			this.materialListView.MinimumSize = new System.Drawing.Size(200, 100);
			this.materialListView.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialListView.MouseState = MaterialSkin.MouseState.OUT;
			this.materialListView.Name = "materialListView";
			this.materialListView.OwnerDraw = true;
			this.materialListView.Size = new System.Drawing.Size(1094, 748);
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
			this.materialButtonTaoMoiKhachHang.Location = new System.Drawing.Point(1287, 718);
			this.materialButtonTaoMoiKhachHang.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
			// tabPageThongTin
			// 
			this.tabPageThongTin.ImageKey = "icons8-male-user-32.png";
			this.tabPageThongTin.Location = new System.Drawing.Point(4, 39);
			this.tabPageThongTin.Name = "tabPageThongTin";
			this.tabPageThongTin.Size = new System.Drawing.Size(1473, 760);
			this.tabPageThongTin.TabIndex = 2;
			this.tabPageThongTin.Text = "Thông Tin";
			this.tabPageThongTin.UseVisualStyleBackColor = true;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
			// 
			// tabPageHoaDonNhap
			// 
			this.tabPageHoaDonNhap.ImageKey = "icons8-purchase-order-32.png";
			this.tabPageHoaDonNhap.Location = new System.Drawing.Point(4, 39);
			this.tabPageHoaDonNhap.Name = "tabPageHoaDonNhap";
			this.tabPageHoaDonNhap.Size = new System.Drawing.Size(1473, 760);
			this.tabPageHoaDonNhap.TabIndex = 3;
			this.tabPageHoaDonNhap.Text = "Hóa Đơn Nhập";
			this.tabPageHoaDonNhap.UseVisualStyleBackColor = true;
			// 
			// tabPageKhachHang
			// 
			this.tabPageKhachHang.ImageKey = "icons8-people-32.png";
			this.tabPageKhachHang.Location = new System.Drawing.Point(4, 39);
			this.tabPageKhachHang.Name = "tabPageKhachHang";
			this.tabPageKhachHang.Size = new System.Drawing.Size(1473, 760);
			this.tabPageKhachHang.TabIndex = 4;
			this.tabPageKhachHang.Text = "Khách Hàng";
			this.tabPageKhachHang.UseVisualStyleBackColor = true;
			// 
			// tabPageNhaCungCap
			// 
			this.tabPageNhaCungCap.ImageKey = "icons8-administrator-male-32.png";
			this.tabPageNhaCungCap.Location = new System.Drawing.Point(4, 39);
			this.tabPageNhaCungCap.Name = "tabPageNhaCungCap";
			this.tabPageNhaCungCap.Size = new System.Drawing.Size(1473, 760);
			this.tabPageNhaCungCap.TabIndex = 5;
			this.tabPageNhaCungCap.Text = "Nhà Cung Cấp";
			this.tabPageNhaCungCap.UseVisualStyleBackColor = true;
			// 
			// tabPageHangHoa
			// 
			this.tabPageHangHoa.ImageKey = "icons8-new-product-32.png";
			this.tabPageHangHoa.Location = new System.Drawing.Point(4, 39);
			this.tabPageHangHoa.Name = "tabPageHangHoa";
			this.tabPageHangHoa.Size = new System.Drawing.Size(1473, 760);
			this.tabPageHangHoa.TabIndex = 6;
			this.tabPageHangHoa.Text = "Hàng Hóa";
			this.tabPageHangHoa.UseVisualStyleBackColor = true;
			// 
			// tabPagePhanTich
			// 
			this.tabPagePhanTich.ImageKey = "icons8-intelligence-32.png";
			this.tabPagePhanTich.Location = new System.Drawing.Point(4, 39);
			this.tabPagePhanTich.Name = "tabPagePhanTich";
			this.tabPagePhanTich.Size = new System.Drawing.Size(1473, 760);
			this.tabPagePhanTich.TabIndex = 7;
			this.tabPagePhanTich.Text = "Phân Tích";
			this.tabPagePhanTich.UseVisualStyleBackColor = true;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1487, 870);
			this.Controls.Add(this.materialTabControl1);
			this.DrawerShowIconsWhenHidden = true;
			this.DrawerTabControl = this.materialTabControl1;
			this.Name = "FormMain";
			this.Text = "Trang chủ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.materialTabControl1.ResumeLayout(false);
			this.tabPageHoaDonBan.ResumeLayout(false);
			this.tabPageHoaDonBan.PerformLayout();
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
	}
}