using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Money.Models.ViewModels;
namespace Money.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult ListMyMoney()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            DateTime today = DateTime.Now;
            var result = new MoneyViewModel
            {
                Category = rnd.Next(1, 3),
                Money = rnd.Next(1, 10000),
                Date = today.AddDays(rnd.Next(0, 50))
            };
            return View(result);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}