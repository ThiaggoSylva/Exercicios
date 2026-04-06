namespace CaixaVolumeApp.Models
{
    // Classe que representa a entidade Caixa (modelo do domínio)
    public class Caixa
    {
        // Propriedades encapsuladas
        public double Comprimento { get; private set; }
        public double Largura { get; private set; }
        public double Altura { get; private set; }

        // Construtor para garantir que a caixa sempre será válida ao ser criada
        public Caixa(double comprimento, double largura, double altura)
        {
            ValidarDimensoes(comprimento, largura, altura);

            Comprimento = comprimento;
            Largura = largura;
            Altura = altura;
        }

        // Método privado responsável por validar os dados (SRP)
        private void ValidarDimensoes(double comprimento, double largura, double altura)
        {
            if (comprimento <= 0 || largura <= 0 || altura <= 0)
                throw new ArgumentException("Todas as dimensões devem ser maiores que zero.");
        }
    }
}