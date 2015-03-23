using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCraigsList.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }

    }
}