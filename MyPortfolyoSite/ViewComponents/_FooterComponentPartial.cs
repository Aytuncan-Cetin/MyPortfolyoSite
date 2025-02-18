using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoSite.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent

    {
        public IViewComponentResult Invoke()
        { 
        return View();
        }
    }
}
