using SalarioVendedorApp.Models;

namespace SalarioVendedorApp.Services
{
    // Responsável pelo cálculo do salário
    public class CalculadoraSalario
    {
        public double CalcularSalarioTotal(Vendedor vendedor)
        {
            double comissao = vendedor.TotalVendas * vendedor.PercentualComissao;
            return vendedor.SalarioBase + comissao;
        }
    }
}