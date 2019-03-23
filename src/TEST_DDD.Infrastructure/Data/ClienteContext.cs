﻿using Microsoft.EntityFrameworkCore;
using TEST_DDD.ApplicationCore.Entity;

namespace TEST_DDD.Infrastructure.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");

            modelBuilder.Entity<Contato>().ToTable("Contato");

            #region "Configuração Clientes"

            modelBuilder.Entity<Cliente>().Property(e => e.CPF)
                                            .HasColumnType("varchar(11)")
                                            .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
                                            .HasColumnType("varchar(200)")
                                            .IsRequired();

            #endregion

            #region "Configuração Contatos"

            modelBuilder.Entity<Contato>().Property(e => e.Nome)
                                            .HasColumnType("varchar(200)")
                                            .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Email)
                                            .HasColumnType("varchar(100)")
                                            .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Telefone)
                                            .HasColumnType("varchar(15)");

            #endregion

        }
    }
}
