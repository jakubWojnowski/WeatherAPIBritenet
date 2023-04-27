using System.Net;

namespace WeatherAPI.Exceptions;

public class NotFoundException : BaseException
{
    public NotFoundException(string message = "Property Not Found") : base(message)
    {
        
    }

    public override HttpStatusCode StatusCode => HttpStatusCode.NotFound;
}