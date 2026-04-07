using MediaPonderadaApp.Models;

namespace MediaPonderadaApp.Services
{
    // Responsável pelo cálculo da média ponderada
    public class CalculadoraMediaPonderada
    {
        public double Calcular(Provas provas)
        {
            double somaPesos = provas.Peso1 + provas.Peso2;

            double media = (provas.Nota1 * provas.Peso1 +
                            provas.Nota2 * provas.Peso2) / somaPesos;

            return media;
        }
    }
}