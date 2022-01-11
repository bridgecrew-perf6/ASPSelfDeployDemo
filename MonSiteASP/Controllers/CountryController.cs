using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MonSite.Library.Datas;
using MonSite.Library.Repositories;
using MonSiteASP.Models;
using MonSiteASP.Models.Forms;

namespace MonSiteASP.Controllers;

public class CountryController : Controller
{
    private readonly CountryRepository _countryRepository;
    private readonly IMapper _mapper;

    public CountryController(CountryRepository countryRepository, IMapper mapper)
    {
        _countryRepository = countryRepository;
        _mapper = mapper;
    }

    public ActionResult Index()
    {
        return View(_mapper.Map<IEnumerable<CountryModel>>(_countryRepository.GetAllWithCities()));
    }

    public ActionResult Details(int id)
    {
        CountryModel? country = _mapper.Map<CountryModel>(_countryRepository.GetByIdWithCities(id));
        return View(country);
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(CountryForm form)
    {
        if (!ModelState.IsValid) return View(form);

        try
        {
            var objForm = _mapper.Map<Country>(form);
            var result = _countryRepository.Insert(objForm);
            CountryModel country = _mapper.Map<CountryModel>(result);
            if (country is null) return View();
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
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
}
