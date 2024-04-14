using InvoicingApp.UI.Properties.Middlewares;
using InvoicingApp.UI.StartupExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureOnStartup();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
} 
else
{
    app.UseExceptionHandler("/Error");
    app.UseMiddleware<ExceptionHandlingMiddleware>();
}

app.MapControllers();

app.Run();
