using Microsoft.EntityFrameworkCore;

namespace AspCoreMvc_Filtros.Models
{
    public class AutorDbContext : DbContext
    {
        public AutorDbContext(DbContextOptions<AutorDbContext> options)
          : base(options)
        {
        }
        public DbSet<Autor> Autores { get; set; }
    }
}
