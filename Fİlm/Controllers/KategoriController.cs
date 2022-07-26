using Film.DAL.Contexts;
using Film.Entities;
using Microsoft.AspNetCore.Mvc;


namespace FİlmMvc.Controllers
{
    public class KategoriController : Controller
    {
        private readonly SqlDbContext context;

        public KategoriController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.Kategoriler.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Kategori kategori = new();
            return View(kategori);
        }

        [HttpPost]
        public IActionResult Create(Kategori kategori)
        {
            if (ModelState.IsValid)
            {

                context.Kategoriler.Add(kategori);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(kategori);
        }
    }
}
