using DeadWax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeadWax.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        [OutputCache(Duration = 3)]
        public ActionResult Index()
        {
            ViewBag.Message = "This page was rendered at " + DateTime.Now;
            return View();
        }

        //Output cache example using a partial view for navigation by category which is called from the db
        [OutputCache(Duration = 3600)]
        public ActionResult CategoryNavigation()
        {
            var db = new AuctionsDataContext();
            var cateogries = db.Auctions.Select(x => x.Category).Distinct();
            ViewBag.Categories = cateogries.ToArray();

            return PartialView();
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