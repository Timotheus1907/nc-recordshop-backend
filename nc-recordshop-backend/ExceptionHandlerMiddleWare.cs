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

        private void HandleException(HttpContext context, Exception e)
        {
            Console.WriteLine("Handling exception");
        }
    }
}
