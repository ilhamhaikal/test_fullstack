using System.ComponentModel;
using test_fullstack.Models;

namespace test_fullstack.Services
{
    public class ExcelService
    {
        public List<DataModel> ReadExcel(string filePath)
        {
            var dataList = new List<DataModel>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Ambil sheet pertama
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++) // Mulai dari baris kedua, anggap baris pertama adalah header
                {
                    var data = new DataModel
                    {
                        Nama = worksheet.Cells[row, 1].Value.ToString(),
                        Jabatan = worksheet.Cells[row, 2].Value.ToString(),
                        Gaji = decimal.Parse(worksheet.Cells[row, 3].Value.ToString())
                    };
                    dataList.Add(data);
                }
            }

            return dataList;
        }
    }
}
