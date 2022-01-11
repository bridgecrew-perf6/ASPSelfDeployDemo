using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonSite.Library.Datas;

namespace MonSite.Library.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.Property(p => p.Name)
            .IsUnicode(true)
            .HasMaxLength(100)
            .IsRequired();
    }
}
