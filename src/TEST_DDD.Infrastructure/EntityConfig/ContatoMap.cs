using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TEST_DDD.ApplicationCore.Entity;

namespace TEST_DDD.Infrastructure.EntityConfig
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasOne(c => c.Cliente)
                   .WithMany(c => c.Contatos)
                   .HasForeignKey(c => c.ClienteId)
                   .HasPrincipalKey(c => c.ClienteId);

            builder.Property(e => e.Nome)
                   .HasColumnType("varchar(200)")
                   .IsRequired();

            builder.Property(e => e.Email)
                   .HasColumnType("varchar(100)")
                   .IsRequired();

            builder.Property(e => e.Telefone)
                   .HasColumnType("varchar(15)");
        }
    }
}
