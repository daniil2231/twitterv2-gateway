using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ocelot.json", false, true);
builder.Services.AddOcelot(builder.Configuration);
var app = builder.Build();


app.UseRouting();

app.UseOcelot().Wait();

app.MapGet("/", () => "Hello World!");

app.Run();
