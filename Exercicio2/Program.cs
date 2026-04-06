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
                Console.Write("Digite a temperatura em Fahrenheit: ");
                double f = Convert.ToDouble(Console.ReadLine());

                // Cria objeto de domínio
                Temperatura temperatura = new Temperatura(f);

                // Serviço de conversão
                ConversorTemperaturaService conversor = new ConversorTemperaturaService();

                // Executa conversão
                double celsius = conversor.ConverterParaCelsius(temperatura);

                Console.WriteLine($"\n🌡️ Temperatura em Celsius: {celsius:F2}°C");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}