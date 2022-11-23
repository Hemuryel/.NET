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
                             select alb;

                foreach (var album in query4)
                {
                    Console.WriteLine(album.Titulo);
                }

                Console.ReadKey();
            }
        }
    }
}
