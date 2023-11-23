using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformWithExternalLibrary._Utilities;
using WinformWithExternalLibrary.DataAccessObjects;

namespace WinformWithExternalLibrary.ExtraForm
{
	public partial class FormListSellBill : MaterialForm
	{
		private string KhachHang_SoDienThoai;
		private readonly ExportTableData exportTableData = new ExportTableData();

		public FormListSellBill(string KhachHang_SoDienThoai)
		{
			this.InitializeComponent();

			//		Material Skin Manager
			MaterialSkinManager.Instance.AddFormToManage(this);

			this.KhachHang_SoDienThoai = KhachHang_SoDienThoai;

			//Debug.WriteLine("FormListSellBill.MaKhachHang: " + KhachHang_MaKhachHang);

			this.Load += (obj, e) =>
			{
				this.Process();
			};

			this.materialButton_XuatLS.Click += this.MaterialButton_XuatLS_Click;

			this.materialButton_XuatBill.Click += this.MaterialButton_XuatBill_Click;

			this.materialListView_LichSuMuaHang.SelectedIndexChanged += this.MaterialListView_LichSuMuaHang_SelectedIndexChanged;

			this.materialButton_Exit.Click += (obj, e) =>
			{
				if (this.ShowMessageBoxYesNo("Bạn có muốn thoát khỏi lịch sử khách hàng không?"))
				{
					this.Close();
				}
			};
		}

		private void MaterialButton_XuatBill_Click(object sender, EventArgs e)
		{
			if (this.materialListView_LichSuMuaHang.SelectedIndices.Count <= 0)
			{
				this.ShowMessageBox("Hãy chọn khách hàng trên bảng trước khi xem lịch sử!");

				return;
			}

			int index = this.materialListView_LichSuMuaHang.SelectedIndices[0];

			if (index >= 0)
			{
				ListViewItem listViewItem = this.materialListView_LichSuMuaHang.Items[index];

				string HoaDon_MaHoaDon = listViewItem.SubItems[1].Text;

				DataTable Bill = ChiTietHDBanDAO.Instance.HoaDonInformationFromMaHoaDon(HoaDon_MaHoaDon);

				this.exportTableData.ExportToExcel(
					dataTable: Bill,
					workSheetName: $"ChiTietHDBan_{HoaDon_MaHoaDon.Split('-')[0]}",
					typeOfFile: ExportTableData.TypeOfExcel.ChiTietHDBan
				);
			}
		}

		private void MaterialButton_XuatLS_Click(object sender, EventArgs e)
		{
			DataTable DTBill = HoaDonBanDAO.Instance.HoaDonBanInformationFromSoDienThoai(KhachHang_SoDienThoai);

			//foreach (DataRow row in DTBill.Rows)
			//{
			//	foreach (object obj in row.ItemArray)
			//	{
			//		Debug.WriteLine(obj.ToString());
			//	}
			//}

			this.exportTableData.ExportToExcel(
				dataTable: DTBill,
				workSheetName: $"HoaDonBan_{KhachHang_SoDienThoai}",
				typeOfFile: ExportTableData.TypeOfExcel.HoaDonBan
			);

		}



		private void MaterialListView_LichSuMuaHang_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.materialListView_HangCoTrongBill.Items.Clear();

			if (this.materialListView_LichSuMuaHang.SelectedIndices.Count <= 0)
			{
				return;
			}

			int index = this.materialListView_LichSuMuaHang.SelectedIndices[0];

			ListViewItem listViewItem = this.materialListView_LichSuMuaHang.Items[index];

			string HoaDon_MaHoaDon = listViewItem.SubItems[1].Text;

			DataTable Bill = ChiTietHDBanDAO.Instance.HoaDonInformationFromMaHoaDon(HoaDon_MaHoaDon);
			ListViewItem item;

			int cnt = 0;

			foreach (DataRow row in Bill.Rows)
			{
				item = new ListViewItem();
				cnt += 1;
				item.SubItems[0].Text = cnt.ToString();
				for (int i = 0; i < Bill.Columns.Count; i++)
				{
					item.SubItems.Add(row[i].ToString().Trim());
				}
				this.materialListView_HangCoTrongBill.Items.Add(item);
			}
		}

		private void Process()
		{
			DataTable DTBill = HoaDonBanDAO.Instance.HoaDonBanInformationFromSoDienThoai(KhachHang_SoDienThoai);
			ListViewItem item;

			int cnt = 0;
			foreach (DataRow row in DTBill.Rows)
			{
				item = new ListViewItem();
				cnt += 1;
				item.SubItems[0].Text = cnt.ToString();
				for (int i = 0; i < DTBill.Columns.Count; i++)
				{
					item.SubItems.Add(row[i].ToString().Trim());
				}
				this.materialListView_LichSuMuaHang.Items.Add(item);
			}
		}

		private void ShowMessageBox(string message)
		{
			MaterialMessageBox.Show(
					text: message,
					caption: "Notification",
					UseRichTextBox: false,
					buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
					);

		}

		private bool ShowMessageBoxYesNo(string message)
		{
			bool ifYes = MaterialMessageBox.Show(
							text: message,
							caption: "Notification",
							buttons: MessageBoxButtons.YesNo,
							icon: MessageBoxIcon.Question,
							UseRichTextBox: false,
							buttonsPosition: FlexibleMaterialForm.ButtonsPosition.Center
							)
						== DialogResult.Yes;


			return ifYes;
		}
	}
}
