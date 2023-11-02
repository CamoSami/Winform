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
    public partial class FormChiTietHoaDonBanFormInfo : MaterialForm
    {
        private string MaHoaDon;
        private readonly PhanTichDAO phanTichDAO = new PhanTichDAO();
        private readonly FormatValues formatValues = new FormatValues();

        public FormChiTietHoaDonBanFormInfo(string maHD)
        {
            this.MaHoaDon = maHD;

            InitializeComponent();

            // List View
            this.FormChiTietHoaDonBanInfo_ListView();
        }

        private void FormChiTietHoaDonBanInfo_ListView()
        {
            // Get Data
            List<BillDetailInfomationDTO> billDetailInfoResponseDTOs 
                = phanTichDAO.GetBillsDetailInformation(MaHoaDon: this.MaHoaDon);

            Debug.WriteLine(billDetailInfoResponseDTOs.Count);

            // Render
            int stt = 0;
            foreach (BillDetailInfomationDTO billDetailInfoResponseDTO in billDetailInfoResponseDTOs)
            {
                ListViewItem item = new ListViewItem();
                stt++;

                item.SubItems[0].Text = stt.ToString();
                item.SubItems.Add(billDetailInfoResponseDTO.BillDetailInfomationDTO_MaDMSanPham);
                item.SubItems.Add(billDetailInfoResponseDTO.BillDetailInfomationDTO_TenHangHoa);
                item.SubItems.Add(billDetailInfoResponseDTO.BillDetailInfomationDTO_SoLuong.ToString());
                item.SubItems.Add(formatValues.FormatPriceToView(billDetailInfoResponseDTO.BillDetailInfomationDTO_ThanhTien.ToString(), 3));


                ChiTietHoaDonBanInfoLV.Items.Add(item);
            }
        }
    }
}
