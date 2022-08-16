using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject
{
    static class Choices
    {
        public static void SortingStudentBasedOnAge()
        {
            List<Student> student = Data.student;
            for (int i = 0; i < student.Count; i++)
            {
                for (int j = i + 1; j < student.Count; j++)
                {

                    if (student[i].age.CompareTo(student[j].age) == 1)
                    {
                        var t = student[i];
                        student[i] = student[j];
                        student[j] = t;
                    }

                }
            }
            foreach (Student st in student)
            {
                Console.WriteLine(st.ToString());
            }
        }

        public static void SortingStudentBasedOnName()
        {
            List<Student> student = Data.student;
            student.Sort();
            foreach (Student st in student)
            {
                Console.WriteLine(st.ToString());
            }
        }

        public static void SortingStudentBasedOnGPA()
        {
            List<Student> student = Data.student;
            for (int i = 0; i < student.Count; i++)
            {
                for (int j = i + 1; j < student.Count; j++)
                {

                    if (student[i].GPA.CompareTo(student[j].GPA) == 1)
                    {
                        var t = student[i];
                        student[i] = student[j];
                        student[j] = t;
                    }

                }
            }
            foreach (Student st in student)
            {
                Console.WriteLine(st.ToString());
            }
        }

        public static void DisplayStudentBasedOnDepartement(int dep)
        {
          
            List<Student> student = Data.student;
            
            foreach (var st in student)
            {
                if (st.departementID == dep)
                {
                    Console.WriteLine(st.ToString());
                }
            }
        }

        public static void DisplayFirstRank()
        {
            List<Departement> deps = Data.departements;
            List<Student> student = Data.student;
            foreach (var dep in deps)
            {
                List<Student> newStudent = new List<Student>();
                foreach (var st in student)
                {
                    if (dep.id == st.departementID)
                    {
                        newStudent.Add(st);
                    }
                }

                for (int i = 0; i < newStudent.Count; i++)
                {
                    for (int j = i + 1; j < newStudent.Count; j++)
                    {

                        if (newStudent[i].GPA.CompareTo(newStudent[j].GPA) == -1)
                        {
                            var t = student[i];
                            student[i] = student[j];
                            student[j] = t;
                        }

                    }
                }
                for(int i=0; i < 1; i++)
                {
                    Console.WriteLine(newStudent[i].ToString());
                }
            }
        }

        public static void DisplayMaleInstructor()
        {
            List<Instructor> ins = Data.instructors;
            for(int i=0; i < ins.Count; i++)
            {
                if (ins[i].gender == "male")
                {
                    Console.WriteLine(ins[i].ToString());
                }
            }
        }
        
        public static void DisplayHighestWorkersSalary()
        {
            List<Worker> workers = Data.workers;
            for (int i = 0; i < workers.Count; i++)
            {
                for (int j = i + 1; j < workers.Count; j++)
                {

                    if (workers[i].salary.CompareTo(workers[j].salary) == 1)
                    {
                        var t = workers[i];
                        workers[i] = workers[j];
                        workers[j] = t;
                    }

                }
            }
            foreach (var w in workers)
            {
                Console.WriteLine(w.ToString());
            }

        }
    }
}
