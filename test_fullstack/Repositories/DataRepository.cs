using test_fullstack.Data;
using test_fullstack.Models;

namespace test_fullstack.Repositories
{
    public class DataRepository
    {
        private readonly ApplicationDbContext _context;

        public DataRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveDataAsync(List<DataModel> dataList)
        {
            foreach (var data in dataList)
            {
                _context.Data.Add(data);
            }
            await _context.SaveChangesAsync();
        }
    }
}
