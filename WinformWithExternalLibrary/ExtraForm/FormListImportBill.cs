using MaterialSkin;
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
using WinformWithExternalLibrary._Utilities;
using WinformWithExternalLibrary.DataAccessObjects;

namespace WinformWithExternalLibrary.ExtraForm
{
	public partial class FormListImportBill : MaterialForm
	{
		string NhaCungCap_DienThoaiCungCap;

		ExportTableData exportTableData = new ExportTableData();
		public FormListImportBill(string NhaCungCap_DienThoaiCungCap)
		{
			InitializeComponent();

			//		Material Skin Manager
			MaterialSkinManager.Instance.AddFormToManage(this);

			this.NhaCungCap_DienThoaiCungCap = NhaCungCap_DienThoaiCungCap;

			this.Load += (obj, e) =>
			{
				Process();
			};

			this.materialButton_XuatBill.Click += (obj, e) =>
			{
				if (this.materialListView_LichSuNhapHang.SelectedIndices.Count <= 0)
				{
					this.ShowMessageBox("Hãy chọn khách hàng trên bảng trước khi xem lịch sử!");

					return;
				}

				int index = this.materialListView_LichSuNhapHang.SelectedIndices[0];

				if (index >= 0)
				{
					ListViewItem listViewItem = this.materialListView_LichSuNhapHang.Items[index];

					string HoaDon_MaHoaDon = listViewItem.SubItems[1].Text;

					DataTable Bill = ChiTietHDNhapDAO.Instance.HoaDonInformationFromMaHoaDon(HoaDon_MaHoaDon);

					this.exportTableData.ExportToExcel(
						dataTable: Bill,
						workSheetName: $"ChiTietHDNhap_{HoaDon_MaHoaDon.Split('-')[0]}",
						filePath: "",
						typeOfFile: ExportTableData.TypeOfExcel.ChiTietHDNhap
					);
				}
			};

			this.materialButton_XuatLS.Click += (obj, e) =>
			{
				DataTable DTBill = HoaDonNhapDAO.Instance.HoaDonNhapInformationFromSoDienThoai(this.NhaCungCap_DienThoaiCungCap);

				//foreach (DataRow row in DTBill.Rows)
				//{
				//	foreach (object obj in row.ItemArray)
				//	{
				//		Debug.WriteLine(obj.ToString());
				//	}
				//}

				this.exportTableData.ExportToExcel(
					dataTable: DTBill,
					workSheetName: $"HoaDonNhap_{this.NhaCungCap_DienThoaiCungCap}",
					filePath: "",
					typeOfFile: ExportTableData.TypeOfExcel.HoaDonNhap
				);
			};

			this.materialListView_LichSuNhapHang.SelectedIndexChanged += materialListView_LichSuNhapHang_SelectedIndexChanged;

			this.materialButton_Exit.Click += (obj, e) =>
			{
				if (ShowMessageBoxYesNo("Bạn có muốn thoát khỏi lịch sử khách hàng không?"))
				{
					this.Close();
				}
			};
		}

		private void materialListView_LichSuNhapHang_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.materialListView_LichSuNhapHang.SelectedIndices.Count <= 0)
			{
				return;
			}

			try
			{
				int index = this.materialListView_LichSuNhapHang.SelectedIndices[0];

				if (index >= 0)
				{
					ListViewItem listViewItem = this.materialListView_LichSuNhapHang.Items[index];

					string HoaDon_MaHoaDon = listViewItem.SubItems[1].Text;

					DataTable Bill = ChiTietHDNhapDAO.Instance.HoaDonInformationFromMaHoaDon(HoaDon_MaHoaDon);
					ListViewItem item;

					this.materialListView_HangCoTrongBill.Items.Clear();

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
			}
			catch (Exception)
			{
				ShowMessageBox("Hãy chọn Bill có trên bảng trước khi xem chi tiết Bill!");
			}
		}

		private void Process()
		{
			DataTable DTBill = HoaDonNhapDAO.Instance.HoaDonNhapInformationFromSoDienThoai(NhaCungCap_DienThoaiCungCap);
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
				this.materialListView_LichSuNhapHang.Items.Add(item);
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
