using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infastructure.Data.Configurations
{
    public class SeasonConfiguration : IEntityTypeConfiguration<Season>
    {
        public void Configure(EntityTypeBuilder<Season> builder) 
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Quantities)
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(s => s.SeriesQuantities)
           .HasMaxLength(50)
           .IsRequired();

            builder.HasOne(s => s.Animes)
                .WithMany(a => a.Seasons)
                .HasForeignKey(a => a.AnimeId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
