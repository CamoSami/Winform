using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformWithExternalLibrary.DataValidateObject;

namespace WinformWithExternalLibrary.ExtraForm
{

	public partial class FormConfirmHoaDonNhap : MaterialForm
	{
		private bool hasDone = false;

		private HoaDonNhapDVO hoaDonNhapDVO;
		private NhanVienThuNganHDNhapDVO nhanVienThuNganDVO;

		public FormConfirmHoaDonNhap(HoaDonNhapDVO hoaDonNhapDVO, NhanVienThuNganHDNhapDVO nhanVienThuNganDVO)
		{
			this.InitializeComponent();

			this.hoaDonNhapDVO = hoaDonNhapDVO;
			this.nhanVienThuNganDVO = nhanVienThuNganDVO;

			//		Attributes
			this.InitializeHardCodedAttributes();

			//		Events
			this.InitializeSpecializedEvent();
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Enter)
			{
				this.TrySubmittingInput(false);
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void InitializeHardCodedAttributes()
		{
			//		Label for Focus
			this.LabelForFocus.Text = "";

			//		Text
			this.FormConfirmHoaDonNhap_NhanVien.Text = "Nhân viên: " + this.nhanVienThuNganDVO.NhanVienThuNganHDNhapDVO_NhanVien;
			this.FormConfirmHoaDonNhap_NhaCungCap.Text = "Nhà cung cấp: " + this.hoaDonNhapDVO.HoaDonNhapDVO_TenNhaCungCap;
			this.FormConfirmHoaDonNhap_TongTien.Text = "Tồng tiền: " + this.hoaDonNhapDVO.HoaDonNhapDVO_TongTien.ToString();
		}

		private void InitializeSpecializedEvent()
		{
			//		Button
			//			Submit
			this.materialButtonSubmit.Click += (obj, e) =>
			{
				this.TrySubmittingInput(false);
			};

			this.materialButtonExport.Click += (obj, e) =>
			{
				this.TrySubmittingInput(true);
			};

			FormMain.Instance.FormClosed += (obj, eventArgs) =>
			{
				this.Dispose();

				this.Close();

				Environment.Exit(0);
			};

			//			DirtyData check before closing
			this.FormClosing += (obj, e) =>
			{
				if (this.hasDone)
				{
					return;
				}

				//		Dirty Data
				if (MaterialMessageBox.Show(
						text: "Bạn còn thông tin nhập dở, bạn muốn rời không?",
						caption: this.Text,
						buttons: MessageBoxButtons.YesNo,
						icon: MessageBoxIcon.Question,
						UseRichTextBox: false,
						buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
						)
					== DialogResult.Yes
					)
				{

				}
				else
				{
					e.Cancel = true;
				}

				//		No DirtyData OR confirmed Leave
				if (e.Cancel == false)
				{
					//		Actually, meh
					//			Release unmanaged resources
					this.Dispose();

					//			Also release resources, but eh
					this.Close();
				}
			};

			//			Upon clicking the Form => Textbox loses Focus
			this.Click += (obj, e) =>
			{
				this.ActiveControl = null;
			};

			//			Upon loading the Form => Textbox loses Focus
			this.Load += (obj, e) =>
			{
				this.ActiveControl = this.LabelForFocus;

				this.TopMost = true;

				this.Activate();
			};
		}

		private void TrySubmittingInput(bool inHoaDonBan)
		{
			//		Send Query
			//			TODO: Nhập HoaDonban
			FormMain.Instance.NhapHoaDonNhap(this.hoaDonNhapDVO, this.nhanVienThuNganDVO, inHoaDonBan);

			this.hasDone = true;

			this.Close();
		}
	}
}
