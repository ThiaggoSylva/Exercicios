using MediaHarmonicaApp.Models;
using MediaHarmonicaApp.Services;

namespace MediaHarmonicaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Quantas notas deseja informar? ");
                int quantidade = int.Parse(Console.ReadLine()!);

                List<double> notas = new List<double>();

                for (int i = 0; i < quantidade; i++)
                {
                    Console.Write($"Digite a nota {i + 1}: ");
                    double nota = Convert.ToDouble(Console.ReadLine());
                    notas.Add(nota);
                }

                // Cria objeto de domínio
                Aluno aluno = new Aluno(notas);

                // Serviço de cálculo
                CalculadoraMediaHarmonica calculadora = new CalculadoraMediaHarmonica();

                double media = calculadora.Calcular(aluno);

                Console.WriteLine($"\n📊 Média Harmônica: {media:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
            }
        }
    }
}