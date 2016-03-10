using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodTruckWebsite.Models
{
    public class Menu
    {
        public int id { get; set; }
        public string foodTruckName { get; set; }
        public string foodItem1 { get; set; }
        public string foodItem2 { get; set; }
        public string foodItem3 { get; set; }
        public string foodItem4 { get; set; }
        public string foodItem5 { get; set; }
        public double itemPrice1 { get; set; }
        public double itemPrice2 { get; set; }
        public double itemPrice3 { get; set; }
        public double itemPrice4 { get; set; }
        public double itemPrice5 { get; set; }
    }
}