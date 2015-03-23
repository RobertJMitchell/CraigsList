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
            new Item() { ID = 100, CreatedBy = "admin", CreatedOnDate = DateTime.Now.AddDays(-2), City = "Pearland", State = "Texas" };
            new Item()
        }
    }
}