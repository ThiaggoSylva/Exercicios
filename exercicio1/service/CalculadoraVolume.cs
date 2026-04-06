using CaixaVolumeApp.Models;

namespace CaixaVolumeApp.Services
{
    // Classe responsável apenas pelo cálculo (Single Responsibility Principle)
    public class CalculadoraVolume
    {
        public double Calcular(Caixa caixa)
        {
            return caixa.Comprimento * caixa.Largura * caixa.Altura;
        }
    }
}