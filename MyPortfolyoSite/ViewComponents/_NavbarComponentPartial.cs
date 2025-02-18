using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoSite.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
