using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject
{
  public  class Student:Person
    {
        public double GPA { get; set; }
        public int departementID { get; set; }
        public override string ToString()
        {
            return $"Name= " + name + " Age= " + age + " GPA= " + GPA + " DepartementID= " + departementID;
        }
    }
}
