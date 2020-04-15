using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;
using ExcelApplication = Microsoft.Office.Interop.Excel.Application;

using WordDocxEditor.Common;


namespace WordDocxEditor.History
{
    public class Exporter
    {
        private string _desktopOutputDirectory = "";
        private bool _isInitialized;
        private ExcelApplication _excelApp;
        private Worksheet _workSheet;
        private Process[] _processesBeforeExporting;

        public bool ExportToExcel(DataGridView data)
        { 
            Initialize();
            _processesBeforeExporting = Process.GetProcessesByName("EXCEL");
            string outputFilePath = _desktopOutputDirectory + $"\\Historia wygenerowanych plików - " +
                                                              $"{DateTime.Now.ToString("H.mm.ss - dd.MM.yyyy")}.xlsx";
            if (TryOpenExcelApp() && TryCreateWorkSheet())
            {
                try
                {
                    GenerateHeader(data);
                    GenerateContent(data);
                    _workSheet.SaveAs(outputFilePath);
                    CloseExcelApp();
                    return true;
                }
                catch { /* Empty */ }
            }

            CloseExcelApp();
            return false;
        }


        private bool TryOpenExcelApp()
        {
            try
            {
                _excelApp = new ExcelApplication();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private bool TryCreateWorkSheet()
        {
            try
            {
                Workbooks books = _excelApp.Workbooks; // <-- The important part
                Workbook book = books.Add(System.Reflection.Missing.Value);

                //Workbook book = _excelApp.Workbooks.Add(System.Reflection.Missing.Value);
                _workSheet = (Worksheet)book.Worksheets.get_Item(1);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void CloseExcelApp()
        {
            _excelApp?.Workbooks.Close();
            _excelApp?.Quit();

            Process[] processesAfterExporting = Process.GetProcessesByName("EXCEL");
            List<Process> exporterProcess = processesAfterExporting.Where(x => !_processesBeforeExporting.Any(y => x.Id == y.Id)).ToList();

            foreach (Process proc in exporterProcess)
            {
                proc.Kill();
            }
        }

        private void GenerateHeader(DataGridView data)
        {
            for (int i = 0; i < data.Columns.Count; i++)
            {
                _workSheet.Cells[1, i + 1] = data.Columns[i].HeaderText;
                ((Range)_workSheet.Cells[1, i + 1]).EntireColumn.ColumnWidth = data.Columns[i].Width * 0.14f;
                ((Range)_workSheet.Cells[1, i + 1]).Font.Bold = true;
            }
        }

        private void GenerateContent(DataGridView data)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    _workSheet.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void Initialize()
        {
            if (!_isInitialized)
            {
                _isInitialized = true;
                _desktopOutputDirectory = new DirectoryPaths().DesktopOutput;
            }
        }
    }
}