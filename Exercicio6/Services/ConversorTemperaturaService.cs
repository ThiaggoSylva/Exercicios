using ConversorTemperatura.Models;

namespace ConversorTemperatura.Services
{
    // Responsável pela regra de conversão
    public class ConversorTemperaturaService
    {
        public double ConverterParaFahrenheit(Temperatura temperatura)
        {
            return (temperatura.Celsius * 9 / 5) + 32;
        }
    }
}