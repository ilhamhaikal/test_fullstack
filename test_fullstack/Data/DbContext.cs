// Data/ApplicationDbContext.cs
namespace test_fullstack.Data
{
    public class DbContext
    {
        private DbContextOptions<ApplicationDbContext> options;

        public DbContext(DbContextOptions<ApplicationDbContext> options)
        {
            this.options = options;
        }
    }
}