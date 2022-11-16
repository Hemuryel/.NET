namespace ConsoleAppSortedList
{
    using static System.Console;

    internal class Program
    {
        static void Main(string[] args)
        {
            //IDictionary<string, Aluno> alunos
            //    = new Dictionary<string, Aluno>();

            //alunos.Add("VT", new Aluno("Vanessa", 34672));
            //alunos.Add("AL", new Aluno("Ana", 5617));
            //alunos.Add("RN", new Aluno("Rafael", 17645));
            //alunos.Add("WN", new Aluno("Wanderson", 11287));

            //foreach (var aluno in alunos)
            //{
            //    WriteLine(aluno);
            //}

            //alunos.Remove("AL");
            //alunos.Add("MO", new Aluno("Marcelo", 12345));
            //WriteLine();

            //foreach (var aluno in alunos)
            //{
            //    WriteLine(aluno);
            //}

            IDictionary<string, Aluno> sorted
                = new SortedList<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WN", new Aluno("Wanderson", 11287));

            foreach (var item in sorted)
            {
                WriteLine(item);
            }
        }
    }
}