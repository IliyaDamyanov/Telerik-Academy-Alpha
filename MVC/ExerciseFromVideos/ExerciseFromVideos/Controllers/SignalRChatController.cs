using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExerciseFromVideos.Controllers
{
    public class SignalRChatController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}