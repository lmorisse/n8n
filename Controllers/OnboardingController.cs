using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class OnboardingController : Controller
    {
        public IActionResult CreateOrganization()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrganization(Organization model)
        {
            if (ModelState.IsValid)
            {
                // Save organization
                return RedirectToAction("CreateProject");
            }
            return View(model);
        }

        public IActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProject(Project model)
        {
            if (ModelState.IsValid)
            {
                // Save project
                return RedirectToAction("InviteTeammates");
            }
            return View(model);
        }

        public IActionResult InviteTeammates()
        {
            return View();
        }

        public IActionResult Tutorial()
        {
            return View();
        }
    }
}