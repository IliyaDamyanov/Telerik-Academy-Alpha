using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExerciseFromVideos.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult About()
        {
            return this.Content("Page about the users.");
        }

        //nai-dobre e Action metoda da vryshta ActionResult
        public string StringMethod(int? firstNumber= 0,int secondNumber = 0,string name="")
        {
            return $"{name} is {firstNumber+secondNumber} years old.";
        }

        public ActionResult DateTime(int? day, int? month, int? year)
        {
            var route = (Route)this.RouteData.Values["EnteredDate"];

            return this.Content($"The date you entered is {day}.{month}.{year}");
        }

        public ActionResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}