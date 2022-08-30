using Film.DAL.Contexts;
using Film.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class FilmlerKategoriController : Controller
    {
        private readonly SqlDbContext context;

        public FilmlerKategoriController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.FilmlerKategori.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            FilmlerKategori filmlerkategori = new();
            return View(filmlerkategori);
        }

        [HttpPost]
        public IActionResult Create(FilmlerKategori filmlerkategori)
        {
            if (ModelState.IsValid)
            {

                context.FilmlerKategori.Add(filmlerkategori);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(filmlerkategori);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            FilmlerKategori filmlerkategori = context.FilmlerKategori.Find(id);
            return View(filmlerkategori);
        }

        [HttpPost]
        public IActionResult Update(FilmlerKategori filmlerkategori)
        {
            context.Update(filmlerkategori);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var filmlerkategori = context.FilmlerKategori.Find(id);
            return View(filmlerkategori);
        }

        [HttpPost]
        public IActionResult Delete(FilmlerKategori filmlerkategori)
        {


            context.Remove(filmlerkategori);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
