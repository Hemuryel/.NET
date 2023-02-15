using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEFCore03.Models
{
    public class AlunoContext : DbContext
    {
        public AlunoContext(DbContextOptions<AlunoContext> options) : base(options)
        {

        }

        public DbSet<Aluno> AlunosEF { get; set; }
        public DbSet<TipoSocio> TipoSociosEF { get; set; }
    }
}
