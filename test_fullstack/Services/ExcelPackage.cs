

namespace test_fullstack.Services
{
    internal class ExcelPackage : IDisposable
    {
        internal object Workbook;

        public ExcelPackage(FileInfo fileInfo)
        {
            FileInfo = fileInfo;
        }

        public static object LicenseContext { get; internal set; }
        public FileInfo FileInfo { get; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}