using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Controllers
{
    public class FilmlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
