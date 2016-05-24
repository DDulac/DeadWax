using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeadWax.Models
{
    public class Artist
    {
        #region Properties
        public long ArtistId { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string StageNames { get; set; }
        public DateTime? Birth { get; set; }
        public string BirthCity { get; set; }
        public DateTime? Death { get; set; }
        public string DeathCity { get; set; }
        public string FatherFirstName { get; set; }
        public string FatherMiddleName { get; set; }
        public string FatherLastName { get; set; }
        public string MotherFirstName { get; set; }
        public string MotherMiddleName { get; set; }
        public string MotherLastName { get; set; }
        public string Genres { get; set; }
        public string Occupations { get; set; }
        public string Instruments { get; set; }
        public string YearsActive { get; set; }
        public string AssociatedActs { get; set; }
        public string Publishers { get; set; }
        public string ImageURL { get; set; }
        public string WebSiteURL { get; set; }
        public string Description { get; set; }
        #endregion

        //Constructor
        public Artist()
        {

        }

    }
}