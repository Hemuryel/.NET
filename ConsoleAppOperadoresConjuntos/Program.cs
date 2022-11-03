namespace ConsoleAppOperadoresConjuntos
{
    using static System.Console;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            var consulta = seq1.Concat(seq2);
            foreach (var item in consulta)
            {
                WriteLine(item);
            }
            WriteLine();

            WriteLine("União de duas sequências");
            var consulta2 = seq1.Union(seq2);
            foreach (var item in consulta2)
            {
                WriteLine(item);
            }

            WriteLine("União de duas sequências, ignorando maiúsculos e minúsculos");
            var consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            foreach (var item in consulta3)
            {
                WriteLine(item);
            }
            WriteLine();

            var consulta4 = seq1.Intersect(seq2);
            foreach (var item in consulta4)
            {
                WriteLine(item);
            }
            WriteLine();

            var consulta5 = seq1.Except(seq2);
            foreach (var item in consulta5)
            {
                WriteLine(item);
            }
            WriteLine();
        }
    }
}