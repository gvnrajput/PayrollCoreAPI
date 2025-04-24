using WebAPI.Common; 
using BAL.Interfaces; 

public class ExceptionLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IExceptionLogger _exceptionLogger;

    public ExceptionLoggingMiddleware(RequestDelegate next, IExceptionLogger exceptionLogger)
    {
        _next = next;
        _exceptionLogger = exceptionLogger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await _exceptionLogger.LogAsync(ex); // Log the exception to the database
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;

        var errorResponse = new ErrorResponse(
            StatusCodes.Status500InternalServerError,
            ResponseMessages.InternalServerError,
            ResponseMessages.GetErrorDetails(ex));

        return context.Response.WriteAsync(errorResponse.ToString());
    }
}
