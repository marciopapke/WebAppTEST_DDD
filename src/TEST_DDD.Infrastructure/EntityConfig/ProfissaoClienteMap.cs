using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TEST_DDD.ApplicationCore.Entity;

namespace TEST_DDD.Infrastructure.EntityConfig
{
   public class ProfissaoClienteMap : IEntityTypeConfiguration<ProfissaoCliente>
    {
        public void Configure(EntityTypeBuilder<ProfissaoCliente> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(pc => pc.Cliente)
                   .WithMany(c => c.ProfissoesClientes)
                   .HasForeignKey(c => c.ClienteId);
        }
    }
}
