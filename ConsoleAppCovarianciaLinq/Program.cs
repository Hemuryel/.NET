namespace ConsoleAppCovarianciaLinq
{
    using static System.Console;

    internal class Program
    {
        static void Main(string[] args)
        {
            //WriteLine("string para object");
            //string titulo = "meses";
            //object obj = titulo;
            //WriteLine(obj);

            //IList<string> listaMeses = new List<string>
            //{
            //    "Janeiro", "Fevereiro", "Março",
            //    "Abril", "Maio", "Junho",
            //    "Julho", "Agosto", "Setembro",
            //    "Outubro", "Novembro", "Dezembro"
            //};
            ////IList<object> listaObj = listaMeses;
            //WriteLine();
            //WriteLine("string[] para object[]?");
            //string[] arrayMeses = new string[]
            //{
            //    "Janeiro", "Fevereiro", "Março",
            //    "Abril", "Maio", "Junho",
            //    "Julho", "Agosto", "Setembro",
            //    "Outubro", "Novembro", "Dezembro"
            //};

            //object[] arrayObj = arrayMeses;
            //WriteLine(arrayObj);
            //foreach (var item in arrayObj)
            //{
            //    WriteLine(item);
            //}
            //WriteLine();

            //arrayObj[0] = "PRIMEIRO MÊS";
            //WriteLine(arrayObj[0]);
            //WriteLine();

            //WriteLine("List<string> para IEnumerable<object>");
            //IEnumerable<object> enumObj = listaMeses;

            var meses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            foreach (var mes in meses)
            {
                WriteLine(mes);
            }
        }
    }
}