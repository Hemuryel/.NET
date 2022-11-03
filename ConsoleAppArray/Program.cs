namespace ConsoleAppArray
{
    using static System.Console;

    public class Program
    {
        static void Main(string[] args)
        {
            Array amostra = Array.CreateInstance(typeof(double), 5);
            //Array amostra = new double[5];
            amostra.SetValue(5.9, 0);
            amostra.SetValue(1.8, 1);
            amostra.SetValue(7.1, 2);
            amostra.SetValue(10, 3);
            amostra.SetValue(6.9, 4);

            TestarMediana(amostra);

            int[] valores = { 10, 58, 36, 47 };
            for (int i = 0; i < 4; i++)
            {
                WriteLine(valores[i]);
            }
        }

        static void TestarMediana(Array array)
        {
            if ((array == null) || (array.Length == 0))
            {
                WriteLine("Array para cálculo da mediana está vazio ou nulo.");
            }

            double[] numerosOrdenados = (double[]) array.Clone();
            Array.Sort(numerosOrdenados);

            int tamanho = numerosOrdenados.Length;
            int meio = tamanho / 2;
            double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
                (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

            WriteLine($"Com base na amostra a mediana = {mediana}");
        }
    }
}