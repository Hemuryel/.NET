using LinqToEntities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToEntities
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AluraTunesEntities())
            {
                //Ativar log de SQL pelo Console
                contexto.Database.Log = Console.WriteLine;

                var query = from g in contexto.Generos
                            select g;

                foreach (var genero in query)
                {
                    Console.WriteLine($"{genero.GeneroId}\t{genero.Nome}");
                }

                Console.WriteLine();

                var faixaGenero = from g in contexto.Generos
                                  join f in contexto.Faixas
                                  on g.GeneroId equals f.GeneroId
                                  select new { f, g };

                faixaGenero = faixaGenero.Take(10);

                foreach (var item in faixaGenero)
                {
                    Console.WriteLine($"{item.f.Nome}\t{item.g.Nome}");
                }

                Console.WriteLine();

                var textoBusca = "Led";
                var queryPesquisa = from a in contexto.Artistas
                                    where a.Nome.Contains(textoBusca)
                                    select a;

                foreach (var artista in queryPesquisa)
                {
                    Console.WriteLine($"{artista.ArtistaId}\t{artista.Nome}");
                }

                Console.WriteLine();

                var query2 = contexto.Artistas.Where(a => a.Nome.Contains(textoBusca));

                foreach (var artista in query2)
                {
                    Console.WriteLine($"{artista.ArtistaId}\t{artista.Nome}");
                }

                Console.WriteLine();

                var query3 = from a in contexto.Artistas
                             join alb in contexto.Albums
                                on a.ArtistaId equals alb.ArtistaId
                             where a.Nome.Contains(textoBusca)
                             select new
                             {
                                 NomeArtista = a.Nome,
                                 NomeAlbum = alb.Titulo
                             };

                foreach (var item in query3)
                {
                    Console.WriteLine($"{item.NomeArtista}\t{item.NomeAlbum}");
                }

                Console.WriteLine();

                var query4 = from alb in contexto.Albums
                             where alb.Artista.Nome.Contains(textoBusca)
                             select new
                             {
                                 NomeArtista = alb.Artista.Nome,
                                 NomeAlbum = alb.Titulo
                             };

                foreach (var item in query4)
                {
                    Console.WriteLine($"{item.NomeArtista}\t{item.NomeAlbum}");
                }

                GetFaixas(contexto, "Led Zeppelin", "");
                GetFaixas(contexto, "Led Zeppelin", "Graffiti");

                var query7 = "";

                Console.ReadKey();
            }
        }

        private static void GetFaixas(AluraTunesEntities contexto, string buscaArtista, string buscaAlbum)
        {
            var query5 = from f in contexto.Faixas
                         where f.Album.Artista.Nome.Contains(buscaArtista)
                         select f;

            if (!string.IsNullOrEmpty(buscaAlbum))
            {
                query5 = query5.Where(q => q.Album.Titulo.Contains(buscaAlbum));
            }

            query5 = query5.OrderBy(q => q.Album.Titulo).ThenByDescending(q => q.Nome);

            foreach (var faixa in query5)
            {
                Console.WriteLine($"{faixa.Album.Titulo.PadRight(40)}\t{faixa.Nome}");
            }


            //teste
            var query6 = from f in contexto.Faixas
                         where f.Album.Artista.Nome.Contains(buscaArtista)
                         && (!string.IsNullOrEmpty(buscaAlbum)
                         ? f.Album.Titulo.Contains(buscaAlbum)
                         : true)
                         select f;

            Console.WriteLine();
        }
    }
}
