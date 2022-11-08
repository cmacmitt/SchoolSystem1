using SchoolSystem1;

Institute mitt = new Institute("MITT");
Department ictDepartment = new Department("ICT Program");
Diploma sdDiploma = new Diploma("Software Devloper");
Diploma nsaDiploma = new Diploma("Network Systems Administrator");

mitt.AddDepartment(ictDepartment);

// add 2 diplomas
ictDepartment.AddDiploma(sdDiploma);
ictDepartment.AddDiploma(nsaDiploma);

// add 2 courses to each diploma
Course introToOOP = new Course("Introdcution to OOP");
Course introToSQL = new Course("Introdution to Databases");
Course entityFramework = new Course("Introdution to Entity Framework");
Course paperHatMaking = new Course("Paper Hat Making");
sdDiploma.AddCourse(introToOOP, true);
sdDiploma.AddCourse(introToSQL, true);
sdDiploma.AddCourse(entityFramework, true);
sdDiploma.AddCourse(paperHatMaking, false);

// add 2 students to each diploma
Student paul = new Student("Paul");
Student susie = new Student("Susie");

// enroll students in their mandatory courses
mitt.EnrollStudentInMandetoryCourses(paul, sdDiploma);
mitt.EnrollStudentInMandetoryCourses(susie, sdDiploma);

Console.WriteLine("Paul's Enrollments");
paul.PrintEnrolledCourses();

Console.WriteLine("------------------------------");
Console.WriteLine("Susie's Enrollments");
susie.PrintEnrolledCourses();
