using VolumeEsferaApp.Models;
using VolumeEsferaApp.Services;

namespace VolumeEsferaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o raio da esfera: ");
                double raio = Convert.ToDouble(Console.ReadLine());

                // Cria objeto de domínio
                Esfera esfera = new Esfera(raio);

                // Serviço de cálculo
                CalculadoraVolumeEsfera calculadora = new CalculadoraVolumeEsfera();

                // Calcula o volume
                double volume = calculadora.Calcular(esfera);

                Console.WriteLine($"\n⚽ Volume da esfera: {volume:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
            }
        }
    }
}