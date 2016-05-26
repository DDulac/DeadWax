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
            //Load an array of auctions to display on a list page
            //Todo: Load from database
            var auctions = new[]
            {
                //Instantiate auction objects into the array
                new Models.Auction()
                {
                    Title = "Example Auction",
                    Description = "This is an example Auction",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(7),
                    StartPrice = 1.00m,
                    CurrentPrice = null,
                },
                new Models.Auction()
                {
                    Title = "Example Auction #2",
                    Description = "This is a second Auction",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(7),
                    StartPrice = 1.00m,
                    CurrentPrice = 30m,
                },
                new Models.Auction()
                {
                    Title = "Example Auction #3",
                    Description = "This a third Auction",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(7),
                    StartPrice = 1.00m,
                    CurrentPrice = 24m,
                },
            };

            //Pass the array out to the view, access with ViewData or ViewBag
            return View(auctions);
        }

        //Use TempData to respond to a request from the view
        public ActionResult TempDataDemo()
        {
            TempData["SuccessMessage"] = "The action succeeded!";

            return RedirectToAction("Index");
        }

        public ActionResult Auction()
        {
            //Passing data Example 2 "ViewData", 3 "ViewBag", and 4 "Model". Instantiating and populating an Auction object
            var auction = new DeadWax.Models.Auction()
            {
                Title = "Example Auction",
                Description = "This is an example Auction",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 1.00m,
                CurrentPrice = null,
            };

            //Passing data Example 2 "ViewData" and 3 "ViewBag" (getting the auction from the ViewBag as a dynamic object)
            //Return the auction object to the view by storing the auction object in the "ViewData" Dictionary. The "ViewBag" Dyanmic Object has access to the object in ViewData
            //ViewData["Auction"] = auction;

            //Passing data Example 4 "Model"
            //Using the view helper method, the instantiated object can be passed as a paramter back to the view
            return View(auction);
            //The view will have to reference the Auction model object as a page directive as a fully qualified name
        }

        public ActionResult Create()
        {
            //Todo: Get a list of categories from the database
            var categoryList = new SelectList(new[] { "Automotive", "Electronics", "Games", "Home" });

            ViewBag.Categorylist = categoryList;

            return View();
        }
    }
}