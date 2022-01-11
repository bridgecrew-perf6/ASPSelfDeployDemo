using AutoMapper.Configuration.Annotations;
using System.ComponentModel.DataAnnotations;

namespace MonSiteASP.Models.Forms;

public class CityForm
{
    public int CountryID { get; set; }

    [Required(AllowEmptyStrings = false)]
    public string Name { get; set; }
}
