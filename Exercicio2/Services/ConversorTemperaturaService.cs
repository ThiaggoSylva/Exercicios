using ConversorTemperatura.Models;

namespace ConversorTemperatura.Services
{
    // Responsável apenas pela regra de conversão
    public class ConversorTemperaturaService
    {
        public double ConverterParaCelsius(Temperatura temperatura)
        {
            return (temperatura.Fahrenheit - 32) * 5 / 9;
        }
    }
}