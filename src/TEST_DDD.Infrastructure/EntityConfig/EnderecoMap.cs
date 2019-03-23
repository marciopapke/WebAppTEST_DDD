﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TEST_DDD.ApplicationCore.Entity;

namespace TEST_DDD.Infrastructure.EntityConfig
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(e => e.Bairro)
                   .HasColumnType("varchar(200)")
                   .IsRequired();

            builder.Property(e => e.CEP)
                   .HasColumnType("varchar(15)")
                   .IsRequired();

            builder.Property(e => e.Logradouro)
                   .HasColumnType("varchar(200)")
                   .IsRequired();

            builder.Property(e => e.Referencia)
                   .HasColumnType("varchar(400)");
        }
    }
}
