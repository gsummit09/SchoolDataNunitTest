using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class SchoolManagement
    {
        private List<Student> students=new List<Student>();
        private List<Teacher>teachers=new List<Teacher>();
        private List<Subject> subjects=new List<Subject>();

        public List<Student> Students
        { 
            get { return students; } 
            private set { students = value; }
        }
        
        public List<Subject> Subjects
        {
            get { return subjects; }
            private set { subjects = value; }
        }
        public List<Teacher> Teachers
        {
            get { return teachers; }
            private set { teachers = value; }
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }
    }
}
