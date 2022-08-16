using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject
{
   public class Worker : Person
    {
        public double salary { get; set; }
        public override string ToString()
        {
            return $"Name= " + name + " Age= " + age + " Salary " + salary;
        }
    }
}
