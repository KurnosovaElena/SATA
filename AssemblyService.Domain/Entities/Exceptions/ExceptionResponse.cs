using System.Net;

namespace AssemblyService.Domain.Entities.Exceptions
{
    public record ExceptionResponse(HttpStatusCode StatusCode, string Message) { }
}