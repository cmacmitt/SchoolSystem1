using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem1
{
    internal class Student
    {
        public string Name { get; set; }
        public HashSet<Enrollment> Enrollments { get; set; }

        public Student(string name)
        {
            Name = name;
            Enrollments = new HashSet<Enrollment>();
        }

        public void PrintEnrolledCourses()
        {
            foreach (var enrollment in Enrollments)
            {
                Console.WriteLine(enrollment.Course.Name);
            }
        }
    }
}
