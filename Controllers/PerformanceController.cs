using ProjectNamespace.Models;
using System.Web.Mvc;

namespace ProjectNamespace.Controllers
{
    public class PerformanceController : Controller
    {
        // GET: Performance
        public ActionResult Index()
        {
            // Normally, you would retrieve data from a database or service
            var model = new PerformanceModel
            {
                Id = 1,
                Description = "Ensure platform scalability and reliability",
                LastUpdated = DateTime.Now
            };

            return View(model);
        }
    }
}