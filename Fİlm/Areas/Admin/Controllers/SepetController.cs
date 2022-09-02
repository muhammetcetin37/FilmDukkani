using Film.DAL.Contexts;
using Film.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class SepetController : Controller
    {
        private readonly SqlDbContext context;

        public SepetController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.Sepet.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Sepet sepet = new();
            return View(sepet);
        }

        [HttpPost]
        public IActionResult Create(Sepet sepet)
        {
            if (ModelState.IsValid)
            {

                context.Sepet.Add(sepet);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(sepet);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Sepet sepet = context.Sepet.Find(id);
            return View(sepet);
        }

        [HttpPost]
        public IActionResult Update(Sepet sepet)
        {
            context.Update(sepet);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var sepet = context.Sepet.Find(id);
            return View(sepet);
        }

        [HttpPost]
        public IActionResult Delete(Sepet sepet)
        {


            context.Remove(sepet);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
