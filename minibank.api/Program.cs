using minibank.api.Helpers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapEndPoints();
app.Run();
