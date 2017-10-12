using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_1.Students_and_courses;

namespace Task_1.UnitTests.CourseTests
{
    [TestClass]
    public class Leave_Should
    {
        [TestMethod]
        [DataRow("Iliya", 15299)]
        [DataRow("Ivan", 999998)]
        [DataRow("Nikola", 10001)]
        public void RemoveStudentFromCourse_WhenStudentExistsInCourse(string name, int uniqueNumber)
        {
            //Arrange
            Course maths = new Course();
            School school = new School();
            maths.Join(new Student(name, uniqueNumber, school));
            int result = 0;

            //Act
            maths.Leave(new Student(name, uniqueNumber, new School()));
            int actualResult = maths.StudentsCount;

            //Assert
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        [DataRow("Iliya", 15299, "Ivan", 15291)]
        [DataRow("Ivan", 999998, "Dimo", 991998)]
        [DataRow("Nikola", 10001, "BaiHui", 10005)]
        public void ThrowsArgumentException_WhenStudentIsNotInTheCourse(string name1 , int uniqueNumber1, string name2, int uniqueNumber2)
        {
            //Arrange
            Course maths = new Course();
            School school = new School();
            maths.Join(new Student(name1, uniqueNumber1, school));

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => maths.Leave(new Student(name2, uniqueNumber2, school)));
        }

        [TestMethod]
        public void ThrowsArgumentNullException_WhenStudentIsNull()
        {
            //Arrange
            Course maths = new Course();
            Student student = null;

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => maths.Leave(student));
        }
    }
}
