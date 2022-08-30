using Film.DAL.Contexts;
using Film.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class IlceController : Controller
    {

        private readonly SqlDbContext context;

        public IlceController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.Ilceler.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Ilce ilce = new();
            return View(ilce);
        }

        [HttpPost]
        public IActionResult Create(Ilce ilce)
        {
            if (!ModelState.IsValid)
            {

                context.Ilceler.Add(ilce);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(ilce);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Ilce ilce = context.Ilceler.Find(id);
            return View(ilce);
        }

        [HttpPost]
        public IActionResult Update(Ilce ilce)
        {
            context.Update(ilce);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var ilce = context.Ilceler.Find(id);
            return View(ilce);
        }

        [HttpPost]
        public IActionResult Delete(Ilce ilce)
        {


            context.Remove(ilce);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
