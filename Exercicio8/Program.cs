using LataOleoApp.Models;
using LataOleoApp.Services;

namespace LataOleoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o raio da lata: ");
                double raio = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a altura da lata: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                // Cria objeto de domínio
                LataOleo lata = new LataOleo(raio, altura);

                // Serviço de cálculo
                CalculadoraVolumeLata calculadora = new CalculadoraVolumeLata();

                double volume = calculadora.Calcular(lata);

                Console.WriteLine($"\n🛢️ Volume da lata de óleo: {volume:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
            }
        }
    }
}
