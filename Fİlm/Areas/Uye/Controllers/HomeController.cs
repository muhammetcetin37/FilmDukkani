using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Uye.Controllers
{
    [Area("Uye")]


    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
