using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject
{
   public class AdminWorkers
    {
        public static List<Worker> workers = Data.workers;
        public static void EnterWorkerData()
        {
            Console.WriteLine("Pleade Enter the Data of the Worker..");
            Console.WriteLine("Enter The Worker ID : ");
            int woId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Worker Name : ");
            string woName = Console.ReadLine();
            Console.WriteLine("Enter The Worker Age : ");
            int woAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Student Salary : ");
            double woSalary = double.Parse(Console.ReadLine());
            Worker wo = new Worker() { id = woId, name = woName, age =woAge,salary = woSalary };
            workers.Add(wo);
        }
        public static void DeleteWorker(int id)
        {


            foreach (var st in workers)
            {
                if (st.id == id)
                {
                    workers.Remove(st);
                }
            }
        }

        public static void EditWorkerAge(int id, int age)
        {


            foreach (var wo in workers)
            {
                if (wo.id == id)
                {
                    wo.age = age;
                }
            }
        }
        public static void EditWorkerName(int id, string name)
        {


            foreach (var wo in workers)
            {
                if (wo.id == id)
                {
                    wo.name = name;
                }
            }
        }
        public static void EditWorkerSalary(int id, double salary)
        {


            foreach (var wo in workers)
            {
                if (wo.id == id)
                {
                    wo.salary = salary;
                }
            }
        }
        public static void DisplayThreeWorkers()
        {
            List<Worker> worker = workers;
            for (int i = 0; i < worker.Count; i++)
            {
                for (int j = i + 1; j < worker.Count; j++)
                {

                    if (worker[i].salary.CompareTo(worker[j].salary) == -1)
                    {
                        var t = worker[i];
                        worker[i] = worker[j];
                        worker[j] = t;
                    }

                }
            }
            for(int i=0; i<3; i++)
            {
                Console.WriteLine(worker[i].ToString());
            }
        }
    }
}
