using DZ_RoutingFromOtherOrdner_2;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMyErrorHandling();
app.UseMyMiddleware();

app.Run();