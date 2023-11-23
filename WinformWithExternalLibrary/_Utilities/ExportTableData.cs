using ClosedXML.Excel;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformWithExternalLibrary._Utilities
{
    public class ExportTableData
    {
		public enum TypeOfExcel
		{
			HoaDonBan,
			HoaDonNhap,
			ChiTietHDBan,
			ChiTietHDNhap,
			KhachHang,
			NhaCungCap,
			NhanVien,
			DMSanPham,
			GiamGia,
			Empty
		}

		private string filePath = $"D:\\06_C#_exe\\_Group Project\\Excel\\";


		public void ExportToExcel(DataTable dataTable, string workSheetName, TypeOfExcel typeOfFile = TypeOfExcel.Empty)
        {
			try
			{
				XLWorkbook workBook = new XLWorkbook();
				workBook.Worksheets.Add(dataTable, sheetName: workSheetName);

				string workSheetAdjustedName = $"{workSheetName}.xlsx";
				int i = 0;

				while (File.Exists(this.filePath + workSheetAdjustedName))
				{
					workSheetAdjustedName = $"{workSheetName}({++i}).xlsx";
				}

				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Excel files: (*.xlsx)|*.xlsx|All files (*.*)|*.*";
				saveFileDialog.FileName = workSheetAdjustedName;
				saveFileDialog.InitialDirectory = this.filePath;

				if (saveFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}

				this.filePath = saveFileDialog.FileName.Substring(0, saveFileDialog.FileName.Length - saveFileDialog.FileName.Split('\\').Last().Length);

				workBook.SaveAs(saveFileDialog.FileName);

				IXLWorksheet workSheet = workBook.Worksheet(1);

				//		TODO
				switch (typeOfFile)
				{
					case TypeOfExcel.DMSanPham:

						workSheet.Column(1).Width = 5;
						workSheet.Column(2).Width = 30;
						workSheet.Column(3).Width = 50;
						workSheet.Column(4).Width = 15;
						workSheet.Column(5).Width = 15;
						workSheet.Column(6).Width = 18;
						workSheet.Column(7).Width = 20;

						break;

					case TypeOfExcel.GiamGia:

						workSheet.Column(1).Width = 40;
						workSheet.Column(2).Width = 40;
						workSheet.Column(3).Width = 15;
						workSheet.Column(4).Width = 15;
						workSheet.Column(5).Width = 10;
						workSheet.Column(6).Width = 20;

						break;

					case TypeOfExcel.NhanVien:

						workSheet.Column(1).Width = 40;
						workSheet.Column(2).Width = 25;
						workSheet.Column(3).Width = 12.5;
						workSheet.Column(4).Width = 7.5;
						workSheet.Column(5).Width = 12.5;
						workSheet.Column(6).Width = 40;
						workSheet.Column(7).Width = 30;

						break;

					case TypeOfExcel.KhachHang:
					case TypeOfExcel.NhaCungCap:

						workSheet.Column(1).Width = 37.5;
						workSheet.Column(2).Width = 25;
						workSheet.Column(3).Width = 40;
						workSheet.Column(4).Width = 12.5;

						break;

					case TypeOfExcel.ChiTietHDBan:
					case TypeOfExcel.ChiTietHDNhap:

						workSheet.Column(1).Width = 37.5;
						workSheet.Column(2).Width = 60;
						workSheet.Column(3).Width = 2.5;
						workSheet.Column(4).Width = 12.5;

						break;

					case TypeOfExcel.HoaDonBan:

						workSheet.Column(1).Width = 37.5;
						workSheet.Column(2).Width = 17.5;
						workSheet.Column(3).Width = 12.5;
						workSheet.Column(4).Width = 12.5;
						workSheet.Column(5).Width = 2.5;
						workSheet.Column(6).Width = 15;
						workSheet.Column(7).Width = 12.5;
						workSheet.Column(8).Width = 17.5;

						break;

					case TypeOfExcel.HoaDonNhap:

						workSheet.Column(1).Width = 37.5;
						workSheet.Column(2).Width = 17.5;
						workSheet.Column(3).Width = 12.5;
						workSheet.Column(4).Width = 20;
						workSheet.Column(5).Width = 40;
						workSheet.Column(6).Width = 12.5;
						workSheet.Column(7).Width = 2.5;
						workSheet.Column(8).Width = 12.5;
						workSheet.Column(9).Width = 17.5;

						break;

					default:

						break;
				}

				workBook.Save();

				MaterialMessageBox.Show("Xuất dữ liệu thành công vào " + saveFileDialog.FileName, "Message", UseRichTextBox: false);
			} 
			catch (Exception ex)
			{
				MaterialMessageBox.Show("Lỗi khi export dữ liệu: \n\n" + ex.Message, "Error", UseRichTextBox: false);
			}
		}
    }
}
