﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace softQld
{

    //Xuất bảng điểm cho lớp học
    class ExportToExcelBangdiemlop
    {
        // taọ các đối tượng Excel
        public Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
        public Microsoft.Office.Interop.Excel.Workbooks oBooks;
        public Microsoft.Office.Interop.Excel.Sheets oSheets;
        public Microsoft.Office.Interop.Excel.Workbook oBook;
        public Microsoft.Office.Interop.Excel.Worksheet oSheet;
        public void Export(DataTable dt, string sheetName, string title)
        {       
            //Tạo mới một Excel WorkBook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("D1", "F1");


            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "16";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            // Tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã Lớp";
            cl1.ColumnWidth = 10;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Mã Học Sinh";
            cl2.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Họ Tên";
            cl3.ColumnWidth = 11.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Mã Môn";
            cl4.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Tên Môn";
            cl5.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Năm Học";
            cl6.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Học Kỳ";
            cl7.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Điểm TB Học Kỳ";
            cl8.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Điểm TB Cả Năm";
            cl9.ColumnWidth = 13.0;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "I3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;


            int rowEnd = rowStart + dt.Rows.Count - 1;
            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;

            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột STT
            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
    }

    //lơp ket xuat diem theo mon hoc

    class ExportToExcelBangdiemmon
    {
        public void Export(DataTable dt, string sheetName, string title)
        {
            // taọ các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;


            //Tạo mới một Excel WorkBook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("E1", "I1");

            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "16";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã Lớp";
            cl1.ColumnWidth = 10;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Mã Học Sinh";
            cl2.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Họ Tên";
            cl3.ColumnWidth = 11.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Mã Môn";
            cl4.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Tên Môn";
            cl5.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Năm Học";
            cl6.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Học Kỳ";
            cl7.ColumnWidth = 13.0;
            
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Điểm Miệng L1";
            cl8.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Điểm Miệng L2";
            cl9.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Điểm 15' L1";
            cl10.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");
            cl11.Value2 = "Điểm 15' L2";
            cl11.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("L3", "L3");
            cl12.Value2 = "Điểm 45'";
            cl12.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl13 = oSheet.get_Range("M3", "M3");
            cl13.Value2 = "Điểm Học kỳ";
            cl13.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range cl14 = oSheet.get_Range("N3", "N3");
            cl14.Value2 = "Điểm TB Học Kỳ";
            cl14.ColumnWidth = 13.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "N3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;
            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;

            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột STT
            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
    }
}
