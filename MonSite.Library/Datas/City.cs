namespace MonSite.Library.Datas;

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int CountryID { get; set; }
    public Country Country { get; set; }
}
