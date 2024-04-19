using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infastructure.Data.Configurations
{
    public class VolumeConfiguration: IEntityTypeConfiguration<Volume>
    {
        public void Configure(EntityTypeBuilder<Volume> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Quantities)
             .HasMaxLength(10)
             .IsRequired();

            builder.Property(v => v.ChaptersQuantities)
            .HasMaxLength(10)
            .IsRequired();

            builder.HasOne(v => v.Manga)
                .WithMany(m => m.Volumes)
                .HasForeignKey(v => v.MandaId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
    }

