using System;

namespace ConsoleAppEnum02
{
    class Program
    {
        private enum EstadoCivil
        {
            Casado,
            Solteiro,
            Viuvo,
            Divorciado
        }

        enum DiaSemana
        {
            Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado
        }

        enum DiaMes: byte
        {
            Janeiro, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro
        }

        enum Estado
        {
            Desligado = 0,
            Ligado = 5,
            Repouso = 10,
            Processando = Ligado + 10
        }

        static void Main(string[] args)
        {
            DiaSemana dia = DiaSemana.Domingo;
            int x = (int) DiaSemana.Domingo;

            Console.WriteLine("Hoje é dia: " + dia);
            Console.WriteLine("Hoje é dia: " + x);
            string s = Enum.GetName(typeof(DiaSemana), 4);
            Console.WriteLine("Hoje é dia: " + s);

            foreach (int i in Enum.GetValues(typeof(DiaSemana)))
                Console.WriteLine(i);

            foreach (string i in Enum.GetNames(typeof(DiaSemana)))
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
