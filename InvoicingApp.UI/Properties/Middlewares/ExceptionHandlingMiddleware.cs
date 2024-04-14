namespace InvoicingApp.UI.Properties.Middlewares;

public class ExceptionHandlingMiddleware : IMiddleware
{
    private readonly ILogger _logger;
    public ExceptionHandlingMiddleware(ILogger logger)
    {
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError("{}.{}", nameof(ExceptionHandlingMiddleware), ex.Message);
            throw;
        }
    }
}