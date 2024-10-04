using test_fullstack.Data;
using test_fullstack.Repositories;
using test_fullstack.Services;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

        services.AddControllers();
        services.AddScoped<ExcelService>();
        services.AddScoped<DataRepository>();
    }

    // Tambahkan metode Configure jika diperlukan
}
