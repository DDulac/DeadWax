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

        public ActionResult Auction(long id)
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
            //Commented out, model was decorated with data annotations to handle error handling
            ////Validate Title
            //if (string.IsNullOrWhiteSpace(auction.Title))
            //{
            //    //Invalid entry
            //    //Add error to model state dictionary
            //    ModelState.AddModelError("Title", "Title is required!");
            //}
            //else if (auction.Title.Length < 5 || auction.Title.Length > 200)
            //{
            //    //Also an invalid entry
            //    //Add error to model state dictionary
            //    ModelState.AddModelError("Title", "Title must be between 5 and 200 characters long!");
            //}

            //If the model is valid save
            if (ModelState.IsValid)
            {
                //Save data to database using the auctions data context
                //Add using DeadWax.Models; to the class
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