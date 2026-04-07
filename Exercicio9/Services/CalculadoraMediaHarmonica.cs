using MediaHarmonicaApp.Models;

namespace MediaHarmonicaApp.Services
{
    // Responsável pelo cálculo da média harmônica
    public class CalculadoraMediaHarmonica
    {
        public double Calcular(Aluno aluno)
        {
            double somaInversos = aluno.Notas.Sum(nota => 1.0 / nota);

            return aluno.Notas.Count / somaInversos;
        }
    }
}