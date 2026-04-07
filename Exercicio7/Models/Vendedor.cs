namespace SalarioVendedorApp.Models
{
    // Representa o vendedor e seus dados
    public class Vendedor
    {
        public double SalarioBase { get; private set; }
        public double TotalVendas { get; private set; }
        public double PercentualComissao { get; private set; }

        public Vendedor(double salarioBase, double totalVendas, double percentualComissao)
        {
            ValidarDados(salarioBase, totalVendas, percentualComissao);

            SalarioBase = salarioBase;
            TotalVendas = totalVendas;
            PercentualComissao = percentualComissao;
        }

        private void ValidarDados(double salarioBase, double vendas, double percentual)
        {
            if (salarioBase < 0)
                throw new ArgumentException("Salário base não pode ser negativo.");

            if (vendas < 0)
                throw new ArgumentException("Total de vendas não pode ser negativo.");

            if (percentual < 0)
                throw new ArgumentException("Percentual de comissão não pode ser negativo.");
        }
    }
}