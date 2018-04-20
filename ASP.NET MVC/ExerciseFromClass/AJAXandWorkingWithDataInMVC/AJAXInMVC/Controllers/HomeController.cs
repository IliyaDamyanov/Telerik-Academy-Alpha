using AJAXInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace AJAXInMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            this.Session["test"] = "this is a value from the session cache";

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

        public ActionResult AjaxTest()
        {
            return this.View();
        }

        public ActionResult ServerTime()
        {
            Thread.Sleep(1000);
            return this.Content(DateTime.Now.ToLongDateString());
        }

        public ActionResult Search(string query)
        {
            List<string> text = new List<string>()
            {
                "some text",
                "some other text",
                "ALPHA rocks"
            };

            var result = text.Where(t => t.ToLower().Contains(query.ToLower())).ToList();
            return this.PartialView("_SearchResults", result);
        }

        [HttpGet]
        public ActionResult EditProfile()
        {
            ProfileViewModel viewModel = new ProfileViewModel()
            {
                Firstname = "Gosho",
                Age = 30
            };

            return this.View(viewModel);
        }

        //[HttpPost]
        //public ActionResult ProfileTest(string Firstname, int Age)
        //{
        //    return this.View();
        //} moje i taka no po-dobre kato otdolu da si poluchavame cql model

        [HttpPost]
        public ActionResult EditProfile(ProfileViewModel viewModel)
        {
            if (this.ModelState.IsValid)
            {
                return this.RedirectToAction("Index");
            }
            // ako vsichko e ok redirect-vame klienta kym Index stranichka.
            //Ako ne e ok mu vryshtame syshtoto VIEW, no to si nosi v nego syshto taka i error message-te za da gi pokajem na klienta.

            return this.View(viewModel);
        }

        public ActionResult DisplayProfile()
        {
            ProfileViewModel viewModel = new ProfileViewModel()
            {
                Firstname = "Pesho",
                Age = 40
            };

            return this.View(viewModel);
        }
    }
}