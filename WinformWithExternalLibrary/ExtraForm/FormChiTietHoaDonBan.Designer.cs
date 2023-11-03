namespace WinformWithExternalLibrary.ExtraForm
{
    partial class FormChiTietHoaDonBan
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
            this.ChiTietHoaDonBanLV = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChiTietHoaDonExelBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.PhanTichDVO_HDB_TimKiemBtn = new MaterialSkin.Controls.MaterialButton();
            this.PhanTichDVO_HDB_TimKiemIP = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChiTietHoaDonBanLV
            // 
            this.ChiTietHoaDonBanLV.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ChiTietHoaDonBanLV.AutoSizeTable = false;
            this.ChiTietHoaDonBanLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChiTietHoaDonBanLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChiTietHoaDonBanLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.ChiTietHoaDonBanLV.Depth = 0;
            this.ChiTietHoaDonBanLV.FullRowSelect = true;
            this.ChiTietHoaDonBanLV.HideSelection = false;
            this.ChiTietHoaDonBanLV.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ChiTietHoaDonBanLV.Location = new System.Drawing.Point(6, 67);
            this.ChiTietHoaDonBanLV.MinimumSize = new System.Drawing.Size(200, 100);
            this.ChiTietHoaDonBanLV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChiTietHoaDonBanLV.MouseState = MaterialSkin.MouseState.OUT;
            this.ChiTietHoaDonBanLV.Name = "ChiTietHoaDonBanLV";
            this.ChiTietHoaDonBanLV.OwnerDraw = true;
            this.ChiTietHoaDonBanLV.Size = new System.Drawing.Size(919, 405);
            this.ChiTietHoaDonBanLV.TabIndex = 0;
            this.ChiTietHoaDonBanLV.UseCompatibleStateImageBehavior = false;
            this.ChiTietHoaDonBanLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "STT";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hóa đơn bán";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nhân viên";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Điện thoại NV";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên khách hàng";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Điện thoại KH";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số sản phẩm";
            this.columnHeader6.Width = 115;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giảm giá";
            this.columnHeader7.Width = 130;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tổng tiền";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ngày bán";
            this.columnHeader9.Width = 140;
            // 
            // ChiTietHoaDonExelBtn
            // 
            this.ChiTietHoaDonExelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChiTietHoaDonExelBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.ChiTietHoaDonExelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChiTietHoaDonExelBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ChiTietHoaDonExelBtn.Depth = 0;
            this.ChiTietHoaDonExelBtn.HighEmphasis = true;
            this.ChiTietHoaDonExelBtn.Icon = null;
            this.ChiTietHoaDonExelBtn.Location = new System.Drawing.Point(766, 6);
            this.ChiTietHoaDonExelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChiTietHoaDonExelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChiTietHoaDonExelBtn.Name = "ChiTietHoaDonExelBtn";
            this.ChiTietHoaDonExelBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ChiTietHoaDonExelBtn.Size = new System.Drawing.Size(137, 36);
            this.ChiTietHoaDonExelBtn.TabIndex = 1;
            this.ChiTietHoaDonExelBtn.Text = "Export to exel";
            this.ChiTietHoaDonExelBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChiTietHoaDonExelBtn.UseAccentColor = false;
            this.ChiTietHoaDonExelBtn.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.PhanTichDVO_HDB_TimKiemIP);
            this.materialCard1.Controls.Add(this.PhanTichDVO_HDB_TimKiemBtn);
            this.materialCard1.Controls.Add(this.ChiTietHoaDonExelBtn);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(7, 473);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(918, 114);
            this.materialCard1.TabIndex = 2;
            // 
            // PhanTichDVO_HDB_TimKiemBtn
            // 
            this.PhanTichDVO_HDB_TimKiemBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PhanTichDVO_HDB_TimKiemBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.PhanTichDVO_HDB_TimKiemBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PhanTichDVO_HDB_TimKiemBtn.Depth = 0;
            this.PhanTichDVO_HDB_TimKiemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PhanTichDVO_HDB_TimKiemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhanTichDVO_HDB_TimKiemBtn.HighEmphasis = true;
            this.PhanTichDVO_HDB_TimKiemBtn.Icon = global::WinformWithExternalLibrary.Properties.Resources.icons8_download_641;
            this.PhanTichDVO_HDB_TimKiemBtn.Image = global::WinformWithExternalLibrary.Properties.Resources.icons8_download_641;
            this.PhanTichDVO_HDB_TimKiemBtn.Location = new System.Drawing.Point(346, 28);
            this.PhanTichDVO_HDB_TimKiemBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PhanTichDVO_HDB_TimKiemBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.PhanTichDVO_HDB_TimKiemBtn.Name = "PhanTichDVO_HDB_TimKiemBtn";
            this.PhanTichDVO_HDB_TimKiemBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PhanTichDVO_HDB_TimKiemBtn.Size = new System.Drawing.Size(114, 36);
            this.PhanTichDVO_HDB_TimKiemBtn.TabIndex = 7;
            this.PhanTichDVO_HDB_TimKiemBtn.Text = "Tìm kiếm";
            this.PhanTichDVO_HDB_TimKiemBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PhanTichDVO_HDB_TimKiemBtn.UseAccentColor = false;
            this.PhanTichDVO_HDB_TimKiemBtn.UseVisualStyleBackColor = true;
            // 
            // PhanTichDVO_HDB_TimKiemIP
            // 
            this.PhanTichDVO_HDB_TimKiemIP.AnimateReadOnly = false;
            this.PhanTichDVO_HDB_TimKiemIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhanTichDVO_HDB_TimKiemIP.Depth = 0;
            this.PhanTichDVO_HDB_TimKiemIP.DetectUrls = false;
            this.PhanTichDVO_HDB_TimKiemIP.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PhanTichDVO_HDB_TimKiemIP.LeadingIcon = null;
            this.PhanTichDVO_HDB_TimKiemIP.Location = new System.Drawing.Point(32, 14);
            this.PhanTichDVO_HDB_TimKiemIP.MaxLength = 50;
            this.PhanTichDVO_HDB_TimKiemIP.MouseState = MaterialSkin.MouseState.OUT;
            this.PhanTichDVO_HDB_TimKiemIP.Multiline = false;
            this.PhanTichDVO_HDB_TimKiemIP.Name = "PhanTichDVO_HDB_TimKiemIP";
            this.PhanTichDVO_HDB_TimKiemIP.Size = new System.Drawing.Size(300, 50);
            this.PhanTichDVO_HDB_TimKiemIP.TabIndex = 8;
            this.PhanTichDVO_HDB_TimKiemIP.Text = "";
            this.PhanTichDVO_HDB_TimKiemIP.TrailingIcon = null;
            // 
            // FormChiTietHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 592);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.ChiTietHoaDonBanLV);
            this.Name = "FormChiTietHoaDonBan";
            this.Text = "Danh sách hóa đơn bán";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView ChiTietHoaDonBanLV;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private MaterialSkin.Controls.MaterialButton ChiTietHoaDonExelBtn;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton PhanTichDVO_HDB_TimKiemBtn;
        private MaterialSkin.Controls.MaterialTextBox PhanTichDVO_HDB_TimKiemIP;
    }
}