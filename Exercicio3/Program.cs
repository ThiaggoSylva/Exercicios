using VolumeCilindroApp.Models;
using VolumeCilindroApp.Services;

namespace VolumeCilindroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o raio do cilindro: ");
                double raio = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a altura do cilindro: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                // Cria objeto de domínio
                Cilindro cilindro = new Cilindro(raio, altura);

                // Serviço de cálculo
                CalculadoraVolumeCilindro calculadora = new CalculadoraVolumeCilindro();

                // Calcula o volume
                double volume = calculadora.Calcular(cilindro);

                Console.WriteLine($"\n📦 Volume do cilindro: {volume:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}