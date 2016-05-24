using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeadWax.Controllers
{
    public class AuctionsController : Controller
    {
        //Add more actions

        // GET: Auctions
        public ActionResult Index()
        {
            return View();
        }
    }
}