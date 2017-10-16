using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashPickUp.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public DateTime Date { get; set; }
    }
}