﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TEST_DDD.ApplicationCore.Entity;

namespace TEST_DDD.Infrastructure.EntityConfig
{
    public class ProfissaoMap : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            builder.Property(e => e.Nome)
                   .HasColumnType("varchar(400)")
                   .IsRequired();

            builder.Property(e => e.CBO)
                   .HasColumnType("varchar(10)")
                   .IsRequired();

            builder.Property(e => e.Descricao)
                   .HasColumnType("varchar(1000)")
                   .IsRequired();
        }
    }
}
