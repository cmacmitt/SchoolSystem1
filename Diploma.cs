using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem1
{
    internal class Diploma
    {
        public string Name { get; set; }
        public Dictionary<Course, bool> Courses { get; set; }
        public List<Student> Students { get; set; }

        public Diploma(string name)
        {
            Name = name;
            Courses = new Dictionary<Course, bool>();
        }

        public void AddCourse(Course course, bool isManditory)
        {
            Courses.Add(course, isManditory);
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public List<Course> GetMandatoryCourseList()
        {
            List<Course> manditoryCourses = new List<Course>();

            foreach (var course in Courses)
            {
                if (course.Value)
                {
                    manditoryCourses.Add(course.Key);
                }
            }

            return manditoryCourses;
        }
    }
}
