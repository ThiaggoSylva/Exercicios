namespace MediaPonderadaApp.Models
{
    // Representa as provas do aluno
    public class Provas
    {
        public double Nota1 { get; private set; }
        public double Nota2 { get; private set; }
        public double Peso1 { get; private set; }
        public double Peso2 { get; private set; }

        public Provas(double nota1, double nota2, double peso1, double peso2)
        {
            ValidarDados(nota1, nota2, peso1, peso2);

            Nota1 = nota1;
            Nota2 = nota2;
            Peso1 = peso1;
            Peso2 = peso2;
        }

        private void ValidarDados(double n1, double n2, double p1, double p2)
        {
            if (p1 <= 0 || p2 <= 0)
                throw new ArgumentException("Os pesos devem ser maiores que zero.");

            if (n1 < 0 || n2 < 0)
                throw new ArgumentException("As notas não podem ser negativas.");
        }
    }
}