﻿using Film.DAL.Contexts;
using Film.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FİlmMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TedarikciController : Controller
    {
        private readonly SqlDbContext context;

        public TedarikciController(SqlDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = context.Tedarikciler.ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Tedarikci tedarikci = new();
            return View(tedarikci);
        }

        [HttpPost]
        public IActionResult Create(Tedarikci tedarikci)
        {
            if (ModelState.IsValid)
            {

                context.Tedarikciler.Add(tedarikci);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(tedarikci);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Tedarikci tedarikci = context.Tedarikciler.Find(id);
            return View(tedarikci);
        }

        [HttpPost]
        public IActionResult Update(Tedarikci tedarikci)
        {
            context.Update(tedarikci);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var tedarikci = context.Tedarikciler.Find(id);
            return View(tedarikci);
        }

        [HttpPost]
        public IActionResult Delete(Tedarikci tedarikci)
        {


            context.Remove(tedarikci);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
