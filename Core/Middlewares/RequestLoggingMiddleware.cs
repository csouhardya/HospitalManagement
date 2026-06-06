namespace HospitalManagement.Middlewares
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("Request: " + context.Request.Method + " " + context.Request.Path);

            var started = DateTime.Now;

            await _next(context);

            var duration = DateTime.Now - started;

            Console.WriteLine("Response: " + context.Response.StatusCode);
            Console.WriteLine("Duration: " + duration.TotalMilliseconds);
        }
    }
}
