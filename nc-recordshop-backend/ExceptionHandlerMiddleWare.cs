using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace nc_recordshop_backend
{
    public class ExceptionHandlerMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);
            }
            catch (Exception e)
            {
                HandleException(context, e);
            }
        }

        private async Task HandleException(HttpContext context, Exception e)
        {
            Console.WriteLine("Handling exception");
            Console.WriteLine(e);

            if (e is ArgumentException)
            {
                context.Response.StatusCode = StatusCodes.Status404NotFound;
                await context.Response.WriteAsJsonAsync(new { message = "Album not found." });
            }
            else
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsJsonAsync(new { message = "Bad request" });
            }
        }
    }
}
