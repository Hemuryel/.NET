namespace ConsoleAppSortedList
{
    internal class Aluno
    {
        private string Nome { get; set; }
        private int Matricula { get; set; }

        public Aluno(string Nome, int Matricula)
        {
            this.Nome = Nome;
            this.Matricula = Matricula;
        }

        public override string ToString()
        {
            return $"Aluno = [Nome: {Nome}, Matricula: {Matricula}]";
        }
    }
}