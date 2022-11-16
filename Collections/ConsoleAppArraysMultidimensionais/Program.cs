namespace ConsoleAppArraysMultidimensionais
{
    using static System.Console;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] resultados = new string[3, 3]
            {
                { "Alemanha", "Espanha", "Itália" },
                { "Argentina", "Holanda", "França" },
                { "Holanda", "Alemanha", "Alemanha" }
            };

            //foreach (var selecao in resultados)
            //{
            //    WriteLine(selecao);
            //}

            for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++)
            {
                int ano = 2014 - copa * 4;
                Write(ano.ToString().PadRight(12));
            }
            WriteLine();

            for (int posicao = 0; posicao <= resultados.GetUpperBound(0); posicao++)
            {
                for (int copa = 0; copa <= resultados.GetUpperBound(1); copa++)
                {
                    Write(resultados[posicao, copa].PadRight(12));
                }
                Console.WriteLine();
            }
        }
    }
}