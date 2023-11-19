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
using static WinformWithExternalLibrary.DataTransferObjects.PhanTichDTO;
using MaterialSkin;

namespace WinformWithExternalLibrary.ExtraForm
{
    public partial class FormChiTietHoaDonBanInfo : MaterialForm
    {
        private string MaHoaDon;
        private readonly PhanTichDAO phanTichDAO = new PhanTichDAO();
        private readonly FormatValues formatValues = new FormatValues();

        public FormChiTietHoaDonBanInfo(string maHD)
        {
            this.MaHoaDon = maHD;

            InitializeComponent();

			//		Material Skin Manager
			MaterialSkinManager.Instance.AddFormToManage(this);

			// List View
			this.FormChiTietHoaDonBanInfo_ListView();
        }

        private void FormChiTietHoaDonBanInfo_ListView()
        {
            // Get Data
            List<BillDetailInfomationDTO> billDetailInfoResponseDTOs 
                = phanTichDAO.GetBillsDetailInformation(MaHoaDon: this.MaHoaDon);

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
