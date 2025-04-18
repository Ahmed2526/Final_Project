using Microsoft.AspNetCore.Diagnostics;

namespace Final_Project.Errors
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        private readonly ILogger<GlobalExceptionHandler> _logger;

        public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
        {
            _logger = logger;
        }

        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            _logger.LogError(exception, exception.Message);

            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            httpContext.Response.ContentType = "application/json";

            var response = new
            {
                StatusCode = httpContext.Response.StatusCode,
                Message = "An unexpected error occurred.",
                Error = exception.Message
            };

            await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);
            return true;
        }

    }
}
