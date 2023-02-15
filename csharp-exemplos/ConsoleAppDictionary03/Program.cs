using static System.Console;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleAppDictionary03
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Segunda-feira", 1);
            dict.Add("Terça-feira", 2);
            dict.Add("Quarta-Feira", 3);
            dict.Add("Quinta-Feira", 4);
            dict.Add("Sexta-Feira", 5);
            dict.Add("Sabado", 6);
            dict.Add("Domingo", 7);
            //exibe a chave e o valor 
            foreach (var item in dict)
            {
                WriteLine(item.Key + "   " + item.Value);
            }
            //outra sintaxe para exibir chave e valor
            foreach (KeyValuePair<string, int> item in dict)
            {
                WriteLine("{0} - {1}", item.Key, item.Value);
            }
            //retorna o valor das chaves
            foreach (var key in dict.Keys)
            {
                WriteLine(key);
            }
            //retorna o valor dos valores
            foreach (var value in dict.Values)
            {
                WriteLine(value.ToString());
            }
            //Exibindo dados do dictionary ordenados por valor
            foreach (var item in dict.OrderByDescending(r => r.Value))
            {
                WriteLine("Chave: {0}, Valor: {1}", item.Key, item.Value);
            }
            //popula um Dictionary com objetos
            Dictionary<int, Aluno> alunos = new Dictionary<int, Aluno>()
            {
               { 101, new Aluno {Nome="Sabrina", Idade=22}},
               { 102, new Aluno {Nome="Diana", Idade =18}},
               { 103, new Aluno {Nome="Antonior", Idade=21}}
            };
            //percorre o dictionary
            foreach (var item in alunos)
            {
                WriteLine(item.Key + "   " + item.Value.Nome + " " + item.Value.Idade);
            }
            ReadKey();
        }
    }
}