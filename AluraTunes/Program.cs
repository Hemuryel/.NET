namespace AluraTunes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var generos = new List<Genero>
            {
                new Genero { Id = 1, Nome = "Rock" },
                new Genero { Id = 2, Nome = "Reggae" },
                new Genero { Id = 3, Nome = "Rock Progressivo" },
                new Genero { Id = 4, Nome = "Punk Rock" },
                new Genero { Id = 5, Nome = "Clássica" },
            };

            foreach (var genero in generos)
            {
                if (genero.Nome.Contains("Rock"))
                {
                    Console.WriteLine($"{genero.Id}\t{genero.Nome}");
                }
            }

            Console.WriteLine();

            var query = from g in generos
                        where g.Nome.Contains("Rock")
                        select g;
            foreach (var genero in query)
            {
                Console.WriteLine($"{genero.Id}\t{genero.Nome}");
            }

            // listar músicas
            var musicas = new List<Musica>
            {
                new Musica { Id = 1, Nome = "Sweet Child O'Mine", GeneroId = 1 },
                new Musica { Id = 2, Nome = "I Shot The Sheriff", GeneroId = 2 },
                new Musica { Id = 3, Nome = "Danúbio Azul", GeneroId = 5 }
            };

            var musicaQuery = from m in musicas
                              join g in generos on m.GeneroId equals g.Id
                              select new { m, g };

            foreach (var musica in musicaQuery)
            {
                Console.WriteLine($"{musica.m.Id}\t{musica.m.Nome}\t{musica.g.Nome}");
            }
        }
    }

    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    public class Musica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int GeneroId { get; set; }
    }
}