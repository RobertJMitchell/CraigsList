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
            new Item() { ID = 100, Description = "4/2 Ranch Home", Price=1200.00, CreatedBy = "Sue Smith", CreatedOnDate = DateTime.Now.AddDays(-2), City = "Pearland", State = "Texas", ImageSize = "/images/im01.jpg"},
            new Item() { ID = 101, Description = "3/2/2 Two Story Family Home", Price=1300.00, CreatedBy = "Sue Smith", CreatedOnDate = DateTime.Now.AddDays(-4), City = "Sugar Land", State = "Texas", ImageSize = "/images/im02.jpg"},
            new Item() { ID = 102, Description = "MUST SEE 5/4/2 MCMANSION", Price=2500.00, CreatedBy = "Tyrone Biggums", CreatedOnDate = DateTime.Now.AddDays(-1), City = "Galveston", State = "Texas", ImageSize = "/images/im03.jpg" },
            new Item() { ID = 103, Description = "1/1 Shack, Low Overhead", Price=500.00, CreatedBy = "Manti Te'o", CreatedOnDate = DateTime.Now.AddDays(-2), City = "Houston", State = "Texas", ImageSize = "/images/im04.jpg" },
            new Item() { ID = 200, Description = "Furniture Antique Mahogany Chair", Price=400.00, CreatedBy = "Torque *Construction Noise* Lewith", CreatedOnDate = DateTime.Now.AddDays(-2), City = "Houston", State = "Texas", ImageSize = "/images/im01.jpg"},
            new Item() { ID = 201, Description = "Furniture 4 table chairs", Price=600.00, CreatedBy = "Fudge", CreatedOnDate = DateTime.Now.AddDays(-4), City = "Sugar Land", State = "Texas", ImageSize = "/images/im02.jpg"},
            new Item() { ID = 202, Description = "Electronics iPad 2 4G White", Price=300.00, CreatedBy = "Hingle McCringleberry", CreatedOnDate = DateTime.Now.AddDays(-1), City = "Galveston", State = "Texas", ImageSize = "/images/im03.jpg" },
            new Item() { ID = 203, Description = "SAMSUNG GALAXY 3 TAB SUPER CHEAP", Price=50.00, CreatedBy = "L'Carpetron Dookmarriot", CreatedOnDate = DateTime.Now.AddDays(-2), City = "Houston", State = "Texas", ImageSize = "/images/im04.jpg" },
            new Item() { ID = 300, Description = "Samsung 850 PRO 2TB SSD", Price=1200.00, CreatedBy = "Quatro Quatro", CreatedOnDate = DateTime.Now.AddDays(-2), City = "Pearland", State = "Texas", ImageSize = "/images/im01.jpg"},
            new Item() { ID = 301, Description = "Auto 2006 BMW 320ci", Price=6300.00, CreatedBy = "Dan Smith", CreatedOnDate = DateTime.Now.AddDays(-4), City = "Sugar Land", State = "Texas", ImageSize = "/images/im02.jpg"},
            new Item() { ID = 302, Description = "Mercedes-Benz C230 2001", Price=2500.00, CreatedBy = "Strunk Flugget", CreatedOnDate = DateTime.Now.AddDays(-1), City = "Galveston", State = "Texas", ImageSize = "/images/im03.jpg" },
            new Item() { ID = 303, Description = "Toyota Tacoma 1999", Price=500.00, CreatedBy = "Jammie Jammie-Jammie", CreatedOnDate = DateTime.Now.AddDays(-2), City = "Houston", State = "Texas", ImageSize = "/images/im04.jpg" },
            new Item() { ID = 300, Description = "Services Car Detailing", Price=60.00, CreatedBy = "Quiznatodd Bidness", CreatedOnDate = DateTime.Now.AddDays(-2), City = "Pearland", State = "Texas", ImageSize = "/images/im01.jpg"},
            new Item() { ID = 301, Description = "Services Tax Preparation", Price=75.00, CreatedBy = "Squeeeeeeeeps", CreatedOnDate = DateTime.Now.AddDays(-4), City = "Sugar Land", State = "Texas", ImageSize = "/images/im02.jpg"},
            new Item() { ID = 302, Description = "Services Taxi and Shuttle", Price=20.00, CreatedBy = "Faux Doadles", CreatedOnDate = DateTime.Now.AddDays(-1), City = "Galveston", State = "Texas", ImageSize = "/images/im03.jpg" },
            new Item() { ID = 303, Description = "Services House Cleaning", Price=100.00, CreatedBy = "Xmus Jaxon Flaxon-Waxon", CreatedOnDate = DateTime.Now.AddDays(-2), City = "Houston", State = "Texas", ImageSize = "/images/im04.jpg" },
            
        };
            return iList;
      }
        
    }
}