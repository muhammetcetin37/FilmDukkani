using Film.BL.Abstract;
using Film.BL.Concrete;
using Film.DAL.Contexts;
using FİlmMvc.Infrastructure.Contexts;
using FİlmMvc.Models.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services
    .AddDbContext<SqlDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FilmDukkani")));

builder.Services
    .AddDbContext<SqlContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FilmDukkani")));

builder.Services.AddIdentity<AppUser, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedPhoneNumber = false;
    x.SignIn.RequireConfirmedEmail = false;
    x.SignIn.RequireConfirmedAccount = false;

    x.Password.RequiredLength = 3;
    x.Password.RequireUppercase = false;
    x.Password.RequireNonAlphanumeric = false;
    x.Password.RequiredUniqueChars = 0;
    x.Password.RequireLowercase = false;

}).AddEntityFrameworkStores<SqlContext>().AddDefaultTokenProviders();

builder.Services.AddScoped<IKategoriManager, KategoriManager>();
builder.Services.AddScoped<IUyelerManager, UyelerManager>();
builder.Services.AddScoped<IFilmlerManager, FilmlerManager>();
builder.Services.AddScoped<ITedarikciManager, TedarikciManager>();
builder.Services.AddScoped<IAdresManager, AdresManager>();
//builder.Services.AddScoped<ISehirManager, SehirManager>();
//builder.Services.AddScoped<IilceManager, IlceManager>();
builder.Services.AddScoped<IPaketManager, PaketManager>();
builder.Services.AddScoped<ISepetManager, SepetManager>();
builder.Services.AddScoped<IFilmlerKategoriManager, FilmlerKategoriManager>();
builder.Services.AddScoped<IKargoManager, KargoManager>();

#region Cookie Ayarlari

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Uyeler/Login";
                    options.LogoutPath = "/Uyeler/Logout";
                    options.AccessDeniedPath = "/Uyeler/Yasak";
                    options.Cookie.Name = "FilmDukkani";
                    options.Cookie.HttpOnly = true;// Guvenlikle ilgili. Tarayicimizdaki diger scriptler okuyamasin
                    options.Cookie.SameSite = SameSiteMode.Strict;// Guvenlik ile iligi. Bizim tarayicimiz disinda okunamasin
                });

#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "AdminArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "UyeArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
