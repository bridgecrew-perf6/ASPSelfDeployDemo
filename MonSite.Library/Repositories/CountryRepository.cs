using Microsoft.EntityFrameworkCore;
using MonSite.Library.Datas;

namespace MonSite.Library.Repositories;

public class CountryRepository : RepositoryBase<Country, int>
{
    public CountryRepository(EFContext context) : base(context) { }

    /// <summary>
    /// Returns a list of countries with the cities for earch country.
    /// </summary>
    /// <returns>List of countries with cities included.</returns>
    public IEnumerable<Country> GetAllWithCities()
    {
        return _context.Countries.Include(c => c.Cities);
    }

    public Country? GetByIdWithCities(int id)
    {
        return _context.Countries.Include(c => c.Cities).SingleOrDefault(c => c.Id == id);
    }
}
