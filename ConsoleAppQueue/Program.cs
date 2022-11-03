namespace ConsoleAppQueue
{
    using static System.Console;

    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            Enfileirar("van");
            Enfileirar("kombi");
            Enfileirar("guincho");
            Enfileirar("pickup");
            Desfileirar();
            Desfileirar();
            Desfileirar();
            Desfileirar();
        }

        private static void Desfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "guincho")
                {
                    WriteLine("guincho está fazendo o pagamento.");
                }

                string veiculo = pedagio.Dequeue();
                WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            WriteLine("FILA: ");
            foreach (var v in pedagio)
            {
                WriteLine(v);
            }
            WriteLine();
        }
    }
}