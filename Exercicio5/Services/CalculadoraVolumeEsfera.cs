using VolumeEsferaApp.Models;

namespace VolumeEsferaApp.Services
{
    // Classe responsável pelo cálculo
    public class CalculadoraVolumeEsfera
    {
        public double Calcular(Esfera esfera)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(esfera.Raio, 3);
        }
    }
}