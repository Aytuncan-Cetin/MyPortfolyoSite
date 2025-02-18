using Microsoft.AspNetCore.Mvc;
using MyPortfolyoSite.DAL.Context;

namespace MyPortfolyoSite.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.AboutTitle).FirstOrDefault();//Tek bir veri getirmek istiyorsak Abouts ın titlesini
            ViewBag.aboutSubDescription=portfolioContext.Abouts.Select(x => x.AboutSubDescription).FirstOrDefault();
            ViewBag.aboutDetails=portfolioContext.Abouts.Select(x => x.AboutDetails).FirstOrDefault();
            return View();
        }
    }
}
