using CaixaVolumeApp.Models;
using CaixaVolumeApp.Services;

namespace CaixaVolumeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Entrada de dados
                Console.Write("Digite o comprimento: ");
                double comprimento = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a largura: ");
                double largura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                // Instancia o objeto Caixa
                Caixa caixa = new Caixa(comprimento, largura, altura);

                // Instancia o serviço de cálculo
                CalculadoraVolume calculadora = new CalculadoraVolume();

                // Executa o cálculo
                double volume = calculadora.Calcular(caixa);

                // Saída
                Console.WriteLine($"\n📦 Volume da caixa: {volume}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
            }
        }
    }
}
