using System.Xml.Linq;

namespace AluraTunesLinqToXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Load(@"Data\XMLFile.xml");

            var queryXML =
                from g in root.Element("Generos").Elements("Genero")
                select g;

            foreach (var genero in queryXML)
            {
                Console.WriteLine($"{genero.Element("GeneroId").Value}\t{genero.Element("Nome").Value}");
            }

            Console.WriteLine();

            var query = from g in root.Element("Generos").Elements("Genero")
                        join m in root.Element("Musicas").Elements("Musica")
                            on g.Element("GeneroId").Value equals m.Element("GeneroId").Value
                        select new
                        {
                            Musica = m.Element("Nome").Value,
                            Genero = g.Element("Nome").Value
                        };

            foreach (var musicaGenero in query)
            {
                Console.WriteLine($"{musicaGenero.Musica}\t{musicaGenero.Genero}");
            }
            Console.ReadKey();
        }
    }
}