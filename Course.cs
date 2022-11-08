using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem1
{
    internal class Course
    {
        public string Name { get; set; }
        public HashSet<Enrollment> Enrollments { get; set; }

        public Course(string name)
        {
            Name = name;
            Enrollments = new HashSet<Enrollment>();
        }
    }
}
