namespace LataOleoApp.Models
{
    // Representa a lata de óleo (modelo do domínio)
    public class LataOleo
    {
        public double Raio { get; private set; }
        public double Altura { get; private set; }

        public LataOleo(double raio, double altura)
        {
            ValidarDados(raio, altura);

            Raio = raio;
            Altura = altura;
        }

        private void ValidarDados(double raio, double altura)
        {
            if (raio <= 0 || altura <= 0)
                throw new ArgumentException("Raio e altura devem ser maiores que zero.");
        }
    }
}