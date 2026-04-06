using ConversorTemperatura.Models;
using ConversorTemperatura.Services;

namespace ConversorTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite a temperatura em Celsius: ");
                double c = Convert.ToDouble(Console.ReadLine());

                // Cria objeto de domínio
                Temperatura temperatura = new Temperatura(c);

                // Serviço de conversão
                ConversorTemperaturaService conversor = new ConversorTemperaturaService();

                // Executa conversão
                double fahrenheit = conversor.ConverterParaFahrenheit(temperatura);

                Console.WriteLine($"\n🌡️ Temperatura em Fahrenheit: {fahrenheit:F2}°F");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}