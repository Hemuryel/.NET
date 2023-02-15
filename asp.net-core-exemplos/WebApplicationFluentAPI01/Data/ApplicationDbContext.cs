using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationFluentAPI01.Models;

namespace WebApplicationFluentAPI01.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        // Mapeamento Fluent API
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // exclui a tabela do modelo do EF, logo, a entidade não será mapeada
            builder.Ignore<LogAudit>();

            // mapeamento para entidade usuário
            builder.Entity<Usuario>().ToTable("Usuarios");

            // valor da propriedade Id não deve ser gerado pelo BD
            builder.Entity<Usuario>().Property(p => p.Id).ValueGeneratedNever();

            // tamanho máximo para nome e e-mail
            builder.Entity<Usuario>().Property(u => u.Nome).HasMaxLength(80).IsRequired();
            builder.Entity<Usuario>().Property(u => u.Email).HasMaxLength(150).IsRequired();

            // mapeamento para entidade cliente
            builder.Entity<Cliente>().ToTable("Clientes");

            // chave primária
            builder.Entity<Cliente>().HasKey(u => u.ClienteId);

            // tamanho máximo 
            builder.Entity<Cliente>().Property(u => u.Nome).HasMaxLength(80).IsRequired();
            builder.Entity<Cliente>().Property(u => u.Endereco).HasMaxLength(100).IsRequired();
            builder.Entity<Cliente>().Property(u => u.Telefone).HasMaxLength(20).IsRequired();
            builder.Entity<Cliente>().Property(u => u.Cidade).HasMaxLength(50).IsRequired();

            builder.Entity<Pedido>().ToTable("Pedidos");
            builder.Entity<Pedido>().HasKey(u => u.PedidoId);

            // relacionamento entre cliente e pedido = propriedade de navegação
            builder.Entity<Pedido>()
                .HasOne(c => c.Cliente)
                .WithMany(p => p.Pedidos)
                .OnDelete(DeleteBehavior.Restrict); // desabilita exclusão em cascata
        }
    }
}
