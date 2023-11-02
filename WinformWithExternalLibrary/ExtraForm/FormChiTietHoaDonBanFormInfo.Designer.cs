namespace WinformWithExternalLibrary.ExtraForm
{
    partial class FormChiTietHoaDonBanFormInfo
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
            this.ChiTietHoaDonBanInfoLV = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ChiTietHoaDonBanInfoLV
            // 
            this.ChiTietHoaDonBanInfoLV.AutoSizeTable = false;
            this.ChiTietHoaDonBanInfoLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChiTietHoaDonBanInfoLV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChiTietHoaDonBanInfoLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ChiTietHoaDonBanInfoLV.Depth = 0;
            this.ChiTietHoaDonBanInfoLV.FullRowSelect = true;
            this.ChiTietHoaDonBanInfoLV.HideSelection = false;
            this.ChiTietHoaDonBanInfoLV.Location = new System.Drawing.Point(6, 86);
            this.ChiTietHoaDonBanInfoLV.MinimumSize = new System.Drawing.Size(200, 100);
            this.ChiTietHoaDonBanInfoLV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChiTietHoaDonBanInfoLV.MouseState = MaterialSkin.MouseState.OUT;
            this.ChiTietHoaDonBanInfoLV.Name = "ChiTietHoaDonBanInfoLV";
            this.ChiTietHoaDonBanInfoLV.OwnerDraw = true;
            this.ChiTietHoaDonBanInfoLV.Size = new System.Drawing.Size(816, 303);
            this.ChiTietHoaDonBanInfoLV.TabIndex = 0;
            this.ChiTietHoaDonBanInfoLV.UseCompatibleStateImageBehavior = false;
            this.ChiTietHoaDonBanInfoLV.View = System.Windows.Forms.View.Details;
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
            this.columnHeader3.Width = 150;
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
            // FormChiTietHoaDonBanFormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 409);
            this.Controls.Add(this.ChiTietHoaDonBanInfoLV);
            this.Name = "FormChiTietHoaDonBanFormInfo";
            this.Text = "Danh sách các sản phẩm";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView ChiTietHoaDonBanInfoLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}