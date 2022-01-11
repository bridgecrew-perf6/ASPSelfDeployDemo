using AutoMapper.Configuration.Annotations;
using System.ComponentModel.DataAnnotations;

namespace MonSiteASP.Models.Forms;

public class CountryForm
{
    [Required(AllowEmptyStrings = false)]
    [MaxLength(100)]
    public string Name { get; set; }
}
