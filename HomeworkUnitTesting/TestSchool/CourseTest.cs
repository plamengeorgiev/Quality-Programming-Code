using System;
using Schools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSchool
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void TestNewCourseConstructorName()
        {
            string name = "History";
            Course course = new Course(name);
            Assert.AreEqual(course.Name, name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNewCourseConstructorNullName()
        {
            string name = null;
            Course course = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNewCourseConstructorEmptyName()
        {
            string name = string.Empty;
            Course course = new Course(name);
        }

        [TestMethod]
        public void TestJoinStudentName()
        {
            string name = "History";
            Student student = new Student("Pesho Peshev", 12345);
            Course course = new Course(name);
            course.Join(student);
            Assert.AreEqual(student.Name, course.StudentsList[0].Name);
        }

        [TestMethod]
        public void TestJoinStudentId()
        {
            string name = "History";
            Student student = new Student("Pesho Peshev", 12345);
            Course course = new Course(name);
            course.Join(student);
            Assert.AreEqual(student.StudentId, course.StudentsList[0].StudentId);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestJoinTheSameStudentId()
        {
            string name = "History";
            Student student = new Student("Pesho Peshev", 12345);
            Course course = new Course(name);
            course.Join(student);
            course.Join(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestJoinMoreThan30Students()
        {
            string name = "History";
            string studentName = "Pesho Peshev";
            int studentId = 12345;
            Course course = new Course(name);
            for (int i = 0; i <= Course.MaxNumberOfStudentsInCourse + 2; i++)
            {
                studentId++;
                course.Join(new Student(studentName, studentId));
            }
        }

        [TestMethod]
        public void TestLeaveStudent()
        {
            string name = "History";
            Student student = new Student("Pesho Peshev", 12345);
            Course course = new Course(name);
            course.Join(student);
            course.Leave(student);
            Assert.IsTrue(course.StudentsList.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestLeaveNotJoinedStudent()
        {
            string name = "History";
            Student student = new Student("Pesho Peshev", 12345);
            Course course = new Course(name);
            course.Leave(student);
        }

        [TestMethod]
        public void TestStudentToString()
        {
            string name = "History";
            Student student = new Student("Pesho Peshev", 12345);
            Course course = new Course(name);
            course.Join(student);
            string expected = string.Format("Course: History{0}Subscribed students{0}12345 Pesho Peshev{0}", Environment.NewLine);
            string actual = course.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
