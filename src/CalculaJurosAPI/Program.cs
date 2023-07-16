using CalculaJurosAPI.Domain;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/showmethecode", () => ShowMeTheCode.GetShowMeTheCode());
app.MapGet("/calculajuros", () => CalculoJuros.CalcularJuros(100m, 5));

app.Run();