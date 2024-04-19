using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infastructure.Data.Configurations
{
    public class ReadingConfiguration: IEntityTypeConfiguration<Reading>
    {
        public void Configure(EntityTypeBuilder<Reading> builder) 
        {
            builder.HasKey(r => r.Id);
            builder.HasOne(r => r.Manga)
                .WithMany(m => m.Readings)
                .HasForeignKey(r => r.MangaId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.User)
                .WithMany(u => u.Readings)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r =>r.Comment)
                .WithMany(c => c.Readings)
                .HasForeignKey(r => r.CommentId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
