using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Controllers
{
    public class FilmlerKategoriController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
