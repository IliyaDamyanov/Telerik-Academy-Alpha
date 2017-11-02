using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ExerciseFromVideos.Controllers
{
    public class AjaxDemoController : Controller
    {
        // GET: AjaxDemo
        public ActionResult Index()
        {
            return this.View();
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

        public ActionResult Search(string query) //trqbva da se kazva kato polenceto vyv formichkata
        {
            List<string> texts = new List<string>()
            {
                "some text",
                "some other text",
                "Alpha Rocks"
            };
            var result = texts.Where(t => t.ToLower().Contains(query.ToLower())).ToList();

            return this.PartialView("_SearchResults", result);
        }

        public JsonResult AllBooks()
        {
            var books = new List<string>() { "book1", "book2", "book3" };
            return this.Json(books, JsonRequestBehavior.AllowGet);
        }

    }
}