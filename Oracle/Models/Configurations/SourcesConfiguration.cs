using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Oracle.Models.Configurations
{
    public class SourcesConfiguration : IEntityTypeConfiguration<Sources>
    {
        public void Configure(EntityTypeBuilder<Sources> builder)
        {
            builder.ToTable("SOURCES");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .HasColumnName("NAME")
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
