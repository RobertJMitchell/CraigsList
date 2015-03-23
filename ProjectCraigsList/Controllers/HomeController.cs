using ProjectCraigsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectCraigsList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Bring in the view model
            ItemViewModel viewModel = new ItemViewModel();

            var itemData = ItemHolder.GetItem();

            var iData = itemData.Where(to => to.ID >= 100).ToList();

            viewModel.MyList = iData;



            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}