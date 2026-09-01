using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace crud_products.Exceptions;

public class AppExceptionHandler : IExceptionHandler
{
    
    private readonly ILogger<AppExceptionHandler> _logger;
    
    public AppExceptionHandler(ILogger<AppExceptionHandler> logger) {
        _logger = logger;
    }

    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        _logger.LogError(exception, "Erro capturado: {Message}", exception.Message);

        var (statusCode, title) = exception switch
        {
            UnauthorizedAccessException => (StatusCodes.Status401Unauthorized, "Usuário não autenticado"),
            Unauthenticated => (StatusCodes.Status403Forbidden, "Usuário não autorizado"),
            NotFoundException => (StatusCodes.Status404NotFound, "Recurso não encontrado"),
            AlreadyExists => (StatusCodes.Status409Conflict, "Conflito de dados"),
            _ => (StatusCodes.Status500InternalServerError, "Erro interno no servidor")
        };

        var problemDetails = new ProblemDetails
        {
            Status = statusCode,
            Title = title,
            Detail = exception.Message,
            Instance = httpContext.Request.Path
        };

        httpContext.Response.StatusCode = statusCode;

        await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);
        return true;
    }
}