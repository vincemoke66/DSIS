using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DSIS
{
    class DBGetter
    {
        

        String id;
        public DBGetter(String id)
        {
            this.id = id;
        }
        
        public List<String> getRowData(int sheetNum)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Program Files\DSIS\DB.xlsx");
            Excel._Worksheet xlStudentSheet = xlWorkbook.Sheets[sheetNum];
            Excel.Range xlRange = xlStudentSheet.UsedRange;

            List<String> rowData = new List<string>();

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for (int r = 1; r <= rowCount; r++)
            {
                for (int c = 1; c <= colCount; c++)
                {
                    if (xlRange.Cells[r, 1].Value2.ToString().Equals(id) && c != 1)
                        rowData.Add(xlRange.Cells[r, c].Value2.ToString());
                }                            
            }

            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlStudentSheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

            return rowData;          

        }

        public void setRowData(String studentID, String pass)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook;
            Excel._Worksheet xlStudentSheet;
            Excel.Range xlRange;
            
            xlApp.DisplayAlerts = false;

            xlWorkbook = xlApp.Workbooks.Open(@"C:\Program Files\DSIS\DB.xlsx", 0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            xlStudentSheet = xlWorkbook.Sheets[1];
            xlRange = xlStudentSheet.UsedRange;

            int rowCount = xlRange.Rows.Count;

            xlStudentSheet.Cells[rowCount + 1, 1] = studentID;
            xlStudentSheet.Cells[rowCount + 1, 2] = pass;

            xlWorkbook.SaveAs(@"C:\Program Files\DSIS\DB.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlStudentSheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
