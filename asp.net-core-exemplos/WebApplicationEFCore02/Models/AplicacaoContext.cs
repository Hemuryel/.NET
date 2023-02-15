using Microsoft.EntityFrameworkCore;

namespace WebApplicationEFCore02.Models
{
    public class AplicacaoContext : DbContext
    {
        public AplicacaoContext(DbContextOptions<AplicacaoContext> options) : base (options)
        {

        }
        public DbSet<Pais> Paises { get; set; }
    }
}
