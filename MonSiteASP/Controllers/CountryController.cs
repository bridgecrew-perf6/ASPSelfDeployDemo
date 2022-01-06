using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonSiteASP.Models;

namespace MonSiteASP.Controllers
{
    public class CountryController : Controller
    {
        public List<Country> Pays { get; set; } = new List<Country>()
        {
            new ("Belgique", "Bruxelles"),
            new ("France", "Paris"),
            new ("Allemagne", "Berlin"),
            new ("Pays Bas", "Amsterdam"),
            new ("Russie", "Moscou"),
            new ("Japon", "Tokyo"),
            new ("Chine", "Pékin"),
            new ("Espagne", "Madrid"),
            new ("Portugal", "Barcelone"),
            new ("Italie", "Rome"),
            new ("Angleterre", "Londre"),
        };

    // GET: CountryController
    public ActionResult Index()
        {
            return View(Pays);
        }

        // GET: CountryController/Details/5
        public ActionResult Details(string pays)
        {
            Country? country = Pays.Single(x => x.Name.Contains(pays));
            return View(country);
        }

        // GET: CountryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: CountryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CountryController/Edit/5
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

        // GET: CountryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CountryController/Delete/5
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
}
