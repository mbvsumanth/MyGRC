var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/bye", () => "bye");
app.MapGet("/firstcommit", () => "first commit");
app.MapGet("/Second checkout", () => "first commit");
app.Run();
