using System;
using System.Collections.Generic;

namespace FacultyProject
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.ReadKey();
                CWFunctions.ExitMenu();
                try
                {
                    int x = int.Parse(Console.ReadLine());
                    if (x == -1)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        CWFunctions.MainMenu();
                        int choiceNum = int.Parse(Console.ReadLine());
                        //try
                        //{
                            if (choiceNum == 1)
                            {
                                CWFunctions.AddMenu();
                                int choiceNumADD = int.Parse(Console.ReadLine());
                                //try
                                //{
                                    if (choiceNumADD == 1)
                                    {
                                        Console.Clear();
                                        AdminStudent.EnterStudentData();
                                    }
                                    else if (choiceNumADD == 2)
                                    {
                                        Console.Clear();
                                        AdminInstructor.EnterInstructorData();
                                    }
                                    else if (choiceNumADD == 3)
                                    {
                                        Console.Clear();
                                        AdminWorkers.EnterWorkerData();
                                    }
                                //}
                                //catch
                                //{
                                //    Console.WriteLine("Enter Valid Number");
                                //}
                            }
                            else if (choiceNum == 2) 
                            {
                                CWFunctions.EditMenu();
                                int edchoic = int.Parse(Console.ReadLine());
                                if (edchoic == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the Student ID..");
                                    int StID= int.Parse(Console.ReadLine());
                                    Console.WriteLine("Choose the Category of Student you want to change..");
                                    Console.WriteLine(" 1. Name");
                                    Console.WriteLine("2. Age");
                                    Console.WriteLine("3. Departement ID");
                                    Console.WriteLine("4.GPA");
                                    int stChoice= int.Parse(Console.ReadLine());
                                    if (stChoice == 1)
                                    {
                                        Console.WriteLine("Enter the new Name..");
                                        string name = Console.ReadLine();
                                        AdminStudent.EditStudentName(StID, name);
                                    }
                                    else if (stChoice == 2)
                                    {
                                        Console.WriteLine("Enter the new Age..");
                                        int age = int.Parse(Console.ReadLine());
                                        AdminStudent.EditStudentAge(StID, age);
                                    }
                                    else if (stChoice == 3)
                                    {
                                        Console.WriteLine("Enter the new Departement ID..");
                                        int depid = int.Parse(Console.ReadLine());
                                        AdminStudent.EditStudentDepID(StID,depid );
                                    }
                                    else if (stChoice == 4)
                                    {
                                        Console.WriteLine("Enter the new GPA..");
                                        double gpa = double.Parse(Console.ReadLine());
                                        AdminStudent.EditStudentGPA(StID, gpa);
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Please enter a valid number");
                                        Console.ReadKey();
                                        CWFunctions.EditMenu();
                                    }
                                }
                               else if (edchoic == 2) //Instructor edit
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the Instructor ID..");
                                    int instID = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Choose the Category of Instructor you want to change..");
                                    Console.WriteLine(" 1. Name");
                                    Console.WriteLine("2. Age");
                                    Console.WriteLine("3. Departement ID");
                                    Console.WriteLine("4. Salary");
                                    Console.WriteLine("5. Gender");
                                    int instchoice= int.Parse(Console.ReadLine());
                                    if (instchoice == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enter the new Name..");
                                        string name = Console.ReadLine();
                                        AdminInstructor.EditInstructorName(instID, name);
                                    }

                                    else if (instchoice == 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enter the new Age..");
                                        int age = int.Parse(Console.ReadLine());
                                        AdminInstructor.EditInstructorAge(instID, age);
                                    }
                                    else if (instchoice == 3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enter the new Departement ID..");
                                        int ID = int.Parse(Console.ReadLine());
                                        AdminInstructor.EditInstructorDepID(instID,ID);
                                    }
                                    else if (instchoice == 4)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enter the new Salary..");
                                       double salary = double.Parse(Console.ReadLine());
                                        AdminInstructor.EditInstructorSalary(instID, salary);
                                    }
                                  else  if (instchoice == 5)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enter the new Gender..");
                                        string gender = Console.ReadLine();
                                        AdminInstructor.EditInstructorGender(instID, gender);
                                    }
                                }
                                else if (edchoic == 3) // worker edit
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the Worker ID..");
                                    int woID = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Choose the Category of Worker you want to change..");
                                    Console.WriteLine("1. Name");
                                    Console.WriteLine("2. Age");
                                    Console.WriteLine("3. Salary");
                                    int wochoice = int.Parse(Console.ReadLine());
                                    if (wochoice == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enter the new Name..");
                                        string name = Console.ReadLine();
                                        AdminWorkers.EditWorkerName(woID, name);
                                    }

                                   else if (wochoice == 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enter the new Age..");
                                        int age = int.Parse(Console.ReadLine());
                                        AdminWorkers.EditWorkerAge(woID, age);
                                    }
                                    else if (wochoice == 3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enter the new Salary..");
                                        double salary = double.Parse(Console.ReadLine());
                                        AdminWorkers.EditWorkerSalary(woID, salary);
                                    }
                                }
                            }
                            
                            else if (choiceNum == 3)
                            {
                                CWFunctions.DeleteMenu();
                                int delchoic = int.Parse(Console.ReadLine());
                                if (delchoic == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the Student ID..");
                                    int StID = int.Parse(Console.ReadLine());
                                    AdminStudent.DeleteStudent(StID);
                                }
                                else if (delchoic == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the Instructor ID..");
                                    int instID = int.Parse(Console.ReadLine());
                                   AdminInstructor.DeleteInstructor(instID);
                                }
                                else if (delchoic == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the Worker ID..");
                                    int woID = int.Parse(Console.ReadLine());
                                    AdminWorkers.DeleteWorker(woID);
                                }
                            }
                            else if (choiceNum == 4)
                            {
                                CWFunctions.SortMenu();
                                int choiceNumSort = int.Parse(Console.ReadLine());
                                try
                                {
                                    if (choiceNumSort == 1)
                                    {
                                        Console.Clear();
                                        AdminStudent.SortingStudentBasedOnAge();
                                        Console.ReadKey();

                                    }
                                    else if (choiceNumSort == 2)
                                    {
                                        Console.Clear();
                                        AdminStudent.SortingStudentBasedOnName();
                                        Console.ReadKey();

                                    }
                                    else if (choiceNumSort == 3)
                                    {
                                        Console.Clear();
                                        AdminStudent.SortingStudentBasedOnGPA();
                                        Console.ReadKey();

                                    }
                                }


                                catch
                                {
                                    Console.Clear();
                                    Console.WriteLine("Something wrong happen");
                                }
                            }
                            else if (choiceNum == 5)
                            {
                                CWFunctions.DisplayMenu();
                                int choiceNumDisplay = int.Parse(Console.ReadLine());
                                //try
                                //{
                                    if (choiceNumDisplay == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enter the Number of Departement you want...");
                                        Console.WriteLine("1. IS");
                                        Console.WriteLine("2. CS");
                                        Console.WriteLine("3. IT");
                                        Console.WriteLine("4. BIO");
                                        int depnum = int.Parse(Console.ReadLine());
                                        Console.Clear();
                                        AdminStudent.DisplayStudentBasedOnDepartement(depnum);
                                        Console.ReadKey();

                                    }
                                    else if (choiceNumDisplay == 2)
                                    {
                                        Console.Clear();
                                        AdminStudent.DisplayFirstRank();
                                        Console.ReadKey();
                                    }
                                    else if (choiceNumDisplay == 3)
                                    {
                                        Console.Clear();
                                        AdminInstructor.DisplayMaleInstructor();
                                        Console.ReadKey();
                                    }
                        else if (choiceNumDisplay == 4)
                        {
                            Console.Clear();
                            AdminWorkers.DisplayThreeWorkers();
                            Console.ReadKey();
                        }
                        else
                                    {
                                        Console.WriteLine("please enter valid number");
                                    }
                                //}
                                //catch
                                //{
                                //    Console.WriteLine("Wrong");
                                //}
                            }
                        //}
                        //catch
                        //{
                        //    Console.WriteLine("Please enter a number");
                        //    Console.Clear();
                        //    CWFunctions.MainMenu();
                        //}
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a number");
                    Console.Clear();
                    CWFunctions.ExitMenu();
                }
            }
        }
    }
}
// Console.WriteLine("Do you want to Enter Another Student Data?");
// Console.WriteLine("if yes Please Press 1");
// int num = int.Parse(Console.ReadLine());
//if (num == 1)
// {
//     Console.Clear();
//     AdminStudent.EnterStudentData();
//     Console.ReadKey();
// }
// else
// {
//     CWFunctions.MainMenu();
// }