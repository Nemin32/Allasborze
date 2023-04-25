﻿using Allasborze.Data;
using Allasborze.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Allasborze.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext db)
        {
            _logger = logger;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Allasok);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Add()
        {
            if (!signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Error");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Add(AllasModel model)
        {
            if (ModelState.IsValid)
            {
                db.Allasok.Add(model);
                db.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}