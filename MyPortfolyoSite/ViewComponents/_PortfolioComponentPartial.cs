using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoSite.ViewComponents
{
    public class _PortfolioComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
