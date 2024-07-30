using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using ViewModels;

namespace PizzeriaApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new Utente { Nome = model.Nome, Email = model.Email, Password = model.Password };
                _context.Utenti.Add(user);
                await _context.SaveChangesAsync();

                var role = await _context.Ruoli.FirstOrDefaultAsync(r => r.Nome == "User");
                if (role == null)
                {
                    role = new Ruolo { Nome = "User" };
                    _context.Ruoli.Add(role);
                    await _context.SaveChangesAsync();
                }

                _context.UtentiRuoli.Add(new UtenteRuolo { UtenteId = user.Id, RuoloId = role.Id });
                await _context.SaveChangesAsync();

                // Logica per la sessione utente (semplificata)
                HttpContext.Session.SetString("UserId", user.Id.ToString());
                HttpContext.Session.SetString("UserName", user.Nome);

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Utenti
                    .Where(u => u.Email == model.Email && u.Password == model.Password)
                    .FirstOrDefaultAsync();

                if (user != null)
                {
                    // Logica per la sessione utente (semplificata)
                    HttpContext.Session.SetString("UserId", user.Id.ToString());
                    HttpContext.Session.SetString("UserName", user.Nome);

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserId");
            HttpContext.Session.Remove("UserName");

            return RedirectToAction("Index", "Home");
        }
    }
}
