using ConsumoVeiculoApp.Models;

namespace CalculadoraConsumo.Services
{
    // Responsável pela regra de negócio
    public class CalculadoraConsumo
    {
        public double CalcularKmPorLitro(Viagem viagem)
        {
            return viagem.DistanciaPercorrida / viagem.CombustivelConsumido;
        }
    }
}