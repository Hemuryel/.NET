using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppAwait01
{
    class Program
    {
        static void Main(string[] args)
        {
            // ExemploPao();
            // ExemploPaoAsync();
            ExemploPaoOuOmeleteAsync();

            Console.ReadKey();
        }

        public async static void ExemploPao()
        {
            Console.WriteLine("Mãe vai mandar a Maria buscar ovos");
            var ovos = MandarAMariaColetarOvos();

            Console.WriteLine("Mãe vai mandar o João comprar farinha");
            var farinha = MandarOJoaoComprarFarinha();

            FazerPao(ovos, farinha);
            Console.WriteLine("fim");
        }

        public async static Task ExemploPaoAsync()
        {
            Console.WriteLine("Mãe vai mandar a Maria buscar ovos");
            Task<string> tarefaOvos = MandarAMariaColetarOvosAsync();

            Console.WriteLine("Mãe vai mandar o João comprar farinha");
            Task<string> tarefaFarinha = MandarOJoaoComprarFarinhaAsync();

            string ovos = await tarefaOvos;
            string farinha = await tarefaFarinha;

            FazerPaoAsync(ovos, farinha);
            Console.WriteLine("fim");
        }

        public async static Task ExemploPaoOuOmeleteAsync()
        {
            Console.WriteLine("Mãe vai mandar a Maria buscar ovos");
            Task<string> tarefaOvos = MandarAMariaColetarOvosAsync();

            Console.WriteLine("Mãe vai mandar o João comprar farinha");
            Task<string> tarefaFarinha = MandarOJoaoComprarFarinhaAsync();

            //var tarefaDeEspera = Task.Delay(9000);
            var tarefaDeEspera = Task.Delay(1000);
            var tarefaFinalizouPrimeiro = await Task.WhenAny(tarefaFarinha, tarefaDeEspera);
            
            if (tarefaFinalizouPrimeiro == tarefaDeEspera)
            {
                Console.WriteLine("João demorou demais!!!");
                string ovos = await tarefaOvos;
                await FazerOmeleteAsync(ovos);
            }
            else
            {
                string ovos = await tarefaOvos;
                string farinha = await tarefaFarinha;
                await FazerPaoAsync(ovos, farinha);
            }
            
            Console.WriteLine("fim");
        }

        public static void FazerPao(string ovos, string farinha)
        {
            Console.WriteLine("Preparando pão");
            Thread.Sleep(2000);
            Console.WriteLine("Pão pronto");
        }

        // Task void usa apenas Task
        public async static Task FazerPaoAsync(string ovos, string farinha)
        {
            Console.WriteLine("Preparando pão");
            await Task.Delay(2000);
            Console.WriteLine("Pão pronto");
        }

        public static void FazerOmelete(string ovos)
        {
            Console.WriteLine("Preparando omelete");
            Thread.Sleep(2000);
            Console.WriteLine("Omelete pronto");
        }

        public async static Task FazerOmeleteAsync(string ovos)
        {
            Console.WriteLine("Preparando omelete");
            await Task.Delay(2000);
            Console.WriteLine("Omelete pronto");
        }

        public static string MandarOJoaoComprarFarinha()
        {
            Console.WriteLine("João sai de casa");
            Thread.Sleep(3000);
            Console.WriteLine("João retorna com farinha");

            return "farinha";
        }

        public static string MandarAMariaColetarOvos()
        {
            Console.WriteLine("Maria sai de casa");
            Thread.Sleep(3000);
            Console.WriteLine("Maria retorna com ovos");

            return "ovos";
        }

        public async static Task<string> MandarOJoaoComprarFarinhaAsync()
        {
            Console.WriteLine("João sai de casa");
            await Task.Delay(1000);
            Console.WriteLine("João retorna com farinha");

            return "farinha";
        }

        public async static Task<string> MandarAMariaColetarOvosAsync()
        {
            Console.WriteLine("Maria sai de casa");
            await Task.Delay(3000);
            Console.WriteLine("Maria retorna com ovos");

            return "ovos";
        }
    }
}
