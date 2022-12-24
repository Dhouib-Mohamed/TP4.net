using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TP4.Models;

namespace TP4.Data
{
    public class StudentRepository
    {
        UniversityContext universityContext;
        public StudentRepository() {
             universityContext = UniversityContext.getInstance();
        }
        public List<Student> getStudent (int id)
        {
            var student = universityContext.Student.Where((Student student) => student.id == id);
            return student.ToList();
        }
        public List<Student> getStudentsByCourse(string course)
        {
            var student = universityContext.Student.Where((Student student) => student.course == course);
            return student.ToList();
        }
        public List<String> getCourses()
        {
            var courses = new List<String>();
            var student = universityContext.Student.ToList();
            foreach (Student s in student )
            {
                if (!courses.Contains(s.course)) courses.Add(s.course);
            }
            return courses;
        }
    }
}
