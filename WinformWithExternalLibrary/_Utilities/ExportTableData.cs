using ClosedXML.Excel;
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
        public void ExportToExcel(DataTable dataTable, string workSheetName, string filePath)
        {
            XLWorkbook wb = new XLWorkbook();
            wb.Worksheets.Add(dataTable, sheetName: workSheetName);

            var path = filePath != "" ? filePath : "E:\\Winform\\" + workSheetName + ".xlsx";
            wb.SaveAs(path);
        }
    }
}
