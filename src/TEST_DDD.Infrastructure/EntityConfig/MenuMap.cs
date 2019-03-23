using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TEST_DDD.ApplicationCore.Entity;

namespace TEST_DDD.Infrastructure.EntityConfig
{
    public class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasMany(c => c.SubMenu)
                   .WithOne()
                   .HasForeignKey(c => c.MenuId);
        }
    }
}
