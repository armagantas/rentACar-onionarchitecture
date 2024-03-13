using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class InternalServerErrorProblemDetails : ProblemDetails
{
    public InternalServerErrorProblemDetails(string detail)
    {
        Title = "Internal Server Error";
        Detail = "Internal Server Error";
        Status = StatusCodes.Status500InternalServerError;
        Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1";
    }
}
