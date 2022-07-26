using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Controllers
{
    public class SehirController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
