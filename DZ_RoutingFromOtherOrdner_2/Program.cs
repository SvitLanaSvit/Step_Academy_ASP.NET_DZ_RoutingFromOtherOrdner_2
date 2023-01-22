using DZ_RoutingFromOtherOrdner_2;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMyErrorHandling();
//app.UseMyMiddleware();
//use or app.UseMyMiddleware() or this if is there file wwwroot with html_file
app.UseStaticFiles(); //it see wwwroot order

app.Run();