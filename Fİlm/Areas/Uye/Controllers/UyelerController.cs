using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Uye.Controllers
{
    [Area("Uye")]


    public class UyelerController : Controller
    {
        #region degiştirildi
        //private readonly IUyelerManager manager;


        //public UyelerController(IUyelerManager manager)
        //{
        //    this.manager = manager;


        //}
        //[HttpGet]

        ////[Authorize(Roles = "User")]
        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}


        //[HttpPost]
        //public async Task<IActionResult> Login(LoginDTO loginDTO)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = manager.GetAll(p => p.Email == loginDTO.Email && p.Password == loginDTO.Password)
        //                            .FirstOrDefault();

        //        if (user != null)
        //        {
        //            var claims = new List<Claim>
        //            {
        //                new Claim(ClaimTypes.Name,user.UserName),
        //                new Claim(ClaimTypes.Email,user.Email),
        //                new Claim(ClaimTypes.Role,user.Role),

        //            };

        //            var userIdentity = new ClaimsIdentity(claims, "login");
        //            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
        //            await HttpContext.SignInAsync(principal);

        //            return RedirectToAction("Index", "Home", new { Areas = "Uye" });
        //        }


        //    }

        //    return View(loginDTO);
        //}




        //[HttpGet]
        //public IActionResult Register()
        //{
        //    RegisterDTO dTO = new();

        //    return View(dTO);
        //}




        //[HttpPost]
        //public IActionResult Register(RegisterDTO dTO)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Uyeler yeniKullanici = new();
        //        yeniKullanici.Ad = dTO.Ad;
        //        yeniKullanici.Soyad = dTO.Soyad;
        //        yeniKullanici.Email = dTO.Email;
        //        yeniKullanici.TcNo = dTO.TcNo;
        //        yeniKullanici.Gsm = dTO.Gsm;
        //        yeniKullanici.Password = dTO.Password;
        //        yeniKullanici.Role = "User";
        //        yeniKullanici.UserName = dTO.UserName;
        //        manager.Add(yeniKullanici);
        //        return RedirectToAction("Login", "Uyeler");
        //    }

        //    return View(dTO);
        //}
        #endregion


        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

