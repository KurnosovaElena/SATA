using AssemblyService.API.Exceptions;
using AssemblyService.BusinessLogic.Exceptions;
using System.Net;

namespace AssemblyService.API.Middleware;

public class ExceptionHandlingMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await next(httpContext);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(httpContext, ex);
        }
    }

    private static async Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
        var responseMessage = ex switch
        {
            NotFoundException => new ExceptionResponse((int)HttpStatusCode.NotFound, ex.Message),

            BadRequestException => new ExceptionResponse(
                (int)HttpStatusCode.BadRequest,
                ex.Message
                ),

            _ => new ExceptionResponse(
                (int)HttpStatusCode.InternalServerError,
                ex.Message
            )
        };

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)responseMessage.StatusCode;

        await context.Response.WriteAsJsonAsync(responseMessage);
    }
}
