namespace WinformWithExternalLibrary.ExtraForm
{
    partial class FormChiTietHoaDonNhapInfo
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
			this.ChiTietHoaDonNhapInfoLV = new MaterialSkin.Controls.MaterialListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// ChiTietHoaDonNhapInfoLV
			// 
			this.ChiTietHoaDonNhapInfoLV.AutoSizeTable = false;
			this.ChiTietHoaDonNhapInfoLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ChiTietHoaDonNhapInfoLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ChiTietHoaDonNhapInfoLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.ChiTietHoaDonNhapInfoLV.Depth = 0;
			this.ChiTietHoaDonNhapInfoLV.FullRowSelect = true;
			this.ChiTietHoaDonNhapInfoLV.HideSelection = false;
			this.ChiTietHoaDonNhapInfoLV.Location = new System.Drawing.Point(5, 86);
			this.ChiTietHoaDonNhapInfoLV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ChiTietHoaDonNhapInfoLV.MinimumSize = new System.Drawing.Size(200, 100);
			this.ChiTietHoaDonNhapInfoLV.MouseLocation = new System.Drawing.Point(-1, -1);
			this.ChiTietHoaDonNhapInfoLV.MouseState = MaterialSkin.MouseState.OUT;
			this.ChiTietHoaDonNhapInfoLV.Name = "ChiTietHoaDonNhapInfoLV";
			this.ChiTietHoaDonNhapInfoLV.OwnerDraw = true;
			this.ChiTietHoaDonNhapInfoLV.Size = new System.Drawing.Size(960, 303);
			this.ChiTietHoaDonNhapInfoLV.TabIndex = 1;
			this.ChiTietHoaDonNhapInfoLV.UseCompatibleStateImageBehavior = false;
			this.ChiTietHoaDonNhapInfoLV.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã sản phẩm";
			this.columnHeader2.Width = 160;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên sản phẩm";
			this.columnHeader3.Width = 210;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Số lượng";
			this.columnHeader4.Width = 100;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Thành tiền";
			this.columnHeader5.Width = 150;
			// 
			// FormChiTietHoaDonNhapInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(991, 409);
			this.Controls.Add(this.ChiTietHoaDonNhapInfoLV);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormChiTietHoaDonNhapInfo";
			this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Danh sách các sản phẩm";
			this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView ChiTietHoaDonNhapInfoLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}