using System;
using System.Web.Mvc;
using PartialViewPractice.Service;

namespace PartialViewPractice.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Index()
        {
            var randomMoneyListData = new DataService().GetRandomMoneyListData();

            return View(randomMoneyListData);
        }

        public ActionResult MoneyList()
        {
            return View();
        }
    }
}