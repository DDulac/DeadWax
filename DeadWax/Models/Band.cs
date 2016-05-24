using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeadWax.Models
{
    public class Band
    {
        #region Properties
        public long BandId { get; set; }

        public string Origin { get; set; }
        public string StageNames { get; set; }
        public string Genres { get; set; }
        public string Members { get; set; }
        public string YearsActive { get; set; }
        public string Publishers { get; set; }
        public string ImageURL { get; set; }
        public string WebSiteURL { get; set; }
        public string Description { get; set; }
        #endregion

        //Constructor
        public Band()
        {

        }
    }
}