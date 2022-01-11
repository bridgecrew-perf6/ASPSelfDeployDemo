using Microsoft.EntityFrameworkCore;
using MonSite.Library.Configurations;
using MonSite.Library.Datas;

namespace MonSite.Library;

public class EFContext : DbContext
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }

    public EFContext(DbContextOptions<EFContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CountryConfiguration());
        modelBuilder.ApplyConfiguration(new CityConfiguration());
    }
}
