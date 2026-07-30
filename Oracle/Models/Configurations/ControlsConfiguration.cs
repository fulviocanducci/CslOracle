using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Oracle.Models.Configurations
{
    public class ControlsConfiguration : IEntityTypeConfiguration<Controls>
    {
        public void Configure(EntityTypeBuilder<Controls> builder)
        {
            builder.ToTable("CONTROL");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Description)
                .HasColumnName("DESCRIPTION")
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
