using System.ComponentModel.DataAnnotations;

namespace MonSiteASP.Models
{
    public class Country
    {
        [Display(Name = "Pays")]
        public string Name { get; set; }
        public string Capital { get; set; }

        public Country() { }

        public Country(string name, string capital)
        {
            Name = name;
            Capital = capital;
        }
    }
}
