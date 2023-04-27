using System.Net;

namespace WeatherAPI.Exceptions;

public abstract class BaseException : Exception
{
    public abstract HttpStatusCode StatusCode { get; }
    protected BaseException(string message) : base(message)
    {
        
    }
}