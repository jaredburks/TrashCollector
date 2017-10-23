using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickUp.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public double Wallet { get; set; }
        public DateTime NoPickUpStartDate { get; set; }//Start date of when you don't want pickups
        public DateTime NoPickUpEndDate { get; set; }//End date of when you don't want pickups
        public DayOfWeek PickUpDay { get; set; }
    }
}