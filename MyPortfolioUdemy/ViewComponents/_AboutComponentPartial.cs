using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{    
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var about = portfolioContext.Abouts.FirstOrDefault();

            if (about != null)
            {
                ViewBag.AboutTitle = about.Title;
                ViewBag.AboutSubDescription = about.SubDescription;
                ViewBag.Details = about.Details;
            }

            return View();
        }

    }
}
