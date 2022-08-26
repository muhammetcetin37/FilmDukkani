using Film.BL.Abstract;
using Film.Entities;
using FİlmMvc.Areas.Uye.Models.DTOs;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FİlmMvc.Areas.Uye.Controllers
{
    [Area("Uye")]
    public class UyelerrrController : Controller
    {
        private readonly IUyelerManager manager;

        public UyelerrrController(IUyelerManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        public IActionResult Uye()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Uye(UyeDTO uyeDTO)
        {
            if (ModelState.IsValid)
            {
                var uyeler = manager.GetAll(p => p.Email == uyeDTO.Email && p.Password == uyeDTO.Password)
                                    .FirstOrDefault();

                if (uyeler != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,uyeler.UserName),
                        new Claim(ClaimTypes.Email,uyeler.Email),
                        new Claim(ClaimTypes.Role,uyeler.Role)
                    };

                    var uyelerIdentity = new ClaimsIdentity(claims, "uye");
                    ClaimsPrincipal principal = new ClaimsPrincipal(uyelerIdentity);
                    await HttpContext.SignInAsync(principal);

                    return RedirectToAction("Index", "Home", new { Area = "Uye" });
                }


            }

            return View(uyeDTO);
        }





        [HttpGet]
        public IActionResult UyeRegister()
        {
            UyeRegisterDTO dTO = new();

            return View(dTO);
        }




        [HttpPost]
        public IActionResult UyeRegister(UyeRegisterDTO dTO)
        {
            if (ModelState.IsValid)
            {
                Uyeler yeniKullanici = new();
                yeniKullanici.Ad = dTO.Ad;
                yeniKullanici.Soyad = dTO.Soyad;
                yeniKullanici.Email = dTO.Email;
                yeniKullanici.TcNo = dTO.TcNo;
                yeniKullanici.Gsm = dTO.Gsm;
                yeniKullanici.Password = dTO.Password;
                yeniKullanici.Role = "User";
                yeniKullanici.UserName = dTO.UserName;
                //yeniKullanici.Adresler = new List<Adres>();
                //Adres yeniAdres = new Adres
                //{
                //    SehirId = dTO.Adresler.SehirId,
                //    IlceId = dTO.Adresler.IlceId,
                //    AdresTip = AdresTip.Ev
                //};
                //yeniKullanici.Adresler.Add(yeniAdres);

                manager.Add(yeniKullanici);
                return RedirectToAction("Uye", "Uyelerrr");
            }

            return View(dTO);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

