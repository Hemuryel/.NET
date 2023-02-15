using System;

namespace ConsoleAppEnum01
{
    // enum
    // - criar tipo próprio com valores pré-definidos
    // - define um tipo e define os tipos que esse valor pode receber
    // - inicia no índice 0
    // - permite criar tipo personalizado pelo programador
    enum DiasSemana
    {
        Domingo,
        Segunda,
        Terça,
        Quarta,
        Quinta,
        Sexta,
        Sábado
    }

    class Program
    {
        static void Main(string[] args)
        {
            DiasSemana ds1 = DiasSemana.Domingo;
            Console.WriteLine(ds1); // Domingo

            DiasSemana ds2 = (DiasSemana) 3;
            Console.WriteLine(ds2);

            int ds3 = (int) DiasSemana.Quinta;
            Console.WriteLine(ds3);
        }
    }
}
