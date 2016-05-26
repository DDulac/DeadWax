using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DeadWax.Models
{
    //Create this class to extend Entity Framework code first data access layer
    public class AuctionsDataContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }

        //Todo: Entity Framework code first migrations as the below database initialize if for development only
        static AuctionsDataContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AuctionsDataContext>());
        }

    }
}