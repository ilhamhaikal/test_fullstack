using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using test_fullstack.Repositories;
using test_fullstack.Services;

namespace test_fullstack.Pages
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        private readonly ExcelService _excelService;
        private readonly DataRepository _dataRepository;

        public DataController(ExcelService excelService, DataRepository dataRepository)
        {
            _excelService = excelService;
            _dataRepository = dataRepository;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadData()
        {
            string filePath = @"C:\Users\PH315-53\source\repos\test_fullstack\test_fullstack\Test untuk programmer.xlsx";

            var dataList = _excelService.ReadExcel(filePath);
            await _dataRepository.SaveDataAsync(dataList);

            return Ok("Data berhasil diunggah ke PostgreSQL");
        }
    }
}
