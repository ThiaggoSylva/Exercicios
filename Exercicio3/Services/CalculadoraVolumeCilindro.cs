using VolumeCilindroApp.Models;

namespace VolumeCilindroApp.Services
{
    // Responsável apenas pela regra de cálculo (SRP)
    public class CalculadoraVolumeCilindro
    {
        public double Calcular(Cilindro cilindro)
        {
            return Math.PI * Math.Pow(cilindro.Raio, 2) * cilindro.Altura;
        }
    }
}