using Film.DAL.Contexts;
using Film.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SehirController : Controller
    {
        private readonly SqlDbContext context;

        public SehirController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.Sehirler.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Sehir sehir = new();
            return View(sehir);
        }

        [HttpPost]
        public IActionResult Create(Sehir sehir)
        {
            if (!ModelState.IsValid)
            {

                context.Sehirler.Add(sehir);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(sehir);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Sehir sehir = context.Sehirler.Find(id);
            return View(sehir);
        }

        [HttpPost]
        public IActionResult Update(Sehir sehir)
        {
            context.Update(sehir);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var sehir = context.Sehirler.Find(id);
            return View(sehir);
        }

        [HttpPost]
        public IActionResult Delete(Sehir sehir)
        {


            context.Remove(sehir);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
