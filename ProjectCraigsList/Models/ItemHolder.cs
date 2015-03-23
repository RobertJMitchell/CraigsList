using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCraigsList.Models
{
    public static class ItemHolder
    {
        public static List<Item> GetItem()
        {
            List<Item> iList = new List<Item>()
            {
            new Item() { ID = 100, Description="4/2 Ranch Home", Price=1200.00, CreatedBy = "Sue Smith", CreatedOnDate = DateTime.Now.AddDays(-2), City = "Pearland", State = "Texas" },
            new Item() { ID = 101, Description = "3/2/2 Two Story Family Home", Price=1300.00, CreatedBy = "Sue Smith", CreatedOnDate = DateTime.Now.AddDays(-4), City = "Sugar Land", State = "Texas" },
            new Item() { ID = 102, Description = "MUST SEE 5/4/2 MCMANSION", Price=2500.00, CreatedBy = "Tyrone Biggums", CreatedOnDate = DateTime.Now.AddDays(-1), City = "Galveston", State = "Texas" },
            new Item() { ID = 103, Description = "1/1 Shack, Low Overhead", Price=500.00, CreatedBy = "The Hood", CreatedOnDate = DateTime.Now.AddDays(-2), City = "Houston", State = "Texas" },
            new Item() {ID = }
        };
            return iList;
      }
        
    }
}