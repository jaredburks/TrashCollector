using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickUp.Models
{
    public class Worker
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }//Zip Code of route of customers 
        public string UserID { get; set; }//testing link to logged in user
        public virtual ApplicationUser loggedUser { get; set; }//testing link to logged in user
    }
}