using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TEST_DDD.ApplicationCore.Entity;

namespace TEST_DDD.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.ClienteId);

            builder.HasMany(c => c.Contatos)
                   .WithOne(c => c.Cliente)
                   .HasForeignKey(c => c.ClienteId)
                   .HasPrincipalKey(c => c.ClienteId);

            builder.HasOne(c => c.Endereco)
                   .WithOne(x => x.Cliente)
                   .HasForeignKey<Endereco>(x => x.ClienteId);

            builder.Property(e => e.CPF)
                   .HasColumnType("varchar(11)")
                   .IsRequired();

            builder.Property(e => e.Nome)
                   .HasColumnType("varchar(200)")
                   .IsRequired();
        }
    }
}
