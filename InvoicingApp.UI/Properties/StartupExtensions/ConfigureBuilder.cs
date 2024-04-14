using InvoicingApp.UI.Properties.Middlewares;
using Microsoft.EntityFrameworkCore;

namespace InvoicingApp.UI.StartupExtensions;

public static class ConfigureBuilder
{
    public static void ConfigureOnStartup(this WebApplicationBuilder builder)
    {
        // Add controllers.
        builder.Services.AddControllersWithViews();

        // Logging.
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        ILogger logger = factory.CreateLogger("Program");
        builder.Services.AddSingleton<ILogger>(logger);

        // Exception Middleware.
        builder.Services.AddScoped<ExceptionHandlingMiddleware>();

        // Add Database Context.
        builder.Services.AddDbContext<ApplicationDbContext>(
            options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultDatabase"))
        );
    }
}