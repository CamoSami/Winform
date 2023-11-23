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
using WinformWithExternalLibrary.DataAccessObjects;
using WinformWithExternalLibrary._Utilities;
using static WinformWithExternalLibrary.DataTransferObjects.PhanTichDTO;
using MaterialSkin;

namespace WinformWithExternalLibrary.ExtraForm
{
	public partial class FormChiTietHoaDonNhap : MaterialForm
	{
		private string search { get; set; } = "";
		private string dateConverted { get; set; } = "";

		private FormatValues formatValues = new FormatValues();
		private ExportTableData exportTableData = new ExportTableData();
		private GetDateTime getDateTime = new GetDateTime();

		public FormChiTietHoaDonNhap()
		{
			InitializeComponent();

			//		Material Skin Manager
			MaterialSkinManager.Instance.AddFormToManage(this);

			// Bill of import information List View
			this.FormChiTietHoaDonNhap_ListView(search: this.search, dateTimeConverted: this.dateConverted);

			// Event
			this.HandleOpenExtraForm();
			this.HandleSearch();
			this.HandleFilterByDateTime();
			this.HandleClickExportBtn();
		}

		private void FormChiTietHoaDonNhap_ListView(string search, string dateTimeConverted)
		{
			// Get data
			List<BillOfImportInfoResponseDTO> billOfImportInfoResponseDTOs
				= PhanTichDAO.Instance.GetBillOfImportInformation(searchValue: search, dateTimeConverted: dateTimeConverted);

			// Render
			int stt = 0;
			foreach (BillOfImportInfoResponseDTO billOfImportInfoResponseDTO in billOfImportInfoResponseDTOs)
			{
				ListViewItem item = new ListViewItem();
				stt++;

				item.SubItems[0].Text = stt.ToString();
				item.SubItems.Add(billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_MaHDNhap);
				item.SubItems.Add(billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_TenNhanVien);
				item.SubItems.Add(billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_DienThoaiNV);
				item.SubItems.Add(billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_TenNCC);
				item.SubItems.Add(billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_DiaChiNCC);
				item.SubItems.Add(billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_DienThoaiNCC);
				item.SubItems.Add(billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_SoSanPham.ToString());
				item.SubItems.Add(formatValues.FormatPriceToView(billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_TongTien.ToString(), 3));
				item.SubItems.Add(billOfImportInfoResponseDTO.BillOfImportInfoResponseDTO_NgayNhap.ToString("dd/MM/yyyy"));

				ChiTietHoaDonNhapLV.Items.Add(item);
			}
		}

		private void HandleOpenExtraForm()
		{
			ChiTietHoaDonNhapLV.DoubleClick += (object sender, EventArgs e) =>
			{
				var firstSelectedItem = ChiTietHoaDonNhapLV.SelectedItems[0];

				FormChiTietHoaDonNhapInfo formChiTietHoaDonNhapInfo
				= new FormChiTietHoaDonNhapInfo(firstSelectedItem.SubItems[1].Text);
				formChiTietHoaDonNhapInfo.Show();
			};
		}

		private void HandleSearch()
		{
			PhanTichDVO_HDN_TimKiemBtn.Click += (object sender, EventArgs e) =>
			{
				string search = PhanTichDVO_HDN_TimKiemIP.Text;
				// Delete all old items
				ChiTietHoaDonNhapLV.Items.Clear();
				// Render new items
				this.FormChiTietHoaDonNhap_ListView(search: search, dateTimeConverted: "");
				// Clear search on UI and save search value
				this.search = search;
				PhanTichDVO_HDN_TimKiemIP.Text = "";
			};
		}

		private void HandleFilterByDateTime()
		{
			PhanTichDVO_HDN_DP.ValueChanged += (object sender, EventArgs e) =>
			{
				string dateTimeConverted = PhanTichDVO_HDN_DP.Value.ToString("MM/dd/yyyy");
				string search = PhanTichDVO_HDN_TimKiemIP.Text; // Remain search value
				this.dateConverted = dateTimeConverted; // Save date
														// Delete all old items
				ChiTietHoaDonNhapLV.Items.Clear();
				// Render new items
				this.FormChiTietHoaDonNhap_ListView(search: this.search, dateTimeConverted: dateTimeConverted);
			};
		}

		private void HandleClickExportBtn()
		{
			ChiTietHoaDonNhapExelBtn.Click += (object sender, EventArgs e) =>
			{
				DataTable dataTable = PhanTichDAO.Instance.GetBillOfImportInfomationDataTable(searchValue: this.search, dateTimeConverted: this.dateConverted);

				this.exportTableData.ExportToExcel(
					dataTable: dataTable,
					workSheetName: "HoaDonNhap" + this.getDateTime.GetDateTimeNow_Date(),
					typeOfFile: ExportTableData.TypeOfExcel.HoaDonNhap
				);
			};
		}
	}
}
