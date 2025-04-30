using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
    public class StatisticController : Controller
    {
       MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.SocialMedias.Count();
            ViewBag.v3 = context.Testimonials.Count();
            ViewBag.v4 = context.Messages.Count();
            ViewBag.v5 = context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.v6 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v7 = context.Messages.Count();            
            ViewBag.v8 = context.Experiences.Count();

            return View();
        }
    }
}
