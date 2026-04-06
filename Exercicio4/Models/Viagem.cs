namespace ConsumoVeiculoApp.Models
{
    // Representa os dados da viagem
    public class Viagem
    {
        public double KmInicial { get; private set; }
        public double KmFinal { get; private set; }
        public double CombustivelConsumido { get; private set; }

        public Viagem(double kmInicial, double kmFinal, double combustivelConsumido)
        {
            ValidarDados(kmInicial, kmFinal, combustivelConsumido);

            KmInicial = kmInicial;
            KmFinal = kmFinal;
            CombustivelConsumido = combustivelConsumido;
        }

        // Propriedade calculada (boa prática)
        public double DistanciaPercorrida => KmFinal - KmInicial;

        private void ValidarDados(double kmInicial, double kmFinal, double combustivel)
        {
            if (kmFinal <= kmInicial)
                throw new ArgumentException("Km final deve ser maior que o inicial.");

            if (combustivel <= 0)
                throw new ArgumentException("Combustível deve ser maior que zero.");
        }
    }
}