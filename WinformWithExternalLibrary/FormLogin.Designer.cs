using MaterialSkin;

namespace WinformWithExternalLibrary
{
	partial class FormLogin
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
			this.LoginDVO_Email = new MaterialSkin.Controls.MaterialTextBox();
			this.LoginDVO_MatKhau = new MaterialSkin.Controls.MaterialTextBox();
			this.materialButtonDangNhap = new MaterialSkin.Controls.MaterialButton();
			this.LoginDVO_Email_Validation = new System.Windows.Forms.Label();
			this.LoginDVO_MatKhau_Validation = new System.Windows.Forms.Label();
			this.labelForFocus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LoginDVO_Email
			// 
			this.LoginDVO_Email.AnimateReadOnly = false;
			this.LoginDVO_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LoginDVO_Email.Depth = 0;
			this.LoginDVO_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
			this.LoginDVO_Email.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LoginDVO_Email.LeadingIcon = null;
			this.LoginDVO_Email.Location = new System.Drawing.Point(17, 77);
			this.LoginDVO_Email.MaxLength = 50;
			this.LoginDVO_Email.MouseState = MaterialSkin.MouseState.OUT;
			this.LoginDVO_Email.Multiline = false;
			this.LoginDVO_Email.Name = "LoginDVO_Email";
			this.LoginDVO_Email.Size = new System.Drawing.Size(494, 50);
			this.LoginDVO_Email.TabIndex = 0;
			this.LoginDVO_Email.Text = "Tên Đăng Nhập";
			this.LoginDVO_Email.TrailingIcon = null;
			// 
			// LoginDVO_MatKhau
			// 
			this.LoginDVO_MatKhau.AnimateReadOnly = false;
			this.LoginDVO_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LoginDVO_MatKhau.Depth = 0;
			this.LoginDVO_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
			this.LoginDVO_MatKhau.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LoginDVO_MatKhau.LeadingIcon = null;
			this.LoginDVO_MatKhau.Location = new System.Drawing.Point(17, 149);
			this.LoginDVO_MatKhau.MaxLength = 50;
			this.LoginDVO_MatKhau.MouseState = MaterialSkin.MouseState.OUT;
			this.LoginDVO_MatKhau.Multiline = false;
			this.LoginDVO_MatKhau.Name = "LoginDVO_MatKhau";
			this.LoginDVO_MatKhau.Size = new System.Drawing.Size(494, 50);
			this.LoginDVO_MatKhau.TabIndex = 1;
			this.LoginDVO_MatKhau.Text = "Mật Khẩu";
			this.LoginDVO_MatKhau.TrailingIcon = null;
			// 
			// materialButtonDangNhap
			// 
			this.materialButtonDangNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButtonDangNhap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.materialButtonDangNhap.Depth = 0;
			this.materialButtonDangNhap.HighEmphasis = true;
			this.materialButtonDangNhap.Icon = null;
			this.materialButtonDangNhap.Location = new System.Drawing.Point(406, 238);
			this.materialButtonDangNhap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButtonDangNhap.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialButtonDangNhap.Name = "materialButtonDangNhap";
			this.materialButtonDangNhap.NoAccentTextColor = System.Drawing.Color.Empty;
			this.materialButtonDangNhap.Size = new System.Drawing.Size(105, 36);
			this.materialButtonDangNhap.TabIndex = 4;
			this.materialButtonDangNhap.TabStop = false;
			this.materialButtonDangNhap.Text = "Đăng nhập";
			this.materialButtonDangNhap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButtonDangNhap.UseAccentColor = false;
			this.materialButtonDangNhap.UseVisualStyleBackColor = true;
			// 
			// LoginDVO_Email_Validation
			// 
			this.LoginDVO_Email_Validation.AutoSize = true;
			this.LoginDVO_Email_Validation.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LoginDVO_Email_Validation.Location = new System.Drawing.Point(17, 130);
			this.LoginDVO_Email_Validation.Name = "LoginDVO_Email_Validation";
			this.LoginDVO_Email_Validation.Size = new System.Drawing.Size(44, 16);
			this.LoginDVO_Email_Validation.TabIndex = 7;
			this.LoginDVO_Email_Validation.Text = "label1";
			// 
			// LoginDVO_MatKhau_Validation
			// 
			this.LoginDVO_MatKhau_Validation.AutoSize = true;
			this.LoginDVO_MatKhau_Validation.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LoginDVO_MatKhau_Validation.Location = new System.Drawing.Point(17, 202);
			this.LoginDVO_MatKhau_Validation.Name = "LoginDVO_MatKhau_Validation";
			this.LoginDVO_MatKhau_Validation.Size = new System.Drawing.Size(44, 16);
			this.LoginDVO_MatKhau_Validation.TabIndex = 8;
			this.LoginDVO_MatKhau_Validation.Text = "label2";
			// 
			// labelForFocus
			// 
			this.labelForFocus.AutoSize = true;
			this.labelForFocus.Location = new System.Drawing.Point(238, 258);
			this.labelForFocus.Name = "labelForFocus";
			this.labelForFocus.Size = new System.Drawing.Size(0, 16);
			this.labelForFocus.TabIndex = 9;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 283);
			this.Controls.Add(this.labelForFocus);
			this.Controls.Add(this.LoginDVO_MatKhau_Validation);
			this.Controls.Add(this.LoginDVO_Email_Validation);
			this.Controls.Add(this.materialButtonDangNhap);
			this.Controls.Add(this.LoginDVO_MatKhau);
			this.Controls.Add(this.LoginDVO_Email);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialTextBox LoginDVO_Email;
		private MaterialSkin.Controls.MaterialTextBox LoginDVO_MatKhau;
		private MaterialSkin.Controls.MaterialButton materialButtonDangNhap;
		private System.Windows.Forms.Label LoginDVO_Email_Validation;
		private System.Windows.Forms.Label LoginDVO_MatKhau_Validation;
		private System.Windows.Forms.Label labelForFocus;
	}
}

