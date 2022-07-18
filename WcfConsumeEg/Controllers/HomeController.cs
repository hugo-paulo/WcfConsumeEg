using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WcfConsumeEg.Models;

namespace WcfConsumeEg.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Message()
        {
            int number = 47;
            
            ServiceReference1.Service1Client _client = new ServiceReference1.Service1Client("basicHttpBinding_IService");
            var message = _client.GetData(number);

            var display = new OutMessage { Message = message };

            return View(display);
        }

    }
}