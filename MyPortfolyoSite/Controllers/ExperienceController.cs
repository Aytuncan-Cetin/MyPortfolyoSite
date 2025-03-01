using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoSite.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}
