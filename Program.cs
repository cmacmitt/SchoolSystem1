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
Course introToSQL = new Course("Introcution to Databases");
sdDiploma.AddCourse(introToOOP, true);
sdDiploma.AddCourse(introToSQL, true);

// add 2 students to each diploma
Student paul = new Student("Paul");
Student susie = new Student("Susie");

sdDiploma.AddStudent(paul);
sdDiploma.AddStudent(susie);

// enroll students in their mandatory courses