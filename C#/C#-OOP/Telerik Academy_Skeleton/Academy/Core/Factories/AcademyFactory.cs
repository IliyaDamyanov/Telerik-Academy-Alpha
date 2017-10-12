using Academy.Core.Contracts;
using Academy.Core.Providers;
using Academy.Models;
using Academy.Models.Common;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy.Core.Factories
{
    public class AcademyFactory : IAcademyFactory
    {
        private static IAcademyFactory instanceHolder = new AcademyFactory();

        // private because of Singleton design pattern
        private AcademyFactory()
        {
        }

        public static IAcademyFactory Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        public ISeason CreateSeason(string startingYear, string endingYear, string initiative)
        {
            var parsedStartingYear = int.Parse(startingYear);
            var parsedEngingYear = int.Parse(endingYear);

            Initiative parsedInitiativeAsEnum;
            Enum.TryParse<Initiative>(initiative, out parsedInitiativeAsEnum);

            return new Season(parsedStartingYear, parsedEngingYear, parsedInitiativeAsEnum);
        }

        public IStudent CreateStudent(string username, string track)
        {
            Track parsedTrack;
            if (!Enum.TryParse(track,out parsedTrack))
            {
                throw new ArgumentException(Constants.TrackExMes);
            }
            return new Student(username, parsedTrack);
            throw new NotImplementedException("Student class not attached to factory.");
        }

        public ITrainer CreateTrainer(string username, string technologies)
        {
            List<string> technologiesList = technologies.Split(',').ToList(); // da vidq za emptyentries
            return new Trainer(username, technologiesList);         
            throw new NotImplementedException("Trainer class not attached to factory.");
        }

        public ICourse CreateCourse(string name, string lecturesPerWeek, string startingDate)
        {
            int lecturesPerWeekInt;
            DateTime startingDateInDateTime;
            if (!int.TryParse(lecturesPerWeek,out lecturesPerWeekInt))
            {
                throw new ArgumentException(string.Format(Constants.CannotParse, nameof(lecturesPerWeek)));
            }
            if (!DateTime.TryParse(startingDate, out startingDateInDateTime))
            {
                throw new ArgumentException(string.Format(Constants.CannotParse, nameof(startingDate)));
            }
            return new Course(name, lecturesPerWeekInt, startingDateInDateTime);
            throw new NotImplementedException("Course class not attached to factory.");
        }

        public ILecture CreateLecture(string name, string date, ITrainer trainer)
        {
            DateTime dateParsed;
            if (!DateTime.TryParse(date, out dateParsed))
            {
                throw new ArgumentException(string.Format(Constants.CannotParse, nameof(date)));
            }
            return new Lecture(name, dateParsed, trainer);
            throw new NotImplementedException("Lecture class not attached to factory.");
        }

        public ILectureResource CreateLectureResource(string type, string name, string url)
        {
            // Use this instead of DateTime.Now if you want any points in BGCoder!!
            var currentDate = DateTimeProvider.Now;

            switch (type)
            {
                case "video": return new VideoResource(name, url, currentDate);
                case "presentation": return new PresentationResource(name, url);
                case "demo": return new DemoResource(name, url);
                case "homework": return new HomeworkResource(name, url,currentDate);
                default: throw new ArgumentException("Invalid lecture resource type");
            }

            throw new NotImplementedException("LectureResource classes not attached to factory.");
        }

        public ICourseResult CreateCourseResult(ICourse course, string examPoints, string coursePoints)
        {
            float examPointsParsed;
            float coursePointsParsed;
            if (!float.TryParse(examPoints,out examPointsParsed))
            {
                throw new ArgumentException(string.Format(Constants.CannotParse, nameof(examPoints)));
            }
            if (!float.TryParse(coursePoints, out coursePointsParsed))
            {
                throw new ArgumentException(string.Format(Constants.CannotParse, nameof(coursePointsParsed)));
            }
            return new CourseResult(course, examPointsParsed, coursePointsParsed);
            throw new NotImplementedException("CourseResult class not attached to factory.");
        }
    }
}
