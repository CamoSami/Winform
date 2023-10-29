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
			this.LoginDVO_LoginName = new MaterialSkin.Controls.MaterialTextBox();
			this.LoginDVO_Password = new MaterialSkin.Controls.MaterialTextBox();
			this.materialButtonDangNhap = new MaterialSkin.Controls.MaterialButton();
			this.materialButtonThoat = new MaterialSkin.Controls.MaterialButton();
			this.LoginDVO_LoginName_Validation = new System.Windows.Forms.Label();
			this.LoginDVO_Password_Validation = new System.Windows.Forms.Label();
			this.labelForFocus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LoginDVO_LoginName
			// 
			this.LoginDVO_LoginName.AnimateReadOnly = false;
			this.LoginDVO_LoginName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LoginDVO_LoginName.Depth = 0;
			this.LoginDVO_LoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
			this.LoginDVO_LoginName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LoginDVO_LoginName.LeadingIcon = null;
			this.LoginDVO_LoginName.Location = new System.Drawing.Point(17, 77);
			this.LoginDVO_LoginName.MaxLength = 50;
			this.LoginDVO_LoginName.MouseState = MaterialSkin.MouseState.OUT;
			this.LoginDVO_LoginName.Multiline = false;
			this.LoginDVO_LoginName.Name = "LoginDVO_LoginName";
			this.LoginDVO_LoginName.Size = new System.Drawing.Size(494, 50);
			this.LoginDVO_LoginName.TabIndex = 0;
			this.LoginDVO_LoginName.Text = "Tên Đăng Nhập";
			this.LoginDVO_LoginName.TrailingIcon = null;
			// 
			// LoginDVO_Password
			// 
			this.LoginDVO_Password.AnimateReadOnly = false;
			this.LoginDVO_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LoginDVO_Password.Depth = 0;
			this.LoginDVO_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
			this.LoginDVO_Password.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LoginDVO_Password.LeadingIcon = null;
			this.LoginDVO_Password.Location = new System.Drawing.Point(17, 153);
			this.LoginDVO_Password.MaxLength = 50;
			this.LoginDVO_Password.MouseState = MaterialSkin.MouseState.OUT;
			this.LoginDVO_Password.Multiline = false;
			this.LoginDVO_Password.Name = "LoginDVO_Password";
			this.LoginDVO_Password.Size = new System.Drawing.Size(494, 50);
			this.LoginDVO_Password.TabIndex = 1;
			this.LoginDVO_Password.Text = "Mật Khẩu";
			this.LoginDVO_Password.TrailingIcon = null;
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
			// LoginDVO_LoginName_Validation
			// 
			this.LoginDVO_LoginName_Validation.AutoSize = true;
			this.LoginDVO_LoginName_Validation.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LoginDVO_LoginName_Validation.Location = new System.Drawing.Point(17, 134);
			this.LoginDVO_LoginName_Validation.Name = "LoginDVO_LoginName_Validation";
			this.LoginDVO_LoginName_Validation.Size = new System.Drawing.Size(44, 16);
			this.LoginDVO_LoginName_Validation.TabIndex = 7;
			this.LoginDVO_LoginName_Validation.Text = "label1";
			// 
			// LoginDVO_Password_Validation
			// 
			this.LoginDVO_Password_Validation.AutoSize = true;
			this.LoginDVO_Password_Validation.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LoginDVO_Password_Validation.Location = new System.Drawing.Point(17, 206);
			this.LoginDVO_Password_Validation.Name = "LoginDVO_Password_Validation";
			this.LoginDVO_Password_Validation.Size = new System.Drawing.Size(44, 16);
			this.LoginDVO_Password_Validation.TabIndex = 8;
			this.LoginDVO_Password_Validation.Text = "label2";
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
			this.Controls.Add(this.LoginDVO_Password_Validation);
			this.Controls.Add(this.LoginDVO_LoginName_Validation);
			this.Controls.Add(this.materialButtonThoat);
			this.Controls.Add(this.materialButtonDangNhap);
			this.Controls.Add(this.LoginDVO_Password);
			this.Controls.Add(this.LoginDVO_LoginName);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialTextBox LoginDVO_LoginName;
		private MaterialSkin.Controls.MaterialTextBox LoginDVO_Password;
		private MaterialSkin.Controls.MaterialButton materialButtonDangNhap;
		private MaterialSkin.Controls.MaterialButton materialButtonThoat;
		private System.Windows.Forms.Label LoginDVO_LoginName_Validation;
		private System.Windows.Forms.Label LoginDVO_Password_Validation;
		private System.Windows.Forms.Label labelForFocus;
	}
}

