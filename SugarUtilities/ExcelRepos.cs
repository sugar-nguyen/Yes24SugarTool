using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace SugarUtilities
{
    /// <summary>
    /// Xử lý tác vụ liên quan đến excel
    /// </summary>
    public class ExcelRepos
    {
        /// <summary>
        /// Đọc file và trả dữ liệu về dạng datatable
        /// </summary>
        /// <param name="filePath">đường dẫn file</param>
        /// <param name="sheetName">Tên của excel sheet</param>
        /// <returns>DataTable</returns>
        public static DataTable ReadFile(string filePath, string sheetName = "")
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new Exception("Duong dan file khong duoc bo trong");
            }

            try
            {

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                FileInfo fileInfo = new FileInfo(filePath);

                ExcelPackage package = new ExcelPackage(fileInfo);

                if (string.IsNullOrEmpty(sheetName))
                {
                    sheetName = package.Workbook.Worksheets.First().Name;
                }

                ExcelWorksheet worksheet = package.Workbook.Worksheets[sheetName];

                int rows = worksheet.Dimension.Rows;
                int columns = worksheet.Dimension.Columns;

                DataTable dataTable = new DataTable();

                for (int col = 1; col <= columns; col++)
                {
                    dataTable.Columns.Add(col.ToString());
                }

                for (int row = 1; row <= rows; row++)
                {
                    string[] arr = new string[columns];
                    for (int col = 1; col <= columns; col++)
                    {
                        arr[col - 1] = worksheet.Cells[row, col].Value != null ? worksheet.Cells[row, col].Value.ToString().Trim() : "";
                    }
                    dataTable.Rows.Add(arr);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
