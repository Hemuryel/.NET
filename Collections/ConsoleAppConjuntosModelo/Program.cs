using static System.Console;

namespace ConsoleAppConjuntosModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            csharpColecoes.Matricular(a1);
            csharpColecoes.Matricular(a2);
            csharpColecoes.Matricular(a3);

            //WriteLine("Imprimindo os alunos matriculados");
            //foreach (var aluno in csharpColecoes.Alunos)
            //{
            //    WriteLine(aluno.ToString());
            //}
            //WriteLine();

            //WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
            //WriteLine(csharpColecoes.EstaMatriculado(a1));

            //Aluno tonini = new Aluno("Vanessa Tonini", 34672);

            //WriteLine("a1 == Vanessa Tonini");
            //WriteLine(a1 == tonini);

            //WriteLine("a1 é equals a Tonini?");
            //WriteLine(a1.Equals(tonini));

            //Aluno aluno5617 = csharpColecoes.BuscarMatriculado(5617);
            //WriteLine("aluno5617: " + aluno5617);

            WriteLine("Quem é o aluno 5617?");
            Console.WriteLine(csharpColecoes.BuscarMatriculado(5617));

            Aluno fabio = new Aluno("Fabio Gushiken", 5617);
            //csharpColecoes.Matricular(fabio);
            csharpColecoes.SubstituirAluno(fabio);

            WriteLine("Quem é o aluno 5617 agora?");
            WriteLine(csharpColecoes.BuscarMatriculado(5617));
        }
    }
}
