using DeadWax.Models;
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
            //Load an array of auctions from database to display on a list page
            var db = new AuctionsDataContext();
            var auctions = db.Auctions.ToArray();

            //Pass the array out to the view, access with ViewData or ViewBag
            return View(auctions);
        }

        public ActionResult Auction(long id)
        {
            var db = new AuctionsDataContext();
            var auction = db.Auctions.Find(id);

            return View(auction);
        }
   
        //The Create auction view action, decorate with HttpGet to differentiate between get and post
        [HttpGet]
        public ActionResult Create()
        {
            //Todo: Get a list of categories from the database
            var categoryList = new SelectList(new[] { "Automotive", "Electronics", "Games", "Home" });

            ViewBag.Categorylist = categoryList;

            return View();
        }

        //The save created auction action, decorate with HttpPost to differentiate between post and get
        //Exclude items from the user posting to the model in the form by decorcating the type with bind 
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "CurrentPrice")]Models.Auction auction)
        {
            //If the model is valid save
            if (ModelState.IsValid)
            {
                //Save data to database using the auctions data context.Add using DeadWax.Models; to the class
                var db = new AuctionsDataContext();
                db.Auctions.Add(auction);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            //If model is not valid fall through and return the create action
            return Create();            
        }
    }
}