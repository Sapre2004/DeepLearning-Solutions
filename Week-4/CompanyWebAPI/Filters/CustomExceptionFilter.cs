using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CompanyWebAPI.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exceptionDetails = context.Exception.ToString();
            File.WriteAllText("ExceptionLogs.txt", exceptionDetails);

            context.Result = new ObjectResult("An error occurred in the application.")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }
    }
}
