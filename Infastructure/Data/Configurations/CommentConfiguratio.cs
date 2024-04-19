using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infastructure.Data.Configurations
{
    public class CommentConfiguratio: IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder) 
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
             .HasMaxLength(80)
             .IsRequired();
        }
    }
}
