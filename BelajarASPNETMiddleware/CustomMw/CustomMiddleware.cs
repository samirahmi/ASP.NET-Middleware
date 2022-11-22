namespace BelajarASPNETMiddleware.CustomMw
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate next;

        public CustomMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("Custom Middleware");
            Console.WriteLine("Custom Middle");
            //await next(httpContext); //tidak perlu
        }
    }
}
