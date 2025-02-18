using Microsoft.AspNetCore.Mvc;
using MyPortfolyoSite.DAL.Context;
namespace MyPortfolyoSite.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList(); //Feature Tablosunda yer alan verileri liste şeklinde getir
            return View(values);//values den gelen verileri döndür
        }
    }
}
