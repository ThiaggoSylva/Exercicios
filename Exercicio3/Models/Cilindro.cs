namespace VolumeCilindroApp.Models
{
    // Representa o objeto Cilindro (modelo do domínio)
    public class Cilindro
    {
        public double Raio { get; private set; }
        public double Altura { get; private set; }

        public Cilindro(double raio, double altura)
        {
            ValidarDimensoes(raio, altura);

            Raio = raio;
            Altura = altura;
        }

        // Garante que o objeto não seja criado com valores inválidos
        private void ValidarDimensoes(double raio, double altura)
        {
            if (raio <= 0 || altura <= 0)
                throw new ArgumentException("Raio e altura devem ser maiores que zero.");
        }
    }
}