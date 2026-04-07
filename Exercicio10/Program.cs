using MediaPonderadaApp.Models;
using MediaPonderadaApp.Services;

namespace MediaPonderadaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite a nota da prova 1: ");
                double n1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o peso da prova 1: ");
                double p1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a nota da prova 2: ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o peso da prova 2: ");
                double p2 = Convert.ToDouble(Console.ReadLine());

                // Cria objeto de domínio
                Provas provas = new Provas(n1, n2, p1, p2);

                // Serviço de cálculo
                CalculadoraMediaPonderada calculadora = new CalculadoraMediaPonderada();

                double media = calculadora.Calcular(provas);

                Console.WriteLine($"\n📊 Média ponderada: {media:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
            }
        }
    }
}