using GeneralAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAccess.Core.Database.EntityConfigurations
{
    public class AuthIconConfiguration : IEntityTypeConfiguration<AuthIcon>
    {
        public void Configure(EntityTypeBuilder<AuthIcon> builder)
        {
            builder.Property(x => x.IconCode).IsRequired().HasMaxLength(50);
        }
    }
}
