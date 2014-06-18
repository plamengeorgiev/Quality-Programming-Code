using System;
using Schools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSchool
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void TestNewSchoolConstructorName()
        {
            string name = "Sample School";
            School school = new School(name);
            Assert.AreEqual(school.Name, name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNewSchoolConstructorNullName()
        {
            string name = null;
            School school = new School(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNewSchoolConstructorEmptyName()
        {
            string name = string.Empty;
            School school = new School(name);
        }

        [TestMethod]
        public void TestAddStudentName()
        {
            string name = "Sample School";
            Student student = new Student("Pesho Peshev", 12345);
            School school = new School(name);
            school.AddStudent(student);
            Assert.AreEqual(student.Name, school.StudentsList[0].Name);
        }

        [TestMethod]
        public void TestAddStudentId()
        {
            string name = "Sample School";
            Student student = new Student("Pesho Peshev", 12345);
            School school = new School(name);
            school.AddStudent(student);
            Assert.AreEqual(student.StudentId, school.StudentsList[0].StudentId);
        }

        [TestMethod]
        public void TestRemoveStudent()
        {
            string name = "Sample School";
            Student student = new Student("Pesho Peshev", 12345);
            School school = new School(name);
            school.AddStudent(student);
            school.RemoveStudent(student);
            Assert.IsTrue(school.StudentsList.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemoveNotAddedStudent()
        {
            string name = "Sample School";
            Student student = new Student("Pesho Peshev", 12345);
            School school = new School(name);
            school.RemoveStudent(student);
        }
    }
}
