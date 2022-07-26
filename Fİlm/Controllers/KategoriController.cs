using Film.DAL.Contexts;
using Film.Entities;
using Microsoft.AspNetCore.Mvc;


namespace FİlmMvc.Controllers
{
    public class KategoriController : Controller
    {
        //private readonly IKategoriManager manager;

        //public KategoriController(IKategoriManager manager)
        //{
        //    this.manager = manager;
        //}

        //public IActionResult Index()
        //{
        //    var sonuc = manager.GetAll();

        //    return View(sonuc);
        //}


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
            Kategori kat = new();
            return View(kat);
        }

        [HttpPost]
        public IActionResult Create(Kategori kat)
        {
            if (ModelState.IsValid)
            {

                context.Kategoriler.Add(kat);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(kat);
        }
    }
}
