namespace WinformWithExternalLibrary.ExtraForm
{
	partial class FormListSellBill
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
			this.materialListView2 = new MaterialSkin.Controls.MaterialListView();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.materialButton_SPTrongDonBan = new MaterialSkin.Controls.MaterialButton();
			this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// materialListView2
			// 
			this.materialListView2.AutoSizeTable = false;
			this.materialListView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.materialListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.materialListView2.Depth = 0;
			this.materialListView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.materialListView2.FullRowSelect = true;
			this.materialListView2.HideSelection = false;
			this.materialListView2.Location = new System.Drawing.Point(604, 75);
			this.materialListView2.Margin = new System.Windows.Forms.Padding(4);
			this.materialListView2.MinimumSize = new System.Drawing.Size(267, 123);
			this.materialListView2.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialListView2.MouseState = MaterialSkin.MouseState.OUT;
			this.materialListView2.Name = "materialListView2";
			this.materialListView2.OwnerDraw = true;
			this.materialListView2.Size = new System.Drawing.Size(419, 698);
			this.materialListView2.TabIndex = 38;
			this.materialListView2.UseCompatibleStateImageBehavior = false;
			this.materialListView2.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "STT";
			this.columnHeader5.Width = 59;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Mã sản phẩm";
			this.columnHeader6.Width = 145;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Giá bán";
			this.columnHeader7.Width = 300;
			// 
			// materialButton_SPTrongDonBan
			// 
			this.materialButton_SPTrongDonBan.AutoSize = false;
			this.materialButton_SPTrongDonBan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton_SPTrongDonBan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.materialButton_SPTrongDonBan.Depth = 0;
			this.materialButton_SPTrongDonBan.HighEmphasis = true;
			this.materialButton_SPTrongDonBan.Icon = null;
			this.materialButton_SPTrongDonBan.Location = new System.Drawing.Point(423, 784);
			this.materialButton_SPTrongDonBan.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
			this.materialButton_SPTrongDonBan.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialButton_SPTrongDonBan.Name = "materialButton_SPTrongDonBan";
			this.materialButton_SPTrongDonBan.NoAccentTextColor = System.Drawing.Color.Empty;
			this.materialButton_SPTrongDonBan.Size = new System.Drawing.Size(149, 44);
			this.materialButton_SPTrongDonBan.TabIndex = 37;
			this.materialButton_SPTrongDonBan.TabStop = false;
			this.materialButton_SPTrongDonBan.Text = "Xem sản phẩm có trong đơn";
			this.materialButton_SPTrongDonBan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton_SPTrongDonBan.UseAccentColor = false;
			this.materialButton_SPTrongDonBan.UseVisualStyleBackColor = true;
			// 
			// materialListView1
			// 
			this.materialListView1.AutoSizeTable = false;
			this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.materialListView1.Depth = 0;
			this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.materialListView1.FullRowSelect = true;
			this.materialListView1.HideSelection = false;
			this.materialListView1.Location = new System.Drawing.Point(12, 75);
			this.materialListView1.Margin = new System.Windows.Forms.Padding(4);
			this.materialListView1.MinimumSize = new System.Drawing.Size(267, 123);
			this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
			this.materialListView1.Name = "materialListView1";
			this.materialListView1.OwnerDraw = true;
			this.materialListView1.Size = new System.Drawing.Size(572, 698);
			this.materialListView1.TabIndex = 36;
			this.materialListView1.UseCompatibleStateImageBehavior = false;
			this.materialListView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			this.columnHeader1.Width = 59;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã Hóa Đơn";
			this.columnHeader2.Width = 145;
			// 
			// columnHeader3
			// 
			this.columnHeader3.DisplayIndex = 3;
			this.columnHeader3.Text = "Đơn Giá";
			this.columnHeader3.Width = 300;
			// 
			// columnHeader4
			// 
			this.columnHeader4.DisplayIndex = 2;
			this.columnHeader4.Text = "Ngày Mua Hàng";
			this.columnHeader4.Width = 140;
			// 
			// FormListSellBill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1035, 902);
			this.Controls.Add(this.materialListView2);
			this.Controls.Add(this.materialButton_SPTrongDonBan);
			this.Controls.Add(this.materialListView1);
			this.Name = "FormListSellBill";
			this.Text = "FormListSellBill";
			this.ResumeLayout(false);

		}

		#endregion

		private MaterialSkin.Controls.MaterialListView materialListView2;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private MaterialSkin.Controls.MaterialButton materialButton_SPTrongDonBan;
		private MaterialSkin.Controls.MaterialListView materialListView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
	}
}