namespace DZ_RoutingFromOtherOrdner_2
{
    public class RoutingMiddleware
    {
        private readonly RequestDelegate next;
        public RoutingMiddleware(RequestDelegate next) 
        { 
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string? path = context.Request.Path.Value?.ToLower();
            string fullpath = $"html/{path}";
            if (File.Exists(fullpath))
            {
                context.Response.ContentType = "text/html; charset=utf-8";
                await context.Response.SendFileAsync(fullpath);
            }
            else
            {
                context.Response.StatusCode = 403;
            }
        }
    }
}
