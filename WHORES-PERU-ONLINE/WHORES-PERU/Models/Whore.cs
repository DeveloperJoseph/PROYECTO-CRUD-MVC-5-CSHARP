using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WHORES_PERU.Models
{
    public class Whore
    {
        [Key]
        public int WhoreID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }
        public double Price { get; set; }
        public String Address { get; set; }
    }
}