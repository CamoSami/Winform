namespace WinformWithExternalLibrary.ExtraForm
{
	partial class FormScanBarCode
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
			this.btnScan = new MaterialSkin.Controls.MaterialButton();
			this.barCodeScannerTb = new MaterialSkin.Controls.MaterialTextBox();
			this.barCodeLb = new System.Windows.Forms.Label();
			this.cameraCb = new System.Windows.Forms.ComboBox();
			this.webcamLb = new System.Windows.Forms.Label();
			this.scannerPictureBox = new System.Windows.Forms.PictureBox();
			this.btnDone = new MaterialSkin.Controls.MaterialButton();
			this.btnReset = new MaterialSkin.Controls.MaterialButton();
			((System.ComponentModel.ISupportInitialize)(this.scannerPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// btnScan
			// 
			this.btnScan.AutoSize = false;
			this.btnScan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnScan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.btnScan.Depth = 0;
			this.btnScan.HighEmphasis = true;
			this.btnScan.Icon = null;
			this.btnScan.Location = new System.Drawing.Point(280, 69);
			this.btnScan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnScan.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnScan.Name = "btnScan";
			this.btnScan.NoAccentTextColor = System.Drawing.Color.Empty;
			this.btnScan.Size = new System.Drawing.Size(115, 36);
			this.btnScan.TabIndex = 15;
			this.btnScan.Text = "Scan";
			this.btnScan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.btnScan.UseAccentColor = false;
			this.btnScan.UseVisualStyleBackColor = true;
			// 
			// barCodeScannerTb
			// 
			this.barCodeScannerTb.AnimateReadOnly = false;
			this.barCodeScannerTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.barCodeScannerTb.Depth = 0;
			this.barCodeScannerTb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.barCodeScannerTb.LeadingIcon = null;
			this.barCodeScannerTb.Location = new System.Drawing.Point(71, 560);
			this.barCodeScannerTb.MaxLength = 50;
			this.barCodeScannerTb.MouseState = MaterialSkin.MouseState.OUT;
			this.barCodeScannerTb.Multiline = false;
			this.barCodeScannerTb.Name = "barCodeScannerTb";
			this.barCodeScannerTb.ReadOnly = true;
			this.barCodeScannerTb.Size = new System.Drawing.Size(324, 50);
			this.barCodeScannerTb.TabIndex = 14;
			this.barCodeScannerTb.Text = "";
			this.barCodeScannerTb.TrailingIcon = null;
			// 
			// barCodeLb
			// 
			this.barCodeLb.AutoSize = true;
			this.barCodeLb.Location = new System.Drawing.Point(6, 572);
			this.barCodeLb.Name = "barCodeLb";
			this.barCodeLb.Size = new System.Drawing.Size(59, 16);
			this.barCodeLb.TabIndex = 13;
			this.barCodeLb.Text = "Barcode";
			// 
			// cameraCb
			// 
			this.cameraCb.FormattingEnabled = true;
			this.cameraCb.Location = new System.Drawing.Point(86, 76);
			this.cameraCb.Name = "cameraCb";
			this.cameraCb.Size = new System.Drawing.Size(181, 24);
			this.cameraCb.TabIndex = 11;
			// 
			// webcamLb
			// 
			this.webcamLb.AutoSize = true;
			this.webcamLb.Location = new System.Drawing.Point(6, 79);
			this.webcamLb.Name = "webcamLb";
			this.webcamLb.Size = new System.Drawing.Size(55, 16);
			this.webcamLb.TabIndex = 10;
			this.webcamLb.Text = "Camera";
			// 
			// scannerPictureBox
			// 
			this.scannerPictureBox.Location = new System.Drawing.Point(6, 114);
			this.scannerPictureBox.Name = "scannerPictureBox";
			this.scannerPictureBox.Size = new System.Drawing.Size(390, 431);
			this.scannerPictureBox.TabIndex = 12;
			this.scannerPictureBox.TabStop = false;
			// 
			// btnDone
			// 
			this.btnDone.AutoSize = false;
			this.btnDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnDone.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.btnDone.Depth = 0;
			this.btnDone.HighEmphasis = true;
			this.btnDone.Icon = null;
			this.btnDone.Location = new System.Drawing.Point(281, 634);
			this.btnDone.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnDone.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnDone.Name = "btnDone";
			this.btnDone.NoAccentTextColor = System.Drawing.Color.Empty;
			this.btnDone.Size = new System.Drawing.Size(115, 36);
			this.btnDone.TabIndex = 16;
			this.btnDone.Text = "Done";
			this.btnDone.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.btnDone.UseAccentColor = false;
			this.btnDone.UseVisualStyleBackColor = true;
			// 
			// btnReset
			// 
			this.btnReset.AutoSize = false;
			this.btnReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.btnReset.Depth = 0;
			this.btnReset.HighEmphasis = true;
			this.btnReset.Icon = null;
			this.btnReset.Location = new System.Drawing.Point(152, 634);
			this.btnReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnReset.Name = "btnReset";
			this.btnReset.NoAccentTextColor = System.Drawing.Color.Empty;
			this.btnReset.Size = new System.Drawing.Size(115, 36);
			this.btnReset.TabIndex = 17;
			this.btnReset.Text = "Reset";
			this.btnReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.btnReset.UseAccentColor = false;
			this.btnReset.UseVisualStyleBackColor = true;
			// 
			// FormScanBarCode
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(402, 679);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.btnScan);
			this.Controls.Add(this.barCodeScannerTb);
			this.Controls.Add(this.barCodeLb);
			this.Controls.Add(this.scannerPictureBox);
			this.Controls.Add(this.cameraCb);
			this.Controls.Add(this.webcamLb);
			this.Name = "FormScanBarCode";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Scan Mã Sản Phẩm";
			((System.ComponentModel.ISupportInitialize)(this.scannerPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialButton btnScan;
		private MaterialSkin.Controls.MaterialTextBox barCodeScannerTb;
		private System.Windows.Forms.Label barCodeLb;
		private System.Windows.Forms.PictureBox scannerPictureBox;
		private System.Windows.Forms.ComboBox cameraCb;
		private System.Windows.Forms.Label webcamLb;
		private MaterialSkin.Controls.MaterialButton btnDone;
		private MaterialSkin.Controls.MaterialButton btnReset;
	}
}