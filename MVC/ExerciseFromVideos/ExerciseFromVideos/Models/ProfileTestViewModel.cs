using System;
using System.ComponentModel.DataAnnotations;

namespace ExerciseFromVideos.Models
{
    public class ProfileTestViewModel
    {
        //[UIHint("CustomString")] sega kato e zaomentirano shte potyrsi dali nqma string.cshtml vyv DisplayTemplates i vyv EditorTemplates
        [Required(ErrorMessage = "First name is required!")]
        public string FirstName { get; set; }

        [Range(18,100,ErrorMessage ="Min age is 18, max age is 100.")]
        public int Age { get; set; }

        public DateTime BirthDate { get; set; }
    }
}