using SchoolLib;
using Moq;
using System.Net.Http.Headers;

namespace TestProject1
{
    [TestFixture]
    public class SchoolDatanUnit
    {
        [Test]
        public void AddStudent()
        {
            var schoolManagement = new SchoolManagement();
            var student = new Student { StudentId = 1, StudentName = "Sumit Nayak", Class = "Class 10" };

            schoolManagement.AddStudent(student);
            Assert.Contains(student, schoolManagement.Students);
        }
        [Test]
        public void AddSubject()
        {
            var schoolManagement = new SchoolManagement();
            var subject = new Subject { SubjectId = 1, SubjectName = "Chemistry" };

            schoolManagement.AddSubject(subject);
            Assert.Contains(subject, schoolManagement.Subjects);
        }
        [Test]
        public void AddTeacher()
        {
            var schoolManagement = new SchoolManagement();
            var teacher = new Teacher { TeacherId = 1, TeacherName = "Mr. Sumit" };
            schoolManagement.AddTeacher(teacher);

            Assert.Contains(teacher, schoolManagement.Teachers);
        }
        [Test]
        public void StudentMockTest()
        {
            var schoolManagement = new SchoolManagement();
            var studentMock = new Mock<Student>();
            studentMock.SetupGet(s =>s.StudentId).Returns(1);
            studentMock.SetupGet(s => s.StudentName).Returns("Sumit Nayak");
            studentMock.SetupGet(s => s.Class).Returns("Class 10");

            schoolManagement.AddStudent(studentMock.Object);
            Assert.Contains(studentMock.Object,schoolManagement.Students);
        }
        [Test]
        public void TeacherMockTest()
        {
            var schoolManagement = new SchoolManagement();
            var teacherMock = new Mock<Teacher>();
            teacherMock.SetupGet(s => s.TeacherId).Returns(1);
            teacherMock.SetupGet(s => s.TeacherName).Returns("Mr.Ashok");


            // Act
            schoolManagement.AddTeacher(teacherMock.Object);

            // Assert
            Assert.Contains(teacherMock.Object, schoolManagement.Teachers);
        }
        [Test]
        public void SubjectMockTest()
        {
            var schoolManagement = new SchoolManagement();
            var subjectMock = new Mock<Subject>();
            subjectMock.SetupGet(s => s.SubjectId).Returns(1);
            subjectMock.SetupGet(s => s.SubjectName).Returns("Math");


            // Act
            schoolManagement.AddSubject(subjectMock.Object);

            // Assert
            Assert.Contains(subjectMock.Object, schoolManagement.Subjects);
        }
    }
}
