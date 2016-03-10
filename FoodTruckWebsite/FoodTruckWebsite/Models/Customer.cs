using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoodTruckWebsite.Models
{
    public class Customer : DbContext
    {
        public Customer() : base("Default Connection")
        {

        }
        public DbSet FoodMenu { get; set; }
    }
}