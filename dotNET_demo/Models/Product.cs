using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dotNET_demo.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Serial { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public int Weight {get;set;}
        public string Manufacturer { get; set; }
        
        [DataType(DataType.Currency)]    
        public int Price { get; set; }
        public int Unit { get; set; }

        [Display(Name = "In Stock")]
        public bool InStock { get; set; }

        [Display(Name = "Available Date")]
        [DataType(DataType.Date)]
        public DateTime Available_Date { get; set; }
    }
}