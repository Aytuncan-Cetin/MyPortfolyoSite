using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoSite.ViewComponents.LayoutViewComponent
{
    public class _LayoutSideBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
