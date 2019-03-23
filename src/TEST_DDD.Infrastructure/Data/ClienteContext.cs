using Microsoft.EntityFrameworkCore;
using TEST_DDD.ApplicationCore.Entity;
using TEST_DDD.Infrastructure.EntityConfig;

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
            //Adicionando os nomes que você quer que crie no banco de dados. 
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");
            modelBuilder.Entity<Menu>().ToTable("Menu");

            //Entity config onde crio os Mappings da tabelas ... 
            //Através da Interface deste cara IEntityTypeConfiguration
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new ProfissaoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new ProfissaoClienteMap());
            modelBuilder.ApplyConfiguration(new MenuMap());
        }
    }
}
