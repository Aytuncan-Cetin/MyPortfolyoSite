using Microsoft.AspNetCore.Mvc;
namespace MyPortfolyoSite.ViewComponents
{
    public class _HeadComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
