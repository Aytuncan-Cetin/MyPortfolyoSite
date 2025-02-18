using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoSite.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
        return View();
        }

    }
}
