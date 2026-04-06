namespace ConversorTemperatura.Models
{
    // Representa a temperatura em Fahrenheit
    public class Temperatura
    {
        public double Fahrenheit { get; private set; }

        public Temperatura(double fahrenheit)
        {
            Fahrenheit = fahrenheit;
        }
    }
}