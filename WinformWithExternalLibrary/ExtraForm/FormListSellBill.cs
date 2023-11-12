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
		string KhachHang_MaKhachHang;

		ExportTableData exportTableData = new ExportTableData();

		public FormListSellBill(string KhachHang_MaKhachHang)
		{
			InitializeComponent();

			this.KhachHang_MaKhachHang = KhachHang_MaKhachHang;

			//Debug.WriteLine("FormListSellBill.MaKhachHang: " + KhachHang_MaKhachHang);

			this.Load += (obj, e) =>
			{
				Process();
			};

			this.materialButton_SPTrongDonBan.Click += MaterialButton_SPTrongDonBan_Click;

			this.materialButton_XuatLS.Click += MaterialButton_XuatLS_Click;

			this.materialButton_XuatBill.Click += MaterialButton_XuatBill_Click;

			this.materialButton_Exit.Click += (obj, e) =>
			{
				if (ShowMessageBoxYesNo("Bạn có muốn thoát khỏi lịch sử khách hàng không?"))
				{
					this.Close();
				}
			};
		}

		private void MaterialButton_XuatBill_Click(object sender, EventArgs e)
		{
			try
			{
				int index = this.materialListView_LichSuMuaHang.SelectedIndices[0];

				if (index >= 0)
				{
					ListViewItem listViewItem = this.materialListView_LichSuMuaHang.Items[index];

					string HoaDon_MaHoaDon = listViewItem.SubItems[1].Text;

					try
					{
						DataTable Bill = ChiTietHDBanDAO.Instance.HoaDonInformationFromMaHoaDon(HoaDon_MaHoaDon);
						this.exportTableData.ExportToExcel(
							dataTable: Bill,
							workSheetName: $"Lịch sử mua hàng - Khách hàng có mã {KhachHang_MaKhachHang}",
							filePath: ""
						);

						MaterialMessageBox.Show("Xuất dữ liệu thành công", "Message", UseRichTextBox: false);
					}
					catch (Exception)
					{
						MaterialMessageBox.Show("Lỗi khi export dữ liệu", "Error", UseRichTextBox: false);
					}
				}
			}
			catch (Exception)
			{
				ShowMessageBox("Hãy chọn khách hàng trên bảng trước khi xem lịch sử!");
			}
		}

		private void MaterialButton_XuatLS_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable DTBill = HoaDonBanDAO.Instance.HoaDonBanInformationFromMaKhachHang(KhachHang_MaKhachHang);
				
				foreach (DataRow row in DTBill.Rows) 
				{
					foreach (object obj in row.ItemArray)
					{
						Debug.WriteLine(obj.ToString());
					}
				}

				this.exportTableData.ExportToExcel(
					dataTable: DTBill,
					workSheetName: $"Lịch sử mua hàng - Khách hàng có mã {KhachHang_MaKhachHang}",
					filePath: ""
				);

				MaterialMessageBox.Show("Xuất dữ liệu thành công", "Message", UseRichTextBox: false);
			}
			catch (Exception)
			{
				MaterialMessageBox.Show("Lỗi khi export dữ liệu", "Error", UseRichTextBox: false);
			}

		}



		private void MaterialButton_SPTrongDonBan_Click(object sender, EventArgs e)
		{
			try
			{
				int index = this.materialListView_LichSuMuaHang.SelectedIndices[0];

				if (index >= 0)
				{
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
			}
			catch (Exception)
			{
				ShowMessageBox("Hãy chọn Bill có trên bảng trước khi xem chi tiết Bill!");
			}
		}

		private void Process()
		{
			DataTable DTBill = HoaDonBanDAO.Instance.HoaDonBanInformationFromMaKhachHang(KhachHang_MaKhachHang);
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
