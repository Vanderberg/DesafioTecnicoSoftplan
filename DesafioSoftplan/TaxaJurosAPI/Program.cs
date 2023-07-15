using TaxaJurosAPI.Domain;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/TaxaJuros", () => TaxaJuros.GetTaxaDeJurosBasica());

app.Run();