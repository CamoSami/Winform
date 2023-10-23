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
			this.LoginDTO_loginName = new MaterialSkin.Controls.MaterialTextBox();
			this.LoginDTO_password = new MaterialSkin.Controls.MaterialTextBox();
			this.materialButtonDangNhap = new MaterialSkin.Controls.MaterialButton();
			this.materialButtonThoat = new MaterialSkin.Controls.MaterialButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelForFocus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LoginDTO_loginName
			// 
			this.LoginDTO_loginName.AnimateReadOnly = false;
			this.LoginDTO_loginName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LoginDTO_loginName.Depth = 0;
			this.LoginDTO_loginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
			this.LoginDTO_loginName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LoginDTO_loginName.LeadingIcon = null;
			this.LoginDTO_loginName.Location = new System.Drawing.Point(17, 77);
			this.LoginDTO_loginName.MaxLength = 50;
			this.LoginDTO_loginName.MouseState = MaterialSkin.MouseState.OUT;
			this.LoginDTO_loginName.Multiline = false;
			this.LoginDTO_loginName.Name = "LoginDTO_loginName";
			this.LoginDTO_loginName.Size = new System.Drawing.Size(494, 50);
			this.LoginDTO_loginName.TabIndex = 0;
			this.LoginDTO_loginName.Text = "Tên Đăng Nhập";
			this.LoginDTO_loginName.TrailingIcon = null;
			// 
			// LoginDTO_password
			// 
			this.LoginDTO_password.AnimateReadOnly = false;
			this.LoginDTO_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LoginDTO_password.Depth = 0;
			this.LoginDTO_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
			this.LoginDTO_password.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LoginDTO_password.LeadingIcon = null;
			this.LoginDTO_password.Location = new System.Drawing.Point(17, 153);
			this.LoginDTO_password.MaxLength = 50;
			this.LoginDTO_password.MouseState = MaterialSkin.MouseState.OUT;
			this.LoginDTO_password.Multiline = false;
			this.LoginDTO_password.Name = "LoginDTO_password";
			this.LoginDTO_password.Size = new System.Drawing.Size(494, 50);
			this.LoginDTO_password.TabIndex = 1;
			this.LoginDTO_password.Text = "Mật Khẩu";
			this.LoginDTO_password.TrailingIcon = null;
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
			this.materialButtonDangNhap.Text = "Đăng nhập";
			this.materialButtonDangNhap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButtonDangNhap.UseAccentColor = false;
			this.materialButtonDangNhap.UseVisualStyleBackColor = true;
			// 
			// materialButtonThoat
			// 
			this.materialButtonThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButtonThoat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.materialButtonThoat.Depth = 0;
			this.materialButtonThoat.HighEmphasis = true;
			this.materialButtonThoat.Icon = null;
			this.materialButtonThoat.Location = new System.Drawing.Point(17, 238);
			this.materialButtonThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButtonThoat.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialButtonThoat.Name = "materialButtonThoat";
			this.materialButtonThoat.NoAccentTextColor = System.Drawing.Color.Empty;
			this.materialButtonThoat.Size = new System.Drawing.Size(69, 36);
			this.materialButtonThoat.TabIndex = 5;
			this.materialButtonThoat.Text = "Thoát";
			this.materialButtonThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButtonThoat.UseAccentColor = false;
			this.materialButtonThoat.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(17, 134);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(17, 206);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "label2";
			// 
			// labelForFocus
			// 
			this.labelForFocus.AutoSize = true;
			this.labelForFocus.Location = new System.Drawing.Point(242, 344);
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
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.materialButtonThoat);
			this.Controls.Add(this.materialButtonDangNhap);
			this.Controls.Add(this.LoginDTO_password);
			this.Controls.Add(this.LoginDTO_loginName);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialTextBox LoginDTO_loginName;
		private MaterialSkin.Controls.MaterialTextBox LoginDTO_password;
		private MaterialSkin.Controls.MaterialButton materialButtonDangNhap;
		private MaterialSkin.Controls.MaterialButton materialButtonThoat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelForFocus;
	}
}

