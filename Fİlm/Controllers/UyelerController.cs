﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Controllers
{


    public class UyelerController : Controller
    {

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

