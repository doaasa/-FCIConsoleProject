using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject
{
    public class AdminInstructor
    {
        public static List<Instructor> instructors = Data.instructors;
        public static void EnterInstructorData()
        {
            Console.WriteLine("Pleade Enter the Data of the Instructor..");
            Console.WriteLine("Enter The Instructor ID : ");
            int instId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Instructor Name : ");
            string instName = Console.ReadLine();
            Console.WriteLine("Enter The Instructor Age : ");
            int instAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Instructor Departement ID : ");
            int instDepId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Instructor Salary : ");
            double instSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Instructor Gender : ");
            string gend = Console.ReadLine();
            Instructor inst = new Instructor() { id = instId, name = instName, age = instAge, departementID = instDepId, gender=gend,salary = instSalary };
            instructors.Add(inst);
        }

        public static void EditInstructorName(int id, string name)
        {


            foreach (var inst in instructors)
            {
                if (inst.id == id)
                {
                    inst.name = name;
                }
            }
        }
        public static void EditInstructorDepID(int id, int depID)
        {


            foreach (var inst in instructors)
            {
                if (inst.id == id)
                {
                    inst.departementID = depID;
                }
            }
        }

        public static void EditInstructorGender(int id, string gender)
        {


            foreach (var inst in instructors)
            {
                if (inst.id == id)
                {
                    inst.gender =gender;
                }
            }
        }
        public static void EditInstructorSalary(int id, double salary)
        {


            foreach (var inst in instructors)
            {
                if (inst.id == id)
                {
                    inst.salary= salary;
                }
            }
        }
        public static void EditInstructorAge(int id, int age)
        {


            foreach (var inst in instructors)
            {
                if (inst.id == id)
                {
                    inst.age = age;
                }
            }
        }
        public static void DisplayMaleInstructor()
        {
            List<Instructor> ins = instructors;
            for (int i = 0; i < ins.Count; i++)
            {
                if (ins[i].gender == "male")
                {
                    Console.WriteLine(ins[i].ToString());
                }
            }
        }

        public static void DeleteInstructor(int id)
        {


            foreach (var st in instructors)
            {
                if (st.id == id)
                {
                    instructors.Remove(st);
                }
            }
        }

    }
}
