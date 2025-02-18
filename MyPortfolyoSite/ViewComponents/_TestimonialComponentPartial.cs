using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoSite.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
