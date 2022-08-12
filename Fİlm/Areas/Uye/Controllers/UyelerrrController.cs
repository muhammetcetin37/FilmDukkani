﻿using Film.BL.Abstract;
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
                var user = manager.GetAll(p => p.Email == uyeDTO.Email && p.Password == uyeDTO.Password)
                                    .FirstOrDefault();

                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,user.UserName),
                        new Claim(ClaimTypes.Email,user.Email),
                        new Claim(ClaimTypes.Role,user.Role)
                    };

                    var userIdentity = new ClaimsIdentity(claims, "uye");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
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

