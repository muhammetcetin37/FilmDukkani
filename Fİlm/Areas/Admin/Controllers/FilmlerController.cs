using Film.DAL.Contexts;
using Film.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class FilmlerController : Controller
    {
        private readonly SqlDbContext context;

        public FilmlerController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.Filmler.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Filmler filmler = new();
            return View(filmler);
        }

        [HttpPost]
        public IActionResult Create(Filmler filmler)
        {
            if (ModelState.IsValid)
            {

                context.Filmler.Add(filmler);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(filmler);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Filmler filmler = context.Filmler.Find(id);
            return View(filmler);
        }

        [HttpPost]
        public IActionResult Update(Filmler filmler)
        {
            context.Update(filmler);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var filmler = context.Filmler.Find(id);
            return View(filmler);
        }

        [HttpPost]
        public IActionResult Delete(Filmler filmler)
        {


            context.Remove(filmler);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
