using Academy.Models.Common;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;
using System.Collections.Generic;

namespace Academy.Models
{
    public class Student : IStudent
    {
        private string username;
        private Track track;
        private IList<ICourseResult> courseResults;


        public Student (string username, Track track)
        {
            this.Username = username;
            this.Track = track;
            this.CourseResults = new List<ICourseResult>();
        }

        public IList<ICourseResult> CourseResults
        {
            get
            {
                return this.courseResults;
            }

            set
            {
                this.courseResults = value;
            }
        }

        public Track Track
        {
            get
            {
                return this.track;
            }

            set
            {
                this.track = value;
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Username)));
                Validator.ValidateIntRange(value.Length, Constants.MinUserNameLength, Constants.MaxUserNameLength, 
                    string.Format(Constants.UsernameExMes, Constants.MinUserNameLength, Constants.MaxUserNameLength));

                this.username = value;
            }
        }

        private string OverridingToStringList(IList<ICourseResult> courseResults)
        {
            string message = string.Empty;
            if (courseResults.Count==0)
            {
                message = Constants.StudentNoCourseResults;
            }
            else
            {
                for (int i = 0; i < courseResults.Count; i++)
                {
                    if (i == this.courseResults.Count - 1)
                    {
                        message += string.Format(courseResults[i].ToString());
                        break;
                    }
                    message += string.Format(courseResults[i].ToString() + "\n");
                }
            }
            return message;
        }

        public override string ToString()
        {
            return string.Format(@"* {0}:
 - {1}: {2}
 - {3}: {4}
 - Course results:
  {5}", nameof(Student), nameof(this.Username), this.Username, nameof(this.Track), this.Track,OverridingToStringList(this.CourseResults));
        }
    }
}
