using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotNET_demo.Models
{
    public class News
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}