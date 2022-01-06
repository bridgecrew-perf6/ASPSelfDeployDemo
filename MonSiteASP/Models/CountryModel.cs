namespace MonSiteASP.Models
{
    public class CountryModel
    {
        public string Name { get; set; }
        public string Capital { get; set; }

        public CountryModel(string name, string capital)
        {
            Name = name;
            Capital = capital;
        }
    }
}
