using LataOleoApp.Models;

namespace LataOleoApp.Services
{
    // Classe responsável pelo cálculo
    public class CalculadoraVolumeLata
    {
        public double Calcular(LataOleo lata)
        {
            return Math.PI * Math.Pow(lata.Raio, 2) * lata.Altura;
        }
    }
}