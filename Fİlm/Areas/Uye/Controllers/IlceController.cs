using Film.DAL.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Uye.Controllers
{
    [Area("Uye")]
    [Authorize]
    public class IlceController : Controller
    {
        private readonly IilceDAL ilceDAL;

        public IlceController(IilceDAL ilceDAL)
        {
            this.ilceDAL = ilceDAL;
        }

        [HttpGet]
        public IActionResult GetIlceler(int? sehirId)
        {
            if (sehirId != null)
            {
                var sonuc = ilceDAL.GetAll(p => p.SehirId == sehirId);
                if (sonuc != null)
                {
                    return Ok(sonuc);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return Ok(ilceDAL.GetAll());
            }

        }
    }
}
