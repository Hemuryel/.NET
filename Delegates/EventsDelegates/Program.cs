namespace ConsoleAppEventsDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arquivo arquivo = new()
            {
                NomeArquivo = "Matrix.xml",
                UrlArquivo = @"C:\matrix.xml"
            };

            ArquivoConverter converter = new ArquivoConverter();
            converter.ArquivoConvertido += EnviarEmail;
            Console.WriteLine("Convertendo arquivo");
            converter.Converter(arquivo);
            Console.ReadLine();
        }

        public static void EnviarEmail(object source, EventArgs args)
        {
            Console.WriteLine("E-mail enviado com sucesso!");
        }
    }
}