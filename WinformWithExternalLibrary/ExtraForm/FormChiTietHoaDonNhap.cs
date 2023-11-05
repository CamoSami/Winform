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
using WinformWithExternalLibrary.Utils;
using static WinformWithExternalLibrary.DataTransferObjects.CustomDTO.PhanTichDTO;

namespace WinformWithExternalLibrary.ExtraForm
{
    public partial class FormChiTietHoaDonNhap : MaterialForm
    {

        PhanTichDAO phanTichDAO = new PhanTichDAO();
        FormatValues formatValues = new FormatValues();
        ExportTableData exportTableData = new ExportTableData();

        public FormChiTietHoaDonNhap()
        {
            InitializeComponent();

            // Bill of import information List View
            this.FormChiTietHoaDonNhap_ListView();

            // Event
            this.HandleOpenExtraForm();
        }

        private void FormChiTietHoaDonNhap_ListView()
        {
            // Get data
            List<BillOfImportInfoResponseDTO> billOfImportInfoResponseDTOs = this.phanTichDAO.GetBillOfImportInformation();

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
    }
}
