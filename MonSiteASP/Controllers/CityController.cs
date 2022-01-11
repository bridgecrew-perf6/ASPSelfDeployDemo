using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MonSite.Library.Datas;
using MonSite.Library.Repositories;
using MonSiteASP.Models;
using MonSiteASP.Models.Forms;

namespace MonSiteASP.Controllers;

public class CityController : Controller
{
    private readonly CityRepository _cityRepository;
    private readonly CountryRepository _countryRepository;
    private readonly IMapper _mapper;

    public CityController(CityRepository cityRepository, CountryRepository countryRepository, IMapper mapper)
    {
        _cityRepository = cityRepository;
        _countryRepository = countryRepository;
        _mapper = mapper;
    }

    public ActionResult Index()
    {
        return RedirectToAction("Index", "Country");
    }

    public ActionResult Details(int id)
    {
        return View();
    }

    public ActionResult Create()
    {
        IEnumerable<CountryModel> countries = _mapper.Map<IEnumerable<CountryModel>>(_countryRepository.GetAll());
        ViewBag.Countries = ToSelectList(countries);
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(CityForm form)
    {
        if (!ModelState.IsValid) return View(ModelState);

        try
        {
            var objFrom = _mapper.Map<City>(form);
            var result = _cityRepository.Insert(objFrom);
            CityModel? city = _mapper.Map<CityModel>(result);
            return city is null ? View(form) : RedirectToAction("Details", "Country", new { id = form.CountryID });
        }
        catch (Exception ex)
        {
            return View(ex.Message);
        }
    }

    public ActionResult Edit(int id)
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    public ActionResult Delete(int id)
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    [NonAction]
    public SelectList ToSelectList(IEnumerable<CountryModel> countries)
    {
        List<SelectListItem> list = new List<SelectListItem>();

        foreach (var country in countries.ToList())
        {
            list.Add(new SelectListItem()
            {
                Text = country.Name,
                Value = country.Id.ToString()
            });
        }

        return new SelectList(list, "Value", "Text");
    }
}
