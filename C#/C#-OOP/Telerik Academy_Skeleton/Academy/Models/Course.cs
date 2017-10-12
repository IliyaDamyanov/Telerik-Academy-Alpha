using Academy.Models.Common;
using Academy.Models.Contracts;
using System;
using System.Collections.Generic;

namespace Academy.Models
{
    public class Course : ICourse
    {
        private string name;
        private int lecturesPerWeek;
        private DateTime startingDate;
        private DateTime endingDate;
        private IList<ILecture> lectures;
        private IList<IStudent> onlineStudents;
        private IList<IStudent> onsiteStudents;

        public Course(string name, int lecturesPerWeek, DateTime startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = lecturesPerWeek;
            this.StartingDate = startingDate;
            this.EndingDate = this.StartingDate.AddDays(30);
            this.Lectures = new List<ILecture>();
            this.OnlineStudents = new List<IStudent>();
            this.OnsiteStudents = new List<IStudent>();
        }

        public DateTime EndingDate
        {
            get
            {
                return this.endingDate;
            }

            set
            {
                this.endingDate = value;
            }
        }

        public IList<ILecture> Lectures
        {
            get
            {
                return this.lectures;
            }
            private set
            {
                this.lectures = value;
            }
        }

        public int LecturesPerWeek
        {
            get
            {
               return this.lecturesPerWeek;
            }

            set
            {
                Validator.ValidateIntRange(value, Constants.MinLecturesPerWeek, Constants.MaxLecturesPerWeek,
                    string.Format(Constants.CourseLecturesPerWeekExMes, Constants.MinLecturesPerWeek, Constants.MaxLecturesPerWeek));

                this.lecturesPerWeek = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Name)));
                Validator.ValidateIntRange(value.Length, Constants.MinCourseNameLength, Constants.MaxCourseNameLength,
                    string.Format(Constants.CourseNameLenghtExMes, Constants.MinCourseNameLength, Constants.MaxCourseNameLength));

                this.name = value;
            }
        }

        public IList<IStudent> OnlineStudents
        {
            get
            {
                return this.onlineStudents;
            }
            private set
            {
                this.onlineStudents = value;
            }
        }

        public IList<IStudent> OnsiteStudents
        {
            get
            {
                return this.onsiteStudents;
            }
            private set
            {
                this.onsiteStudents = value;
            }
        }

        public DateTime StartingDate
        {
            get
            {
                return this.startingDate;
            }

            set
            {
                this.startingDate = value;
            }
        }

        private string OverridingToStringLecturesList(IList<ILecture> lectures)
        {
            string message = string.Empty;
            if (lectures.Count == 0)
            {
                message = "  " +Constants.CourseNoLectures;
            }
            else
            {
                for (int i = 0; i < lectures.Count; i++)
                {
                    if (i < lectures.Count - 1)
                    {
                        if (i == 0)
                        {
                            message += string.Format("  " + lectures[i].ToString() + "\n");
                        }
                        else
                        {
                            message += string.Format("  " + lectures[i].ToString() + "\n");
                        }
                    }
                    else if (i == lectures.Count - 1)
                    {
                        message += string.Format("  " + lectures[i].ToString());
                    }
                }
            }
            return message;
        }

        public override string ToString()
        {
            return string.Format(@"* {0}:
 - {1}: {2}
 - Lectures per week: {3}
 - Starting date: {4}
 - Ending date: {5}
 - Onsite students: {6}
 - Online students: {7}
 - {8}:
{9}", nameof(Course), nameof(this.Name), this.Name, this.LecturesPerWeek, this.StartingDate, this.EndingDate,this.OnsiteStudents.Count, 
  this.OnlineStudents.Count, nameof(this.Lectures), OverridingToStringLecturesList(this.Lectures));
        }
    }
}
