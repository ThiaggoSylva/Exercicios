namespace VolumeEsferaApp.Models
{
    // Representa o modelo da Esfera
    public class Esfera
    {
        public double Raio { get; private set; }

        public Esfera(double raio)
        {
            ValidarRaio(raio);
            Raio = raio;
        }

        // Validação para garantir consistência do objeto
        private void ValidarRaio(double raio)
        {
            if (raio <= 0)
                throw new ArgumentException("O raio deve ser maior que zero.");
        }
    }
}