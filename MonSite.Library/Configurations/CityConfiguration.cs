using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MonSite.Library.Datas;

namespace MonSite.Library.Configurations;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.HasOne(c => c.Country)
            .WithMany(p => p.Cities)
            .HasForeignKey(c => c.CountryID);
    }
}