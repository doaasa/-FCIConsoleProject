using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject
{
   public class CWFunctions
    {
        public static void ExitMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("            Computer And Information System Project");
            Console.WriteLine("            Press any Number to continue");
            Console.WriteLine("            Press -1 to Exit");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                     Choose the number you want to do ...");
            Console.WriteLine("                     1.ADD");
            Console.WriteLine("                     2.Edit");
            Console.WriteLine("                     3.Delete");
            Console.WriteLine("                     4.Sort");
            Console.WriteLine("                     5.Display");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void SortMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                     Choose the number you want to do ...");
            Console.WriteLine("                     1. Sorting Student based on age");
            Console.WriteLine("                     2. Sorting Student based on Name");
            Console.WriteLine("                     3. Sorting Student based on GPA");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                     Choose the number you want to do ...");
            Console.WriteLine("                     1. Display Student in Specific Departement");
            Console.WriteLine("                     2. Display all the first Rank Student in Each Departement");
            Console.WriteLine("                     3. Display Male Gender Instructors");
            Console.WriteLine("                     4. Display the Largest three Workers' Salary");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void AddMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                     Choose the number you want to do ...");
            Console.WriteLine("                     1.Student");
            Console.WriteLine("                     2.Instructor");
            Console.WriteLine("                     3.Worker");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void EditMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                     Choose the number you want to do ...");
            Console.WriteLine("                     1.Student");
            Console.WriteLine("                     2.Instructor");
            Console.WriteLine("                     3.Worker");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void DeleteMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("                     Choose the number you want to do ...");
            Console.WriteLine("                     1.Student");
            Console.WriteLine("                     2.Instructor");
            Console.WriteLine("                     3.Worker");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
