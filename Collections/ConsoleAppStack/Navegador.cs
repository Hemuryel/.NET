namespace ConsoleAppStack
{
    using System;
    using static System.Console;

    public class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        private string atual = "vazia";

        public Navegador()
        {
            WriteLine("Página atual: " + atual);
        }

        public void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            WriteLine("Página atual: " + atual);
        }

        public void Anterior()
        {
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                atual = historicoAnterior.Pop();
                WriteLine("Página atual: " + atual);
            }
        }

        public void Proximo()
        {
            if (historicoProximo.Any())
            {
                atual = historicoProximo.Pop();
                WriteLine("Página atual: " + atual);
            }
        }
    }
}