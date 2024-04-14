using InvoicingApp.UI.Properties.Middlewares;

namespace InvoicingApp.UI.StartupExtensions;

public static class ConfigureBuilder
{
    public static void ConfigureOnStartup(this WebApplicationBuilder builder)
    {
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        ILogger logger = factory.CreateLogger("Program");
        
        // Add Controllers with views
        builder.Services.AddControllersWithViews();

        // Add Logging
        builder.Services.AddSingleton<ILogger>(logger); 

        builder.Services.AddScoped<ExceptionHandlingMiddleware>();
    }
}