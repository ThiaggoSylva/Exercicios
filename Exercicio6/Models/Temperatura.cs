namespace ConversorTemperatura.Models
{
    // Representa a temperatura em Celsius
    public class Temperatura
    {
        public double Celsius { get; private set; }

        public Temperatura(double celsius)
        {
            Celsius = celsius;
        }
    }
}