using System.Net;

namespace WeatherAPI.Exceptions;

public class BadRequestException : BaseException
{
    public BadRequestException(string message) : base(message)
    {
        
    }

    public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;
}