using Academy.Models.Common;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;

namespace Academy.Models
{
    public class CourseResult : ICourseResult
    {
        private ICourse course;
        private float examPoints;
        private float coursePoints;
        private Grade grade;

        public CourseResult(ICourse course, float examPoints, float coursePoints)
        {
            this.Course = course;
            this.ExamPoints = examPoints;
            this.CoursePoints = coursePoints;
        }

        public ICourse Course
        {
            get
            {
                return this.course;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.Course)));

                // may be not valid

                this.course = value; 
            }
        }

        public float CoursePoints
        {
            get
            {
                return this.coursePoints;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.CoursePoints)));
                Validator.ValidateFloatRange(value, Constants.MinCourseResultCoursePoints, Constants.MaxCourseResultCoursePoints, 
                    string.Format(Constants.CourseResultsCoursePointsExMes, Constants.MinCourseResultCoursePoints, Constants.MaxCourseResultCoursePoints));

                this.coursePoints = value;
            }
        }

        public float ExamPoints
        {
            get
            {
                return this.examPoints;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.CannotBeNull, nameof(this.ExamPoints)));
                Validator.ValidateFloatRange(value, Constants.MinCourseResultExamPoints, Constants.MaxCourseResultExamPoints, 
                    string.Format(Constants.CourseResultsExamPointsExMes, Constants.MinCourseResultExamPoints, Constants.MaxCourseResultExamPoints));

                this.examPoints = value;
            }
        }

        public Grade Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (this.ExamPoints >= 65 || this.CoursePoints >= 75)
                {
                    this.grade = Grade.Excellent;
                }
                else if ((this.ExamPoints < 60 && this.ExamPoints >= 30) || (this.CoursePoints < 75 && this.CoursePoints >= 45))
                {
                    this.grade = Grade.Passed;
                }
                else if (this.ExamPoints<30 || this.CoursePoints<45)
                {
                    this.grade = Grade.Failed;
                }
            }           
        }

        public override string ToString()
        {
            return string.Format(@"* {0}: Points - {1}, {2} - {3}", this.Course.Name, this.CoursePoints, nameof(Grade), this.Grade);
        }
    }
}
