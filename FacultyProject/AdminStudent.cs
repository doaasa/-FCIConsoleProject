using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject
{
    public class AdminStudent
    {
        public static List<Student> students = Data.student;
        public static void EnterStudentData()
        {
            Console.WriteLine("Pleade Enter the Data of the Student..");
            Console.WriteLine("Enter The Student ID : ");
            int stId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Student Name : ");
            string stName = Console.ReadLine();
            Console.WriteLine("Enter The Student Age : ");
            int stAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Student Departement ID : ");
            int stDepId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Student GPA : ");
            double stGPA = double.Parse(Console.ReadLine());
            Student st = new Student() { id = stId, name = stName, age = stAge, departementID = stDepId, GPA = stGPA };
            students.Add(st);
        }
        public static void SortingStudentBasedOnAge()
        {
            List<Student> student = students;
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
            List<Student> student = students;
            student.Sort();
            foreach (Student st in student)
            {
                Console.WriteLine(st.ToString());
            }
        }

        public static void SortingStudentBasedOnGPA()
        {
            List<Student> student = students;
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

            List<Student> student = students;

            foreach (var st in student)
            {
                if (st.departementID == dep)
                {
                    Console.WriteLine(st.ToString());
                }
            }
        }

        public static void DeleteStudent(int id)
        {
                foreach (var st in students)
                {
                    if (st.id == id)
                    {
                        students.Remove(st);
                    }
                }
            
        }


        public static void EditStudentName(int id, string name)
        {


            foreach (var st in students)
            {
                if (st.id==id)
                {
                    st.name = name;
                }
            }
        }

        public static void EditStudentAge(int id, int age)
        {


            foreach (var st in students)
            {
                if (st.id == id)
                {
                    st.age=age;
                }
            }
        }

        public static void EditStudentDepID(int id, int depid)
        {


            foreach (var st in students)
            {
                if (st.id == id)
                {
                    st.departementID=depid;
                }
            }
        }
        public static void EditStudentGPA(int id, double GPA)
        {
            foreach (var st in students)
            {
                if (st.id == id)
                {
                    st.GPA=GPA;
                }
            }
        }
        public static void DisplayFirstRank()
        {
            List<Departement> deps = Data.departements;
            List<Student> student = students;
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

                if (newStudent.Count != 0)
                {
                    Console.WriteLine(newStudent[0].ToString());
                }
            }
        }

    }
}