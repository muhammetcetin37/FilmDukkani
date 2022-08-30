using Film.DAL.Contexts;
using Film.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PaketController : Controller
    {
        private readonly SqlDbContext context;

        public PaketController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.Paketler.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Paket paket = new();
            return View(paket);
        }

        [HttpPost]
        public IActionResult Create(Paket paket)
        {
            if (ModelState.IsValid)
            {

                context.Paketler.Add(paket);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(paket);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Paket paket = context.Paketler.Find(id);
            return View(paket);
        }

        [HttpPost]
        public IActionResult Update(Paket paket)
        {
            context.Update(paket);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var paket = context.Paketler.Find(id);
            return View(paket);
        }

        [HttpPost]
        public IActionResult Delete(Paket paket)
        {


            context.Remove(paket);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
