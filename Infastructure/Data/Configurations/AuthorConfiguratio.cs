﻿using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infastructure.Data.Configurations
{
    partial class AuthorConfiguratio : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder) 
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.FullName)
          
               .IsRequired();

            builder.Property(a => a.YearOfDirth)
          
              .IsRequired();

        }
    }
}
