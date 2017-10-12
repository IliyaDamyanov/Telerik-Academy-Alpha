using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_1.Students_and_courses;
using Task_1.Students_and_courses.Contracts;

namespace Task_1.UnitTests.CourseTests
{
    [TestClass]
    public class Join_Should
    {
        [TestMethod]
        [DataRow("Iliya", 15299)]
        [DataRow("Ivan", 999998)]
        [DataRow("Nikola", 10001)]
        public void AddStudentInCourse_WhenThereAreLessThan30PeopleInCourse(string name, int uniqueNumber)
        {
            //Arrange
            Course maths = new Course();
            int result = 1;

            //Act
            maths.Join(new Student(name, uniqueNumber, new School()));
            int actualResult = maths.StudentsCount;

            //Assert
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void ThrowArgumentNullException_WhenStudentIsNull()
        {
            //Arrange
            Course maths = new Course();
            IStudent student = null;

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => maths.Join(student));
        }

        [TestMethod]
        public void ThrowsArgumentException_WhenThereAreMoreThan30PeopleInCourse()
        {
            //Arrange
            Course maths = new Course();
            School school = new School();
            for (int i = 0; i < 30; i++)
            {
                maths.Join(new Student("Iliya", 10000 + i, school));
            }

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => maths.Join(new Student("Iliya", 15299, school)));
        }

        [TestMethod]
        [DataRow("Iliya", 15299)]
        public void ThrowsArgumentException_WhenStudentsIsAlreadyInCourse(string name, int uniqueNumber)
        {
            //Assert            
            Course course = new Course();
            School school = new School();
            course.Join(new Student(name, uniqueNumber, school));

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => course.Join(new Student(name, uniqueNumber, school)));
        }

        // tva e za StudentTest
        //[TestMethod]
        //[DataRow(15299)]
        //[DataRow(999998)]
        //[DataRow(10001)]
        //public void ThrowArgumentException_WhenStudentNameIsEmpty(int uniqueNumber)
        //{
        //    //Arrange
        //    Course maths = new Course();
        //    Student student = new Student(string.Empty, uniqueNumber);
        //
        //    //Act & Assert
        //    Assert.ThrowsException<ArgumentException>(() => maths.Join(student));
        //}
        // tva sy6to
        //[TestMethod]
        //[DataRow("Iliya",-5)]
        //[DataRow("Iliya",0)]
        //[DataRow("Iliya",1)]
        //[DataRow("Iliya",100)]
        //[DataRow("Iliya",9999)]
        //[DataRow("Iliya",100000)]
        //public void ThrowArgumentOutOfRangeException_WhenStudentUniqueNumberIsOutOfRange(string name, int uniqueNumber)
        //{
        //    //Arrange
        //    Course maths = new Course();
        //    Student student = new Student(name, uniqueNumber);
        //
        //    //Act & Assert
        //    Assert.ThrowsException<ArgumentOutOfRangeException>(() => maths.Join(student));
        //}
    }
}
