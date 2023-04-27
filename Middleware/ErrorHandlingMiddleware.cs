using WeatherAPI.Exceptions;

namespace WeatherAPI.Middleware;

public class ErrorHandlingMiddleware : IMiddleware
{
    private readonly ILogger<ErrorHandlingMiddleware> _logger;

    public ErrorHandlingMiddleware(ILogger<ErrorHandlingMiddleware> logger)
    {
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        /*try
        {
            await next.Invoke(context);
        }
        catch (BaseException e)
        {
            e.StatusCode
        }*/
    
    }
    }

