using Microsoft.AspNetCore.Mvc;
using MyPortfolyoSite.DAL.Context;

namespace MyPortfolyoSite.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
