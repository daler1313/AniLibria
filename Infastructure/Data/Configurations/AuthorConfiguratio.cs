using Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Data.Configurations
{
    partial class AuthorConfiguration : IEntityTypeConfiguration<Author>
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
