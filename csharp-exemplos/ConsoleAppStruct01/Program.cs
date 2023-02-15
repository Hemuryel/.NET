using System;

namespace ConsoleAppStruct01
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1;

            c1.marca = "VW";
            c1.modelo = "Golf";
            c1.cor = "Branco";
            c1.imprimir();
            
            Carro c2 = new Carro("Honda", "HRV", "Prata");
            c2.imprimir();
        }
    }

    // Class = acessado por referência

    // Struct = acessado diretamente (por valor)
    // não pode herdar e não pode servir como herança, pois não é classe
    // permite usar construtor
    // cenário recomendado = Data Transfer Objects

    /*1 - não é possível criar uma classe que herde de uma struct
     *2 - não possui construtor vazio. Você é obrigado a ter construtores com parâmetros
     *3 - é obrigado a atribuir valor às variáveis locais ao criá-las. Não pode “deixar pra depois”
     *4 - quando se atribui um valor de uma variável com valor de outra variável, é sempre feita uma cópia do conteúdo e não feita a referência
     *5 - a instância da struct “morre” na memória (stack)
     */

    struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void imprimir()
    {
        Console.WriteLine("Marca : {0}", this.marca);
        Console.WriteLine($"Modelo : {this.modelo}");
        Console.WriteLine($@"Cor : {this.cor}");
    }
}
}
