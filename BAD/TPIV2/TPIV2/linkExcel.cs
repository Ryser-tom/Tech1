using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace TPIV2
{
    class linkExcel
    {
        private student[] studentArray;
        private teacher[] teacherArray;
        private subject[] subjectArray;

        public void createFile()
        {
            ExcelPackage excel = new ExcelPackage();
            excel.Workbook.Worksheets.Add("Etudiants");
            excel.Workbook.Worksheets.Add("Enseignants");
            excel.Workbook.Worksheets.Add("Sujets");

            var headerRow = new List<string[]>()
            {
                new string[] { "ID", "First Name", "Last Name", "DOB" },
                new string[] { "0", "Tom", "Ryser", "18" }
            };

            // Determine the header range (e.g. A1:D1)
            string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";

            // Target a worksheet
            var worksheet = excel.Workbook.Worksheets["Worksheet1"];

            // Popular header row data
            worksheet.Cells[headerRange].LoadFromArrays(headerRow);

            FileInfo excelFile = new FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +@"\test.xlsx");
            excel.SaveAs(excelFile);
        }
    }

}
