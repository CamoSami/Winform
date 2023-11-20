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
			Empty
		} 

        public void ExportToExcel(DataTable dataTable, string workSheetName, string filePath, TypeOfExcel typeOfFile = TypeOfExcel.Empty)
        {
			try
			{
				XLWorkbook workBook = new XLWorkbook();
				workBook.Worksheets.Add(dataTable, sheetName: workSheetName);

				string path = filePath != "" ? filePath : $"D:\\06_C#_exe\\_Group Project\\Excel\\{workSheetName}.xlsx";
				int i = 0;

				while (File.Exists(path))
				{
					path = filePath != "" ? filePath : $"D:\\06_C#_exe\\_Group Project\\Excel\\{workSheetName}({++i}).xlsx";
				}

				workBook.SaveAs(path);

				IXLWorksheet workSheet = workBook.Worksheet(1);

				//		TODO
				switch (typeOfFile)
				{
					case TypeOfExcel.DMSanPham:

						break;

					case TypeOfExcel.NhanVien:

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

				MaterialMessageBox.Show("Xuất dữ liệu thành công vào " + path, "Message", UseRichTextBox: false);
			} 
			catch (Exception ex)
			{
				MaterialMessageBox.Show("Lỗi khi export dữ liệu: \n\n" + ex.Message, "Error", UseRichTextBox: false);
			}
		}
    }
}
