namespace MediaHarmonicaApp.Models
{
    // Representa o aluno e suas notas
    public class Aluno
    {
        public List<double> Notas { get; private set; }

        public Aluno(List<double> notas)
        {
            ValidarNotas(notas);
            Notas = notas;
        }

        private void ValidarNotas(List<double> notas)
        {
            if (notas == null || notas.Count == 0)
                throw new ArgumentException("O aluno deve possuir pelo menos uma nota.");

            if (notas.Any(n => n <= 0))
                throw new ArgumentException("As notas devem ser maiores que zero (média harmônica não aceita zero).");
        }
    }
}