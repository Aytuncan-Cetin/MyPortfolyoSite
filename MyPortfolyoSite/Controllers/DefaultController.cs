using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoSite.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
