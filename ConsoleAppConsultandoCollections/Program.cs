using static System.Console;

List<Mes> meses = new List<Mes>
{
   new Mes("Janeiro", 31),
   new Mes("Fevereiro", 28),
   new Mes("Março", 31),
   new Mes("Abril", 30),
   new Mes("Maio", 31),
   new Mes("Junho", 30),
   new Mes("Julho", 31),
   new Mes("Agosto", 31),
   new Mes("Setembro", 30),
   new Mes("Outubro", 31),
   new Mes("Novembro", 30),
   new Mes("Dezembro", 31)
};

//meses.Sort();

//foreach (var mes in meses)
//{
//    if (mes.Dias == 31)
//    {
//        WriteLine(mes.Nome.ToUpper());
//    }
//}

//IEnumerable<string> consulta = meses
//    .Where(m => m.Dias == 31)
//    .OrderBy(m => m.Nome)
//    .Select(m => m.Nome.ToUpper());
//foreach (var item in consulta)
//{
//    WriteLine(item);
//}
//WriteLine();

//IEnumerable<Mes> consulta2 = from x in meses.Where(x => x.Dias == 31) select x;
//foreach (var item in consulta2)
//{
//    WriteLine(item);
//}

var consulta = meses.Take(3);
foreach (var item in consulta)
{
    WriteLine(item);
}
WriteLine();

var consulta2 = meses.Skip(3);
foreach (var item in consulta2)
{
    WriteLine(item);
}
WriteLine();

var consulta3 = meses.Skip(6).Take(3);
foreach (var item in consulta3)
{
    WriteLine(item);
}
WriteLine();

var consulta4 = meses.TakeWhile(m => !m.Nome.StartsWith("S"));
foreach (var item in consulta4)
{
    WriteLine(item);
}
WriteLine();

var consulta5 = meses.SkipWhile(m => !m.Nome.StartsWith("S"));
foreach (var item in consulta5)
{
    WriteLine(item);
}
WriteLine();

class Mes : IComparable
{
    public Mes(string nome, int dias)
    {
        Nome = nome;
        Dias = dias;
    }

    public string Nome { get; private set; }
    public int Dias { get; set; }

    public int CompareTo(object? obj)
    {
        Mes outro = obj as Mes;

        return this.Nome.CompareTo(outro.Nome);
    }

    public override string ToString()
    {
        return $"{Nome} - {Dias}";
    }
}