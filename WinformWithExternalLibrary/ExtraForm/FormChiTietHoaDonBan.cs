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
using WinformWithExternalLibrary.Utils;
using static WinformWithExternalLibrary.DataTransferObjects.CustomDTO.PhanTichDTO;

namespace WinformWithExternalLibrary.ExtraForm
{
    public partial class FormChiTietHoaDonBan : MaterialForm
    {
        PhanTichDAO phanTichDAO = new PhanTichDAO();
        FormatValues formatValues = new FormatValues();
        ExportTableData exportTableData = new ExportTableData();

        public FormChiTietHoaDonBan()
        {
            InitializeComponent();

            // Bill of seller information List View
            this.FormChiTietHoaDonBan_ListView();

            // Event
            this.HandleClickExportBtn();
        }

        private void FormChiTietHoaDonBan_ListView()
        {
            // Get data
            List<BillsOfSellerInfoResponseDTO> billsOfSellerInfoResponseDTOs = this.phanTichDAO.GetBillsOfSellerInformation();

            // Render
            int stt = 0;
            foreach(BillsOfSellerInfoResponseDTO billsOfSellerInfoResponseDTO in billsOfSellerInfoResponseDTOs)
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
                item.SubItems.Add(formatValues.FormatPriceToView(billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_GiamGia.ToString(), 3));
                item.SubItems.Add(formatValues.FormatPriceToView(billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_TongTien.ToString(), 3));
                item.SubItems.Add(billsOfSellerInfoResponseDTO.BillOfSellerInfoResponseDTO_NgayBan.ToShortDateString());

                ChiTietHoaDonBanLV.Items.Add(item);
            }
        }

        private void HandleClickExportBtn()
        {
            ChiTietHoaDonExelBtn.Click += (object sender, EventArgs e) =>
            {
                try
                {
                    DataTable dataTable = this.phanTichDAO.GetBillsOfSellerInformationDataTable();
                    this.exportTableData.ExportToExcel(
                        dataTable: dataTable,
                        workSheetName: "Chi tiết hóa đơn",
                        filePath: ""
                    );

                    MaterialMessageBox.Show("Xuất dữ liệu thành công", "Message");
                }
                catch(Exception)
                {
                    MaterialMessageBox.Show("Lỗi khi export dữ liệu", "Error");
                }
            };
        }
    }
}
