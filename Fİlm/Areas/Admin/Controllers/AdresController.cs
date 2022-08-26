using Film.DAL.Contexts;
using Film.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AdresController : Controller
    {
        private readonly SqlDbContext context;

        public AdresController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.Adresler.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Adres adres = new();
            return View(adres);
        }

        [HttpPost]
        public IActionResult Create(Adres adres)
        {
            if (!ModelState.IsValid)
            {

                context.Adresler.Add(adres);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(adres);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Adres adres = context.Adresler.Find(id);
            return View(adres);
        }

        [HttpPost]
        public IActionResult Update(Adres adres)
        {
            context.Update(adres);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var adres = context.Adresler.Find(id);
            return View(adres);
        }

        [HttpPost]
        public IActionResult Delete(Adres adres)
        {


            context.Remove(adres);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
