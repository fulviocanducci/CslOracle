using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WinForm.Models.Configurations;

public sealed class PeopleConfiguration : IEntityTypeConfiguration<People>
{
    public void Configure(EntityTypeBuilder<People> builder)
    {
        builder.ToTable("PEOPLES");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).HasColumnName("ID").ValueGeneratedOnAdd().IsRequired();
        builder.Property(p => p.Name).HasColumnName("NAME").HasMaxLength(100).IsRequired();
        builder.Property(p => p.Price).HasColumnName("PRICE").HasPrecision(18, 2).IsRequired();
        builder.Property(p => p.Active).HasColumnName("ACTIVE").HasDefaultValue(true).IsRequired();
        builder.Property(p => p.CreatedAt).HasColumnName("CREATEDAT").IsRequired();

        builder.HasIndex(i => i.Name, "IX_PEOPLES_NAME_UPPER").IsUnique(false);
    }
}
