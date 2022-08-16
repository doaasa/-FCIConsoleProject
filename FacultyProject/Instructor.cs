using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject
{
   public class Instructor:Person
    {
        public int departementID { get; set; }
        public string gender { get; set; }
        public double salary { get; set; }
        public override string ToString()
        {
            return $"Name= " + name + " Age= " + age + " Gender= " + gender + " DepartementID= " + departementID+" Salary= "+salary;
        }
    }
}

