using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            // Display registration form
            return View();
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                // Save user and send confirmation email
                return RedirectToAction("ConfirmEmail");
            }
            return View(model);
        }

        public IActionResult ConfirmEmail()
        {
            // Handle email confirmation logic
            return View();
        }
    }
}