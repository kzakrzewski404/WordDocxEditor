using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

using WordDocxEditor.Common;


namespace WordDocxEditor.History
{
    public class Exporter
    {
        private static string _desktopOutputDirectory = "";
        private static bool _isInitialized;
        private static Microsoft.Office.Interop.Excel.Application _excelApp;
        private Worksheet _worksheet;


        public bool ExportToExcel(DataGridView source) => SaveData(source);


        private void copyAlltoClipboard(DataGridView source)
        {
            source.SelectAll();
            DataObject dataObj = source.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }


        private void GenerateHeader(Worksheet workSheet, DataGridView source)
        {
            //todo: docelowy font ms san serif 10

            for (int i = 0; i < source.Columns.Count; i++)
            {
                workSheet.Cells[1, i + 1] = source.Columns[i].HeaderText;
                //workSheet.Columns[1, i + 1].Width = source.Columns[i].Width;
                //((Range)workSheet.Cells[1, i]).EntireColumn.ColumnWidth = source.Columns[i - 1].Width;
                ((Range)workSheet.Cells[1, i + 1]).EntireColumn.ColumnWidth = source.Columns[i].Width / 6;
            }
        }

        private bool SaveData(DataGridView source)
        {
            Initialize();

            bool hasTriedToLocalizeExcelApp = false;
            for (int t = 0; t < 2; t++)
            {
                try
                {
                    Workbook book;
                    Worksheet sheet;
                    object missingValue = System.Reflection.Missing.Value;
                    book = _excelApp.Workbooks.Add(missingValue);
                    sheet = (Worksheet)book.Worksheets.get_Item(1);
                    _excelApp.Visible = true;

                    GenerateHeader(sheet, source);
                    //// storing header part in Excel  
                    //for (int i = 1; i < source.Columns.Count + 1; i++)
                    //{
                    //    sheet.Cells[1, i] = source.Columns[i - 1].HeaderText;
                    //}
                    // storing Each row and column value to excel sheet  
                    for (int i = 0; i < source.Rows.Count; i++)
                    {
                        for (int j = 0; j < source.Columns.Count; j++)
                        {
                            sheet.Cells[i + 2, j + 1] = source.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    break;
                }
                catch (Exception e)
                {
                    if (hasTriedToLocalizeExcelApp)
                    {
                        CloseExcelFile();
                        return false;
                    }
                    else
                    {
                        hasTriedToLocalizeExcelApp = true;
                        LocalizeExcelApp();
                        continue;
                    }
                }
            }

            return true;
        }

        private void Initialize()
        {
            if (!_isInitialized)
            {
                _isInitialized = true;
                _desktopOutputDirectory = new DirectoryPaths().DesktopOutput;
                LocalizeExcelApp();
            }
        }

        private void LocalizeExcelApp()
        {
            _excelApp = new Microsoft.Office.Interop.Excel.Application();
            //_excelApp.StandardFont = "Arial";
            //_excelApp.StandardFontSize = 11;
        }

        private void CloseExcelFile()
        {
            object missing = System.Reflection.Missing.Value;
            _excelApp.Quit();
        }

        private bool CanCreateFile(string targetFilePath)
        {
            if (File.Exists(targetFilePath))
            {
                DialogResult result = MessageBox.Show($"Plik {Path.GetFileName(targetFilePath)} już istnieje, nadpisać?",
                                                      "Plik już istnieje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    File.Delete(targetFilePath);
                    return true;
                }

                return false;
            }

            return true;
        }
    }
}