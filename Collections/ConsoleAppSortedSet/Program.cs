namespace ConsoleAppSortedSet
{
    using static System.Console;

    internal class Program
    {
        static void Main(string[] args)
        {
            ISet<string> alunos
                = new SortedSet<string>(new ComparadorMinusculo())
                {
                    "Vanessa Tonini",
                    "Ana Losnak",
                    "Rafael Nercessian",
                    "Priscila Stuani"
                };

            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("FABIO GUSHIKEN");

            foreach (var aluno in alunos)
            {
                WriteLine(aluno);
            }
            WriteLine();

            ISet<string> outroConjunto
                = new SortedSet<string>(new ComparadorMinusculo())
                {
                    "Vanessa Tonini",
                    "Ana Losnak",
                    "Rafael Nercessian",
                    "Priscila Stuani"
                };

            outroConjunto.Add("Rafael Rollo");
            outroConjunto.Add("Fabio Gushiken");
            outroConjunto.Add("Fabio Gushiken");
            outroConjunto.Add("Fabio Gushiken");
            outroConjunto.Add("FABIO GUSHIKEN");

            alunos.IsSubsetOf(outroConjunto);
            alunos.IsSupersetOf(outroConjunto);
            alunos.SetEquals(outroConjunto);
            alunos.ExceptWith(outroConjunto);
            alunos.IntersectWith(outroConjunto);
            alunos.SymmetricExceptWith(outroConjunto);
            alunos.UnionWith(outroConjunto);

            WriteLine("fim");
        }
    }

    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}