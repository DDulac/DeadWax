using DeadWax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DeadWax.Controllers
{
    public class AuctionsController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            var db = new AuctionsDataContext();
            var auctions = db.Auctions.ToArray();

            return View(auctions);
        }

        public ActionResult Auction(long id)
        {
            var db = new AuctionsDataContext();
            var auction = db.Auctions.Find(id);

            return View(auction);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Bid(Bid bid)
        {
            var db = new AuctionsDataContext();
            var auction = db.Auctions.Find(bid.AuctionId);

            if (auction == null)
            {
                ModelState.AddModelError("AuctionId", "Auction not found!");
            }
            else if (auction.CurrentPrice >= bid.Amount)
            {
                ModelState.AddModelError("Ammount", "Bid amount must exceed current bid");
            }
            else
            {
                bid.Username = User.Identity.Name;
                auction.Bids.Add(bid);
                auction.CurrentPrice = bid.Amount;
                db.SaveChanges();
            }

            if (!Request.IsAjaxRequest())
            {
                return RedirectToAction("Auction", new { id = bid.AuctionId });
            }

            //Returning a partial view when an AJAX response
            //return PartialView("_CurrentPrice", auction);

            //Returning JSON to the view when an AJAX response
            return Json(new {
                CurrentPrice = bid.Amount.ToString("C"),
                BidCount = auction.BidCount
            });
        }
   
        [HttpGet]
        public ActionResult Create()
        {
            //Todo: Get a list of categories from the database
            var categoryList = new SelectList(new[] { "Automotive", "Electronics", "Games", "Home" });

            ViewBag.Categorylist = categoryList;

            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Exclude = "CurrentPrice")]Models.Auction auction)
        {
            if (ModelState.IsValid)
            {
                var db = new AuctionsDataContext();
                db.Auctions.Add(auction);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return Create();            
        }
    }
}