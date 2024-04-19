using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infastructure.Data.Configurations
{
    public class VewingConfiguration : IEntityTypeConfiguration<Vewing>
    {
        public void Configure(EntityTypeBuilder<Vewing> builder)
        {
            builder.HasKey(v => v.Id);

            builder.HasOne(v => v.Animes)
              .WithMany(a => a.Vewings)
              .HasForeignKey(v => v.AnimeId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(v => v.User)
            .WithMany(u => u.Vewings)
            .HasForeignKey(v => v.UserId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(v => v.Comment)
          .WithMany(c => c.Vewings)
          .HasForeignKey(v => v.CommentsId)
          .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
