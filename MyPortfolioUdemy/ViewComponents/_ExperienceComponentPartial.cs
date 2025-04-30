using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _ExperienceComponentPartial :ViewComponent
    {
        MyPortfolioContext MyPortfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = MyPortfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
