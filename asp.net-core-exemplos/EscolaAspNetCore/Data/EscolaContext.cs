using EscolaAspNetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAspNetCore.Data
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        {
        }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Estudante> Estudantes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Curso
            builder.Entity<Curso>().ToTable("Cursos");
            builder.Entity<Curso>().HasKey(x => x.CursoId);
            builder.Entity<Curso>().Property(x => x.Titulo).HasMaxLength(100).IsRequired();
            //Estudante
            builder.Entity<Estudante>().ToTable("Estudantes");
            builder.Entity<Estudante>().HasKey(x => x.Id);
            builder.Entity<Estudante>().Property(x => x.Nome).HasMaxLength(100).IsRequired();
        }
    }
}
