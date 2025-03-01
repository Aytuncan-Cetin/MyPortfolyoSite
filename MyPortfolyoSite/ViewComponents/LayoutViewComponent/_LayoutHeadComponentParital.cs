using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoSite.ViewComponents.LayoutViewComponent
{
    public class _LayoutHeadComponentParital : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }   
    }
}
