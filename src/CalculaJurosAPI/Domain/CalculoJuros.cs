namespace CalculaJurosAPI.Domain;

public static class CalculoJuros
{
    public static string CalcularJuros(decimal valorInicial, int meses)
    {
        var taxaJuros = 0.01m; //buscar na outra API
        var valorFinal = valorInicial * (decimal)Math.Pow(1 + (double)taxaJuros, meses);
        
        return valorFinal.ToString("F2");
    }
}