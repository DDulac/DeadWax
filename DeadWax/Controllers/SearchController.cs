using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DeadWax.Controllers
{
    public class SearchController : AsyncController
    {
        //Asyncronus operations, for operations greater than 1 second 
        // to help with scaling for more concurrent users
        // releases its thread back to the pool until the process is done
        // Examples long running operations over 1 second, network or I/O intensive operations, when users can cancel a long running operation

        public async Task<ActionResult> Auctions(string keyword)
        {
            var auctions = await Task.Run<IEnumerable<Models.Auction>>(
                () =>
                {
                    var db = new Models.AuctionsDataContext();
                    return db.Auctions.Where(x => x.Title.Contains(keyword)).ToArray();
                });

            return Json(auctions, JsonRequestBehavior.AllowGet);
        }
    }
}