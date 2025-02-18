using Microsoft.AspNetCore.Mvc;
using MyPortfolyoSite.DAL.Context;

namespace MyPortfolyoSite.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        { 
            var values = portfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
