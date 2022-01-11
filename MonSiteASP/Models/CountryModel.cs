using System.ComponentModel.DataAnnotations;

namespace MonSiteASP.Models;

public class CountryModel
{
    public int Id { get; set; }
    [Display(Name = "Pays")]
    public string Name { get; set; }

    [Display(Name = "Villes")]
    public List<CityModel> Cities { get; set; }
}
