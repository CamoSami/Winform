namespace WinformWithExternalLibrary.ExtraForm
{
	partial class FormCreateCongViec
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
			this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
			this.TabPageNV_btnOK = new MaterialSkin.Controls.MaterialButton();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.CongViecDVO_MucLuong = new MaterialSkin.Controls.MaterialTextBox();
			this.CongViecDVO_TenCongViec = new MaterialSkin.Controls.MaterialTextBox();
			this.materialCard1.SuspendLayout();
			this.SuspendLayout();
			// 
			// materialCard1
			// 
			this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard1.Controls.Add(this.TabPageNV_btnOK);
			this.materialCard1.Controls.Add(this.materialLabel1);
			this.materialCard1.Controls.Add(this.CongViecDVO_MucLuong);
			this.materialCard1.Controls.Add(this.CongViecDVO_TenCongViec);
			this.materialCard1.Depth = 0;
			this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard1.Location = new System.Drawing.Point(111, 119);
			this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
			this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard1.Name = "materialCard1";
			this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
			this.materialCard1.Size = new System.Drawing.Size(586, 282);
			this.materialCard1.TabIndex = 4;
			// 
			// TabPageNV_btnOK
			// 
			this.TabPageNV_btnOK.AutoSize = false;
			this.TabPageNV_btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TabPageNV_btnOK.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.TabPageNV_btnOK.Depth = 0;
			this.TabPageNV_btnOK.HighEmphasis = true;
			this.TabPageNV_btnOK.Icon = null;
			this.TabPageNV_btnOK.Location = new System.Drawing.Point(258, 214);
			this.TabPageNV_btnOK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.TabPageNV_btnOK.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabPageNV_btnOK.Name = "TabPageNV_btnOK";
			this.TabPageNV_btnOK.NoAccentTextColor = System.Drawing.Color.Empty;
			this.TabPageNV_btnOK.Size = new System.Drawing.Size(75, 36);
			this.TabPageNV_btnOK.TabIndex = 2;
			this.TabPageNV_btnOK.Text = "OK";
			this.TabPageNV_btnOK.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.TabPageNV_btnOK.UseAccentColor = false;
			this.TabPageNV_btnOK.UseVisualStyleBackColor = true;
			// 
			// materialLabel1
			// 
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.Location = new System.Drawing.Point(483, 174);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(33, 19);
			this.materialLabel1.TabIndex = 1;
			this.materialLabel1.Text = "VNĐ";
			// 
			// CongViecDVO_MucLuong
			// 
			this.CongViecDVO_MucLuong.AnimateReadOnly = false;
			this.CongViecDVO_MucLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CongViecDVO_MucLuong.Depth = 0;
			this.CongViecDVO_MucLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
			this.CongViecDVO_MucLuong.LeadingIcon = null;
			this.CongViecDVO_MucLuong.Location = new System.Drawing.Point(76, 143);
			this.CongViecDVO_MucLuong.MaxLength = 50;
			this.CongViecDVO_MucLuong.MouseState = MaterialSkin.MouseState.OUT;
			this.CongViecDVO_MucLuong.Multiline = false;
			this.CongViecDVO_MucLuong.Name = "CongViecDVO_MucLuong";
			this.CongViecDVO_MucLuong.Size = new System.Drawing.Size(401, 50);
			this.CongViecDVO_MucLuong.TabIndex = 0;
			this.CongViecDVO_MucLuong.Text = "Mức Lương";
			this.CongViecDVO_MucLuong.TrailingIcon = null;
			// 
			// CongViecDVO_TenCongViec
			// 
			this.CongViecDVO_TenCongViec.AnimateReadOnly = false;
			this.CongViecDVO_TenCongViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.CongViecDVO_TenCongViec.Depth = 0;
			this.CongViecDVO_TenCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
			this.CongViecDVO_TenCongViec.LeadingIcon = null;
			this.CongViecDVO_TenCongViec.Location = new System.Drawing.Point(76, 75);
			this.CongViecDVO_TenCongViec.MaxLength = 50;
			this.CongViecDVO_TenCongViec.MouseState = MaterialSkin.MouseState.OUT;
			this.CongViecDVO_TenCongViec.Multiline = false;
			this.CongViecDVO_TenCongViec.Name = "CongViecDVO_TenCongViec";
			this.CongViecDVO_TenCongViec.Size = new System.Drawing.Size(440, 50);
			this.CongViecDVO_TenCongViec.TabIndex = 0;
			this.CongViecDVO_TenCongViec.Text = "Tên Công Việc ";
			this.CongViecDVO_TenCongViec.TrailingIcon = null;
			// 
			// FormCreateCongViec
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.materialCard1);
			this.Name = "FormCreateCongViec";
			this.Text = "Chi Tiết Công Việc";
			this.materialCard1.ResumeLayout(false);
			this.materialCard1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MaterialSkin.Controls.MaterialCard materialCard1;
		private MaterialSkin.Controls.MaterialButton TabPageNV_btnOK;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialTextBox CongViecDVO_MucLuong;
		private MaterialSkin.Controls.MaterialTextBox CongViecDVO_TenCongViec;
	}
}