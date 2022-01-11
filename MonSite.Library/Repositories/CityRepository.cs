using MonSite.Library.Datas;

namespace MonSite.Library.Repositories;

public class CityRepository : RepositoryBase<City, int>
{
    public CityRepository(EFContext context) : base(context) { }
}
