namespace DZ_RoutingFromOtherOrdner_2
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await next.Invoke(context);
            var resp = context.Response;
            if(resp.StatusCode == 403 || resp.StatusCode == 404)
            {
                context.Response.Headers.ContentType = "text/html; charset=utf-8";
                await resp.WriteAsync($"<h2 style='color: red'>You haven`t access to this site!</h2>");
            }
            
        }
    }
}
