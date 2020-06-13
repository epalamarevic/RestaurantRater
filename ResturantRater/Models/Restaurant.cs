using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ResturantRater.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
    }

    public class RestaurantDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; } //a table with all of our restaurants on it.
        //i want a new collection of restaurant objects called Restaurants

        //entity- data level model - get stored in our database
        //model - 
    }
}