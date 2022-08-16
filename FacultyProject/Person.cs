using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace FacultyProject
{
   public class Person : IComparable<Person>
    {
        public int id { get; set; }
        public int age { get; set; }
        public string name { get; set; }

        public int CompareTo(Person other)
        {
            return name.CompareTo(other.name);
        }

    }
}
