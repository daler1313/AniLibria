using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infastructure.Data.Configurations
{
    public class AnimeConfiguration : IEntityTypeConfiguration<Anime>
    {
        public void Configure(EntityTypeBuilder<Anime> builder) 
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.Description)
             .IsRequired();

            builder.Property(a => a.DateOfSsue)
             .IsRequired();

            builder.HasOne(a => a.Author)
                .WithMany(f => f.Animes)
                .HasForeignKey (a => a.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Genre)
                .WithMany(g => g.Animes)
                .HasForeignKey(a => a.GenreId)
                 .OnDelete(DeleteBehavior.Cascade);

        }

    }
}
