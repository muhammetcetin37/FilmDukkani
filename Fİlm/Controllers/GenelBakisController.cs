using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Controllers
{
    public class GenelBakisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
