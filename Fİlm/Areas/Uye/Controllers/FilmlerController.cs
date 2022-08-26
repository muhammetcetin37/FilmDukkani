using Film.DAL.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Uye.Controllers
{
    [Area("Uye")]
    [Authorize]
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


    }
}