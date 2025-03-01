using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoSite.ViewComponents.LayoutViewComponent
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
