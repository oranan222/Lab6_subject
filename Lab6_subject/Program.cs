using System;
using System.Collections.Generic;

namespace Lab6_subject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Subject> subjects = new List<Subject>();

            while (true)
            {
                Console.WriteLine("\n===== Computer Science Grade Clculated =====");
                Console.WriteLine("1. Add a subject");
                Console.WriteLine("2. Add a student");
                Console.WriteLine("3. Show subject information");
                Console.WriteLine("0. Exit");
                Console.Write("Choose (0-3): ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        Console.Write("Subject: ");
                        string name = Console.ReadLine();
                        Console.Write("Subject ID: ");
                        string id = Console.ReadLine();

                        subjects.Add(new Subject(name, id));
                        break;

                    case 2:
                        Console.Write("Choose Subject (index): ");
                        int index = int.Parse(Console.ReadLine());

                        Console.Write("Student name: ");
                        string sName = Console.ReadLine();
                        Console.Write("Student ID: ");
                        string sId = Console.ReadLine();
                        Console.Write("Score: ");
                        double score = double.Parse(Console.ReadLine());

                        subjects[index].AddStudent(new Student(sName, sId, score));
                        break;

                    case 3:
                        foreach (var sub in subjects)
                        {
                            sub.ShowAllStudents();
                            sub.ShowMaxMin();
                            sub.ShowAverage();
                        }
                        break;
                }
            }
        }
    }
}