using Microsoft.AspNetCore.Mvc;
using MyPortfolyoSite.DAL.Context;

namespace MyPortfolyoSite.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
