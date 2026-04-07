using SalarioVendedorApp.Models;
using SalarioVendedorApp.Services;

namespace SalarioVendedorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o salário base: ");
                double salarioBase = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o total de vendas: ");
                double vendas = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o percentual de comissão (%): ");
                double percentual = Convert.ToDouble(Console.ReadLine()) / 100;

                // Cria objeto de domínio
                Vendedor vendedor = new Vendedor(salarioBase, vendas, percentual);

                // Serviço de cálculo
                CalculadoraSalario calculadora = new CalculadoraSalario();

                double salarioTotal = calculadora.CalcularSalarioTotal(vendedor);

                Console.WriteLine($"\n💰 Salário total: R$ {salarioTotal:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
            }
        }
    }
}
