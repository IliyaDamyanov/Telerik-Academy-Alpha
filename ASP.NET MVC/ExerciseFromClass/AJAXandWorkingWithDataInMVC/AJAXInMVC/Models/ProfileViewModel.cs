using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AJAXInMVC.Models
{
    public class ProfileViewModel
    {
        //[UIHint("CustomString")]
        [Required(ErrorMessage ="Firstname is rquired!")]
        public string Firstname { get; set; }

        [Range(18, 100, ErrorMessage ="Min age is 18 , max age is 100!")]
        public int Age { get; set; }

        public DateTime BirthDate { get; set; }
    }
}