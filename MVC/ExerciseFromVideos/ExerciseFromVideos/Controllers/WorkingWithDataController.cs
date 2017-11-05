using ExerciseFromVideos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExerciseFromVideos.Controllers
{
    public class WorkingWithDataController : Controller
    {
        // GET: WorkingWithData
        public ActionResult Index()
        {
            this.Session["test"] = "This is a value from the session cache.";
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ProfileTestParameterBinding()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult ProfileTestParameterBinding(string FirstName, int Age)
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult ProfileTestObjectBinding()
        {
            ProfileTestViewModel viewModel = new ProfileTestViewModel()
            {
                FirstName = "Gosho",
                Age = 22
            };
            // taka gosho i 22 shte bydat direktno popylneni i vizualizirani vyv  polencata na stranicata
            return this.View(viewModel);
        }

        [HttpPost]
        public ActionResult ProfileTestObjectBinding(ProfileTestViewModel viewModel)
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult ProfileTestDisplayAndEditorTemplates()
        {
            ProfileTestViewModel viewModel = new ProfileTestViewModel()
            {
                FirstName = "Pesho",
                Age = 24
            };
            // taka Pesho i 24 shte bydat direktno popylneni i vizualizirani vyv  polencata na stranicata
            return this.View(viewModel);
        }

        [HttpPost]
        public ActionResult ProfileTestDisplayAndEditorTemplates(ProfileTestViewModel viewModel)
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult ProfileTestValidationExercise()
        {
            ProfileTestViewModel viewModel = new ProfileTestViewModel()
            {
                FirstName = "Gosho",
                Age = 30
            };
            // taka Pesho i 24 shte bydat direktno popylneni i vizualizirani vyv  polencata na stranicata
            return this.View(viewModel);
        }

        [HttpPost]
        public ActionResult ProfileTestValidationExercise(ProfileTestViewModel viewModel)
        {
            if(this.ModelState.IsValid)
            {
                return this.RedirectToAction("Index");
            }

            return this.View();
        }
    }
}