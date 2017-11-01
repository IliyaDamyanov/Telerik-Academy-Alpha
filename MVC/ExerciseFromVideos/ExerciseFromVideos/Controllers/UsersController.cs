using ExerciseFromVideos.Models;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExerciseFromVideos.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        [HttpGet] // get moje i da go nqma
        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";

            return this.View("NewAbout");
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult About()
        {
            return this.Content("Page about the users.");
        }

        //nai-dobre e Action metoda da vryshta ActionResult
        public string StringMethod(int? firstNumber,int secondNumber = 0,string name="")
        {
            return $"{name} is {firstNumber+secondNumber} years old.";
        }

        public ActionResult DateTime(int? day, int? month, int? year)
        {
            var route = (Route)this.RouteData.Values["EnteredDate"];

            return this.Content($"The date you entered is {day}.{month}.{year}");
        }

        [NonAction] // taka nqma da uchastva v routinga
        public ActionResult EmptyResult()
        {
            //mojev empty result da vyrnem
            return new EmptyResult();
        }

        public ActionResult General(string username)
        {
            var userModel = new UsersModel
            {
                Username = "IliyaSD",
                Fullname = "Iliya Damyanov",
                Age = 25
            };
            return View(userModel);
        }

        [ChildActionOnly]
        public ActionResult MyPartial()
        {
            return PartialView("_MyPartial");
        }
    }
}