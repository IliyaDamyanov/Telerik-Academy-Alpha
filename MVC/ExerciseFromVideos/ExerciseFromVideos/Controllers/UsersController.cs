using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExerciseFromVideos.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult About()
        {
            return Content("Page about the users.");
        }

        public string StringMethod(int? firstNumber= 0,int secondNumber = 0,string name="")
        {
            return $"{name} is {firstNumber+secondNumber} years old.";
        }

        public ActionResult DateTime(int? day, int? month, int? year)
        {
            return Content($"The date you entered is {day}.{month}.{year}");
        }
    }
}