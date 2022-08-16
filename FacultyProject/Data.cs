using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject
{
    static class Data
    {
        public static List<Worker> workers = new List<Worker>()
        {
            new Worker(){id=1, name="Worker1",age=25,salary=2000},
            new Worker(){id=2, name="Worker2",age=20,salary=3000},
            new Worker(){id=3, name="Worker3",age=28,salary=1000},
            new Worker(){id=4, name="Worker4",age=30,salary=2000},
            new Worker(){id=5, name="Worker5",age=40,salary=1500},
            new Worker(){id=6, name="Worker6",age=34,salary=2000},
        };
        public static List<Instructor> instructors = new List<Instructor>()
        {
            new Instructor(){id=1,name="Instructor1", age=35,gender="male", salary=3000,departementID=1 },
            new Instructor(){id=2,name="Instructor2", age=37,gender="male", salary=3600,departementID=2 },
            new Instructor(){id=3,name="Instructor3", age=45,gender="female", salary=6000,departementID=3 },
            new Instructor(){id=4,name="Instructor4", age=30,gender="female", salary=2000,departementID=4 },

            new Instructor(){id=5,name="Instructor5", age=55,gender="male", salary=8000,departementID=1 },
            new Instructor(){id=6,name="Instructor6", age=47,gender="male", salary=6600,departementID=2 },
            new Instructor(){id=7,name="Instructor7", age=31,gender="female", salary=1500,departementID=3 },
            new Instructor(){id=8,name="Instructor8", age=38,gender="female", salary=4500,departementID=4 },



        };


        public static List<Departement> departements = new List<Departement>()
        {

            new Departement(){id=1, name="IS"},
            new Departement(){id=2, name="CS"},
            new Departement(){id=3, name="IT"},
            new Departement(){id=4, name="Bio"}

        };
        public static List<Student> student = new List<Student>()
        {
            new Student() { id=1,name="Doaa",age=21,departementID=1, GPA=3.7 },
            new Student() { id=2,name="student",age=25,departementID=2, GPA=3.5 },
            new Student() { id=3,name="Student1",age=26,departementID=3, GPA=3.6 },
            new Student() { id=4,name="Student2",age=19,departementID=4, GPA=2.8 },
            new Student() { id=5,name="Student3",age=22,departementID=1, GPA=4 },
            new Student() { id=6,name="Student4",age=20,departementID=3, GPA=3.1 },
            new Student() { id=7,name="Student5",age=20,departementID=2, GPA=1.3 }
        };
    }
}
