using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infastructure.Data.Configurations
{
    public class MangaConfiguration : IEntityTypeConfiguration<Manga>
    {
        public void Configure(EntityTypeBuilder<Manga> builder) 
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Name)
             .HasMaxLength(50)
             .IsRequired();

            builder.Property(m => m.Description)
           .IsRequired();

        builder.HasOne(g => g.Genre)
                .WithMany(m => m.Mangas)
                .HasForeignKey(g => g.GenreId)
                .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(a => a.Author)
                .WithMany(m => m.Mangas)
                .HasForeignKey(a  => a.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

        builder.Property(m => m.DateOfSsue)
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
