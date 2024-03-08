using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        // Konfigurasi layanan di sini
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Konfigurasi middleware di sini
    }
}
