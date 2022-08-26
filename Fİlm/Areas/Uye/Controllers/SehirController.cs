using Film.DAL.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Uye.Controllers
{
    [Route("Uye/[controller]")]
    [Area("Uye")]
    [Authorize]
    public class SehirController : Controller
    {
        private readonly ISehirDAL sehirDAL;

        public SehirController(ISehirDAL sehirDAL)
        {
            this.sehirDAL = sehirDAL;
        }
        [HttpGet]
        public IActionResult GetSehirler()
        {
            var sonuc = sehirDAL.GetAll();

            if (sonuc != null)
            {
                return Ok(sonuc);
            }
            else
            {
                return NotFound();
            }

        }
    }
}
