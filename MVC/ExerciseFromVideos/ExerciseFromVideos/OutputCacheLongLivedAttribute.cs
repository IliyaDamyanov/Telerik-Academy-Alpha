using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExerciseFromVideos
{
    public class OutputCacheLongLivedAttribute : OutputCacheAttribute
    {
        public OutputCacheLongLivedAttribute()
        {
            CacheProfile = "LongLived"; 
        }
    }
}