namespace DZ_RoutingFromOtherOrdner_2
{
    public static class MiddlewareExtentions
    {
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<RoutingMiddleware>();
        }

        public static IApplicationBuilder UseMyErrorHandling(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ErrorHandlingMiddleware>();
        }
    }
}