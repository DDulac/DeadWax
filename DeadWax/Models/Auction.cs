using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeadWax.Models
{
    public class Auction
    {
        #region Properties
        public long AuctionId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public decimal StartPrice { get; set; }
        public decimal? CurrentPrice { get; set; }
        #endregion

        //Constructor
        public Auction()
        {

        }

    }
}