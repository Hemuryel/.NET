using ConsoleAppListasDeObjetos;

namespace ListasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adicionar(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adicionar(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adicionar(new Aula("Modelando com Coleções", 19));
            Imprimir(csharpColecoes.Aulas);

            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);
            aulasCopiadas.Sort();
            Imprimir(aulasCopiadas);

            Console.WriteLine(csharpColecoes.TempoTotal);

            Console.WriteLine(csharpColecoes);
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            //Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
            Console.WriteLine();
        }
    }
}