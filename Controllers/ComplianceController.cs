using System.Web.Mvc;
using ComplianceProject.Models;

namespace ComplianceProject.Controllers
{
    public class ComplianceController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            // Code to fetch and display compliance data
            return View();
        }

        [HttpPost]
        public ActionResult Save(ComplianceModel model)
        {
            // Code to save compliance data
            return RedirectToAction("Index");
        }
    }
}