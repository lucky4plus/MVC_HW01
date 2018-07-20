using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Money.Models.ViewModels;
using Money.Models;
using Money.Service;
using Money.Repository;
namespace Money.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccountBookService _accountBookService;
        private readonly UnitOfWork _unitOfWork;

        public HomeController()
        {
            _unitOfWork = new UnitOfWork();
            _accountBookService = new AccountBookService(_unitOfWork);
        }

        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 儲存記帳
        /// </summary>
        /// <param name="moneyRecord"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(MoneyViewModel moneyRecord)
        {
            if (ModelState.IsValid)
            {
                moneyRecord.Id = Guid.NewGuid();
                _accountBookService.Add(moneyRecord);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }
            return View(moneyRecord);
        }

        [ChildActionOnly]
        public ActionResult ListMyMoney()
        {
            var result = _accountBookService.Lookup().OrderByDescending(x => x.Date).Take(50);
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