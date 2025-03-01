using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoSite.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
