using Microsoft.EntityFrameworkCore;
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

            modelBuilder.Entity<Endereco>().ToTable("Endereco");

            modelBuilder.Entity<Profissao>().ToTable("Profissao");

            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");


            #region "Configuração Clientes"

            modelBuilder.Entity<Cliente>().HasKey(c => c.ClienteId);

            modelBuilder.Entity<Cliente>().HasMany(c => c.Contatos)
                                          .WithOne(c => c.Cliente)
                                          .HasForeignKey(c => c.ClienteId)
                                          .HasPrincipalKey(c => c.ClienteId);

            modelBuilder.Entity<Cliente>().Property(e => e.CPF)
                                            .HasColumnType("varchar(11)")
                                            .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
                                            .HasColumnType("varchar(200)")
                                            .IsRequired();

            #endregion

            #region "Configuração Contatos"

            modelBuilder.Entity<Contato>().HasOne(c => c.Cliente)
                                          .WithMany(c => c.Contatos)
                                          .HasForeignKey(c => c.ClienteId)
                                          .HasPrincipalKey(c => c.ClienteId);

            modelBuilder.Entity<Contato>().Property(e => e.Nome)
                                            .HasColumnType("varchar(200)")
                                            .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Email)
                                            .HasColumnType("varchar(100)")
                                            .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Telefone)
                                            .HasColumnType("varchar(15)");

            #endregion

            #region "Configuração de Profissão"

            modelBuilder.Entity<Profissao>().Property(e => e.Nome)
                                          .HasColumnType("varchar(400)")
                                          .IsRequired();

            modelBuilder.Entity<Profissao>().Property(e => e.CBO)
                                          .HasColumnType("varchar(10)")
                                          .IsRequired();

            modelBuilder.Entity<Profissao>().Property(e => e.Descricao)
                                          .HasColumnType("varchar(1000)")
                                          .IsRequired();

            #endregion

            #region "Configuração de Endereço"

            modelBuilder.Entity<Endereco>().Property(e => e.Bairro)
                                         .HasColumnType("varchar(200)")
                                         .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.CEP)
                                         .HasColumnType("varchar(15)")
                                         .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Logradouro)
                                       .HasColumnType("varchar(200)")
                                       .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Referencia)
                                      .HasColumnType("varchar(400)");
            #endregion

            #region "Configuração de Profissão Cliente"

            modelBuilder.Entity<ProfissaoCliente>().HasKey(c => c.Id);

            modelBuilder.Entity<ProfissaoCliente>()
                        .HasOne(pc => pc.Cliente)
                        .WithMany(c => c.ProfissoesClientes)
                        .HasForeignKey(c => c.ClienteId);

            #endregion

            #region "Configuração de Menu"

            modelBuilder.Entity<Menu>().HasMany(c => c.SubMenu)
                                       .WithOne()
                                       .HasForeignKey(c => c.MenuId);

            #endregion
        }
    }
}
