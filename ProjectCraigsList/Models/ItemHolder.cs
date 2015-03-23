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
            {
            new Item() { ID = 100, Description="4/2 Ranch Home", CreatedBy = "Sue Smith", CreatedOnDate = DateTime.Now.AddDays(-2), City = "Pearland", State = "Texas" };
            new Item() { ID = 101, Description = "3/2/2 Two Story Family Home", CreatedBy = "Sue Smith", CreatedOnDate = DateTime.Now.AddDays(-4), City = "Sugar Land", State = "Texas" };
            new Item() { ID = 102, Description = "MUST SEE 5/4/2 MCMANSION", CreatedBy = "Tyrone Biggums", CreatedOnDate = DateTime.Now.AddDays(-1), City = "Galveston", State = "Texas" };
            new Item() { ID = 103, Description = "1/1 Shack, Low Overhead", CreatedBy = "The Hood", CreatedOnDate = DateTime.Now.AddDays(-2), City = "Houston", State = "Texas" };
        }
        }
        return
    }
}