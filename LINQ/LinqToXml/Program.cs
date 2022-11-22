using System.Xml.Linq;

namespace AluraTunesLinqToXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Load(@"XMLFile.xml");

            var queryXML =
                from g in root.Element("Generos").Elements("Genero")
                select g;

            foreach (var genero in queryXML)
            {
                Console.WriteLine($"{genero.Element("GeneroId").Value}\t{genero.Element("Nome").Value}");
            }
        }
    }
}