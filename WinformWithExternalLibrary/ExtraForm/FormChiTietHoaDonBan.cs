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
using WinformWithExternalLibrary.DataAccessObjects;
using WinformWithExternalLibrary._Utilities;
using static WinformWithExternalLibrary.DataTransferObjects.CustomDTO.PhanTichDTO;

namespace WinformWithExternalLibrary.ExtraForm
{
	public partial class FormChiTietHoaDonBan : MaterialForm
	{
		private string search { get; set; } = "";
		private string dateConverted { get; set; } = "";

		FormatValues formatValues = new FormatValues();
		ExportTableData exportTableData = new ExportTableData();
		GetDateTime getDateTime = new GetDateTime();

		public FormChiTietHoaDonBan()
		{
			InitializeComponent();

			//		Material Skin Manager
			MaterialSkinManager.Instance.AddFormToManage(this);

			// Bill of seller information List View
			this.FormChiTietHoaDonBan_ListView(search: this.search, dateTimeConverted: this.dateConverted);

			// Event
			this.HandleClickExportBtn();
			this.HandleOpenExtraForm();
			this.HandleSearch();
			this.HandleFilterByDateTime();
		}

		private void FormChiTietHoaDonBan_ListView(string search, string dateTimeConverted)
		{
			// Get data
			List<BillsOfSellerInfoResponseDTO> billsOfSellerInfoResponseDTOs = PhanTichDAO.Instance.GetBillsOfSellerInformation(searchValue: search, dateTimeConverted: dateTimeConverted);

			// Render
			int stt = 0;
			foreach (BillsOfSellerInfoResponseDTO billsOfSellerInfoResponseDTO in billsOfSellerInfoResponseDTOs)
			{
				ListViewItem item = new ListViewItem();
				stt++;

				item.SubItems[0].Text = stt.ToString();
				item.SubItems.Add(billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_MaHDBan);
				item.SubItems.Add(billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_TenNhanVien);
				item.SubItems.Add(billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_DienThoaiNV);
				item.SubItems.Add(billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_TenKhachHang);
				item.SubItems.Add(billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_DienThoaiKH);
				item.SubItems.Add(billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_SoSanPham.ToString());
				item.SubItems.Add(billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_GiamGia);
				item.SubItems.Add(formatValues.FormatPriceToView(billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_TongTien.ToString(), 3));
				item.SubItems.Add(billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_NgayBan.ToString("dd/MM/yyyy"));

				ChiTietHoaDonBanLV.Items.Add(item);
			}
		}

		private void HandleClickExportBtn()
		{
			ChiTietHoaDonExelBtn.Click += (object sender, EventArgs e) =>
			{
				DataTable dataTable = PhanTichDAO.Instance.GetBillsOfSellerInformationDataTable(searchValue: this.search, dateTimeConverted: this.dateConverted);
				this.exportTableData.ExportToExcel(
					dataTable: dataTable,
					workSheetName: "HoaDonBan" + this.getDateTime.GetDateTimeNow_Date(),
					filePath: "",
					typeOfFile: ExportTableData.TypeOfExcel.HoaDonBan
				);

			};
		}

		private void HandleOpenExtraForm()
		{
			ChiTietHoaDonBanLV.DoubleClick += (object sender, EventArgs e) =>
			{
				var firstSelectedItem = ChiTietHoaDonBanLV.SelectedItems[0];

				FormChiTietHoaDonBanInfo formChiTietHoaDonBanFormInfo
				= new FormChiTietHoaDonBanInfo(firstSelectedItem.SubItems[1].Text);
				formChiTietHoaDonBanFormInfo.Show();
			};
		}

		private void HandleSearch()
		{
			PhanTichDVO_HDB_TimKiemBtn.Click += (object sender, EventArgs e) =>
			{
				string search = PhanTichDVO_HDB_TimKiemIP.Text;
				// Delete all old items
				ChiTietHoaDonBanLV.Items.Clear();
				// Render new items
				this.FormChiTietHoaDonBan_ListView(search: search, dateTimeConverted: "");
				// Clear search on UI and save search value
				this.search = search;
				PhanTichDVO_HDB_TimKiemIP.Text = "";
			};
		}

		private void HandleFilterByDateTime()
		{
			PhanTichDVO_HDB_DP.ValueChanged += (object sender, EventArgs e) =>
			{
				string dateTimeConverted = PhanTichDVO_HDB_DP.Value.ToString("MM/dd/yyyy");
				string search = PhanTichDVO_HDB_TimKiemIP.Text; // Remain search value
				this.dateConverted = dateTimeConverted; // Save date
														// Delete all old items
				ChiTietHoaDonBanLV.Items.Clear();
				// Render new items
				this.FormChiTietHoaDonBan_ListView(search: this.search, dateTimeConverted: dateTimeConverted);
			};
		}
	}
}
