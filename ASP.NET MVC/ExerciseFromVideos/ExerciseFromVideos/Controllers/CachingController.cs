using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.UI;

namespace ExerciseFromVideos.Controllers
{
    public class CachingController : Controller
    {
        // GET: Caching
        //[OutputCache(Duration = 5)]
        //[OutputCache(Duration = 30 , VaryByParam = "id")] tozi varira sprqmo vhodniq parametyr
        //[OutputCache(Duration = 5, VaryByCustom = "Browser", VaryByParam = "id")] varira i sprqmo browsera - za razlichen browser , razlichen cache
        [OutputCache(Duration = 5, VaryByParam ="none",Location = OutputCacheLocation.Client, NoStore = false)]
        public ActionResult Index(int? id)
        {
            return View();
        }

        //[OutputCacheLongLived]
        //[OutputCache(CacheProfile = "LongLived")]
        [OutputCache(Duration =30)]
        public ActionResult ProfileCache()
        {
            this.ViewBag.Time = DateTime.Now;
            return this.View();
        }

        [OutputCache(Duration =10,VaryByParam ="none")]
        [ChildActionOnly]
        public ActionResult CachedDate()
        {
            return this.PartialView("ChildAction");
        }

        public ActionResult DataCaching()
        {
            //this.HttpContext.Cache["time"] = DateTime
            if(this.HttpContext.Cache["time"]==null)
            {
                //this.Cache["time"] = DateTime.Now;
                this.HttpContext.Cache.Insert(
                    "time",                            //key
                    DateTime.Now,                      //value
                    null,                              //dependencies
                    DateTime.Now.AddSeconds(10),       //absolute exp.
                    TimeSpan.Zero,                     //sliding exp
                    CacheItemPriority.Default,         //priority
                    new CacheItemRemovedCallback(this.OnCacheItemRemovedCallBack));  //callback delegate
            }

            this.ViewBag.CurrentTimeSpan = ((DateTime)this.HttpContext.Cache["time"]).ToString();

            return this.View();
        }

        private void OnCacheItemRemovedCallBack(string key, object value, CacheItemRemovedReason reason)
        {
            //cache item removed
            System.IO.File.WriteAllText(Server.MapPath("/mytext.txt"),key);
        }
    }
}