using AutoMapper;
using MonSite.Library.Datas;
using MonSiteASP.Models;
using MonSiteASP.Models.Forms;

namespace MonSiteASP.Mappers;

public class Mapper : Profile
{
    public Mapper()
    {
        CreateMap<Country, CountryModel>().ReverseMap();
        CreateMap<CountryForm, Country>();

        CreateMap<City, CityModel>().ReverseMap();
        CreateMap<CityForm, City>();
    }
}