using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem1
{
    

    internal class Institute
    {
        public string Name { get; set; }
        public HashSet<Department> Departments { get; set; }
    
        public Institute(string name)
        {
            Name = name;
            Departments = new HashSet<Department>();
        }

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

        public void EnrollStudent(Student student, Course course)
        {
            Enrollment newEnrollment = new Enrollment(student, course);
            student.Enrollments.Add(newEnrollment);
            course.Enrollments.Add(newEnrollment);
        }

        public void EnrollStudentInMandetoryCourses(Student student, Diploma diploma)
        {
            // get all the mandatory course from the dictionary in Diploma
            // iterate over the course list
            // call the enrollment method for each course
        }
    }
}
