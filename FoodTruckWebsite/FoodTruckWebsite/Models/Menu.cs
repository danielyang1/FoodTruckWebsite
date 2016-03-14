using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodTruckWebsite.Models
{
    public class Menu
    {
        public int id { get; set; }
        [Display(Name = "Food Truck Name")]
        public string foodTruckName { get; set; }
        [Display(Name = "Food 1")]
        public string foodItem1 { get; set; }
        [Display(Name = "Food 2")]
        public string foodItem2 { get; set; }
        [Display(Name = "Food 3")]
        public string foodItem3 { get; set; }
        [Display(Name = "Food 4")]
        public string foodItem4 { get; set; }
        [Display(Name = "Food 5")]
        public string foodItem5 { get; set; }
        [Display(Name = "Price: Food 1")]
        public double itemPrice1 { get; set; }
        [Display(Name = "Price: Food 2")]
        public double itemPrice2 { get; set; }
        [Display(Name = "Price: Food 3")]
        public double itemPrice3 { get; set; }
        [Display(Name = "Price: Food 4")]
        public double itemPrice4 { get; set; }
        [Display(Name = "Price: Food 5")]
        public double itemPrice5 { get; set; }
        public string UserID { get; set; }
        //public virtual ApplicationUser applicationuser { get; set; }
    }
}