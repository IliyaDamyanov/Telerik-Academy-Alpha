namespace Academy.Models.Common
{
    public class Constants
    {
        // String lengths
        public const int MinCourseNameLength = 3;
        public const int MaxCourseNameLength = 45;
        public const int MinUserNameLength = 3;
        public const int MaxUserNameLength = 16;
        public const int MinLectureNameLength = 5;
        public const int MaxLectureNameLength = 30;
        public const int MinResourceNameLength = 3;
        public const int MaxResourceNameLength = 15;
        public const int MinResourceUrlLength = 5;
        public const int MaxResourceUrlLength = 150;

        // Numbers validation
        public const int MinLecturesPerWeek = 1;
        public const int MaxLecturesPerWeek = 7;
        public const float MinCourseResultExamPoints = 0f;
        public const float MaxCourseResultExamPoints = 1000f;
        public const float MinCourseResultCoursePoints = 0f;
        public const float MaxCourseResultCoursePoints = 125f;

        public const string CannotBeNull = "{0} cannot be null!";
        public const string CannotParse = "{0} was not parsed!";
        public const string ObjectNotCreated = "The instance of the {0} class was not created.";

        public const string CourseNameLenghtExMes = "The name of the course must be between {0} and {1} symbols!";
        public const string LectureNameLenghtExMes = "Lecture's name should be between {0} and {1} symbols long!";
        public const string DemoResourceUrlLenghtExMes = "Resource url should be between {0} and {1} symbols long!";
        public const string UsernameExMes = "User's username should be between {0} and {1} symbols long!";
        public const string DemoResourceNameExMes = "Resource name should be between {0} and {1} symbols long!";
        public const string CourseLecturesPerWeekExMes = "The number of lectures per week must be between {0} and {1}!";        
        public const string CourseResultsExamPointsExMes = "Course result's exam points should be between {0} and {1}!";
        public const string CourseResultsCoursePointsExMes = "Course result's course points should be between {0} and {1}!";
        public const string TrackExMes = "The provided track is not valid!";
        public const string StudentNoCourseResults = "* User has no course results!";
        public const string CourseNoLectures = "* There are no lectures in this course!";
        public const string LectureNoResources = "* There are no resources in this lecture.";
    }
}
