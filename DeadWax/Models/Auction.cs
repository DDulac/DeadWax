using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeadWax.Models
{
    public class Auction
    {
        #region Properties
        [Required]
        public long AuctionId { get; set; }
        
        //Add data annotations to help html helpers and validators understand the model objects properties
        [Required]
        [DataType(DataType.Text)]
        public string Category { get; set; }

        //You could put a message in the string length annotation but it is already in the controller
        [Required]
        [DataType(DataType.Text)]
        [StringLength(maximumLength:200, MinimumLength = 5 )]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Image Url")]
        public string ImageURL { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Starting Price")]
        public decimal StartPrice { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Current Bid Price")]
        public decimal? CurrentPrice { get; set; }
        #endregion

        //Constructor
        public Auction()
        {

        }

    }
}