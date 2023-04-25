using Allasborze.Data;
using Allasborze.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace Allasborze.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AllasUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<AllasUser> signInManager;
        private readonly ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger, UserManager<AllasUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AllasUser> signInManager, ApplicationDbContext db)
        {
            _logger = logger;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.db = db;
        }

        public async Task<IActionResult> DelegateAdmin()
        {
            var principal = this.User;
            var user = await userManager.GetUserAsync(principal);
            var role = new IdentityRole()
            {
                Name = "Admin"
            };
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(role);
            }
            await userManager.AddToRoleAsync(user, "Admin");
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {
            return View(db.Allasok);
        }

        public IActionResult Index()
        {
            return View(db.Allasok);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Jobs()
        {
            return View(db.Allasok);
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

        [HttpGet]
        public async Task<IActionResult> Jelentkez(string id)
        {
            var allas = db.Allasok.FirstOrDefault(t => t.Id == id);

            if (allas == null) return RedirectToAction(nameof(Error));

            var user = await userManager.GetUserAsync(this.User);
            allas.Dolgozok.Add(user);
            user.Allasok.Add(allas);
            db.SaveChanges();


            return RedirectToAction(nameof(Index));
        }
    }
}